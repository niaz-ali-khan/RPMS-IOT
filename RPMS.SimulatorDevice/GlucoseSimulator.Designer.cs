namespace RPMS.SimulatorDevice
{
    partial class GlucoseSimulator
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
        /// Required method for Designer sup
        /// - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlucoseSimulator));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBarGlucose = new System.Windows.Forms.TrackBar();
            this.lblGlucoseFigure = new System.Windows.Forms.Label();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHeartRateTracker = new System.Windows.Forms.Label();
            this.lblTemperatureTracker = new System.Windows.Forms.Label();
            this.trackBarHeartRate = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarTemperature = new System.Windows.Forms.TrackBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.txtPatent = new System.Windows.Forms.TextBox();
            this.gBLog = new System.Windows.Forms.GroupBox();
            this.btnShowMessage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGlucose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeartRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBarGlucose);
            this.groupBox1.Controls.Add(this.lblGlucoseFigure);
            this.groupBox1.Controls.Add(this.cboLevel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblHeartRateTracker);
            this.groupBox1.Controls.Add(this.lblTemperatureTracker);
            this.groupBox1.Controls.Add(this.trackBarHeartRate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.trackBarTemperature);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDevice);
            this.groupBox1.Controls.Add(this.txtPatent);
            this.groupBox1.Location = new System.Drawing.Point(11, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(683, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Data";
            // 
            // trackBarGlucose
            // 
            this.trackBarGlucose.Location = new System.Drawing.Point(112, 142);
            this.trackBarGlucose.Maximum = 600;
            this.trackBarGlucose.Name = "trackBarGlucose";
            this.trackBarGlucose.Size = new System.Drawing.Size(149, 45);
            this.trackBarGlucose.TabIndex = 13;
            this.trackBarGlucose.Scroll += new System.EventHandler(this.trackBarGlucose_Scroll);
            this.trackBarGlucose.ValueChanged += new System.EventHandler(this.trackBarGlucose_ValueChanged);
            // 
            // lblGlucoseFigure
            // 
            this.lblGlucoseFigure.AutoSize = true;
            this.lblGlucoseFigure.Location = new System.Drawing.Point(142, 120);
            this.lblGlucoseFigure.Name = "lblGlucoseFigure";
            this.lblGlucoseFigure.Size = new System.Drawing.Size(0, 20);
            this.lblGlucoseFigure.TabIndex = 12;
            // 
            // cboLevel
            // 
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Location = new System.Drawing.Point(370, 143);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(155, 28);
            this.cboLevel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Glucose Figure:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Health Level:";
            // 
            // lblHeartRateTracker
            // 
            this.lblHeartRateTracker.AutoSize = true;
            this.lblHeartRateTracker.Location = new System.Drawing.Point(141, 72);
            this.lblHeartRateTracker.Name = "lblHeartRateTracker";
            this.lblHeartRateTracker.Size = new System.Drawing.Size(0, 20);
            this.lblHeartRateTracker.TabIndex = 11;
            // 
            // lblTemperatureTracker
            // 
            this.lblTemperatureTracker.AutoSize = true;
            this.lblTemperatureTracker.Location = new System.Drawing.Point(396, 73);
            this.lblTemperatureTracker.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblTemperatureTracker.Name = "lblTemperatureTracker";
            this.lblTemperatureTracker.Size = new System.Drawing.Size(0, 20);
            this.lblTemperatureTracker.TabIndex = 10;
            this.lblTemperatureTracker.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarHeartRate
            // 
            this.trackBarHeartRate.LargeChange = 3;
            this.trackBarHeartRate.Location = new System.Drawing.Point(112, 91);
            this.trackBarHeartRate.Maximum = 150;
            this.trackBarHeartRate.Name = "trackBarHeartRate";
            this.trackBarHeartRate.Size = new System.Drawing.Size(159, 45);
            this.trackBarHeartRate.SmallChange = 2;
            this.trackBarHeartRate.TabIndex = 9;
            this.trackBarHeartRate.TickFrequency = 5;
            this.trackBarHeartRate.Scroll += new System.EventHandler(this.trackBarHeartRate_Scroll);
            this.trackBarHeartRate.ValueChanged += new System.EventHandler(this.trackBarHeartRate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Heart Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Temperature:";
            // 
            // trackBarTemperature
            // 
            this.trackBarTemperature.LargeChange = 3;
            this.trackBarTemperature.Location = new System.Drawing.Point(373, 91);
            this.trackBarTemperature.Maximum = 105;
            this.trackBarTemperature.Name = "trackBarTemperature";
            this.trackBarTemperature.Size = new System.Drawing.Size(147, 45);
            this.trackBarTemperature.SmallChange = 2;
            this.trackBarTemperature.TabIndex = 5;
            this.trackBarTemperature.TickFrequency = 5;
            this.trackBarTemperature.Scroll += new System.EventHandler(this.trackBarTemperature_Scroll);
            this.trackBarTemperature.ValueChanged += new System.EventHandler(this.trackBarTemperature_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(307, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(194, 201);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(93, 38);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send Data";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Device:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient:";
            // 
            // txtDevice
            // 
            this.txtDevice.Location = new System.Drawing.Point(370, 42);
            this.txtDevice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(156, 27);
            this.txtDevice.TabIndex = 0;
            // 
            // txtPatent
            // 
            this.txtPatent.Location = new System.Drawing.Point(105, 42);
            this.txtPatent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatent.Name = "txtPatent";
            this.txtPatent.Size = new System.Drawing.Size(156, 27);
            this.txtPatent.TabIndex = 0;
            // 
            // gBLog
            // 
            this.gBLog.Location = new System.Drawing.Point(31, 368);
            this.gBLog.Name = "gBLog";
            this.gBLog.Size = new System.Drawing.Size(501, 68);
            this.gBLog.TabIndex = 1;
            this.gBLog.TabStop = false;
            this.gBLog.Text = "Log";
            // 
            // btnShowMessage
            // 
            this.btnShowMessage.Location = new System.Drawing.Point(545, 379);
            this.btnShowMessage.Name = "btnShowMessage";
            this.btnShowMessage.Size = new System.Drawing.Size(140, 57);
            this.btnShowMessage.TabIndex = 2;
            this.btnShowMessage.Text = "Show Message";
            this.btnShowMessage.UseVisualStyleBackColor = true;
            this.btnShowMessage.Click += new System.EventHandler(this.btnShowMessage_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 100);
            this.panel1.TabIndex = 3;
            // 
            // GlucoseSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShowMessage);
            this.Controls.Add(this.gBLog);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GlucoseSimulator";
            this.Text = "Health Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGlucose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeartRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCancel;
        private Button btnSend;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDevice;
        private TextBox txtPatent;
        private Label label4;
        private GroupBox gBLog;
        private Button btnShowMessage;
        private Label label5;
        private TrackBar trackBarTemperature;
        private Label label6;
        private Label lblTemperatureTracker;
        private TrackBar trackBarHeartRate;
        private Label lblHeartRateTracker;
        private Panel panel1;
        private Label lblGlucoseFigure;
        private TrackBar trackBarGlucose;
        private ComboBox cboLevel;
    }
}