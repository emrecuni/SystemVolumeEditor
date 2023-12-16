namespace SystemVolumeEditer
{
    partial class FormPortSelection
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
            this.timerPorts = new System.Windows.Forms.Timer(this.components);
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelClosingInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerPorts
            // 
            this.timerPorts.Enabled = true;
            this.timerPorts.Interval = 1000;
            this.timerPorts.Tick += new System.EventHandler(this.timerPorts_Tick);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.BackColor = System.Drawing.Color.LawnGreen;
            this.comboBoxPorts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(13, 14);
            this.comboBoxPorts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(180, 28);
            this.comboBoxPorts.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSave.Location = new System.Drawing.Point(13, 51);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 37);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Kaydet";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelClosingInfo
            // 
            this.labelClosingInfo.AutoSize = true;
            this.labelClosingInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelClosingInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelClosingInfo.Location = new System.Drawing.Point(33, 97);
            this.labelClosingInfo.Name = "labelClosingInfo";
            this.labelClosingInfo.Size = new System.Drawing.Size(142, 15);
            this.labelClosingInfo.TabIndex = 2;
            this.labelClosingInfo.Text = "(Çıkmak İçin Çift Tıklayın)";
            // 
            // FormPortSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(211, 114);
            this.ControlBox = false;
            this.Controls.Add(this.labelClosingInfo);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxPorts);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPortSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPortSelection";
            this.Load += new System.EventHandler(this.FormPortSelection_Load);
            this.DoubleClick += new System.EventHandler(this.FormPortSelection_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerPorts;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelClosingInfo;
    }
}