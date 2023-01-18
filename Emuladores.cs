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
    public partial class Emuladores : Form
    {
        public Emuladores()
        {
            InitializeComponent();
        }
        private void AbrirLink(string endereco)
        {
            System.Diagnostics.Process.Start(endereco);
        }

        //bluestacks 4
        private void BtnBaixarBS4_Click(object sender, EventArgs e)
        {
            if (Switch1Blue4.Checked == true)
            {
                AbrirLink("https://cdn3.bluestacks.com/downloads/windows/bgp/4.300.0.5129/f52990c3c794891856c1e3397fad91a2/BlueStacksMicroInstaller_4.300.0.5129_native.exe");
            }
            if (Switch2Blue4.Checked == true)
            {
                AbrirLink("https://cdn3.bluestacks.com/downloads/windows/bgp/4.280.1.1002/c9da3f767aed4858fde55c0f37209f8a/x64/BlueStacks-Installer_4.280.1.1002_amd64_native.exe");
            }
            if (Switch3Blue4.Checked == true)
            {
                AbrirLink("https://download2389.mediafire.com/tbr2jr2p0cwg/2b8vsrb9lndwee4/BlueStacks_App_Player_v4.280.0.1022.exe");
            }
            if (Switch4Blue4.Checked == true)
            {
                AbrirLink("https://cdn3.bluestacks.com/downloads/windows/bgp/4.270.0.1053/3474935d685deb8569c2bdde47ab3957/x64/BlueStacks-Installer_4.270.0.1053_amd64_native.exe");
            }
            if (Switch5Blue4.Checked == true)
            {
                AbrirLink("https://cdn3.bluestacks.com/downloads/windows/bgp/4.260.0.1032/c0a68ea9cb87973b3be6c8da4e48730f/x64/BlueStacks-Installer_4.260.0.1032_amd64_native.exe");
            }
            if (Switch6Blue4.Checked == true)
            {
                AbrirLink("https://cdn3.bluestacks.com/downloads/windows/bgp/4.250.1.1002/3790841bfde4ba1a8840ff96c4e69684/x64/BlueStacks-Installer_4.250.1.1002_amd64_native.exe");
            }
            if (Switch7Blue4.Checked == true)
            {
                AbrirLink("https://cdn3.bluestacks.com/downloads/windows/bgp/4.250.0.1070/cc667c126ae92c070b1e71b4f870f1a4/x64/BlueStacks-Installer_4.250.0.1070_amd64_native.exe");
            }
            if (Switch8Blue4.Checked == true)
            {
                AbrirLink("https://download.filepuma.com/files/desktop/bluestacks-app-player/BlueStacks_App_Player_v4.240.15.1005.exe?Expires=1650156716&Signature=KBQNV6b4Nvv~lSytvhGOXd8XO4SR9vEEpi7qW2cUSn30h6hca4Csvc7IGrO2obo-h1qC0CHHR96KsqJTeU4~9UQ773Y~3Kjuus9SxYtjEoxk771cZ4609jnTyi4FFaCaaEzT9Prf52Tk1qzbHLOocOV8qa5-mUDw0ova5jhZJxKqX7bfDm-hGbXph638QdywueyBMaMVKPEHxrerPJvYethhQZ7VELX4PZnpbAbIbBB4nBSRIffy~xIP0~uYkohIat6VETXVzJVNwfvSHQcfHn7EeqMOMcpPt5Kyywlxh0d4fA~sepAp9YUKR0H4raqCcVkF3b2vZ5PIAd9gQ3oxgQ__&Key-Pair-Id=APKAJ4QTZAMVFRE2J7AQ");
            }
            if (Switch9Blue4.Checked == true)
            {
                AbrirLink("https://download2346.mediafire.com/ixvsp5qdnh2g/hz71yiqkhtaseye/BlueStacks-Installer_4.240.5.1001+dluzgames.com.br.exe");
            }
            if (Switch10Blue4.Checked == true)
            {
                AbrirLink("https://download2389.mediafire.com/sb42zp3zr24g/48zkt2rs4ylmrmi/bluestacks-app-player-4-240-0-1075.exe");
            }
            if (Switch11Blue4.Checked == true)
            {
                AbrirLink("https://cdn3.bluestacks.com/downloads/windows/bgp/4.240.30.1002/8c6ba9ef64cc2e5c31f0e855e519e5b3/x64/BlueStacks-Installer_4.240.30.1002_amd64_native.exe");
            }
            if (Switch12Blue4.Checked == true)
            {
                AbrirLink("https://download2391.mediafire.com/h8sl66a6b5gg/3wxtxp1aac4jvpx/BlueStacks_App_Player_v4.240.20.1016+%281%29.exe");
            }
            if (Switch13Blue4.Checked == true)
            {
                AbrirLink("https://cdn3.bluestacks.com/downloads/windows/bgp/4.230.20.1001/1ae0bdcd1662730d450c373df15602d0/x64/BlueStacks-Installer_4.230.20.1001_amd64_native.exe");
            }
            if (Switch14Blue4.Checked == true)
            {
                AbrirLink("https://download2388.mediafire.com/z5de0lbhb3qg/ugia8woga5fgdtf/BlueStacks-Installer_4.230.10.1008_amd64_native.exe");
            }

            
        }

        //bluestacks 5
        private void BtnBaixarBS5_Click(object sender, EventArgs e)
        {
            if (Switch1Blue5.Checked == true)
            {
                AbrirLink("https://cloud.bluestacks.com/api/getdownloadnow?platform=win&win_version=10&mac_version=&client_uuid=ee8d2e03-6636-4aa4-83ba-268ff93e5625&app_pkg=com.dts.freefireth&platform_cloud=%257B%2522description%2522%253A%2522Chrome%2520103.0.5060.66%2520on%2520Windows%252010%252064-bit%2522%252C%2522layout%2522%253A%2522Blink%2522%252C%2522manufacturer%2522%253Anull%252C%2522name%2522%253A%2522Chrome%2522%252C%2522prerelease%2522%253Anull%252C%2522product%2522%253Anull%252C%2522ua%2522%253A%2522Mozilla%252F5.0%2520(Windows%2520NT%252010.0%253B%2520Win64%253B%2520x64)%2520AppleWebKit%252F537.36%2520(KHTML%252C%2520like%2520Gecko)%2520Chrome%252F103.0.5060.66%2520Safari%252F537.36%2522%252C%2522version%2522%253A%2522103.0.5060.66%2522%252C%2522os%2522%253A%257B%2522architecture%2522%253A64%252C%2522family%2522%253A%2522Windows%2522%252C%2522version%2522%253A%252210%2522%257D%257D&preferred_lang=pt-br&utm_source=&utm_medium=&gaCookie=&gclid=&clickid=&msclkid=&affiliateId=&offerId=&transaction_id=&aff_sub=&first_landing_page=&referrer=&download_page_referrer=&utm_campaign=afr2b-65ee0a7d374777ad476ae8eb027c4e73-com.dts.freefireth-pt_br-1&exit_utm_campaign=ap-free-fire-battlegrounds-pt-br&incompatible=false&bluestacks_version=bs5");
            }
            if (Switch2Blue5.Checked == true)
            {
                AbrirLink("https://cdn3.bluestacks.com/downloads/windows/nxt/5.7.0.1064/064f27221f58418ba143309ca1aa9e34/FullInstaller/x64/BlueStacksFullInstaller_5.7.0.1064_amd64_native.exe");
            }
            if (Switch3Blue5.Checked == true)
            {
                AbrirLink("https://download1649.mediafire.com/it307tsc49ig/f1emxk6tc7xr6ut/BlueStacksInstaller_5.6.0.1126_native_e0175934c4a0a56f1db683585ffd1bcf.exe");
            }
            if (Switch4Blue5.Checked == true)
            {
                AbrirLink("https://download626.mediafire.com/4blamafnqgbg/5lkybr0nrkg4io7/BlueStacksInstaller_5.5.120.1028_native_e0175934c4a0a56f1db683585ffd1bcf.exe");
            }
            if (Switch5Blue5.Checked == true)
            {
                AbrirLink("https://download1779.mediafire.com/tnzhk7c6jweg/nodyw14idscfipa/BlueStacksInstaller_5.5.0.1083_native_e0175934c4a0a56f1db683585ffd1bcf.exe");
            }
            if (Switch6Blue5.Checked == true)
            {
                AbrirLink("https://download1489.mediafire.com/fqnsiq1xpdxg/ack4xdlxp64d3t4/BlueStacksInstaller_5.3.120.1002_native_e0175934c4a0a56f1db683585ffd1bcf.exe");
            }
            if (Switch7Blue5.Checked == true)
            {
                AbrirLink("https://cdn3.bluestacks.com/downloads/windows/arabica/5.0.0.7228/b228b0da964c1f588d75747cccd884d4/BlueStacksMicroInstaller_5.0.0.7228_native.exe?filename=BlueStacksInstaller_5.0.0.7228_native_e0175934c4a0a56f1db683585ffd1bcf.exe");
            }
            if (Switch8Blue5.Checked == true)
            {
                AbrirLink("https://download2391.mediafire.com/umfpsosfk43g/jzq87js6bs9nkza/bluestacks+5.3+dluzgames.com.br.rar");
            }
            if (Switch9Blue5.Checked == true)
            {
                AbrirLink("https://download2389.mediafire.com/hans71tarjfg/zktxd3dukohz7d5/BlueStacks+5.4.0.1063+dluzgames.com.br.exe");
            }
            if (Switch10Blue5.Checked == true)
            {
                AbrirLink("https://cdn3.bluestacks.com/downloads/windows/nxt/5.5.120.1028/cdd952b22aad404997077cf8d9cc4fbf/BlueStacksMicroInstaller_5.5.120.1028_native.exe?filename=BlueStacksMicroInstaller_5.5.120.1028_native_06d3b6e56bf40c7c99911e40f1649447_0.exe");
            }
            if (Switch11Blue5.Checked == true)
            {
                AbrirLink("https://cdn3.bluestacks.com/downloads/windows/nxt/5.3.110.1002/445d5150d8604901992bb2ac53fe9c20/BlueStacksMicroInstaller_5.3.110.1002_native.exe?filename=BlueStacksInstaller_5.3.110.1002_native_e0175934c4a0a56f1db683585ffd1bcf.exe");
            }
            if (Switch12Blue5.Checked == true)
            {
                AbrirLink("https://download2391.mediafire.com/tplozgstxkjg/jzq87js6bs9nkza/bluestacks+5.3+dluzgames.com.br.rar");
            }
            if (Switch13Blue5.Checked == true)
            {
                AbrirLink("https://cdn3.bluestacks.com/downloads/windows/nxt/5.6.110.1002/18a5de87fb8e46c596c84e8e8cbd15b6/BlueStacksMicroInstaller_5.6.110.1002_native.exe?filename=BlueStacksInstaller_5.6.110.1002_native_f8e9b5b412b4d7820bd1ea36b6bff266_0_RnJlZSBGaXJlOiBCYXR0bGVncm91bmRz.exe");
            }
            if (Switch14Blue5.Checked == true)
            {
                AbrirLink("https://download1510.mediafire.com/vtez40worasg/yzwwvvoznf7qzoa/BlueStacksInstaller_5.0.220.2101_native_04a56122c1226a7c55eaa2adb40407f1_0.exe");
            }
        }

        //MSI e OUTROS
        private void BtnBaixarMSI_Click(object sender, EventArgs e)
        {
            if (Switch1MSI.Checked == true)
            {
                AbrirLink("https://download.msi.com/uti_exe/nb/MSI-APP-Player.zip");
            }
            if (Switch2MSI.Checked == true)
            {
                AbrirLink("https://download.msi.com/uti_exe/nb/MSI-APP-Player.zip");
            }
            if (Switch3MSI.Checked == true)
            {
                AbrirLink("https://download2325.mediafire.com/tvcfphowlpng/f12ia0wzmrzcs3l/BlueStacksMicroInstaller_4.240.15.6305_native.exe");
            }
            if (Switch4MSI.Checked == true)
            {
                AbrirLink("https://download2391.mediafire.com/ypij08d5umkg/6fwqrao5iuq5ias/BlueStacks-Installer_4.240.15.5321_amd64_native.exe");
            }
            if (Switch5MSI.Checked == true)
            {
                AbrirLink("https://download2390.mediafire.com/kfn34fhh4lng/an62n2hz8wa7ir3/BlueStacks-Installer_4.240.15.5320_amd64_native.exe");
            }
            if (Switch6MSI.Checked == true)
            {
                AbrirLink("https://download656.mediafire.com/c3kefsb5g85g/tfgidqovz9nl4h0/BlueStacks-Installer_4.240.15.5318_amd64_native.exe");
            }
            if (Switch7MSI.Checked == true)
            {
                AbrirLink("https://download2389.mediafire.com/h8b9zk60qfdg/ipa9pneoknv62mf/MSI+4.80+LITE.zip");
            }
            if (Switch1LD.Checked == true)
            {
                AbrirLink("https://ldcdn.ldmnq.com/download/ldad/LDPlayer4.exe?n=LDPlayer4_pt_7409_ld.exe");
            }
            if (Switch1MEMU.Checked == true)
            {
                AbrirLink("https://www.memuplay.com/download-en.php?file_name=Memu-Setup&from=official_release");
            }
            if (Switch1NOX.Checked == true)
            {
                AbrirLink("https://pt.bignox.com/pt/download/fullPackage?formal");
            }
            if (Switch1Smart.Checked == true)
            {
                AbrirLink("https://download1486.mediafire.com/zwj6zzoy8tmg/mlaj5cyqmf6uddb/SmartGaga+1.1+Atualizado.rar");
            }

        }
    }
}
