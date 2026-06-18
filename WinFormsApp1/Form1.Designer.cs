namespace WinFormsApp1
{
    partial class window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            fov_textbox = new TextBox();
            width_textbox = new TextBox();
            height_textbox = new TextBox();
            width_label = new Label();
            profile_textbox = new TextBox();
            profile_label = new Label();
            profile_button = new Button();
            resolution_label = new Label();
            height_label = new Label();
            fov_label = new Label();
            change_button = new Button();
            oldcalc_cb = new CheckBox();
            old_calc_tooltip = new ToolTip(components);
            SuspendLayout();
            // 
            // fov_textbox
            // 
            fov_textbox.BackColor = Color.FromArgb(40, 40, 40);
            fov_textbox.BorderStyle = BorderStyle.FixedSingle;
            fov_textbox.ForeColor = Color.White;
            fov_textbox.Location = new Point(49, 142);
            fov_textbox.Name = "fov_textbox";
            fov_textbox.Size = new Size(29, 23);
            fov_textbox.TabIndex = 13;
            fov_textbox.Text = "70";
            fov_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // width_textbox
            // 
            width_textbox.BackColor = Color.FromArgb(40, 40, 40);
            width_textbox.BorderStyle = BorderStyle.FixedSingle;
            width_textbox.ForeColor = Color.White;
            width_textbox.Location = new Point(49, 85);
            width_textbox.Name = "width_textbox";
            width_textbox.Size = new Size(63, 23);
            width_textbox.TabIndex = 0;
            width_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // height_textbox
            // 
            height_textbox.BackColor = Color.FromArgb(40, 40, 40);
            height_textbox.BorderStyle = BorderStyle.FixedSingle;
            height_textbox.ForeColor = Color.White;
            height_textbox.Location = new Point(49, 114);
            height_textbox.Name = "height_textbox";
            height_textbox.Size = new Size(63, 23);
            height_textbox.TabIndex = 1;
            height_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // width_label
            // 
            width_label.AutoSize = true;
            width_label.Location = new Point(4, 89);
            width_label.Name = "width_label";
            width_label.Size = new Size(39, 15);
            width_label.TabIndex = 3;
            width_label.Text = "Width";
            // 
            // profile_textbox
            // 
            profile_textbox.BackColor = Color.FromArgb(40, 40, 40);
            profile_textbox.BorderStyle = BorderStyle.FixedSingle;
            profile_textbox.ForeColor = Color.White;
            profile_textbox.Location = new Point(4, 28);
            profile_textbox.Name = "profile_textbox";
            profile_textbox.Size = new Size(159, 23);
            profile_textbox.TabIndex = 4;
            // 
            // profile_label
            // 
            profile_label.AutoSize = true;
            profile_label.Location = new Point(4, 8);
            profile_label.Name = "profile_label";
            profile_label.Size = new Size(68, 15);
            profile_label.TabIndex = 5;
            profile_label.Text = "Profile path";
            // 
            // profile_button
            // 
            profile_button.BackColor = Color.FromArgb(45, 45, 48);
            profile_button.FlatAppearance.BorderSize = 0;
            profile_button.FlatStyle = FlatStyle.Flat;
            profile_button.Location = new Point(169, 28);
            profile_button.Name = "profile_button";
            profile_button.Size = new Size(75, 23);
            profile_button.TabIndex = 6;
            profile_button.Text = "Select";
            profile_button.UseVisualStyleBackColor = false;
            profile_button.Click += profile_button_Click;
            // 
            // resolution_label
            // 
            resolution_label.AutoSize = true;
            resolution_label.Location = new Point(49, 67);
            resolution_label.Name = "resolution_label";
            resolution_label.Size = new Size(63, 15);
            resolution_label.TabIndex = 7;
            resolution_label.Text = "Resolution";
            // 
            // height_label
            // 
            height_label.AutoSize = true;
            height_label.Location = new Point(4, 117);
            height_label.Name = "height_label";
            height_label.Size = new Size(43, 15);
            height_label.TabIndex = 8;
            height_label.Text = "Height";
            // 
            // fov_label
            // 
            fov_label.AutoSize = true;
            fov_label.Location = new Point(4, 145);
            fov_label.Name = "fov_label";
            fov_label.Size = new Size(29, 15);
            fov_label.TabIndex = 14;
            fov_label.Text = "FOV";
            // 
            // change_button
            // 
            change_button.BackColor = Color.FromArgb(45, 45, 48);
            change_button.FlatAppearance.BorderSize = 0;
            change_button.FlatStyle = FlatStyle.Flat;
            change_button.Location = new Point(169, 145);
            change_button.Name = "change_button";
            change_button.Size = new Size(75, 23);
            change_button.TabIndex = 15;
            change_button.Text = "Change";
            change_button.UseVisualStyleBackColor = false;
            change_button.Click += change_button_Click;
            // 
            // oldcalc_cb
            // 
            oldcalc_cb.AutoSize = true;
            oldcalc_cb.Location = new Point(118, 85);
            oldcalc_cb.Name = "oldcalc_cb";
            oldcalc_cb.Size = new Size(126, 19);
            oldcalc_cb.TabIndex = 16;
            oldcalc_cb.Text = "Use old calculation";
            old_calc_tooltip.SetToolTip(oldcalc_cb, "Uses the legacy FOV calculation\r\n");
            oldcalc_cb.UseVisualStyleBackColor = true;
            // 
            // old_calc_tooltip
            // 
            old_calc_tooltip.AutoPopDelay = 5000;
            old_calc_tooltip.InitialDelay = 500;
            old_calc_tooltip.ReshowDelay = 1000;
            // 
            // window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(252, 181);
            Controls.Add(oldcalc_cb);
            Controls.Add(change_button);
            Controls.Add(fov_label);
            Controls.Add(fov_textbox);
            Controls.Add(height_label);
            Controls.Add(resolution_label);
            Controls.Add(profile_button);
            Controls.Add(profile_label);
            Controls.Add(profile_textbox);
            Controls.Add(width_label);
            Controls.Add(height_textbox);
            Controls.Add(width_textbox);
            Font = new Font("Segoe UI", 9F);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "window";
            Text = "Arma FOV changer";
            Load += Form1_Lod;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox width_textbox;
        private TextBox height_textbox;
        private Label width_label;
        private TextBox profile_textbox;
        private Label profile_label;
        private Button profile_button;
        private Label resolution_label;
        private Label height_label;
        private TextBox fov_textbox;
        private Label fov_label;
        private Button change_button;
        private CheckBox oldcalc_cb;
        private ToolTip old_calc_tooltip;
    }
}
