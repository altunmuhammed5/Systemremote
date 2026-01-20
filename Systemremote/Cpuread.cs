using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Systemremote
{
    class Cpuread
    {
        private PerformanceCounter cpuCounter;

        public Cpuread()
        {
            cpuCounter = new PerformanceCounter(
                "Processor",
                "% Processor Time",
                "_Total"
            );
            cpuCounter.NextValue();
            Thread.Sleep(500);
        }

        public float GetCpuUsage()
        {
            return cpuCounter.NextValue();
        }
    }
}
