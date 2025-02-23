namespace DAQ_Simulator
{
    public partial class Form1 : Form
    {

        private Sensor[] analogSensors; // Declare as Sensor array
        private Sensor[] digitalSensors; // Declare as Sensor array
        private LowPassFilter[] filters;
        public Form1()
        {
            InitializeComponent();

            int numAnalogSensors = 7; // From Image
            int numDigitalSensors = 3; // From Image


            // Initialize analog and digital sensors
            analogSensors = new Sensor[numAnalogSensors];
            digitalSensors = new Sensor[numDigitalSensors];

            for (int i = 0; i < numAnalogSensors; i++)
            {
                analogSensors[i] = new Sensor(i);
            }

            for (int i = 0; i < numDigitalSensors; i++)
            {
                digitalSensors[i] = new Sensor(i + numAnalogSensors); // Unique IDs
            }

            // Initialize low-pass filters for analog sensors (e.g., window size = 5)
            filters = new LowPassFilter[numAnalogSensors];
            for (int i = 0; i < numAnalogSensors; i++)
            {
                filters[i] = new LowPassFilter(5); // Window size = 5
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSample_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNextSamplingTime.Text))
            {
                MessageBox.Show("Please set a valid sampling time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear previous sensor values
            txtSensorValues.Clear();

            // Read analog sensor values
            foreach (var sensor in analogSensors)
            {
                txtSensorValues.AppendText($"Sensor {sensor.GetSensId()}: {sensor.GetValue()}\n");
            }

            // Read digital sensor values
            foreach (var sensor in digitalSensors)
            {
                double value = sensor.GetValue();
                string digitalValue = value > 0.5 ? "1" : "0"; // Binary representation
                txtSensorValues.AppendText($"Sensor {sensor.GetSensId()}: {digitalValue}\n");
            }

            // Update next sampling time
            double nextSamplingTime = double.Parse(txtNextSamplingTime.Text) + 3.8; // Minimum interval
            txtNextSamplingTime.Text = nextSamplingTime.ToString("F1");

        }


        private void lblNextSamplingTime_Click(object sender, EventArgs e)
        {


        }

        private void txtNextSamplingTime_TextChanged(object sender, EventArgs e)
        {
            // Validate input to ensure it is a numeric value
            if (!double.TryParse(txtNextSamplingTime.Text, out _))
            {
                MessageBox.Show("Please enter a valid number for the sampling time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNextSamplingTime.Text = "3.8"; // Reset to default value
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(txtNextLoggingTime.Text))
            {
                MessageBox.Show("Please set a valid logging time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fileName = "SensorLog.csv";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true)) // Append mode
            {
                DateTime timestamp = DateTime.Now;
                string logLine = $"{timestamp},{string.Join(",", analogSensors.Select(s => s.GetValue()))}";
                file.WriteLine(logLine);
            }

            double nextLoggingTime = double.Parse(txtNextLoggingTime.Text) + 33; // Minimum interval
            txtNextLoggingTime.Text = nextLoggingTime.ToString("F1");

        }
        private void txtNextLoggingTime_TextChanged(object sender, EventArgs e)
        {
            // Validate input to ensure it is a numeric value
            if (!double.TryParse(txtNextLoggingTime.Text, out _))
            {
                MessageBox.Show("Please enter a valid number for the logging time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNextLoggingTime.Text = "33"; // Reset to default value
            }

        }
        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display a message box with application information
            string aboutMessage = "DAQ Simulator v1.0\n" +
                                  "Created by Mohammad Ahmadi\n" +
                                  "Course: IIA1319 Software Engineering\n" +
                                  "Description: A Data Acquisition Simulation Application";
            MessageBox.Show(aboutMessage, "About DAQ Simulator", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
