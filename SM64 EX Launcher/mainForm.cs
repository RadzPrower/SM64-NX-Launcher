using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Text;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using LibGit2Sharp;
using System.Security.Cryptography;

namespace SM64_NX_Launcher
{
    public partial class mainForm : Form
    {
        JArray PAKList;
        static string mainDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "sm64nx");
        static string nxDir = Path.Combine(mainDir, "repo");
        static string pakDir = Path.Combine(nxDir, "romfs");
        List<Process> processes = new List<Process>();
        static string pakJSON = Path.Combine(mainDir, @"PAKList.json");

        public mainForm()
        {
            InitializeComponent();

            // Handle the ApplicationExit event to know when the application is exiting.
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            if (!Directory.Exists(mainDir))
            {
                Directory.CreateDirectory(mainDir);
            }
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            foreach (Process process in processes)
            {
                process.Kill();
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Process process in processes)
            {
                process.Kill();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (File.Exists(pakJSON))
            {
                populateGrid();
            }
            else
            {
                pullJSON();
                populateGrid();
            }
        }

        private void populateGrid()
        {
            try
            {
                string json = File.ReadAllText(pakJSON);
                PAKList = JArray.Parse(json);
                modGrid.DataSource = PAKList;
            }
            catch
            {
                MessageBox.Show("An error occurred while populating PAK list.\n\nIt may be corrupted. Please refresh your list.", "PAK List Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            int result = 0;
            if (Directory.Exists(nxDir))
            {
                using (var repo = new Repository(nxDir))
                {
                    Branch b = repo.Branches["master"];
                    result = (int)b.TrackingDetails.BehindBy;
                }
            }
            else
            {
                var answer = MessageBox.Show("You do not appear to have a repository for SM64 NX.\n\nWould you like to download and build it now?", "Missing Repository", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    if (updateRepo())
                    {
                        return;
                    }
                    if (checkDependencies())
                    {
                        return;
                    }
                    if (buildBase()) return;
                }
            }

            if (result > 0)
            {
                var answer = MessageBox.Show("Your current repository is out of date.\n\nWould you like to update it and rebuild?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    updateRepo();
                }
            }
        }

        private bool buildBase()
        {
            this.outputText.Visible = true;

            if (!File.Exists(Path.Combine(nxDir, "baserom.us.z64")))
            {
                if (File.Exists(Path.Combine(nxDir, "baserom.us.z64")))
                {
                    File.Move(Path.Combine(nxDir, "baserom.us.z64"), Path.Combine(nxDir, "baserom.us.z64"));
                }
                else
                {
                    MessageBox.Show("You are missing baserom.us.z64.\n\nPlease select your baserom.us.z64.", "ROM Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Boolean exit = false;
                    var result = new OpenFileDialog();
                    while (!exit)
                    {
                        if (result.ShowDialog() == DialogResult.OK)
                        {
                            if (checkHash(result.FileName))
                            {
                                File.Copy(result.FileName, Path.Combine(nxDir, "baserom.us.z64"));
                                exit = true;
                            }
                            else
                            {
                                var answer = MessageBox.Show("ROM hash is not valid.\n\nWould you like to select another?", "Invalid ROM Hash", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                if (answer == DialogResult.No) return true;
                            }
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
            if (runProcess("cmd.exe", @"/C build.bat"))
            {
                this.outputText.Text += "Traditional build.bat file failed.\n\nAttempting static calls as a fallback...\n\n";

                if (runProcess("cmd.exe", " /C py extract_assets.py && py ..\\scripts\\pak.py --source . --output ..\\romfs\\!!base.pak"))
                {
                    MessageBox.Show("!!Base.pak failed to build.\n\nCheck for error messages in log or share them with troubleshooters.", "Base PAK Build Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            
            return false;
        }

        private void pullJSON()
        {
            string url = "https://api.jsonbin.io/b/5f05f3e0a62f9b4b27613c5a/latest";

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                File.WriteAllText(pakJSON, reader.ReadToEnd());
            }
        }

        private void pullJSON(object sender, EventArgs e)
        {
            string url = "https://api.jsonbin.io/b/5f05f3e0a62f9b4b27613c5a/latest";

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                File.WriteAllText(pakJSON, reader.ReadToEnd());
            }

            populateGrid();
        }

        private void outputText_TextChanged(object sender, EventArgs e)
        {
            this.outputText.SelectionStart = this.outputText.Text.Length;
            this.outputText.ScrollToCaret();
        }

        private void selectedModsButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in modGrid.Rows)
            {
                Boolean enable = Convert.ToBoolean(row.Cells[0].Value);

                PAK pak = new PAK();
                pak.modName = row.Cells[1].Value.ToString();
                pak.modCreator = row.Cells[2].Value.ToString();
                pak.modDesc = row.Cells[3].Value.ToString();
                pak.modDir = row.Cells[4].Value.ToString();
                pak.modURL = row.Cells[5].Value.ToString();
                pak.modFile = row.Cells[6].Value.ToString();

                if (enable)
                {
                    enablePAK(pak);
                }
                else
                {
                    disablePAK(pak);
                }
            }

            if (launch())
            {
                Application.Exit();
            }
        }

        private bool launch()
        {
            if (!File.Exists(Path.Combine(pakDir,"!!base.pak")))
            {
                MessageBox.Show("You do not have !!base.pak.\n\nIt will need to be generated from baserom.us.z64 before launching.\n\nThis is a one-time process.", "Base Build Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (checkDependencies()) return false;
                if (buildBase()) return false;
            }
            Process sm64nx = new Process();

            ProcessStartInfo sm64nxStart = new ProcessStartInfo();
            sm64nxStart.FileName = Path.Combine(nxDir,"sm64.exe");
            sm64nxStart.WorkingDirectory = nxDir;

            sm64nx.StartInfo = sm64nxStart;
            sm64nx.Start();

            return true;
        }

        private void enablePAK(PAK pak)
        {
            if (Directory.Exists(Path.Combine(pakDir,"~" + modDir)))
            {
                Directory.Move(Path.Combine(pakDir, "~" + modDir), Path.Combine(pakDir, pak.modDir));
            }
            else if (!Directory.Exists(Path.Combine(pakDir, pak.modDir)))
            {
                downloadPak(pak);
            }
        }

        private void disablePAK(PAK pak)
        {
            if (Directory.Exists(Path.Combine(pakDir,pak.modDir)))
            {
                Directory.Move(Path.Combine(pakDir, pak.modDir), Path.Combine(pakDir, "~" + pak.modDir));
            }
        }

        private void downloadPak(PAK pak)
        {
            using (var client = new WebClient())
            {
                if (!Directory.Exists(Path.Combine(pakDir, pak.modDir)))
                {
                    Directory.CreateDirectory(Path.Combine(pakDir, pak.modDir));
                }
                client.DownloadFile(pak.modURL, Path.Combine(pakDir, pak.modDir, pak.modFile));
            }
        }

        private Boolean checkDependencies()
        {
            this.outputText.Visible = true;

            this.outputText.Text += "Python Dependency Update\n";
            if (runProcess("cmd.exe", @"/C py -m pip install --upgrade pip wheel pillow zstandard tqdm xxhash"))
            {
                MessageBox.Show("Unable to update dependencies.\n\nCheck the log output or provide it for support.", "Dependency Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            this.outputText.Text += "Python dependencies updated!";
            return false;
        }

        private Boolean runProcess(string filename, string arguments)
        {
            this.outputText.Text += "\nExecuting " + filename + arguments + "\n";

            ProcessStartInfo sInfo = new ProcessStartInfo();
            sInfo.FileName = filename;
            sInfo.Arguments = arguments;
            sInfo.WorkingDirectory = Path.Combine(nxDir, "import");
            sInfo.RedirectStandardOutput = true;
            sInfo.RedirectStandardError = true;
            sInfo.UseShellExecute = false;
            sInfo.CreateNoWindow = true;

            Process process = new Process();
            process.StartInfo = sInfo;
            processes.Add(process);

            process.OutputDataReceived += new DataReceivedEventHandler((s, e) =>
            {
                this.BeginInvoke(new MethodInvoker(() =>
                {
                    this.outputText.Text += e.Data + "\n";
                }));
            });

            process.ErrorDataReceived += new DataReceivedEventHandler((s, e) =>
            {
                this.BeginInvoke(new MethodInvoker(() =>
                {
                    this.outputText.Text += e.Data + "\n";
                }));
            });

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            while (!process.HasExited)
            {
                Application.DoEvents();
            }

            processes.Remove(process);
            
            if (process.ExitCode > 0)
            {
                return true;
            }

            process.Close();

            return false;
        }

        private Boolean updateRepo()
        {
            if (Directory.Exists(nxDir))
            {
                using (var repo = new Repository(nxDir))
                {
                    try
                    {
                        Commands.Pull(repo, new Signature("guest", "guest", DateTimeOffset.Now), new PullOptions());
                    }
                    catch
                    {
                        MessageBox.Show("Unable to update repository.\n\nCheck your Internet connect or try again later.", "Repository Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                }
            }
            else
            {
                MessageBox.Show("You are about to download the sm64nx repository.\n\nDepending on your system, this could take several minutes.\n\nDownload will begin when you clikc OK.", "Repository Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    Repository.Clone("https://github.com/teamsalta/sm64nx.git", nxDir);
                }
                catch
                {
                    MessageBox.Show("An error occurred cloning the repository.");
                    return true;
                }
            }

            return false;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (updateRepo())
            {
                MessageBox.Show("Unable to update repository.\n\nCheck your Internet connect or try again later.", "Repository Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkDependencies())
            {
                MessageBox.Show("Unable to update dependencies.\n\nCheck the log output or provide it for support.", "Dependency Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private Boolean checkHash(string file)
        {
            using (SHA1Managed sha1Hasher = new SHA1Managed())
            using (FileStream stream = new FileStream(file, FileMode.Open))
            using (BufferedStream buffer = new BufferedStream(stream))
            {
                byte[] hash = sha1Hasher.ComputeHash(buffer);
                StringBuilder hashString = new StringBuilder(2 * hash.Length);
                foreach (byte b in hash)
                {
                    hashString.AppendFormat("{0:x2}", b);
                }

                if (hashString.ToString() == "9bef1128717f958171a4afac3ed78ee2bb4e86ce") return true;
            }
            return false;
        }
    }
    public class PAK
    {
        public string modName { get; set; }
        public string modDesc { get; set; }
        public string modURL { get; set; }
        public string modDir { get; set; }
        public string modFile { get; set; }
        public string modCreator { get; set; }
    }
}
