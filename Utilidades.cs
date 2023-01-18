using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Otimizaçao
{
    public partial class BtnBSTweaker : Form
    {
        private WebClient client;
        private string diretorio, rotaDiretorio;
        public BtnBSTweaker()
        {
            InitializeComponent();
            client = new WebClient();
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(baixado);
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(baixando);
        }

        private void baixando(object sender, DownloadProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void baixado(object sender, AsyncCompletedEventArgs e)
        {
            System.Diagnostics.Process.Start(rotaDiretorio);
        }
        private void AbrirLink(string endereco)
        {
            System.Diagnostics.Process.Start(endereco);
        }

        //brave
        private void BtnBrave_Click(object sender, EventArgs e)
        {          
            diretorio = "https://laptop-updates.brave.com/latest/winx64";
            String nomeArquivo = Path.GetFileName(diretorio + ".exe");
            rotaDiretorio = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + nomeArquivo;
           
             
            client.DownloadFileAsync(new Uri(diretorio), rotaDiretorio);           
        }

//Chrome
        private void BtnChrome_Click(object sender, EventArgs e)
        {
            diretorio = "https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7BA962074A-DEBF-E504-4EC4-54E7982E07AE%7D%26lang%3Den%26browser%3D3%26usagestats%3D1%26appname%3DChrome%2520Beta%26needsadmin%3Dprefers%26ap%3Dx64-beta%26installdataindex%3Ddefaultbrowser/update2/installers/ChromeSetup.exe";
            String nomeArquivo = Path.GetFileName(diretorio + ".exe");
            rotaDiretorio = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + nomeArquivo;


            client.DownloadFileAsync(new Uri(diretorio), rotaDiretorio);
        }

        

        //OperaGX
        private void BtnOperaGX_Click(object sender, EventArgs e)
        {
            diretorio = "https://cdn.discordapp.com/attachments/992546964107444285/992568171624153229/OperaGXSetup.exe";
            String nomeArquivo = Path.GetFileName(diretorio + ".exe");
            rotaDiretorio = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + nomeArquivo;


            client.DownloadFileAsync(new Uri(diretorio), rotaDiretorio);
        }


        //Opera
        private void BtnOpera_Click(object sender, EventArgs e)
        {
            diretorio = "https://cdn.discordapp.com/attachments/992546964107444285/992547025038082048/OperaSetup.exe";
            String nomeArquivo = Path.GetFileName(diretorio + "1.exe");
            rotaDiretorio = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + nomeArquivo;


            client.DownloadFileAsync(new Uri(diretorio), rotaDiretorio);

        }

        //mozilla
        private void BtnMozilla_Click(object sender, EventArgs e)
        {
            diretorio = "https://cdn.discordapp.com/attachments/992546964107444285/992548884406607923/Firefox_Installer.exe";
            String nomeArquivo = Path.GetFileName(diretorio + "1.exe");
            rotaDiretorio = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + nomeArquivo;


            client.DownloadFileAsync(new Uri(diretorio), rotaDiretorio);
        }

        //netframework 4.7
        private void NetFramework1_Click(object sender, EventArgs e)
        {

            diretorio = "https://cdn.discordapp.com/attachments/992546964107444285/992550142509064242/netframework4.7.exe";
            String nomeArquivo = Path.GetFileName(diretorio + "1.exe");
            rotaDiretorio = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + nomeArquivo;


            client.DownloadFileAsync(new Uri(diretorio), rotaDiretorio);
        }

        //netframework 4.7.2
        private void Netframework2_Click(object sender, EventArgs e)
        {
        
            diretorio = "https://cdn.discordapp.com/attachments/992546964107444285/992550798506610729/netframework4.7.2.exe";
            String nomeArquivo = Path.GetFileName(diretorio + "1.exe");
            rotaDiretorio = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + nomeArquivo;


            client.DownloadFileAsync(new Uri(diretorio), rotaDiretorio);
        }

        //Microsoftx64
        private void Microsoftx64_Click(object sender, EventArgs e)
        {

            AbrirLink("https://cdn.discordapp.com/attachments/992546964107444285/992552536802328626/c.x64.exe");
            
        }

        //Microsoftx86
        private void Microsoftx86_Click(object sender, EventArgs e)
        {
            AbrirLink("https://cdn.discordapp.com/attachments/992546964107444285/992552535804088440/cx86.exe");
            
        }

        

        //BSTweaker
        private void Btnbst_Click(object sender, EventArgs e)
        {
            AbrirLink("https://cdn.discordapp.com/attachments/992546964107444285/992553691477442620/BSTweaker51610.zip");
            
        }

        

        //Discord
        private void BtnDiscord_Click(object sender, EventArgs e)
        {
            AbrirLink("https://cdn.discordapp.com/attachments/992546964107444285/992555089925517322/DiscordSetup.exe");
            
        }

        //WinRar
        private void BtnWinRar_Click(object sender, EventArgs e)
        {

            AbrirLink("https://cdn.discordapp.com/attachments/992546964107444285/992555341168509078/winrar-x64-611br.exe");
            
        }

        //RevoUnistaller
        private void BtnRevoUnistaller_Click(object sender, EventArgs e)
        {

            AbrirLink("https://cdn.discordapp.com/attachments/992546964107444285/992556497684926566/revosetup.exe");
            
        }

        //Anydesk
        private void BtnAnydesk_Click(object sender, EventArgs e)
        {
            AbrirLink("https://cdn.discordapp.com/attachments/992546964107444285/992557415356694558/AnyDesk.exe");
            
        }

        

        //spotify
        private void BtnSpotify_Click(object sender, EventArgs e)
        {
            AbrirLink("https://cdn.discordapp.com/attachments/992546964107444285/992560929004863558/SpotifySetup.exe");
            
        }

        



        //GeForce
        private void BtnGeForce_Click(object sender, EventArgs e)
        {

            AbrirLink("https://us.download.nvidia.com/GFE/GFEClient/3.25.1.27/GeForce_Experience_v3.25.1.27.exe");
            
        }

        

        //logitch G HUB
        private void BtnLogitech_Click(object sender, EventArgs e)
        {
            AbrirLink("https://cdn.discordapp.com/attachments/992546964107444285/992562783281496194/lghub_installer_1.exe");
            
        }

        

        //Redragon
        private void BtnRedragon_Click(object sender, EventArgs e)
        {
            AbrirLink("https://cdn.discordapp.com/attachments/992546964107444285/992563300434968586/REDRAGON_Gaming_Mouse_M711_V2.exe");
            
        }

        

        //Razer Synapse 3
        private void BtnSynapse_Click(object sender, EventArgs e)
        {
            AbrirLink("https://cdn.discordapp.com/attachments/992546964107444285/992563022193238096/RazerSynapseInstaller_V1.6.0.292.exe");
            
        }

        

        //Steam
        private void BtnSteam_Click(object sender, EventArgs e)
        {
            AbrirLink("https://cdn.discordapp.com/attachments/992546964107444285/992563971636871268/SteamSetup.exe");
            
        }

        



        //Epic games
        private void BtnEpic_Click(object sender, EventArgs e)
        {
            AbrirLink("https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi");
        }

        



        //Color Changer PRO
        private void BtnColorChanger_Click(object sender, EventArgs e)
        {
            AbrirLink("https://drive.google.com/file/d/1USIBTPA14vC2FMhX3CjfwE_4R0yRQFv-/view");
        }

        

        //Painel Nvidia
        private void BtnPainelNvidia_Click(object sender, EventArgs e)
        {
            AbrirLink("https://apps.microsoft.com/store/detail/nvidia-control-panel/9NF8H0H7WMLT?hl=pt-br&gl=BR");
        }

        

        //Windows
        private void BtnAtlasOS_Click(object sender, EventArgs e)
        {
            AbrirLink("https://atlasos.net/download");
        }

        private void BtnMEGAOS_Click(object sender, EventArgs e)
        {
            AbrirLink("https://www.mediafire.com/file/9eozb0uyda34qyw/Windows+10+Mega+OS.zip/file");
        }

        private void BtnWindows_Click(object sender, EventArgs e)
        {
            AbrirLink("https://www.microsoft.com/pt-br/software-download/windows10");
        }

        private void BtnGGOS_Click(object sender, EventArgs e)
        {
            AbrirLink("https://drive.google.com/file/d/163zv0iOH6WocAPTLaUYVWIQk-t7DGYU0/view");
        }


    }
}
