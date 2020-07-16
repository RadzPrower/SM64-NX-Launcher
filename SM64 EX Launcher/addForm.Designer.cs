namespace SM64_NX_Launcher
{
    partial class addForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addForm));
            this.localLabel = new System.Windows.Forms.Label();
            this.fileText = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.creatorText = new System.Windows.Forms.TextBox();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.descText = new System.Windows.Forms.RichTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // localLabel
            // 
            this.localLabel.AutoSize = true;
            this.localLabel.Location = new System.Drawing.Point(15, 12);
            this.localLabel.Name = "localLabel";
            this.localLabel.Size = new System.Drawing.Size(76, 13);
            this.localLabel.TabIndex = 0;
            this.localLabel.Text = "Local PAK File";
            // 
            // fileText
            // 
            this.fileText.Location = new System.Drawing.Point(15, 28);
            this.fileText.Name = "fileText";
            this.fileText.Size = new System.Drawing.Size(248, 20);
            this.fileText.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.AutoSize = true;
            this.browseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseButton.Location = new System.Drawing.Point(269, 26);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(26, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(15, 67);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(200, 20);
            this.nameText.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(15, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "PAK Mod Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PAK Type";
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Items.AddRange(new object[] {
            "Texture",
            "Model",
            "Music",
            "Misc",
            "Combo"});
            this.typeCombo.Location = new System.Drawing.Point(301, 26);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(121, 21);
            this.typeCombo.TabIndex = 6;
            this.typeCombo.Text = "Select PAK type...";
            // 
            // creatorText
            // 
            this.creatorText.Location = new System.Drawing.Point(222, 67);
            this.creatorText.Name = "creatorText";
            this.creatorText.Size = new System.Drawing.Size(200, 20);
            this.creatorText.TabIndex = 7;
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Location = new System.Drawing.Point(219, 51);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(65, 13);
            this.creatorLabel.TabIndex = 8;
            this.creatorLabel.Text = "PAK Creator";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(15, 90);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(84, 13);
            this.descLabel.TabIndex = 9;
            this.descLabel.Text = "Brief Description";
            // 
            // descText
            // 
            this.descText.Location = new System.Drawing.Point(15, 106);
            this.descText.Name = "descText";
            this.descText.Size = new System.Drawing.Size(407, 31);
            this.descText.TabIndex = 10;
            this.descText.Text = "";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(347, 143);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(269, 143);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1159, 641);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.descText);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.creatorLabel);
            this.Controls.Add(this.creatorText);
            this.Controls.Add(this.typeCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.fileText);
            this.Controls.Add(this.localLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "addForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Local PAK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label localLabel;
        private System.Windows.Forms.TextBox fileText;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.TextBox creatorText;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.RichTextBox descText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
    }
}