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
        string[] ports;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //defaultPlaybackDevice.Volume = int.Parse(numericUpDown1.Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //timer1.Enabled = true;
                //timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Data Received Error");
            }
        }

        private void serialPortVolume_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                if(serialPortVolume.BytesToRead > 0)
                {
                    string data = serialPortVolume.ReadLine();
                    MessageBox.Show(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Data Received Error");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                ports = SerialPort.GetPortNames();
                foreach (var port in ports)
                {
                    if(comboBox1.Items.IndexOf(port) == -1)
                        comboBox1.Items.Add(port);
                    //if(comboBox1.Items.IndexOf(port)!= -1)
                    //    comboBox1.Items.Remove(port);
                }
                //foreach (var item in comboBox1.Items)
                //{
                //    if (!ports.Contains(item.ToString()))
                //        comboBox1.Items.Remove(item);
                //}
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Timer Error");
            }
        }
        private SerialPort serialPort;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //serialPortVolume.PortName = comboBox1.SelectedItem.ToString();
                //serialPortVolume.Open();
                string portName = "COM4";
                int baudRate = 9600;

                // Seri port nesnesini oluştur
                serialPort = new SerialPort(portName, baudRate);

                // Seri port event'lerini tanımla
                serialPort.DataReceived += SerialPort_DataReceived;
                try
                {
                    // Seri portu aç
                    serialPort.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Seri port açılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Port Selection Error");
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Seri porttan gelen veriyi oku ve TextBox'a yaz
            string data = serialPort.ReadLine();

            // Bu örnekte TextBox kullanılıyor, uygun bir kontrolü kullanabilirsiniz
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new Action(() => textBox1.Text = data));
            }
        }
    }
}
