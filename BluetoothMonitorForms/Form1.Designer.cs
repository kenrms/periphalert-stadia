using System.Windows.Forms;

namespace BluetoothMonitorForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            barBatteryLevel = new ProgressBar();
            label1 = new Label();
            lblBatteryLevel = new Label();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // barBatteryLevel
            // 
            barBatteryLevel.Location = new Point(334, 227);
            barBatteryLevel.Name = "barBatteryLevel";
            barBatteryLevel.Size = new Size(125, 29);
            barBatteryLevel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 130);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 1;
            label1.Text = "Stadia Battery Level";
            // 
            // lblBatteryLevel
            // 
            lblBatteryLevel.AutoSize = true;
            lblBatteryLevel.Font = new Font("Segoe UI", 20F);
            lblBatteryLevel.Location = new Point(382, 178);
            lblBatteryLevel.Name = "lblBatteryLevel";
            lblBatteryLevel.Size = new Size(41, 46);
            lblBatteryLevel.TabIndex = 2;
            lblBatteryLevel.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBatteryLevel);
            Controls.Add(label1);
            Controls.Add(barBatteryLevel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private NotifyIcon notifyIcon1;
        private ProgressBar barBatteryLevel;
        private Label label1;
        private Label lblBatteryLevel;
    }
}
