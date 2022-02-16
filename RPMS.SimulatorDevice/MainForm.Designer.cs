namespace RPMS.SimulatorDevice
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbGlucose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbTemperature = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbHeartRate = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlucose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeartRate)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGlucose
            // 
            this.pbGlucose.Image = ((System.Drawing.Image)(resources.GetObject("pbGlucose.Image")));
            this.pbGlucose.Location = new System.Drawing.Point(52, 13);
            this.pbGlucose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbGlucose.Name = "pbGlucose";
            this.pbGlucose.Size = new System.Drawing.Size(114, 59);
            this.pbGlucose.TabIndex = 0;
            this.pbGlucose.TabStop = false;
            this.pbGlucose.Click += new System.EventHandler(this.pbGlucose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Glucose Simulator";
            // 
            // pbTemperature
            // 
            this.pbTemperature.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbTemperature.ErrorImage")));
            this.pbTemperature.Image = ((System.Drawing.Image)(resources.GetObject("pbTemperature.Image")));
            this.pbTemperature.Location = new System.Drawing.Point(226, 13);
            this.pbTemperature.Margin = new System.Windows.Forms.Padding(0, 0, 3, 4);
            this.pbTemperature.Name = "pbTemperature";
            this.pbTemperature.Size = new System.Drawing.Size(114, 59);
            this.pbTemperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTemperature.TabIndex = 0;
            this.pbTemperature.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperature Simulator";
            // 
            // pbHeartRate
            // 
            this.pbHeartRate.Image = ((System.Drawing.Image)(resources.GetObject("pbHeartRate.Image")));
            this.pbHeartRate.Location = new System.Drawing.Point(391, 13);
            this.pbHeartRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbHeartRate.Name = "pbHeartRate";
            this.pbHeartRate.Size = new System.Drawing.Size(114, 59);
            this.pbHeartRate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeartRate.TabIndex = 0;
            this.pbHeartRate.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Heart-Rate Simulator";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbHeartRate);
            this.Controls.Add(this.pbTemperature);
            this.Controls.Add(this.pbGlucose);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "RPMS Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pbGlucose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeartRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbGlucose;
        private Label label1;
        private PictureBox pbTemperature;
        private Label label2;
        private PictureBox pbHeartRate;
        private Label label3;
    }
}