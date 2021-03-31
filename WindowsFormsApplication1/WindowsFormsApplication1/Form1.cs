using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmLogin : Form
    {
        QLNguoiDung ql = new QLNguoiDung();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text.Trim()))
            {
                MessageBox.Show("Khong duoc de trong !!!");
                this.txtUser.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                MessageBox.Show("Khong duoc de trong !!!");
                this.txtPass.Focus();
                return;
            }
            int kq = ql.CheckConfig();
            if(kq == 0)
            {
                processLogin();
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuoi cau hinh k ton tai !!!");
                processConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuoi cau hinh k phu hop !!!");
                processConfig();
            }

        }

        private void processConfig()
        {
            throw new NotImplementedException();
        }

        private void processLogin()
        {
            int result;
            result = ql.checkUser(txtUser.Text, txtPass.Text);
            if (result == 1)
            {

                MessageBox.Show("Sai ten dn or mk !!!");
                return;
            }
            else if (result == 2)
            {
                MessageBox.Show("Tai khoan bi khoa!!!");
                return;
            }
            if (Program.main == null || Program.main.IsDisposed)
            {
                Program.main = new frmMain();
            }
            this.Visible = false;
            Program.main.Show();

        }
    }
}
