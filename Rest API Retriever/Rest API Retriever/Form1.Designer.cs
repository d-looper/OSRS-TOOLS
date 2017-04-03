namespace SBR_DocDesigner
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SBTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBackup = new System.Windows.Forms.RadioButton();
            this.rbDefault = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTest = new System.Windows.Forms.RadioButton();
            this.rbPro = new System.Windows.Forms.RadioButton();
            this.btnClr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDesign = new System.Windows.Forms.ComboBox();
            this.btnPut = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbResponse = new System.Windows.Forms.RichTextBox();
            this.lblAPI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Settings = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDefaultTemplatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPreview = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SBTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Settings.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SBTab);
            this.tabControl1.Controls.Add(this.Settings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1303, 815);
            this.tabControl1.TabIndex = 0;
            // 
            // SBTab
            // 
            this.SBTab.Controls.Add(this.btnPreview);
            this.SBTab.Controls.Add(this.groupBox2);
            this.SBTab.Controls.Add(this.groupBox1);
            this.SBTab.Controls.Add(this.btnClr);
            this.SBTab.Controls.Add(this.label3);
            this.SBTab.Controls.Add(this.cbDesign);
            this.SBTab.Controls.Add(this.btnPut);
            this.SBTab.Controls.Add(this.btnClose);
            this.SBTab.Controls.Add(this.tbResponse);
            this.SBTab.Controls.Add(this.lblAPI);
            this.SBTab.Controls.Add(this.label2);
            this.SBTab.Controls.Add(this.label1);
            this.SBTab.Controls.Add(this.comboBox1);
            this.SBTab.Location = new System.Drawing.Point(4, 22);
            this.SBTab.Name = "SBTab";
            this.SBTab.Padding = new System.Windows.Forms.Padding(3);
            this.SBTab.Size = new System.Drawing.Size(1295, 789);
            this.SBTab.TabIndex = 0;
            this.SBTab.Text = "Springboard";
            this.SBTab.UseVisualStyleBackColor = true;
            this.SBTab.Click += new System.EventHandler(this.SBTab_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBackup);
            this.groupBox2.Controls.Add(this.rbDefault);
            this.groupBox2.Controls.Add(this.rbCustomer);
            this.groupBox2.Location = new System.Drawing.Point(808, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 89);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Design Location";
            // 
            // rbBackup
            // 
            this.rbBackup.AutoSize = true;
            this.rbBackup.Location = new System.Drawing.Point(18, 63);
            this.rbBackup.Name = "rbBackup";
            this.rbBackup.Size = new System.Drawing.Size(103, 17);
            this.rbBackup.TabIndex = 19;
            this.rbBackup.TabStop = true;
            this.rbBackup.Text = "Backup Designs";
            this.rbBackup.UseVisualStyleBackColor = true;
            this.rbBackup.CheckedChanged += new System.EventHandler(this.rbBackup_CheckedChanged);
            // 
            // rbDefault
            // 
            this.rbDefault.AutoSize = true;
            this.rbDefault.Location = new System.Drawing.Point(18, 17);
            this.rbDefault.Name = "rbDefault";
            this.rbDefault.Size = new System.Drawing.Size(100, 17);
            this.rbDefault.TabIndex = 17;
            this.rbDefault.TabStop = true;
            this.rbDefault.Text = "Default Designs";
            this.rbDefault.UseVisualStyleBackColor = true;
            this.rbDefault.CheckedChanged += new System.EventHandler(this.rbDefault_CheckedChanged);
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Location = new System.Drawing.Point(18, 40);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(110, 17);
            this.rbCustomer.TabIndex = 18;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "Customer Designs";
            this.rbCustomer.UseVisualStyleBackColor = true;
            this.rbCustomer.CheckedChanged += new System.EventHandler(this.rbCustomer_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTest);
            this.groupBox1.Controls.Add(this.rbPro);
            this.groupBox1.Location = new System.Drawing.Point(595, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 89);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Account";
            // 
            // rbTest
            // 
            this.rbTest.AutoSize = true;
            this.rbTest.Location = new System.Drawing.Point(18, 16);
            this.rbTest.Name = "rbTest";
            this.rbTest.Size = new System.Drawing.Size(103, 17);
            this.rbTest.TabIndex = 12;
            this.rbTest.TabStop = true;
            this.rbTest.Text = "Testing Account";
            this.rbTest.UseVisualStyleBackColor = true;
            this.rbTest.CheckedChanged += new System.EventHandler(this.rbTest_CheckedChanged);
            // 
            // rbPro
            // 
            this.rbPro.AutoSize = true;
            this.rbPro.Location = new System.Drawing.Point(18, 39);
            this.rbPro.Name = "rbPro";
            this.rbPro.Size = new System.Drawing.Size(119, 17);
            this.rbPro.TabIndex = 13;
            this.rbPro.TabStop = true;
            this.rbPro.Text = "Production Account";
            this.rbPro.UseVisualStyleBackColor = true;
            this.rbPro.CheckedChanged += new System.EventHandler(this.rbPro_CheckedChanged);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(1208, 178);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(75, 23);
            this.btnClr.TabIndex = 16;
            this.btnClr.Text = "Clear Text";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Design Template";
            // 
            // cbDesign
            // 
            this.cbDesign.FormattingEnabled = true;
            this.cbDesign.Location = new System.Drawing.Point(8, 116);
            this.cbDesign.Name = "cbDesign";
            this.cbDesign.Size = new System.Drawing.Size(543, 21);
            this.cbDesign.TabIndex = 14;
            this.cbDesign.SelectedIndexChanged += new System.EventHandler(this.cbDesign_SelectedIndexChanged);
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(1095, 28);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(75, 23);
            this.btnPut.TabIndex = 10;
            this.btnPut.Text = "Put";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1208, 28);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbResponse
            // 
            this.tbResponse.AcceptsTab = true;
            this.tbResponse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbResponse.Location = new System.Drawing.Point(3, 207);
            this.tbResponse.Name = "tbResponse";
            this.tbResponse.Size = new System.Drawing.Size(1289, 579);
            this.tbResponse.TabIndex = 7;
            this.tbResponse.TabStop = false;
            this.tbResponse.Text = "";
            // 
            // lblAPI
            // 
            this.lblAPI.AllowDrop = true;
            this.lblAPI.AutoSize = true;
            this.lblAPI.Location = new System.Drawing.Point(9, 75);
            this.lblAPI.Name = "lblAPI";
            this.lblAPI.Size = new System.Drawing.Size(53, 13);
            this.lblAPI.TabIndex = 3;
            this.lblAPI.Text = "API Label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "API Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(543, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.textBox1);
            this.Settings.Controls.Add(this.label5);
            this.Settings.Controls.Add(this.label4);
            this.Settings.Controls.Add(this.btnBackup);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(1295, 789);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SBR_DocDesigner.Properties.Settings.Default, "SaveLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(11, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = global::SBR_DocDesigner.Properties.Settings.Default.SaveLocation;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Backup File Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Backup Customer Designs";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(11, 41);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Start";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1303, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateDefaultTemplatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // updateDefaultTemplatesToolStripMenuItem
            // 
            this.updateDefaultTemplatesToolStripMenuItem.Name = "updateDefaultTemplatesToolStripMenuItem";
            this.updateDefaultTemplatesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.updateDefaultTemplatesToolStripMenuItem.Text = "Update Default Templates";
            this.updateDefaultTemplatesToolStripMenuItem.Click += new System.EventHandler(this.updateDefaultTemplatesToolStripMenuItem_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(1095, 178);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 21;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 839);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SBR DocDesigner V 1.0";
            this.tabControl1.ResumeLayout(false);
            this.SBTab.ResumeLayout(false);
            this.SBTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SBTab;
        private System.Windows.Forms.Label lblAPI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.RichTextBox tbResponse;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbPro;
        private System.Windows.Forms.RadioButton rbTest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDefaultTemplatesToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDesign;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.RadioButton rbDefault;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBackup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPreview;
    }
}

