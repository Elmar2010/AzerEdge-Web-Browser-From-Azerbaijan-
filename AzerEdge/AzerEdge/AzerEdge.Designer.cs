namespace AzerEdge
{
    partial class AzerEdge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AzerEdge));
            this.radTabbedFormControl1 = new Telerik.WinControls.UI.RadTabbedFormControl();
            this.radTabbedFormControlTab1 = new Telerik.WinControls.UI.RadTabbedFormControlTab();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.forwardBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.searchPnl = new System.Windows.Forms.Panel();
            this.gotoHomeMainBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addAccountBtn = new System.Windows.Forms.Button();
            this.getDeviceInfoBtn = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radTabbedFormControl1)).BeginInit();
            this.radTabbedFormControl1.SuspendLayout();
            this.radTabbedFormControlTab1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.searchPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTabbedFormControl1
            // 
            this.radTabbedFormControl1.CaptionHeight = 36;
            this.radTabbedFormControl1.Controls.Add(this.radTabbedFormControlTab1);
            this.radTabbedFormControl1.LeftItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1});
            this.radTabbedFormControl1.Location = new System.Drawing.Point(0, 0);
            this.radTabbedFormControl1.Name = "radTabbedFormControl1";
            this.radTabbedFormControl1.SelectedTab = this.radTabbedFormControlTab1;
            this.radTabbedFormControl1.ShowNewTabButton = false;
            this.radTabbedFormControl1.ShowTabCloseButton = false;
            this.radTabbedFormControl1.ShowTabPinButton = true;
            this.radTabbedFormControl1.Size = new System.Drawing.Size(1135, 789);
            this.radTabbedFormControl1.TabHeight = 36;
            this.radTabbedFormControl1.TabIndex = 0;
            this.radTabbedFormControl1.TabWidth = 300;
            this.radTabbedFormControl1.Text = "AzerEdge";
            this.radTabbedFormControl1.SelectedTabChanged += new System.EventHandler(this.radTabbedFormControl1_SelectedTabChanged);
            // 
            // radTabbedFormControlTab1
            // 
            this.radTabbedFormControlTab1.Controls.Add(this.webView21);
            this.radTabbedFormControlTab1.Controls.Add(this.panel1);
            this.radTabbedFormControlTab1.Location = new System.Drawing.Point(1, 37);
            this.radTabbedFormControlTab1.Name = "radTabbedFormControlTab1";
            this.radTabbedFormControlTab1.Size = new System.Drawing.Size(1133, 751);
            this.radTabbedFormControlTab1.Text = "Yeni Pəncərə";
            this.radTabbedFormControlTab1.Paint += new System.Windows.Forms.PaintEventHandler(this.radTabbedFormControlTab1_Paint);
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.ShowBorder = false;
            this.radButtonElement1.StretchHorizontally = false;
            this.radButtonElement1.StretchVertically = false;
            this.radButtonElement1.Text = "AzerEdge Pəncərələr";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.getDeviceInfoBtn);
            this.panel1.Controls.Add(this.addAccountBtn);
            this.panel1.Controls.Add(this.searchPnl);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.forwardBtn);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 32);
            this.panel1.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(3, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(35, 23);
            this.backBtn.TabIndex = 0;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // forwardBtn
            // 
            this.forwardBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forwardBtn.BackgroundImage")));
            this.forwardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.forwardBtn.FlatAppearance.BorderSize = 0;
            this.forwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardBtn.Location = new System.Drawing.Point(36, 3);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(35, 23);
            this.forwardBtn.TabIndex = 1;
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshBtn.BackgroundImage")));
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Location = new System.Drawing.Point(72, 4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(35, 23);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // searchPnl
            // 
            this.searchPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchPnl.Controls.Add(this.button1);
            this.searchPnl.Controls.Add(this.textBox1);
            this.searchPnl.Controls.Add(this.gotoHomeMainBtn);
            this.searchPnl.Location = new System.Drawing.Point(113, 4);
            this.searchPnl.Name = "searchPnl";
            this.searchPnl.Size = new System.Drawing.Size(877, 22);
            this.searchPnl.TabIndex = 3;
            // 
            // gotoHomeMainBtn
            // 
            this.gotoHomeMainBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gotoHomeMainBtn.BackgroundImage")));
            this.gotoHomeMainBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gotoHomeMainBtn.FlatAppearance.BorderSize = 0;
            this.gotoHomeMainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gotoHomeMainBtn.Location = new System.Drawing.Point(3, 1);
            this.gotoHomeMainBtn.Name = "gotoHomeMainBtn";
            this.gotoHomeMainBtn.Size = new System.Drawing.Size(29, 19);
            this.gotoHomeMainBtn.TabIndex = 4;
            this.gotoHomeMainBtn.UseVisualStyleBackColor = true;
            this.gotoHomeMainBtn.Click += new System.EventHandler(this.gotoHomeMainBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(63, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(811, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // addAccountBtn
            // 
            this.addAccountBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addAccountBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addAccountBtn.BackgroundImage")));
            this.addAccountBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addAccountBtn.FlatAppearance.BorderSize = 0;
            this.addAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAccountBtn.Location = new System.Drawing.Point(993, 4);
            this.addAccountBtn.Name = "addAccountBtn";
            this.addAccountBtn.Size = new System.Drawing.Size(35, 23);
            this.addAccountBtn.TabIndex = 4;
            this.addAccountBtn.UseVisualStyleBackColor = true;
            this.addAccountBtn.Click += new System.EventHandler(this.addAccountBtn_Click);
            // 
            // getDeviceInfoBtn
            // 
            this.getDeviceInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getDeviceInfoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("getDeviceInfoBtn.BackgroundImage")));
            this.getDeviceInfoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.getDeviceInfoBtn.FlatAppearance.BorderSize = 0;
            this.getDeviceInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getDeviceInfoBtn.Location = new System.Drawing.Point(1029, 3);
            this.getDeviceInfoBtn.Name = "getDeviceInfoBtn";
            this.getDeviceInfoBtn.Size = new System.Drawing.Size(35, 23);
            this.getDeviceInfoBtn.TabIndex = 5;
            this.getDeviceInfoBtn.UseVisualStyleBackColor = true;
            this.getDeviceInfoBtn.Click += new System.EventHandler(this.getDeviceInfoBtn_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 32);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1133, 719);
            this.webView21.TabIndex = 1;
            this.webView21.ZoomFactor = 1D;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(28, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 19);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AzerEdge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 789);
            this.Controls.Add(this.radTabbedFormControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AzerEdge";
            this.ShowIcon = false;
            this.Text = "AzerEdge";
            ((System.ComponentModel.ISupportInitialize)(this.radTabbedFormControl1)).EndInit();
            this.radTabbedFormControl1.ResumeLayout(false);
            this.radTabbedFormControlTab1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.searchPnl.ResumeLayout(false);
            this.searchPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTabbedFormControl radTabbedFormControl1;
        private Telerik.WinControls.UI.RadTabbedFormControlTab radTabbedFormControlTab1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.Panel searchPnl;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button gotoHomeMainBtn;
        private System.Windows.Forms.Button getDeviceInfoBtn;
        private System.Windows.Forms.Button addAccountBtn;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button button1;
    }
}
