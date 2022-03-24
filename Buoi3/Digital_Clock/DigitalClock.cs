using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class DigitalClock : UserControl
    {
        public DigitalClock()
        {
            InitializeComponent();
            label1.Text = "Time: " + DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Time: "+ DateTime.Now.ToString();
        }
    }
}
