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

namespace Controls
{
    public partial class CustomControls : UserControl
    {
       
        DocFile df;
        public CustomControls()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CustomControls_Load(object sender, EventArgs e)
        {

        }

        private void txtMa_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter)
            {
                if (txtMa.Text == string.Empty)
                    MessageBox.Show("Vui lòng nhập mã để tìm kiếm!", "Thông báo");
                else
                {
                    df = new DocFile(txtDuongDan.Text);                          
                    string[] dong = File.ReadAllLines(df.DuongDan);
                    foreach (string s in dong)
                    {
                        string[] s1 = s.Split(',');
                        if (s1[0].Equals(txtMa.Text.ToString()))
                        {
                            lblTen.Text = s1[1].ToString();
                            lblMaLop.Text = s1[2].ToString();
                            lblNgaySinh.Text = s1[3].ToString();
                            lblGioiTinh.Text = s1[4].ToString();
                            lblCMND.Text = s1[5].ToString();
                            return;
                        }
                    }
                    MessageBox.Show("Không tìm thấy sinh viên có mã: " + txtMa.Text, "Thông báo");
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDuongDan_Click(object sender, EventArgs e)
        {
            
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Chọn file (txt)| *.txt;";
                ofd.Multiselect = false;
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    txtDuongDan.Text = ofd.FileName;
                }
            }
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
