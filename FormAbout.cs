using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemVolumeEditer
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            try
            {
                labelSoftwareName.Text = "System Volume Editer v1.0.0";
                labelDeveloper.Text = "Geliştirici: Emre Cüni";
                linkLabelLinkedin.Text = "LinkedIn";
                linkLabelLinkedin.Links.Add(0, linkLabelLinkedin.Text.Length, "https://www.linkedin.com/in/emrecuni/");
                linkLabelGithub.Text = "GitHub";
                linkLabelGithub.Links.Add(0, linkLabelGithub.Text.Length, "https://github.com/emrecuni");
                labelDate.Text = "Yayınlanma Tarihi: 16.12.2023";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace,"Load Error");
            }
        }

        private void linkLabelLinkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string url = e.Link.LinkData as string;
                if (url != null)
                    System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Linkedin Error");
            }
        }

        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string url = e.Link.LinkData as string;
                if (url != null)
                    System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Github Error");
            }
        }
    }
}
