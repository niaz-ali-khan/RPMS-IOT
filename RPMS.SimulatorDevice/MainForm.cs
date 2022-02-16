namespace RPMS.SimulatorDevice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pbGlucose_Click(object sender, EventArgs e)
        {
            GlucoseSimulator glucoseSimulator = new GlucoseSimulator();
            glucoseSimulator.ShowDialog();
        }
    }
}