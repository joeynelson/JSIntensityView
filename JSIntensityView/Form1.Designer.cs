namespace JSIntensityView
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            textBoxSerialNumber = new TextBox();
            label2 = new Label();
            textBoxScanPeriod = new TextBox();
            label3 = new Label();
            textBoxLaserOn = new TextBox();
            label4 = new Label();
            textBoxProfileCount = new TextBox();
            buttonStartScanning = new Button();
            IntensityImage = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IntensityImage).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(textBoxSerialNumber);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(textBoxScanPeriod);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(textBoxLaserOn);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(textBoxProfileCount);
            flowLayoutPanel1.Controls.Add(buttonStartScanning);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1745, 51);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "Serial Number";
            // 
            // textBoxSerialNumber
            // 
            textBoxSerialNumber.Location = new Point(133, 3);
            textBoxSerialNumber.Name = "textBoxSerialNumber";
            textBoxSerialNumber.Size = new Size(150, 31);
            textBoxSerialNumber.TabIndex = 1;
            textBoxSerialNumber.Text = "22765";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 2;
            label2.Text = "Scan Period[μs]";
            // 
            // textBoxScanPeriod
            // 
            textBoxScanPeriod.Location = new Point(427, 3);
            textBoxScanPeriod.Name = "textBoxScanPeriod";
            textBoxScanPeriod.Size = new Size(150, 31);
            textBoxScanPeriod.TabIndex = 3;
            textBoxScanPeriod.Text = "2500";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(583, 0);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 4;
            label3.Text = "Laser On Time[μs]";
            // 
            // textBoxLaserOn
            // 
            textBoxLaserOn.Location = new Point(741, 3);
            textBoxLaserOn.Name = "textBoxLaserOn";
            textBoxLaserOn.Size = new Size(150, 31);
            textBoxLaserOn.TabIndex = 5;
            textBoxLaserOn.Text = "40";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(897, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 7;
            label4.Text = "Profile Count";
            // 
            // textBoxProfileCount
            // 
            textBoxProfileCount.Location = new Point(1018, 3);
            textBoxProfileCount.Name = "textBoxProfileCount";
            textBoxProfileCount.Size = new Size(150, 31);
            textBoxProfileCount.TabIndex = 8;
            textBoxProfileCount.Text = "2000";
            // 
            // buttonStartScanning
            // 
            buttonStartScanning.Location = new Point(1174, 3);
            buttonStartScanning.Name = "buttonStartScanning";
            buttonStartScanning.Size = new Size(156, 34);
            buttonStartScanning.TabIndex = 6;
            buttonStartScanning.Text = "Start Scanning";
            buttonStartScanning.UseVisualStyleBackColor = true;
            buttonStartScanning.Click += buttonStartScan_Click;
            // 
            // IntensityImage
            // 
            IntensityImage.Dock = DockStyle.Bottom;
            IntensityImage.Location = new Point(0, 43);
            IntensityImage.Name = "IntensityImage";
            IntensityImage.Size = new Size(1745, 986);
            IntensityImage.TabIndex = 1;
            IntensityImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1745, 1029);
            Controls.Add(IntensityImage);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "JSIntensityView";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IntensityImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox textBoxSerialNumber;
        private Label label2;
        private TextBox textBoxScanPeriod;
        private Label label3;
        private TextBox textBoxLaserOn;
        private Button buttonStartScanning;
        private PictureBox IntensityImage;
        private Label label4;
        private TextBox textBoxProfileCount;
    }
}
