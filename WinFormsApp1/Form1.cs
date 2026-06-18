using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }

        private void Form1_Lod(object sender, EventArgs e)
        {
            try
            {
                int screenWidth = Screen.PrimaryScreen.Bounds.Width;
                int screenHeight = Screen.PrimaryScreen.Bounds.Height;

                width_textbox.Text = screenWidth.ToString();
                height_textbox.Text = screenHeight.ToString();
            } catch (Exception)
            {
                return;
            }
            
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string docsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                
                openFileDialog.InitialDirectory = $@"{docsFolder}\Arma 3 - Other Profiles";
                openFileDialog.Filter = "Arma 3 Profile (*.Arma3Profile)|*.Arma3Profile";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    string lowerPath = selectedFilePath.ToLower();
                    if (lowerPath.Contains(".vars.") || lowerPath.Contains(".3den."))
                    {
                        MessageBox.Show("Invalid file, use {profilename}.Arma3Profile", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    profile_textbox.Text = selectedFilePath;
                }
            }
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            // First check if there's a valid path in the profile_textbox
            string profilePath = profile_textbox.Text;
            string profileText = "";

            try
            {
                profileText = File.ReadAllText(profilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Your profile field was invalid: {ex}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                double width = double.Parse(width_textbox.Text);
                double height = double.Parse(height_textbox.Text);
                double desiredHFOV = double.Parse(fov_textbox.Text);
                bool legacyCalculation = oldcalc_cb.Checked;
                var newFovObj = FovCalculator.CalculateArmaFov(width, height, desiredHFOV, legacyCalculation);

                profileText = Regex.Replace(profileText, @"fovTop=.*?\;", $"fovTop={newFovObj.FovTop};");
                profileText = Regex.Replace(profileText, @"fovLeft=.*?\;", $"fovLeft={newFovObj.FovLeft};");
                File.WriteAllText(profilePath, profileText);

                MessageBox.Show("Arma FOV Updated!", "Success");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please make sure Width, Height, and FOV are valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fov_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
