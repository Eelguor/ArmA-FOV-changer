using System;
using System.Globalization;

namespace WinFormsApp1
{
    public static class FovCalculator
    {
        // Notice this method is 'public static' and returns a tuple with both values
        public static (string FovTop, string FovLeft) CalculateArmaFov(double width, double height, double desiredFOV, bool oldFovCalculation)
        {
            (double fovTop, double fovLeft) fovRatios;

            if (oldFovCalculation)
            {
                fovRatios = legacyFovCalculator(width, height, desiredFOV);
            } else
            {
                fovRatios = newFovCalculator(width, height, desiredFOV);
            }

            string finalFovTop =  fovRatios.fovTop.ToString("0.00000", CultureInfo.InvariantCulture);
            string finalFovLeft = fovRatios.fovLeft.ToString("0.00000", CultureInfo.InvariantCulture);

            return (finalFovTop, finalFovLeft);
        }

        private static (double FovTop, double FovLeft) newFovCalculator (double width, double height, double desiredFOV)
        {
            double aspectRatio = width / height;
            double hFovRad = desiredFOV * (Math.PI / 180.0);

            double fovTop = 2.0 * Math.Atan(Math.Tan(hFovRad / 2.0) / aspectRatio);
            double fovLeft = fovTop * aspectRatio;

            return (fovTop, fovLeft);
        }


        private static (double FovTop, double FovLeft) legacyFovCalculator (double width, double height, double desiredFOV)
        {
            double hFovRad = desiredFOV / 57.2957795130823;
            double aspectRatio = width / height;

            double vFovRad = 2.0 * Math.Atan(Math.Tan(hFovRad / 2.0) * (height / width));
            double roundedVFovDeg = Math.Round(vFovRad * 57.2957795130823, 0);
            double fovTop = 0.0174 * roundedVFovDeg;
            double fovLeft = fovTop * aspectRatio;
             
            double roundFovTop  = Math.Round(fovTop, 2);
            double roundFovLeft = Math.Round(fovLeft, 2);

            return (roundFovTop, roundFovLeft);
        }
    }
}