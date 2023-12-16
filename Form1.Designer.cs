namespace SystemVolumeEditer
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
            this.serialPortVolume = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.portSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarAudioVolume = new System.Windows.Forms.ProgressBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.buttonMute = new System.Windows.Forms.Button();
            this.imageListSound = new System.Windows.Forms.ImageList(this.components);
            this.timerVolume = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPortVolume
            // 
            this.serialPortVolume.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortVolume_DataReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LimeGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Italic);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portSelectionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(251, 31);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // portSelectionToolStripMenuItem
            // 
            this.portSelectionToolStripMenuItem.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portSelectionToolStripMenuItem.Name = "portSelectionToolStripMenuItem";
            this.portSelectionToolStripMenuItem.Size = new System.Drawing.Size(114, 27);
            this.portSelectionToolStripMenuItem.Text = "Port Seçimi";
            this.portSelectionToolStripMenuItem.Click += new System.EventHandler(this.portSelectionToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.aboutToolStripMenuItem.Text = "Hakkında";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // progressBarAudioVolume
            // 
            this.progressBarAudioVolume.Location = new System.Drawing.Point(98, 59);
            this.progressBarAudioVolume.Name = "progressBarAudioVolume";
            this.progressBarAudioVolume.Size = new System.Drawing.Size(119, 23);
            this.progressBarAudioVolume.TabIndex = 7;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVolume.Location = new System.Drawing.Point(34, 102);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(115, 25);
            this.labelVolume.TabIndex = 8;
            this.labelVolume.Text = "Ses Seviyesi: ";
            // 
            // buttonMute
            // 
            this.buttonMute.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMute.ImageIndex = 1;
            this.buttonMute.ImageList = this.imageListSound;
            this.buttonMute.Location = new System.Drawing.Point(34, 50);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(40, 40);
            this.buttonMute.TabIndex = 9;
            this.buttonMute.UseVisualStyleBackColor = false;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // imageListSound
            // 
            this.imageListSound.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSound.ImageStream")));
            this.imageListSound.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSound.Images.SetKeyName(0, "mute_icon.png");
            this.imageListSound.Images.SetKeyName(1, "speaker.png");
            // 
            // timerVolume
            // 
            this.timerVolume.Interval = 1000;
            this.timerVolume.Tick += new System.EventHandler(this.timerVolume_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(251, 133);
            this.Controls.Add(this.buttonMute);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.progressBarAudioVolume);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPortVolume;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem portSelectionToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBarAudioVolume;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Button buttonMute;
        private System.Windows.Forms.ImageList imageListSound;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timerVolume;
    }
}

