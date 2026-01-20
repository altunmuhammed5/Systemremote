using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systemremote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cpuread cp = new Cpuread();
        Ramread rm = new Ramread();
        private void button1_Click(object sender, EventArgs e)
        {
          
            
            MessageBox.Show(cp.GetCpuUsage().ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cputext.Text = cp.GetCpuUsage().ToString();
            Ramtext.Text = rm.GetRamUsagePercent().ToString();

        }
    }
}
