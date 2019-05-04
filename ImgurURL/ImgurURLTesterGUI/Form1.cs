using ImgurURL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurURLTesterGUI
{
    public partial class Form1 : Form
    {
        public ImgurURLGrabber grabber = new ImgurURLGrabber();

        public Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenURL();
        }

        private void OpenURL()
        {
            bool foundLink = false;

            while (foundLink == false)
            {
                string url = grabber.GetImgurURL(rnd.Next(999999999).ToString());

                if (grabber.CheckURLAvailable(url))
                {
                    DownloadImage(url);
                    label1.Text = url;
                    foundLink = true;
                }
            }
        }

        public void DownloadImage(string url)
        {
            WebRequest req = WebRequest.Create(url + ".png");
            WebResponse response = req.GetResponse();
            Stream stream = response.GetResponseStream();

            pictureBox1.Image = new Bitmap(stream);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(label1.Text);
        }
    }
}
