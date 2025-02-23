namespace DAQ_Simulator
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
            groupBox1 = new GroupBox();
            lblNextSamplingTime = new Label();
            txtNextSamplingTime = new TextBox();
            btnSample = new Button();
            groupBox3 = new GroupBox();
            txtSensorValues = new TextBox();
            groupBox2 = new GroupBox();
            lblNextLoggingTime = new Label();
            txtNextLoggingTime = new TextBox();
            btnLog = new Button();
            menuStrip1 = new MenuStrip();
            mainToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblNextSamplingTime);
            groupBox1.Controls.Add(txtNextSamplingTime);
            groupBox1.Controls.Add(btnSample);
            groupBox1.Location = new Point(12, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sampling";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblNextSamplingTime
            // 
            lblNextSamplingTime.AutoSize = true;
            lblNextSamplingTime.Location = new Point(6, 45);
            lblNextSamplingTime.Name = "lblNextSamplingTime";
            lblNextSamplingTime.Size = new Size(144, 20);
            lblNextSamplingTime.TabIndex = 2;
            lblNextSamplingTime.Text = "Next Sampling Time";
            lblNextSamplingTime.Click += lblNextSamplingTime_Click;
            // 
            // txtNextSamplingTime
            // 
            txtNextSamplingTime.Location = new Point(156, 45);
            txtNextSamplingTime.Name = "txtNextSamplingTime";
            txtNextSamplingTime.Size = new Size(88, 27);
            txtNextSamplingTime.TabIndex = 1;
            txtNextSamplingTime.TextChanged += txtNextSamplingTime_TextChanged;
            // 
            // btnSample
            // 
            btnSample.Location = new Point(150, 90);
            btnSample.Name = "btnSample";
            btnSample.Size = new Size(94, 29);
            btnSample.TabIndex = 0;
            btnSample.Text = "Sampling";
            btnSample.UseVisualStyleBackColor = true;
            btnSample.Click += btnSample_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSensorValues);
            groupBox3.Location = new Point(284, 47);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(198, 262);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sensor Values";
            // 
            // txtSensorValues
            // 
            txtSensorValues.Location = new Point(30, 26);
            txtSensorValues.Multiline = true;
            txtSensorValues.Name = "txtSensorValues";
            txtSensorValues.Size = new Size(137, 223);
            txtSensorValues.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblNextLoggingTime);
            groupBox2.Controls.Add(txtNextLoggingTime);
            groupBox2.Controls.Add(btnLog);
            groupBox2.Location = new Point(12, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Logging";
            // 
            // lblNextLoggingTime
            // 
            lblNextLoggingTime.AutoSize = true;
            lblNextLoggingTime.Location = new Point(6, 47);
            lblNextLoggingTime.Name = "lblNextLoggingTime";
            lblNextLoggingTime.Size = new Size(136, 20);
            lblNextLoggingTime.TabIndex = 2;
            lblNextLoggingTime.Text = "Next Logging Time";
            lblNextLoggingTime.Click += btnSample_Click;
            // 
            // txtNextLoggingTime
            // 
            txtNextLoggingTime.Location = new Point(156, 44);
            txtNextLoggingTime.Name = "txtNextLoggingTime";
            txtNextLoggingTime.Size = new Size(88, 27);
            txtNextLoggingTime.TabIndex = 1;
            txtNextLoggingTime.TextChanged += txtNextLoggingTime_TextChanged;
            // 
            // btnLog
            // 
            btnLog.Location = new Point(150, 90);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(94, 29);
            btnLog.TabIndex = 0;
            btnLog.Text = "Log On File";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(536, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            mainToolStripMenuItem.Size = new Size(56, 24);
            mainToolStripMenuItem.Text = "Main";
            mainToolStripMenuItem.Click += mainToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 324);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "DAQ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button btnLog;
        private Button btnSample;
        private TextBox txtSensorValues;
        private TextBox txtNextSamplingTime;
        private Label lblNextSamplingTime;
        private Label lblNextLoggingTime;
        private TextBox txtNextLoggingTime;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
