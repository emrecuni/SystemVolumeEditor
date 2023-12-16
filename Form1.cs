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
                    string data = serialPortVolume.ReadExisting();
                    progressBarAudioVolume.Value = int.Parse(data); 
                    defaultPlaybackDevice.Volume = int.Parse(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Data Received Error");
            }
        }        
    }
}
