using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class mdDangNhap : UserControl
    {
        public mdDangNhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == string.Empty)
                MessageBox.Show("Vui lòng nhập tên đăng nhập");
            else
                MessageBox.Show("Vui lòng nhập mật khẩu");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
