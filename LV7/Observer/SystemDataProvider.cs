using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class SystemDataProvider:SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;
            float difference = currentLoad - this.previousCPULoad;
            if (difference >= this.previousCPULoad*0.1)
            {
                this.Notify();
            }
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            float availableRAM = this.AvailableRAM;
            float difference = availableRAM - this.previousRAMAvailable;
            if (difference >= this.previousRAMAvailable*0.1)
            {
                this.Notify();
            }
            this.previousRAMAvailable = availableRAM;
            return availableRAM;
        }
    }
}
