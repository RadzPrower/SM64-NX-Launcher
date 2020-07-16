using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64_NX_Launcher
{
    public partial class addForm : Form
    {
        private string filename;
        public addForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            var result = new OpenFileDialog();

            if (result.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(result.FileName) == ".pak")
                {
                    this.fileText.Text = result.FileName;
                    filename = result.SafeFileName;
                    this.nameText.Text = filename.Substring(0, filename.Length - 4);
                }
                else
                {
                    MessageBox.Show("The selected file is not a valid PAK file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PAK pak = new PAK();

            pak.modName = this.nameText.Text;
            pak.modCreator = this.creatorText.Text;
            pak.modType = this.typeCombo.Text;
            pak.modDesc = this.descText.Text;
            pak.modFile = filename;
            pak.modDir = filename.Substring(0, filename.Length - 4);

            if (!Directory.Exists(Path.Combine(mainForm.pakDir, "~" + pak.modDir)))
            {
                Directory.CreateDirectory(Path.Combine(mainForm.pakDir, "~" + pak.modDir));
                File.Copy(this.fileText.Text, Path.Combine(mainForm.pakDir, "~" + pak.modDir, pak.modFile));
            }
            else
            {
                MessageBox.Show("A directory already exists for this PAK filename.\n\nIf you still wish to add this PAK file, you must either rename this PAK file or delete the existing directory.",
                    "Directory Already Exists",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string jsonString = File.ReadAllText(mainForm.localJSON);
            var list = JsonConvert.DeserializeObject<List<PAK>>(jsonString);
            list.Add(pak);
            var convertedJSON = JsonConvert.SerializeObject(list);
            File.WriteAllText(mainForm.localJSON, convertedJSON);

            this.Close();
        }
    }
}
