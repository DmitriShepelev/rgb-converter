using System;

namespace RgbConverter
{
    public static class Rgb
    {
#pragma warning disable SA1625 // Element documentation should not be copied and pasted
        /// <summary>
        /// Gets hexadecimal representation source RGB decimal values.
        /// </summary>
        /// <param name="red">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="green">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="blue">The valid decimal value for RGB is in the range 0-255.</param>
        /// <returns>Returns hexadecimal representation source RGB decimal values.</returns>
        public static string GetHexRepresentation(int red, int green, int blue)
#pragma warning restore SA1625 // Element documentation should not be copied and pasted
        {
            return GetHex(red) + GetHex(green) + GetHex(blue);
        }

        private static string GetHex(int intensity)
        {
            var invariantCulture = System.Globalization.CultureInfo.InvariantCulture;
            if (intensity < 0)
            {
                return "00";
            }
            else if (intensity > 255)
            {
                return "FF";
            }
            else if (intensity > 16)
            {
                return Convert.ToString(intensity, 16).ToUpper(invariantCulture);
            }
            else
            {
                return "0" + Convert.ToString(intensity, 16).ToUpper(invariantCulture);
            }
        }
    }
}
