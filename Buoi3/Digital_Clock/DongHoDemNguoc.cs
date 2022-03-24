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
    public partial class DongHoDemNguoc : UserControl
    {
        int gio, phut, giay, ml = 0;
        public DongHoDemNguoc()
        {
            InitializeComponent();
        }

        private void DongHoDemNguoc_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Stop();
        }

        private void txtTimes_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "" + ml;
            ml++;
            if (ml > 59)
            {
                giay--;
                ml = 0;
            }
            if (giay < 0)
            {
                phut--;
                giay = 59;
            }
            if (phut < 0)
            {
                gio--;
                phut = 59;
            }
            string time = gio + ":" + phut + ":" + giay;
            txtTimes.Text = time;
            if (gio == phut && giay == phut && giay == 0)
            {
                timer1.Stop();
                btnRun.Text = "Run";
            }
        }

        private void txtTimes_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                xuLyTime();
                btnRun.Focus();
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(btnRun.Text.ToString().Trim().ToLower().Contains("run"))
            {
                btnRun.Text = "Stop";
                timer1.Start();
                xuLyTime();
            }
            else
            {
                timer1.Stop();
                btnRun.Text = "Run";
            }
            
            
            
        }

        void xuLyTime()
        {
            string[] so = txtTimes.Text.ToString().Split(':');
            int lenght = so.Length;
            if (lenght == 1)
            {
                giay = int.Parse(so[0]);
            }
            else
            if (lenght == 2)
            {
                phut = int.Parse(so[0]);
                giay = int.Parse(so[1]);
            }
            else
            {
                gio = int.Parse(so[0]);
                phut = int.Parse(so[1]);
                giay = int.Parse(so[2]);
            }
            if (giay > 59)
                phut++;
            if (phut > 59)
                gio++;
        }
    }
}
