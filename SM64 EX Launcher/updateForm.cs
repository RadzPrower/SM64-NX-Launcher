using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64_NX_Launcher
{
    public partial class updateForm : Form
    {
        private int progress = 0;
        private string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public updateForm()
        {
            InitializeComponent();

            this.Shown += new System.EventHandler(this.checkUpdate);
        }

        private void checkUpdate(object sender, EventArgs e)
        {
            if (!progressForm.IsConnectedToInternet())
            {
                this.Dispose();
                return;
            }

            string url = "https://api.github.com/repos/ajohns6/SM64-NX-Launcher/releases";
            string releaseString = "";

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Accept = "application/json";
            request.Method = "GET";
            request.UserAgent = "Foo";
            try
            {
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    releaseString = reader.ReadToEnd();
                }
            }
            catch
            {
                this.Dispose();
                return;
            }

            Application.DoEvents();

            var releaseList = JsonConvert.DeserializeObject<List<release>>(releaseString);

            if (releaseList[0].tag_name != ("v" + version))
            {
                this.statusLabel.Text = "Downloading v" + Assembly.GetExecutingAssembly().GetName().Version.ToString() + "...";
                this.progBar.Visible = true;
                string tempPath = Path.Combine(Path.GetTempPath(),
                             "sm64nxlauncherinstaller",
                             version);
                string zipPath = Path.Combine(tempPath, "installer.zip");
                if (Directory.Exists(tempPath)) mainForm.DeleteDirectory(tempPath);

                Task.Run(() =>
                {
                    using (var client = new WebClient())
                    {
                        if (!Directory.Exists(tempPath))
                        {
                            Directory.CreateDirectory(tempPath);
                        }

                        client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadProgress);
                        client.DownloadFileCompleted += new AsyncCompletedEventHandler(downloadComplete);
                        Uri installerLink = new Uri(releaseList[0].assets[0].browser_download_url);
                        client.DownloadFileAsync(installerLink, zipPath);
                    }
                });

                progBar.Maximum = 100;

                Application.DoEvents();

                do
                {
                    progBar.Value = progress;
                } while (progress < 100);

                this.statusLabel.Text = "Extracting installer...";

                Task.Run(() =>
                {
                    ZipFile.ExtractToDirectory(zipPath, tempPath);
                }).Wait();

                ProcessStartInfo installStart = new ProcessStartInfo();
                installStart.FileName = Path.Combine(tempPath, "setup.exe");

                Process installer = new Process();
                installer.StartInfo = installStart;

                installer.Start();

                Application.Exit();
            }

            this.Close();
        }

        private void downloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            progress = e.ProgressPercentage;
        }

        private void downloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            progress = 100;
        }

        public class release
        {
            public string tag_name { set; get; }
            public List<assets> assets { set; get; }
        }

        public class assets
        {
            public string browser_download_url { set; get; }
        }
    }}
