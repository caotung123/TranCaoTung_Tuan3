using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Digital_Clock
{
    public partial class DongHoBamGio : UserControl
    {
        Boolean fl = true;
        int gio = 0, phut = 0, giay = 0, mlGiay;
        public DongHoBamGio()
        {
            InitializeComponent();
            timer1.Interval = 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(fl == true)
            {
                btnStart.Text = "Stop";
                timer1.Start();
                fl = false;
            }
            else
            {
                btnStart.Text = "Start";
                timer1.Stop();
                fl = true;
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mlGiay+=10;
            if(mlGiay == 1000)
            {
                giay++;
                mlGiay = 0;
            }
            
            if(giay == 60 )
            {
                phut++;
                giay = 0;
            }
            if(phut == 60)
            {
                gio++;
                phut = 0;
            }
            label2.Text = mlGiay.ToString();
            label1.Text = gio + " : " + phut + " : " + giay ;
        }

        void rest()
        {
            giay = 0;
            mlGiay = 0;
            gio = 0;
            phut = 0;
        }
        private void btnLap_Click(object sender, EventArgs e)
        {
            btnStart.Text = "Start"; fl = true;
            rest();
            timer1.Stop();
                        
            using (StreamWriter streamWriter = new StreamWriter(@"..\..\time.txt",true))
            {
                streamWriter.WriteLine( label1.Text + Environment.NewLine);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DongHoBamGio_Load(object sender, EventArgs e)
        {

        }
    }
}
