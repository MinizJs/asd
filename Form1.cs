using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Otimizaçao
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            

        }
        private Form frmAtivo;
        private void AbrirForm(Form frm)
        {
            FecharFormAberto();
            frmAtivo = frm;
            frm.TopLevel = false;
            PanelForms.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        private void FecharFormAberto()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }


        private void BtnOtimizacoes_Click(object sender, EventArgs e)
        {
            PanelBtn1.Visible = true;
            PanelBtn2.Visible = false;
            PanelBtn3.Visible = false;
            PanelBtn4.Visible = false;
            PanelBtn5.Visible = false;
            FecharFormAberto();

        }

        private void BtnSensibilidades_Click(object sender, EventArgs e)
        {
            PanelBtn1.Visible = false;
            PanelBtn2.Visible = true;
            PanelBtn3.Visible = false;
            PanelBtn4.Visible = false;
            PanelBtn5.Visible = false;
            AbrirForm(new Sensibilidades());
        }

        private void BtnEmuladores_Click(object sender, EventArgs e)
        {
            PanelBtn1.Visible = false;
            PanelBtn2.Visible = false;
            PanelBtn3.Visible = true;
            PanelBtn4.Visible = false;
            PanelBtn5.Visible = false;
            AbrirForm(new Emuladores());
        }
        private void BtnUtilidades_Click(object sender, EventArgs e)
        {
            PanelBtn1.Visible = false;
            PanelBtn2.Visible = false;
            PanelBtn3.Visible = false;
            PanelBtn4.Visible = true;
            PanelBtn5.Visible = false;
            AbrirForm(new BtnBSTweaker());
        }

        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            PanelBtn1.Visible = false;
            PanelBtn2.Visible = false;
            PanelBtn3.Visible = false;
            PanelBtn4.Visible = false;
            PanelBtn5.Visible = true;
            AbrirForm(new Perfil());
        }
    
        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirForm2(Form frm)
        {
            FecharFormAberto2();
            frmAtivo = frm;
            frm.TopLevel = false;
            PanelForms2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        private void FecharFormAberto2()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            PanelBtnGerais.Visible = true;
            PanelBtnBoost.Visible = false;
            PanelBtnFps.Visible = false;
            PanelBtnCleans.Visible = false;
            FecharFormAberto2();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            PanelBtnGerais.Visible = false;
            PanelBtnBoost.Visible = true;
            PanelBtnFps.Visible = false;
            PanelBtnCleans.Visible = false;
            AbrirForm2(new FpsBoost());

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {
            PanelBtnGerais.Visible = false;
            PanelBtnBoost.Visible = false;
            PanelBtnFps.Visible = true;
            PanelBtnCleans.Visible = false;
            AbrirForm2(new FpsOn());
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
            PanelBtnGerais.Visible = false;
            PanelBtnBoost.Visible = false;
            PanelBtnFps.Visible = false;
            PanelBtnCleans.Visible = true;
            AbrirForm2(new Cleans());
        }

        private void Switch1_CheckedChanged(object sender, EventArgs e)
        {
            if (Switch1.Checked == true)
            {
                otimizar.EnablePerformanceTweaks();
                MessageBox.Show("Aplicado com Sucesso");
            }
            else
            {
                otimizar.DisablePerformanceTweaks();
                MessageBox.Show("Remolvido com Sucesso");
            }    

        }

        private void Switch2_CheckedChanged(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Hidden;

            ps.Arguments = @"/c powercfg /hibernate off";

            Process.Start(ps);

        }

        private void Switch3_CheckedChanged(object sender, EventArgs e)
        {
            if (Switch3.Checked == true)
            {
                otimizar.DisableNetworkThrottling();
                MessageBox.Show("Aplicado com Sucesso");
            }
            else
            {
                otimizar.EnableNetworkThrottling();
                MessageBox.Show("Remolvido com Sucesso");
            }
        }

        private void Switch5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }  
}
/* ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Normal;
            ps.Arguments = @"/c del C:\Users\melod\AppData\Local\Temp";
            
            Process.Start(ps);
/*
    $$$$$$\     $$$$$$$\  $$\   $$\      $$\                    $$\   $$\ 
  $$$ ___$$$\   $$  __$$\ $$ | $$  |     $$ |                   $$ |  $$ |
 $$ _/   \_$$\  $$ |  $$ |$$ |$$  / $$$$$$$ | $$$$$$\   $$$$$$\ \$$\ $$  |
$$ / $$$$$\ $$\ $$$$$$$  |$$$$$  / $$  __$$ |$$  __$$\ $$  __$$\ \$$$$  / 
$$ |$$  $$ |$$ |$$  ____/ $$  $$<  $$ /  $$ |$$ /  $$ |$$ |  \__|$$  $$<  
$$ |$$ /$$ |$$ |$$ |      $$ |\$$\ $$ |  $$ |$$ |  $$ |$$ |     $$  /\$$\ 
$$ |\$$$$$$$$  |$$ |      $$ | \$$\\$$$$$$$ |\$$$$$$  |$$ |     $$ /  $$ |
\$$\ \________/ \__|      \__|  \__|\_______| \______/ \__|     \__|  \__|
 \$$$\   $$$\                                                             
  \_$$$$$$  _|                                                            
    \______/                                                              
*/

