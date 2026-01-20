using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Systemremote
{
    class Logsadd
    {

        private static readonly string logPath = "logs.txt";

        public static void Write(string message)
        {
            File.AppendAllText(
                logPath,
                $"{DateTime.Now} - {message}{Environment.NewLine}"
            );
        }
    }
}
