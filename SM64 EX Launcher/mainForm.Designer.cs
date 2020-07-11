namespace SM64_NX_Launcher
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.modGrid = new System.Windows.Forms.DataGridView();
            this.selectedModsButton = new System.Windows.Forms.Button();
            this.noModsButton = new System.Windows.Forms.Button();
            this.allModsButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.jsonButton = new System.Windows.Forms.Button();
            this.pAKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.modChecks = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.modGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAKBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // modGrid
            // 
            this.modGrid.AllowUserToAddRows = false;
            this.modGrid.AllowUserToDeleteRows = false;
            this.modGrid.AutoGenerateColumns = false;
            this.modGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.modGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modChecks,
            this.dataGridViewTextBoxColumn1,
            this.modCreator,
            this.dataGridViewTextBoxColumn2,
            this.modDir,
            this.modURL,
            this.modFile});
            this.modGrid.DataSource = this.pAKBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.modGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.modGrid.Location = new System.Drawing.Point(171, 15);
            this.modGrid.Name = "modGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.modGrid.RowHeadersVisible = false;
            this.modGrid.Size = new System.Drawing.Size(850, 339);
            this.modGrid.TabIndex = 0;
            // 
            // selectedModsButton
            // 
            this.selectedModsButton.Location = new System.Drawing.Point(15, 15);
            this.selectedModsButton.Name = "selectedModsButton";
            this.selectedModsButton.Size = new System.Drawing.Size(150, 25);
            this.selectedModsButton.TabIndex = 1;
            this.selectedModsButton.Text = "Launch w/Selected Mods";
            this.selectedModsButton.UseVisualStyleBackColor = true;
            this.selectedModsButton.Click += new System.EventHandler(this.selectedModsButton_Click);
            // 
            // noModsButton
            // 
            this.noModsButton.Enabled = false;
            this.noModsButton.Location = new System.Drawing.Point(15, 77);
            this.noModsButton.Name = "noModsButton";
            this.noModsButton.Size = new System.Drawing.Size(150, 25);
            this.noModsButton.TabIndex = 2;
            this.noModsButton.Text = "Launch w/No Mods";
            this.noModsButton.UseVisualStyleBackColor = true;
            // 
            // allModsButton
            // 
            this.allModsButton.Enabled = false;
            this.allModsButton.Location = new System.Drawing.Point(15, 46);
            this.allModsButton.Name = "allModsButton";
            this.allModsButton.Size = new System.Drawing.Size(150, 25);
            this.allModsButton.TabIndex = 3;
            this.allModsButton.Text = "Launch w/All Mods";
            this.allModsButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Enabled = false;
            this.settingsButton.Location = new System.Drawing.Point(15, 329);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(150, 25);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(15, 298);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(150, 25);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Check For Updates";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.SystemColors.Window;
            this.outputText.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.ForeColor = System.Drawing.SystemColors.InfoText;
            this.outputText.Location = new System.Drawing.Point(15, 360);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(1006, 350);
            this.outputText.TabIndex = 6;
            this.outputText.Text = "";
            this.outputText.Visible = false;
            this.outputText.TextChanged += new System.EventHandler(this.outputText_TextChanged);
            // 
            // jsonButton
            // 
            this.jsonButton.Location = new System.Drawing.Point(15, 267);
            this.jsonButton.Name = "jsonButton";
            this.jsonButton.Size = new System.Drawing.Size(150, 25);
            this.jsonButton.TabIndex = 7;
            this.jsonButton.Text = "Check for PAK Updates";
            this.jsonButton.UseVisualStyleBackColor = true;
            this.jsonButton.Click += new System.EventHandler(this.pullJSON);
            // 
            // pAKBindingSource
            // 
            this.pAKBindingSource.DataSource = typeof(SM64_NX_Launcher.PAK);
            // 
            // pAKBindingSource1
            // 
            this.pAKBindingSource1.DataSource = typeof(SM64_NX_Launcher.PAK);
            // 
            // modChecks
            // 
            this.modChecks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.modChecks.HeaderText = "";
            this.modChecks.Name = "modChecks";
            this.modChecks.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.modChecks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.modChecks.ToolTipText = "Allows you turn mods on or off.";
            this.modChecks.Width = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "modName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // modCreator
            // 
            this.modCreator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.modCreator.DataPropertyName = "modCreator";
            this.modCreator.HeaderText = "Creator";
            this.modCreator.Name = "modCreator";
            this.modCreator.Width = 66;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "modDesc";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // modDir
            // 
            this.modDir.DataPropertyName = "modDir";
            this.modDir.HeaderText = "modDir";
            this.modDir.Name = "modDir";
            this.modDir.ReadOnly = true;
            this.modDir.Visible = false;
            // 
            // modURL
            // 
            this.modURL.DataPropertyName = "modURL";
            this.modURL.HeaderText = "modURL";
            this.modURL.Name = "modURL";
            this.modURL.ReadOnly = true;
            this.modURL.Visible = false;
            // 
            // modFile
            // 
            this.modFile.DataPropertyName = "modFile";
            this.modFile.HeaderText = "modFile";
            this.modFile.Name = "modFile";
            this.modFile.ReadOnly = true;
            this.modFile.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1278, 812);
            this.Controls.Add(this.jsonButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.allModsButton);
            this.Controls.Add(this.noModsButton);
            this.Controls.Add(this.selectedModsButton);
            this.Controls.Add(this.modGrid);
            this.Name = "mainForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Super Mario 64 NX Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.mainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.modGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAKBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView modGrid;
        private System.Windows.Forms.Button selectedModsButton;
        private System.Windows.Forms.Button noModsButton;
        private System.Windows.Forms.Button allModsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn modNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modDirDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.Button jsonButton;
        private System.Windows.Forms.BindingSource pAKBindingSource1;
        private System.Windows.Forms.BindingSource pAKBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modChecks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modCreator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn modDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn modURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn modFile;
    }
}

