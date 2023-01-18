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
    public partial class Cleans : Form
    {
        public Cleans()
        {
            InitializeComponent();
        }

        //temp
        private void BtnTemp_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.Arguments = @"/c del /s /f /q %temp%\";            
            Process.Start(ps);

            ProcessStartInfo ps2 = new ProcessStartInfo();
            ps2.FileName = "cmd.exe";
            ps2.WindowStyle = ProcessWindowStyle.Normal;
            ps2.Arguments = @" /c  del C:\Windows\temp"; ;
            Process.Start(ps2);
            MessageBox.Show("temp limpo com sucesso");

        }

        //logs emuladores

        private void BtnLogEmuladores_Click(object sender, EventArgs e)
        {
            var msi = @"C:\ProgramData\BlueStacks_msi2\Logs";
            var bluestacks4 = @"C:\ProgramData\BlueStacks\Logs";
            var bluestacks5 = @"C:\ProgramData\BlueStacks_nxt\Logs";
            
            if (Directory.Exists(msi))
            {
                Directory.Delete(msi, true);
            }
            if (Directory.Exists(bluestacks4))
            {
                Directory.Delete(bluestacks4, true);
            }
            if (Directory.Exists(bluestacks5))
            {
                Directory.Delete(bluestacks5, true);
            }
            MessageBox.Show("cache limpo com sucesso");

        }

        //cache emuladores
        private void BtnCacheBst4_Click(object sender, EventArgs e)
        {
            var cache = @"C:\ProgramData\BlueStacks\CefData\Cache";

            if (Directory.Exists(cache))
            {
                Directory.Delete(cache, true);
                MessageBox.Show("cache limpo com sucesso");
            }
        }

        private void BtnCacheMsi_Click(object sender, EventArgs e)
        {
            var cache = @"C:\ProgramData\BlueStacks_msi2\CefData\Cache";

            if (Directory.Exists(cache))
            {
                Directory.Delete(cache, true);
                MessageBox.Show("cache limpo com sucesso");
            }
        }

        private void BtnCacheBst5_Click(object sender, EventArgs e)
        {
            var cache = @"C:\ProgramData\BlueStacks_nxt\Engine\Nougat32\AppCache";
            if (Directory.Exists(cache))
            {
                Directory.Delete(cache, true);
                MessageBox.Show("cache limpo com sucesso");
            }
        }
        //historico windows
        private void BtnHistoricoWind_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Normal;
        
            ps.Arguments = @"/c del C:\Windows\Prefetch";
            Process.Start(ps);
            MessageBox.Show("historico do windows limpo com sucesso");
        }

        private void CacheNavegador_Click(object sender, EventArgs e)
        {
        
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Normal;

            ps.Arguments = @"/c del C:\Windows\SoftwareDistribution\Download\*";
            Process.Start(ps);
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            
        }
    }
}
