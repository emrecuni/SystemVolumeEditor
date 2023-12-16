using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemVolumeEditer
{
    public partial class FormPortSelection : Form
    {
        public FormPortSelection()
        {
            InitializeComponent();
        }

        string[] ports;

        private void FormPortSelection_Load(object sender, EventArgs e)
        {
            try
            {
                timerPorts.Start(); // aktif portların listelenmesi için form açılır açılmaz timer başlatılır
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Load Error");
            }
        }

        private void FormPortSelection_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Close(); // ekrana çift tıklandığında form kapatılır
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Closing Error");
            }
        }

        private void timerPorts_Tick(object sender, EventArgs e)
        {
            try
            {
                ports = SerialPort.GetPortNames(); // anlık olarak bulduğu portları ports dizisine atar
                foreach (var port in ports)
                {
                    if(comboBoxPorts.Items.IndexOf(port) == -1) // combobox'ta olmayan portları combobox'a ekler
                        comboBoxPorts.Items.Add(port);                    
                }
                for (int i = 0; i < comboBoxPorts.Items.Count; i++) 
                {
                    if (!ports.Contains(comboBoxPorts.Items[i])) // bağlantısı kopan portları combobox'tan kaldırır
                        comboBoxPorts.Items.Remove(comboBoxPorts.Items[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Timer Error");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.portName = comboBoxPorts.SelectedItem.ToString(); // seçilen port adı ana formdaki "portName" değişkenine atanır
                Close();// ve form kapatılır
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Save Error");
            }
        }
    }
}
