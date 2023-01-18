using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otimizaçao
{
    public partial class FpsBoost : Form
    {
        public FpsBoost()
        {
            InitializeComponent();
        }

        private void Switch11_CheckedChanged(object sender, EventArgs e)
        {
            if (Switch11.Checked == true)
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", true);
                registryKey.SetValue("AppsUseLightTheme", 0);
            }
            else
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", true);
                registryKey.SetValue("AppsUseLightTheme", 1);
            }
        }
    }
}
