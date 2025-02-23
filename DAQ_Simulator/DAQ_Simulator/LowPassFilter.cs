using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQ_Simulator
{
    class LowPassFilter
    {
        private Queue<double> buffer;
        private int windowSize;

        // Purpose: Initializes a new instance of the LowPassFilter class
        // Version: 1.0, Your Name
        public LowPassFilter(int windowSize)
        {
            this.windowSize = windowSize;
            buffer = new Queue<double>();
        }

        // Purpose: Applies the low-pass filter to the input value
        // Version: 1.0, Your Name
        public double Apply(double value)
        {
            buffer.Enqueue(value);
            if (buffer.Count > windowSize)
            {
                buffer.Dequeue();
            }
            return buffer.Count == 0 ? 0 : buffer.Average();
        }
    }

}

