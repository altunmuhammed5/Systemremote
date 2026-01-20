using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;

namespace Systemremote
{
    class Ramread
    {
        public double GetRamUsagePercent()
        {
            ComputerInfo info = new ComputerInfo();

            double total = info.TotalPhysicalMemory;
            double available = info.AvailablePhysicalMemory;

            return ((total - available) / total) * 100;
        }
    }
}
