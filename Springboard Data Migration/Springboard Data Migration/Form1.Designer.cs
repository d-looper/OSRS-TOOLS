namespace Springboard_Data_Migration
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
            this.tbURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAPI = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tcVend = new System.Windows.Forms.TabPage();
            this.btnVen = new System.Windows.Forms.Button();
            this.lblVen = new System.Windows.Forms.Label();
            this.tcCust = new System.Windows.Forms.TabPage();
            this.btnCust = new System.Windows.Forms.Button();
            this.lblCust = new System.Windows.Forms.Label();
            this.tcInven = new System.Windows.Forms.TabPage();
            this.tcTickets = new System.Windows.Forms.TabPage();
            this.tcOrder = new System.Windows.Forms.TabPage();
            this.tcPO = new System.Windows.Forms.TabPage();
            this.tcPR = new System.Windows.Forms.TabPage();
            this.tcPRet = new System.Windows.Forms.TabPage();
            this.dgVen = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbAPI = new System.Windows.Forms.TextBox();
            this.btnInv = new System.Windows.Forms.Button();
            this.lblInv = new System.Windows.Forms.Label();
            this.btnTick = new System.Windows.Forms.Button();
            this.lblTick = new System.Windows.Forms.Label();
            this.btnSO = new System.Windows.Forms.Button();
            this.lblSO = new System.Windows.Forms.Label();
            this.btnPO = new System.Windows.Forms.Button();
            this.lblPO = new System.Windows.Forms.Label();
            this.btnPR = new System.Windows.Forms.Button();
            this.lblPR = new System.Windows.Forms.Label();
            this.btnPRet = new System.Windows.Forms.Button();
            this.lblPRet = new System.Windows.Forms.Label();
            this.tcSett = new System.Windows.Forms.TabPage();
            this.btnSett = new System.Windows.Forms.Button();
            this.lblSett = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tcVend.SuspendLayout();
            this.tcCust.SuspendLayout();
            this.tcInven.SuspendLayout();
            this.tcTickets.SuspendLayout();
            this.tcOrder.SuspendLayout();
            this.tcPO.SuspendLayout();
            this.tcPR.SuspendLayout();
            this.tcPRet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVen)).BeginInit();
            this.tcSett.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(23, 40);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(411, 20);
            this.tbURL.TabIndex = 0;
            this.tbURL.TextChanged += new System.EventHandler(this.tbURL_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account URL";
            // 
            // lblAPI
            // 
            this.lblAPI.AutoSize = true;
            this.lblAPI.Location = new System.Drawing.Point(20, 63);
            this.lblAPI.Name = "lblAPI";
            this.lblAPI.Size = new System.Drawing.Size(45, 13);
            this.lblAPI.TabIndex = 2;
            this.lblAPI.Text = "API Key";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tcSett);
            this.tabControl1.Controls.Add(this.tcVend);
            this.tabControl1.Controls.Add(this.tcCust);
            this.tabControl1.Controls.Add(this.tcInven);
            this.tabControl1.Controls.Add(this.tcTickets);
            this.tabControl1.Controls.Add(this.tcOrder);
            this.tabControl1.Controls.Add(this.tcPO);
            this.tabControl1.Controls.Add(this.tcPR);
            this.tabControl1.Controls.Add(this.tcPRet);
            this.tabControl1.Location = new System.Drawing.Point(0, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1209, 168);
            this.tabControl1.TabIndex = 3;
            // 
            // tcVend
            // 
            this.tcVend.Controls.Add(this.btnVen);
            this.tcVend.Controls.Add(this.lblVen);
            this.tcVend.Location = new System.Drawing.Point(4, 22);
            this.tcVend.Name = "tcVend";
            this.tcVend.Padding = new System.Windows.Forms.Padding(3);
            this.tcVend.Size = new System.Drawing.Size(1201, 142);
            this.tcVend.TabIndex = 0;
            this.tcVend.Text = "Vendors";
            this.tcVend.UseVisualStyleBackColor = true;
            // 
            // btnVen
            // 
            this.btnVen.Location = new System.Drawing.Point(11, 47);
            this.btnVen.Name = "btnVen";
            this.btnVen.Size = new System.Drawing.Size(75, 23);
            this.btnVen.TabIndex = 1;
            this.btnVen.Text = "Browse";
            this.btnVen.UseVisualStyleBackColor = true;
            this.btnVen.Click += new System.EventHandler(this.btnVen_Click);
            // 
            // lblVen
            // 
            this.lblVen.AutoSize = true;
            this.lblVen.Location = new System.Drawing.Point(14, 18);
            this.lblVen.Name = "lblVen";
            this.lblVen.Size = new System.Drawing.Size(83, 13);
            this.lblVen.TabIndex = 0;
            this.lblVen.Text = "Vendor filename";
            // 
            // tcCust
            // 
            this.tcCust.Controls.Add(this.btnCust);
            this.tcCust.Controls.Add(this.lblCust);
            this.tcCust.Location = new System.Drawing.Point(4, 22);
            this.tcCust.Name = "tcCust";
            this.tcCust.Padding = new System.Windows.Forms.Padding(3);
            this.tcCust.Size = new System.Drawing.Size(1201, 142);
            this.tcCust.TabIndex = 1;
            this.tcCust.Text = "Customers";
            this.tcCust.UseVisualStyleBackColor = true;
            // 
            // btnCust
            // 
            this.btnCust.Location = new System.Drawing.Point(11, 47);
            this.btnCust.Name = "btnCust";
            this.btnCust.Size = new System.Drawing.Size(75, 23);
            this.btnCust.TabIndex = 4;
            this.btnCust.Text = "Browse";
            this.btnCust.UseVisualStyleBackColor = true;
            this.btnCust.Click += new System.EventHandler(this.btnCust_Click);
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Location = new System.Drawing.Point(14, 18);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(93, 13);
            this.lblCust.TabIndex = 3;
            this.lblCust.Text = "Customer filename";
            // 
            // tcInven
            // 
            this.tcInven.Controls.Add(this.btnInv);
            this.tcInven.Controls.Add(this.lblInv);
            this.tcInven.Location = new System.Drawing.Point(4, 22);
            this.tcInven.Name = "tcInven";
            this.tcInven.Size = new System.Drawing.Size(1201, 142);
            this.tcInven.TabIndex = 7;
            this.tcInven.Text = "Inventory";
            this.tcInven.UseVisualStyleBackColor = true;
            // 
            // tcTickets
            // 
            this.tcTickets.Controls.Add(this.btnTick);
            this.tcTickets.Controls.Add(this.lblTick);
            this.tcTickets.Location = new System.Drawing.Point(4, 22);
            this.tcTickets.Name = "tcTickets";
            this.tcTickets.Size = new System.Drawing.Size(1201, 142);
            this.tcTickets.TabIndex = 2;
            this.tcTickets.Text = "Tickets";
            this.tcTickets.UseVisualStyleBackColor = true;
            // 
            // tcOrder
            // 
            this.tcOrder.Controls.Add(this.btnSO);
            this.tcOrder.Controls.Add(this.lblSO);
            this.tcOrder.Location = new System.Drawing.Point(4, 22);
            this.tcOrder.Name = "tcOrder";
            this.tcOrder.Size = new System.Drawing.Size(1201, 142);
            this.tcOrder.TabIndex = 3;
            this.tcOrder.Text = "Sales Orders";
            this.tcOrder.UseVisualStyleBackColor = true;
            // 
            // tcPO
            // 
            this.tcPO.Controls.Add(this.btnPO);
            this.tcPO.Controls.Add(this.lblPO);
            this.tcPO.Location = new System.Drawing.Point(4, 22);
            this.tcPO.Name = "tcPO";
            this.tcPO.Size = new System.Drawing.Size(1201, 142);
            this.tcPO.TabIndex = 4;
            this.tcPO.Text = "Purchase Orders";
            this.tcPO.UseVisualStyleBackColor = true;
            // 
            // tcPR
            // 
            this.tcPR.Controls.Add(this.btnPR);
            this.tcPR.Controls.Add(this.lblPR);
            this.tcPR.Location = new System.Drawing.Point(4, 22);
            this.tcPR.Name = "tcPR";
            this.tcPR.Size = new System.Drawing.Size(1201, 142);
            this.tcPR.TabIndex = 5;
            this.tcPR.Text = "Purchase Receipts";
            this.tcPR.UseVisualStyleBackColor = true;
            // 
            // tcPRet
            // 
            this.tcPRet.Controls.Add(this.btnPRet);
            this.tcPRet.Controls.Add(this.lblPRet);
            this.tcPRet.Location = new System.Drawing.Point(4, 22);
            this.tcPRet.Name = "tcPRet";
            this.tcPRet.Size = new System.Drawing.Size(1201, 142);
            this.tcPRet.TabIndex = 6;
            this.tcPRet.Text = "Purchase Returns";
            this.tcPRet.UseVisualStyleBackColor = true;
            // 
            // dgVen
            // 
            this.dgVen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVen.Location = new System.Drawing.Point(0, 284);
            this.dgVen.Name = "dgVen";
            this.dgVen.Size = new System.Drawing.Size(1205, 470);
            this.dgVen.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbAPI
            // 
            this.tbAPI.Location = new System.Drawing.Point(23, 79);
            this.tbAPI.Name = "tbAPI";
            this.tbAPI.Size = new System.Drawing.Size(411, 20);
            this.tbAPI.TabIndex = 4;
            // 
            // btnInv
            // 
            this.btnInv.Location = new System.Drawing.Point(11, 47);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(75, 23);
            this.btnInv.TabIndex = 6;
            this.btnInv.Text = "Browse";
            this.btnInv.UseVisualStyleBackColor = true;
            this.btnInv.Click += new System.EventHandler(this.btnInv_Click);
            // 
            // lblInv
            // 
            this.lblInv.AutoSize = true;
            this.lblInv.Location = new System.Drawing.Point(14, 18);
            this.lblInv.Name = "lblInv";
            this.lblInv.Size = new System.Drawing.Size(93, 13);
            this.lblInv.TabIndex = 5;
            this.lblInv.Text = "Inventory filename";
            // 
            // btnTick
            // 
            this.btnTick.Location = new System.Drawing.Point(11, 47);
            this.btnTick.Name = "btnTick";
            this.btnTick.Size = new System.Drawing.Size(75, 23);
            this.btnTick.TabIndex = 6;
            this.btnTick.Text = "Browse";
            this.btnTick.UseVisualStyleBackColor = true;
            this.btnTick.Click += new System.EventHandler(this.btnTick_Click);
            // 
            // lblTick
            // 
            this.lblTick.AutoSize = true;
            this.lblTick.Location = new System.Drawing.Point(14, 18);
            this.lblTick.Name = "lblTick";
            this.lblTick.Size = new System.Drawing.Size(79, 13);
            this.lblTick.TabIndex = 5;
            this.lblTick.Text = "Ticket filename";
            // 
            // btnSO
            // 
            this.btnSO.Location = new System.Drawing.Point(11, 47);
            this.btnSO.Name = "btnSO";
            this.btnSO.Size = new System.Drawing.Size(75, 23);
            this.btnSO.TabIndex = 6;
            this.btnSO.Text = "Browse";
            this.btnSO.UseVisualStyleBackColor = true;
            this.btnSO.Click += new System.EventHandler(this.btnSO_Click);
            // 
            // lblSO
            // 
            this.lblSO.AutoSize = true;
            this.lblSO.Location = new System.Drawing.Point(14, 18);
            this.lblSO.Name = "lblSO";
            this.lblSO.Size = new System.Drawing.Size(64, 13);
            this.lblSO.TabIndex = 5;
            this.lblSO.Text = "SO filename";
            // 
            // btnPO
            // 
            this.btnPO.Location = new System.Drawing.Point(11, 47);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(75, 23);
            this.btnPO.TabIndex = 6;
            this.btnPO.Text = "Browse";
            this.btnPO.UseVisualStyleBackColor = true;
            this.btnPO.Click += new System.EventHandler(this.btnPO_Click);
            // 
            // lblPO
            // 
            this.lblPO.AutoSize = true;
            this.lblPO.Location = new System.Drawing.Point(14, 18);
            this.lblPO.Name = "lblPO";
            this.lblPO.Size = new System.Drawing.Size(64, 13);
            this.lblPO.TabIndex = 5;
            this.lblPO.Text = "PO filename";
            // 
            // btnPR
            // 
            this.btnPR.Location = new System.Drawing.Point(11, 47);
            this.btnPR.Name = "btnPR";
            this.btnPR.Size = new System.Drawing.Size(75, 23);
            this.btnPR.TabIndex = 6;
            this.btnPR.Text = "Browse";
            this.btnPR.UseVisualStyleBackColor = true;
            this.btnPR.Click += new System.EventHandler(this.btnPR_Click);
            // 
            // lblPR
            // 
            this.lblPR.AutoSize = true;
            this.lblPR.Location = new System.Drawing.Point(14, 18);
            this.lblPR.Name = "lblPR";
            this.lblPR.Size = new System.Drawing.Size(64, 13);
            this.lblPR.TabIndex = 5;
            this.lblPR.Text = "PR filename";
            // 
            // btnPRet
            // 
            this.btnPRet.Location = new System.Drawing.Point(11, 47);
            this.btnPRet.Name = "btnPRet";
            this.btnPRet.Size = new System.Drawing.Size(75, 23);
            this.btnPRet.TabIndex = 6;
            this.btnPRet.Text = "Browse";
            this.btnPRet.UseVisualStyleBackColor = true;
            this.btnPRet.Click += new System.EventHandler(this.btnPRet_Click);
            // 
            // lblPRet
            // 
            this.lblPRet.AutoSize = true;
            this.lblPRet.Location = new System.Drawing.Point(14, 18);
            this.lblPRet.Name = "lblPRet";
            this.lblPRet.Size = new System.Drawing.Size(73, 13);
            this.lblPRet.TabIndex = 5;
            this.lblPRet.Text = "PRet filename";
            // 
            // tcSett
            // 
            this.tcSett.Controls.Add(this.btnSett);
            this.tcSett.Controls.Add(this.lblSett);
            this.tcSett.Location = new System.Drawing.Point(4, 22);
            this.tcSett.Name = "tcSett";
            this.tcSett.Padding = new System.Windows.Forms.Padding(3);
            this.tcSett.Size = new System.Drawing.Size(1201, 142);
            this.tcSett.TabIndex = 8;
            this.tcSett.Text = "Settings";
            this.tcSett.UseVisualStyleBackColor = true;
            // 
            // btnSett
            // 
            this.btnSett.Location = new System.Drawing.Point(11, 47);
            this.btnSett.Name = "btnSett";
            this.btnSett.Size = new System.Drawing.Size(75, 23);
            this.btnSett.TabIndex = 3;
            this.btnSett.Text = "Browse";
            this.btnSett.UseVisualStyleBackColor = true;
            this.btnSett.Click += new System.EventHandler(this.btnSett_Click);
            // 
            // lblSett
            // 
            this.lblSett.AutoSize = true;
            this.lblSett.Location = new System.Drawing.Point(14, 18);
            this.lblSett.Name = "lblSett";
            this.lblSett.Size = new System.Drawing.Size(87, 13);
            this.lblSett.TabIndex = 2;
            this.lblSett.Text = "Settings filename";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 754);
            this.Controls.Add(this.dgVen);
            this.Controls.Add(this.tbAPI);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblAPI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbURL);
            this.Name = "Form1";
            this.Text = "REST Data Migration Tool";
            this.tabControl1.ResumeLayout(false);
            this.tcVend.ResumeLayout(false);
            this.tcVend.PerformLayout();
            this.tcCust.ResumeLayout(false);
            this.tcCust.PerformLayout();
            this.tcInven.ResumeLayout(false);
            this.tcInven.PerformLayout();
            this.tcTickets.ResumeLayout(false);
            this.tcTickets.PerformLayout();
            this.tcOrder.ResumeLayout(false);
            this.tcOrder.PerformLayout();
            this.tcPO.ResumeLayout(false);
            this.tcPO.PerformLayout();
            this.tcPR.ResumeLayout(false);
            this.tcPR.PerformLayout();
            this.tcPRet.ResumeLayout(false);
            this.tcPRet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVen)).EndInit();
            this.tcSett.ResumeLayout(false);
            this.tcSett.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAPI;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tcVend;
        private System.Windows.Forms.TabPage tcCust;
        private System.Windows.Forms.TabPage tcInven;
        private System.Windows.Forms.TabPage tcTickets;
        private System.Windows.Forms.TabPage tcOrder;
        private System.Windows.Forms.TabPage tcPO;
        private System.Windows.Forms.TabPage tcPR;
        private System.Windows.Forms.TabPage tcPRet;
        private System.Windows.Forms.Button btnVen;
        private System.Windows.Forms.Label lblVen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgVen;
        private System.Windows.Forms.TextBox tbAPI;
        private System.Windows.Forms.Button btnCust;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.Label lblInv;
        private System.Windows.Forms.Button btnTick;
        private System.Windows.Forms.Label lblTick;
        private System.Windows.Forms.Button btnSO;
        private System.Windows.Forms.Label lblSO;
        private System.Windows.Forms.Button btnPO;
        private System.Windows.Forms.Label lblPO;
        private System.Windows.Forms.Button btnPR;
        private System.Windows.Forms.Label lblPR;
        private System.Windows.Forms.Button btnPRet;
        private System.Windows.Forms.Label lblPRet;
        private System.Windows.Forms.TabPage tcSett;
        private System.Windows.Forms.Button btnSett;
        private System.Windows.Forms.Label lblSett;
    }
}

