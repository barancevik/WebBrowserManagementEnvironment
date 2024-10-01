using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async(null);

            string url = textBox1.Text;

            if (!url.StartsWith("htt://") && !url.StartsWith("https://"))
            {
                url = "https://" + url + "/";
            }

            webView21.Source = new Uri(url);



        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            webView21.GoForward();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webView21.Reload();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.google.com/");
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://mail.google.com/");
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.youtube.com/");
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://translate.google.com/");
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.facebook.com/");
        }

        private void btnBbc_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.bbc.co.uk/");
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://streaming.radionomy.com/Number1-Radio/";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //webView21.Size = this.ClientSize;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }
    }
}
