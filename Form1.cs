using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SystemVolumeEditer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
        public static string portName = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                progressBarAudioVolume.Value = int.Parse(defaultPlaybackDevice.Volume.ToString());
                labelVolume.Text = $"Ses Seviyesi: {defaultPlaybackDevice.Volume}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Data Received Error");
            }
        }

        private void portSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormPortSelection portSelection = new FormPortSelection();
                portSelection.ShowDialog();

                if (portName != null) // port seçiminin yapılıp yapılmadığını kontrol eder
                {
                    serialPortVolume.PortName = portName;
                    try
                    {
                        serialPortVolume.Open();
                        Text = $"{serialPortVolume.PortName} Açık";
                        timerVolume.Enabled = true;
                        timerVolume.Start();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"{portName} Portu Açılırken Bir Hata Oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Port Selection Error");
            }
        }

        private void serialPortVolume_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                if (serialPortVolume.BytesToRead > 0)
                {

                    
                    //int volume = serialPortVolume.ReadByte();
                    string data = serialPortVolume.ReadExisting();
                    if (buttonMute.ImageIndex == 1) // mute butonuna tıklandıktan sonra alınan veride anlık bir parse edememe sorunu oluyordu
                    {
                        int.TryParse(data, out int volume);
                        progressBarAudioVolume.Value = volume;
                        defaultPlaybackDevice.Volume = volume;
                        labelVolume.Text = $"Ses Seviyesi: {volume}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Data Received Error");
            }
        }

        private void buttonMute_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonMute.ImageIndex == 1) // unmute
                {
                    defaultPlaybackDevice.Mute(true); // sistem sesi mute edilir
                    labelVolume.Text = "Sessiz";
                    progressBarAudioVolume.Value = 0;
                    buttonMute.ImageIndex = 0; // butonun ikonu mute yapılır
                }
                else // mute
                {
                    defaultPlaybackDevice.Mute(false); // sistem sesi unmute edilir
                    labelVolume.Text = $"Ses Seviyesi: {defaultPlaybackDevice.Volume}";
                    progressBarAudioVolume.Value = int.Parse(defaultPlaybackDevice.Volume.ToString());
                    buttonMute.ImageIndex = 1; // butonun ikonu unmute yapılır
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Mute Error");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormAbout about = new FormAbout();
                about.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "About Error");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult warning = MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (warning == DialogResult.Yes)
                    serialPortVolume.Close();
                else
                    e.Cancel = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Closing Error");
            }
        }

        private void timerVolume_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBarAudioVolume.Value = int.Parse(defaultPlaybackDevice.Volume.ToString());
                labelVolume.Text = $"Ses Seviyesi: {defaultPlaybackDevice.Volume}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Closing Error");
            }
        }
    }
}
