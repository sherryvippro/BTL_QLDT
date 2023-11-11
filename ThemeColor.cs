using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static List<string> ColorList = new List<string>()
        {
            "#3F51B5",
            "#009688",
            "#FF5722",
            "#607D88",
            "#FF9800",
            "#9C27B0",
            "#FF33FF",
            "#993300",
            "#008800",
            "#363636",
            "#79CDCD",
            "#A0522D",
            "#CDC9A5",
            "#CDB7B5",
            "#6A5ACD",
            "#4169E1",
            "#87CEEB"
        };
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            if(correctionFactor < 0)
            {
                correctionFactor += 1;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
