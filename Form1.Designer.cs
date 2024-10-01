namespace WebBrowser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnYoutube = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.btnBbc = new System.Windows.Forms.Button();
            this.btnListen = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSearch.Location = new System.Drawing.Point(814, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(356, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Url Address:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(445, 11);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 38);
            this.textBox1.TabIndex = 3;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnNext.Location = new System.Drawing.Point(12, 43);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 25);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next Page";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnPrevious.Location = new System.Drawing.Point(12, 12);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(84, 25);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous Page";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(12, 134);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1583, 715);
            this.webView21.TabIndex = 6;
            this.webView21.ZoomFactor = 1D;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(102, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(58, 56);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(219, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(84, 56);
            this.btnHome.TabIndex = 8;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnMail
            // 
            this.btnMail.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMail.BackgroundImage")));
            this.btnMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMail.Location = new System.Drawing.Point(1044, 12);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(84, 38);
            this.btnMail.TabIndex = 9;
            this.btnMail.UseVisualStyleBackColor = false;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // btnYoutube
            // 
            this.btnYoutube.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnYoutube.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYoutube.BackgroundImage")));
            this.btnYoutube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYoutube.Location = new System.Drawing.Point(1134, 12);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.Size = new System.Drawing.Size(84, 38);
            this.btnYoutube.TabIndex = 10;
            this.btnYoutube.UseVisualStyleBackColor = false;
            this.btnYoutube.Click += new System.EventHandler(this.btnYoutube_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnTranslate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTranslate.BackgroundImage")));
            this.btnTranslate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTranslate.Location = new System.Drawing.Point(954, 65);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(84, 38);
            this.btnTranslate.TabIndex = 11;
            this.btnTranslate.UseVisualStyleBackColor = false;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnFacebook
            // 
            this.btnFacebook.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnFacebook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFacebook.BackgroundImage")));
            this.btnFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacebook.Location = new System.Drawing.Point(954, 12);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(84, 38);
            this.btnFacebook.TabIndex = 12;
            this.btnFacebook.UseVisualStyleBackColor = false;
            this.btnFacebook.Click += new System.EventHandler(this.btnFacebook_Click);
            // 
            // btnBbc
            // 
            this.btnBbc.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBbc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBbc.BackgroundImage")));
            this.btnBbc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBbc.Location = new System.Drawing.Point(1134, 65);
            this.btnBbc.Name = "btnBbc";
            this.btnBbc.Size = new System.Drawing.Size(84, 38);
            this.btnBbc.TabIndex = 13;
            this.btnBbc.UseVisualStyleBackColor = false;
            this.btnBbc.Click += new System.EventHandler(this.btnBbc_Click);
            // 
            // btnListen
            // 
            this.btnListen.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnListen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListen.Location = new System.Drawing.Point(1310, 11);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(58, 48);
            this.btnListen.TabIndex = 15;
            this.btnListen.Text = "Listen Music";
            this.btnListen.UseVisualStyleBackColor = false;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1374, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(220, 48);
            this.axWindowsMediaPlayer1.TabIndex = 14;
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimer.ForeColor = System.Drawing.Color.Black;
            this.lblTimer.Location = new System.Drawing.Point(1404, 92);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(190, 23);
            this.lblTimer.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1607, 826);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnBbc);
            this.Controls.Add(this.btnFacebook);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.btnYoutube);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            this.Text = "Web Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Button btnYoutube;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnFacebook;
        private System.Windows.Forms.Button btnBbc;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

