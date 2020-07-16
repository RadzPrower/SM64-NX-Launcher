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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.onlineGrid = new System.Windows.Forms.DataGridView();
            this.modChecks = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectedModsButton = new System.Windows.Forms.Button();
            this.noModsButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.jsonButton = new System.Windows.Forms.Button();
            this.localGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.closeCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.onlineGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // onlineGrid
            // 
            this.onlineGrid.AllowUserToAddRows = false;
            this.onlineGrid.AllowUserToDeleteRows = false;
            this.onlineGrid.AutoGenerateColumns = false;
            this.onlineGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.onlineGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.onlineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.onlineGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modChecks,
            this.dataGridViewTextBoxColumn3,
            this.modCreator,
            this.modType,
            this.dataGridViewTextBoxColumn4,
            this.modDir,
            this.modURL,
            this.modFile,
            this.modHash});
            this.onlineGrid.DataSource = this.pAKBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.onlineGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.onlineGrid.Location = new System.Drawing.Point(171, 32);
            this.onlineGrid.Name = "onlineGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.onlineGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.onlineGrid.RowHeadersVisible = false;
            this.onlineGrid.Size = new System.Drawing.Size(800, 233);
            this.onlineGrid.TabIndex = 0;
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "modName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mod";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 53;
            // 
            // modCreator
            // 
            this.modCreator.DataPropertyName = "modCreator";
            this.modCreator.HeaderText = "Creator";
            this.modCreator.Name = "modCreator";
            this.modCreator.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // modType
            // 
            this.modType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.modType.DataPropertyName = "modType";
            this.modType.HeaderText = "Type";
            this.modType.Name = "modType";
            this.modType.ReadOnly = true;
            this.modType.Width = 56;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "modDesc";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // modDir
            // 
            this.modDir.DataPropertyName = "modDir";
            this.modDir.HeaderText = "modDir";
            this.modDir.Name = "modDir";
            this.modDir.ReadOnly = true;
            this.modDir.Visible = false;
            this.modDir.Width = 65;
            // 
            // modURL
            // 
            this.modURL.DataPropertyName = "modURL";
            this.modURL.HeaderText = "modURL";
            this.modURL.Name = "modURL";
            this.modURL.ReadOnly = true;
            this.modURL.Visible = false;
            this.modURL.Width = 74;
            // 
            // modFile
            // 
            this.modFile.DataPropertyName = "modFile";
            this.modFile.HeaderText = "modFile";
            this.modFile.Name = "modFile";
            this.modFile.ReadOnly = true;
            this.modFile.Visible = false;
            this.modFile.Width = 68;
            // 
            // modHash
            // 
            this.modHash.DataPropertyName = "modHash";
            this.modHash.HeaderText = "modHash";
            this.modHash.Name = "modHash";
            this.modHash.ReadOnly = true;
            this.modHash.Visible = false;
            // 
            // pAKBindingSource
            // 
            this.pAKBindingSource.DataSource = typeof(SM64_NX_Launcher.PAK);
            this.pAKBindingSource.Sort = "";
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
            this.noModsButton.Location = new System.Drawing.Point(15, 46);
            this.noModsButton.Name = "noModsButton";
            this.noModsButton.Size = new System.Drawing.Size(150, 25);
            this.noModsButton.TabIndex = 2;
            this.noModsButton.Text = "Launch w/No Mods";
            this.noModsButton.UseVisualStyleBackColor = true;
            this.noModsButton.Click += new System.EventHandler(this.noModsButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Enabled = false;
            this.settingsButton.Location = new System.Drawing.Point(1058, 240);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(150, 25);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Visible = false;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(15, 240);
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
            this.outputText.Location = new System.Drawing.Point(15, 536);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(956, 191);
            this.outputText.TabIndex = 6;
            this.outputText.Text = "";
            this.outputText.Visible = false;
            this.outputText.TextChanged += new System.EventHandler(this.outputText_TextChanged);
            // 
            // jsonButton
            // 
            this.jsonButton.Location = new System.Drawing.Point(15, 77);
            this.jsonButton.Name = "jsonButton";
            this.jsonButton.Size = new System.Drawing.Size(150, 25);
            this.jsonButton.TabIndex = 7;
            this.jsonButton.Text = "Check for PAK Updates";
            this.jsonButton.UseVisualStyleBackColor = true;
            this.jsonButton.Click += new System.EventHandler(this.pullJSON);
            // 
            // localGrid
            // 
            this.localGrid.AllowUserToAddRows = false;
            this.localGrid.AllowUserToDeleteRows = false;
            this.localGrid.AutoGenerateColumns = false;
            this.localGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.localGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.localGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.localGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.localGrid.DataSource = this.pAKBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.localGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.localGrid.Location = new System.Drawing.Point(171, 297);
            this.localGrid.Name = "localGrid";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.localGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.localGrid.RowHeadersVisible = false;
            this.localGrid.Size = new System.Drawing.Size(800, 233);
            this.localGrid.TabIndex = 8;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.ToolTipText = "Allows you turn mods on or off.";
            this.dataGridViewCheckBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "modName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mod";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 53;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "modCreator";
            this.dataGridViewTextBoxColumn6.HeaderText = "Creator";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 66;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "modType";
            this.dataGridViewTextBoxColumn7.HeaderText = "Type";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 56;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "modDesc";
            this.dataGridViewTextBoxColumn8.HeaderText = "Description";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "modDir";
            this.dataGridViewTextBoxColumn9.HeaderText = "modDir";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "modURL";
            this.dataGridViewTextBoxColumn10.HeaderText = "modURL";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "modFile";
            this.dataGridViewTextBoxColumn11.HeaderText = "modFile";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "modHash";
            this.dataGridViewTextBoxColumn12.HeaderText = "modHash";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Location = new System.Drawing.Point(172, 16);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(110, 13);
            this.databaseLabel.TabIndex = 9;
            this.databaseLabel.Text = "Online PAK Database";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(172, 281);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(106, 13);
            this.userLabel.TabIndex = 10;
            this.userLabel.Text = "Local PAK Database";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(15, 505);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(150, 25);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Remove Selected PAKs";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 297);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 25);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add Local PAK File";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // closeCheck
            // 
            this.closeCheck.Location = new System.Drawing.Point(15, 108);
            this.closeCheck.Name = "closeCheck";
            this.closeCheck.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.closeCheck.Size = new System.Drawing.Size(150, 30);
            this.closeCheck.TabIndex = 13;
            this.closeCheck.Text = "Leave Launcher Open\r\nAfter Launching Game";
            this.closeCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeCheck.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1278, 812);
            this.Controls.Add(this.closeCheck);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.localGrid);
            this.Controls.Add(this.jsonButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.noModsButton);
            this.Controls.Add(this.selectedModsButton);
            this.Controls.Add(this.onlineGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Super Mario 64 NX Launcher v";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.mainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.onlineGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView onlineGrid;
        private System.Windows.Forms.Button selectedModsButton;
        private System.Windows.Forms.Button noModsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn modNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modDirDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.Button jsonButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource pAKBindingSource;
        private System.Windows.Forms.DataGridView localGrid;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modChecks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn modCreator;
        private System.Windows.Forms.DataGridViewTextBoxColumn modType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn modDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn modURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn modFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn modHash;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.CheckBox closeCheck;
    }
}

