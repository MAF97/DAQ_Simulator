using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQ_Simulator
{
    class Sensor
    {
        private double dVal;
        private int sId;
        private Random rSensVal;

        // Constructor
        public Sensor(int id)
        {
            sId = id;
            rSensVal = new Random(id);
            dVal = 0.0;
        }

        // Purpose: Returns the current sensor value
        // Version: 1.0, Your Name
        public double GetValue()
        {
            dVal += rSensVal.NextDouble() * 0.2 - 0.1; // Simulate voltage range [0, 1]
            return Math.Round(dVal, 3); // Round to 3 decimal places
        }

        // Purpose: Returns the sensor ID
        // Version: 1.0, Your Name
        public int GetSensId()
        {
            return sId;
        }

        internal double GetDigitalValue()
        {
            throw new NotImplementedException();
        }
    }
}
