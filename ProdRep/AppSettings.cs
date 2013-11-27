/* static class used for general application settings
 *  it sets the colors used for the textboxes background 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace ProdRep
{
    public sealed class AppSettings
    {
        Color blankTextColor = Color.OrangeRed;
        Color disabledTextBoxColor = SystemColors.GradientActiveCaption;
        Color enabledTextBoxColor = SystemColors.Window;

        private static readonly AppSettings instance = new AppSettings();
        
        public static AppSettings Instance
        {
            get
            {
                return instance;
            }
        }
        
        private AppSettings() { }

        public Color getBlankTextColor()
        {
            return blankTextColor;
        }

        public Color getDisabledTextBoxColor()
        {
            return disabledTextBoxColor;
        }

        public Color getEnabledTextBoxColor()
        {
            return enabledTextBoxColor;
        }
    }
}
