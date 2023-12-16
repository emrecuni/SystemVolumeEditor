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
            this.serialPortVolume = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.portSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarAudioVolume = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPortVolume
            // 
            this.serialPortVolume.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortVolume_DataReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SpringGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portSelectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 31);
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
            // progressBarAudioVolume
            // 
            this.progressBarAudioVolume.Location = new System.Drawing.Point(0, 46);
            this.progressBarAudioVolume.Name = "progressBarAudioVolume";
            this.progressBarAudioVolume.Size = new System.Drawing.Size(339, 23);
            this.progressBarAudioVolume.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(339, 381);
            this.Controls.Add(this.progressBarAudioVolume);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
    }
}

