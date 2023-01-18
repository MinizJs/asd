using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otimizaçao
{
    public partial class Sensibilidades : Form
    {
        public Sensibilidades()
        {
            InitializeComponent();
        }

        private void BtnRmvAce_Click(object sender, EventArgs e)
        {
            if(TxtAce.Text == "100%")
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Mouse", true);
                registryKey.SetValue("SmoothMouseXCurve" , "0000000000000000C0CC0C0000000000809919000000000040662600000000000033330000000000");
                registryKey.SetValue("SmoothMouseYCurve", "0000000000000000000038000000000000007000000000000000A800000000000000E00000000000");
                registryKey.SetValue("MouseSensitivity", "10");
                registryKey.SetValue("MouseSpeed", "0");
                registryKey.SetValue("MouseThreshold1", "0");
                registryKey.SetValue("MouseThreshold2", "0");
                registryKey.SetValue("SmoothMouseXCurve", "0000000000000000703D0A0000000000E07A14000000000050B81E0000000000C0F5280000000000");
                registryKey.SetValue("SmoothMouseYCurve", "0000000000000000000038000000000000007000000000000000A800000000000000E00000000000");
                MessageBox.Show("Aplicado com Sucesso");
                
            }
            if (TxtAce.Text == "125%")
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Mouse", true);
                registryKey.SetValue("SmoothMouseXCurve", "00000000000000000000100000000000000020000000000000003000000000000000400000000000");
                registryKey.SetValue("SmoothMouseYCurve", "0000000000000000000038000000000000007000000000000000A800000000000000E00000000000");
                registryKey.SetValue("MouseSensitivity", "10");
                registryKey.SetValue("MouseSpeed", "0");
                registryKey.SetValue("MouseThreshold1", "0");
                registryKey.SetValue("MouseThreshold2", "0");
                MessageBox.Show("Aplicado com Sucesso");
            }
            if (TxtAce.Text == "150%")
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Mouse", true);
                registryKey.SetValue("SmoothMouseXCurve", "0000000000000000303313000000000060662600000000009099390000000000C0CC4C0000000000");
                registryKey.SetValue("SmoothMouseYCurve", "0000000000000000000038000000000000007000000000000000A800000000000000E00000000000");
                registryKey.SetValue("MouseSensitivity", "10");
                registryKey.SetValue("MouseSpeed", "0");
                registryKey.SetValue("MouseThreshold1", "0");
                registryKey.SetValue("MouseThreshold2", "0");
                MessageBox.Show("Aplicado com Sucesso");
            }
            if (TxtAce.Text == "175%")
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Mouse", true);
                registryKey.SetValue("SmoothMouseXCurve", "00000000000000006066160000000000C0CC2C000000000020334300000000008099590000000000");
                registryKey.SetValue("SmoothMouseYCurve", "0000000000000000000038000000000000007000000000000000A800000000000000E00000000000");
                registryKey.SetValue("MouseSensitivity", "10");
                registryKey.SetValue("MouseSpeed", "0");
                registryKey.SetValue("MouseThreshold1", "0");
                registryKey.SetValue("MouseThreshold2", "0");
                MessageBox.Show("Aplicado com Sucesso");
            }
            if (TxtAce.Text == "200%")
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Mouse", true);
                registryKey.SetValue("SmoothMouseXCurve", "000000000000000090991900000000002033330000000000B0CC4C00000000004066660000000000");
                registryKey.SetValue("SmoothMouseYCurve", "0000000000000000000038000000000000007000000000000000A800000000000000E00000000000");
                registryKey.SetValue("MouseSensitivity", "10");
                registryKey.SetValue("MouseSpeed", "0");
                registryKey.SetValue("MouseThreshold1", "0");
                registryKey.SetValue("MouseThreshold2", "0");
                MessageBox.Show("Aplicado com Sucesso");
            }
            if (TxtAce.Text == "Default")
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Mouse", true);
                registryKey.SetValue("SmoothMouseXCurve", "0000000000000000156e000000000000004001000000000029dc0300000000000000280000000000");
                registryKey.SetValue("SmoothMouseYCurve", "0000000000000000fd11010000000000002404000000000000fc12000000000000c0bb0100000000");
                MessageBox.Show("Aplicado com Sucesso");
            }
            else if (TxtAce.Text == "")
            {
                MessageBox.Show("Selecione o seu Monitor Size");
            }
        }

        private void BtnVerSize_Click(object sender, EventArgs e)
        {
            Process.Start("ms-settings:display");
        }

        private void BtnSensiAlta_Click(object sender, EventArgs e)
        {
            if (TxtEmulador.Text == "Bluestacks 4")
            {
                TxtDpiMouse.Text =  "DPI MOUSE: 1200";
                TxtDpiEmulador.Text = "DPI EMUALDOR: 440 ou 240";
                TxtResluçao.Text = "RESOLUÇÃO: 1920X1080";
                TxtGan.Text = "GAN: 101";
                TxtAjustes.Text = "AJUSTES: 16450";
                TxtX.Text = "X: 80";
                TxtY.Text = "Y: 60";

                MessageBox.Show("Aplicado com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um Emulador");
            }
        }
    }
}
