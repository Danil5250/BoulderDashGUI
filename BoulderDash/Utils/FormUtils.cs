using BoulderDash.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoulderDash.Utils
{
    internal static class FormUtils
    {
        internal static Point GetFormCenterCoordinates(int formWidth, int formHeight)
        {
            //without task panel
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int centerX = screen.Left + (screen.Width - formWidth) / 2;
            int centerY = screen.Top + (screen.Height - formHeight) / 2;

            return new Point(centerX, centerY - AllFormConfig.YCenterOffset);
        }
    }
}
