using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.Devices.Client;
using RPMS.Common;

namespace RPMS.SimulatorDevice
{
    public partial class GlucoseSimulator : Form
    {
        private const string DeviceConnectionString = "HostName=RPM-Hub.azure-devices.net;DeviceId=device01;SharedAccessKey=HAGxVc5KK+XeVgzbExf8ZzO6UE32W4H8sqD/zwfZPPU=";

        public GlucoseSimulator()
        {
           
            InitializeComponent();
            loadCbo();

        }

        private static async Task RecieveEvents(DeviceClient device)
        {
           while (true)
            {
                var msg = await device.ReceiveAsync();
                if (msg == null)
                {
                    continue;
                }
                var messageContent = msg.GetBytes();
                var messagePayload= Encoding.ASCII.GetString(messageContent);
               
                MessageBox.Show("Message Receieved!" + messagePayload);
                await device.CompleteAsync(msg);
               
            }
        }
        private void loadCbo()
        {
            cboLevel.DataSource = Enum.GetValues(typeof(Level));
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var device = DeviceClient.CreateFromConnectionString(DeviceConnectionString);
            device.OpenAsync();
            
            var telemetryData = new Telemetry
            {
                Patient = txtPatent.Text,
                Device = txtDevice.Text,
                GlucoseFigure = trackBarGlucose.Value,
                HealthLevel = (Level)cboLevel.SelectedItem,
                RecordingTime= DateTime.Now,
                HeartRate=trackBarHeartRate.Value,
                Temperature=trackBarTemperature.Value
              

            };

            var payload = JsonConvert.SerializeObject(telemetryData);
            var message = new Microsoft.Azure.Devices.Client.Message(Encoding.ASCII.GetBytes(payload));
            device.SendEventAsync(message);
            MessageBox.Show("Message Sent Successfully");
            var recieveEvents = RecieveEvents(device);
            gBLog.Text = recieveEvents.ToString();
            RefreshFileds();
          //  this.Close();
        }
        private void RefreshFileds()
        {
            txtDevice.Text = "";
            trackBarGlucose.Value = 0;
            txtPatent.Text = "";
            cboLevel.SelectedIndex = -1;
            trackBarHeartRate.Value = 0;
            trackBarTemperature.Value = 0;
            lblGlucoseFigure.Text = "";
            lblHeartRateTracker.Text = "";
            lblTemperatureTracker.Text = "";

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            var device= DeviceClient.CreateFromConnectionString(DeviceConnectionString);
            while (true)
            {
                var recieveEvents = device.ReceiveAsync().GetAwaiter().GetResult();
                if (recieveEvents == null)
                {
                    continue;
                }
                gBLog.Text = Encoding.ASCII.GetString(recieveEvents.GetBytes()); 
                device.CompleteAsync(recieveEvents).GetAwaiter().GetResult();
            }
             

        }

        private void trackBarTemperature_Scroll(object sender, EventArgs e)
        {
            this.lblTemperatureTracker.Text = trackBarTemperature.Value.ToString();
            this.lblTemperatureTracker.Text += " °F";
        }

        private void trackBarHeartRate_Scroll(object sender, EventArgs e)
        {
            this.lblHeartRateTracker.Text=trackBarHeartRate.Value.ToString();
            this.lblHeartRateTracker.Text += " bpm";
        }
        private void trackBarGlucose_Scroll(object sender, EventArgs e)
        {
            this.lblGlucoseFigure.Text = trackBarGlucose.Value.ToString();
            this.lblGlucoseFigure.Text += " mg/dl";
        }

        private void trackBarTemperature_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarTemperature.Value >= 101)
            {
                cboLevel.SelectedItem = Level.Emergency;
            }
            else if(trackBarTemperature.Value == 98)
            {
                cboLevel.SelectedItem = Level.Moderate;
            }
            else if(trackBarTemperature.Value==99 || trackBarTemperature.Value == 100)
            {
                cboLevel.SelectedItem = Level.High;
            }
            else
            {
                cboLevel.SelectedItem = Level.Normal;
            }
        }
        private void trackBarGlucose_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarGlucose.Value >= 500 || trackBarGlucose.Value <100 )
            {
                cboLevel.SelectedItem = Level.Emergency;
            }
            else if (trackBarGlucose.Value >=300 && trackBarGlucose.Value < 500)
            {
                cboLevel.SelectedItem = Level.High;
            }
            else if (trackBarGlucose.Value >=200 && trackBarGlucose.Value<300)
            {
                cboLevel.SelectedItem = Level.Moderate;
            }
            
            else
            {
                cboLevel.SelectedItem = Level.Normal;
            }
        }
        private void trackBarHeartRate_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarHeartRate.Value >= 80)
            {
                cboLevel.SelectedItem = Level.Emergency;
            }
            else if (trackBarGlucose.Value >= 70 && trackBarGlucose.Value < 80)
            {
                cboLevel.SelectedItem = Level.High;
            }
            else if (trackBarGlucose.Value >= 50 && trackBarGlucose.Value < 70)
            {
                cboLevel.SelectedItem = Level.Moderate;
            }

            else
            {
                cboLevel.SelectedItem = Level.Normal;
            }
        }
    }
}
