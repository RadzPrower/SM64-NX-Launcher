using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibGit2Sharp;
using LibGit2Sharp.Handlers;
using System.Net.NetworkInformation;

namespace SM64_NX_Launcher
{
    public partial class progressForm : Form
    {
        private volatile int progress = 0;
        private volatile int max = 999999;
        private PAK progressPAK;
        public progressForm(string title, string message)
        {
            InitializeComponent();

            this.Text = title;
            this.updateLabel.Text = message;

            this.Shown += new System.EventHandler(this.cloneRepo);
        }

        public progressForm(string title, string message, PAK pak)
        {
            InitializeComponent();

            this.Text = title;
            this.updateLabel.Text = message;
            progressPAK = pak;

            this.Shown += new System.EventHandler(this.downloadPAK);
        }

        private void cloneRepo(object sender, EventArgs e)
        {
            this.Refresh();

            if (!IsConnectedToInternet())
            {
                MessageBox.Show("Unable to connect to the internet.\n\nPlease ensure you have a stable internet connection before updating your repository.", "No Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
                return;
            }

            Task.Run(() =>
            {
                Repository.Clone("https://github.com/teamsalta/sm64nx.git", mainForm.nxDir,
                    new CloneOptions
                    { 
                        OnCheckoutProgress = (clonePath, completed, total) => CheckoutProgress(clonePath, completed, total)
                    });
            });

            while (!Directory.Exists(mainForm.nxDir))
            {
                Application.DoEvents();
            }

            do
            {
                progBar.Value = progress;
                progBar.Maximum = max;
            } while (progress < max);

            this.Close();
        }

        public void CheckoutProgress(string path, int completed, int total)
        {
            max = total;
            progress = completed;
        }

        private void downloadPAK(object sender, EventArgs e)
        {
            this.Refresh();

            if (!IsConnectedToInternet())
            {
                MessageBox.Show("Unable to connect to the internet.\n\nPlease ensure you have a stable internet connection before downloading new PAK files.\n\n" + progressPAK.modName + " was not downloaded and will not be applied at this time.", 
                    "No Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
                return;
            }

            Task.Run(() =>
            {
                using (var client = new WebClient())
                {
                    if (!Directory.Exists(Path.Combine(mainForm.pakDir, progressPAK.modDir)))
                    {
                        Directory.CreateDirectory(Path.Combine(mainForm.pakDir, progressPAK.modDir));
                    }
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadProgress);
                    Uri pakLink = new Uri(progressPAK.modURL);
                    client.DownloadFileAsync(pakLink, Path.Combine(mainForm.pakDir, progressPAK.modDir, progressPAK.modFile));
                }
            });

            while (!Directory.Exists(Path.Combine(mainForm.pakDir, progressPAK.modDir)))
            {
                Application.DoEvents();
            }

            progBar.Maximum = 100;

            do
            {
                progBar.Value = progress;
            } while (progress < 100);

            this.Close();
        }

        private void downloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            progress = e.ProgressPercentage;
        }

        public static bool IsConnectedToInternet()
        {
            string host = "google.com";  
            bool result = false;
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 3000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch { }
            return result;
        }
    }
}
