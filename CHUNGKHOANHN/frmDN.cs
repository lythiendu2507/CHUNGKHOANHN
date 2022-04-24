using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHUNGKHOANHN
{
    public partial class frmDN : Form
    {
        public frmDN()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (rbNhanVien.Checked == true)
            {
                if (txtLogin.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập, mật khẩu không được để trống!!!", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mlogin = txtLogin.Text;
                Program.password = txtPassword.Text;
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
                if (Program.KetNoi() == 0) return;
                Program.mChinhanh = cmbChiNhanh.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;

                String strLenh = "EXEC SP_DANGNHAP_NV '" + Program.mlogin + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Tài khoản của bạn không có quyền truy cập vào hệ thống!!", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();

                Program.frmChinh = new formMain();
                Program.frmChinh.Activate();
                Program.frmChinh.Show();
                Program.frmDN.Visible = false;

                
                Program.frmChinh.MaSo.Text = "Mã: " + Program.username;
                Program.frmChinh.HoTen.Text = "Họ và Tên: " + Program.mHoten;
                Program.frmChinh.Nhom.Text = "Nhóm: " + Program.mGroup;
                
            }
            else if (rbNhanVienSGD.Checked == true)
            {
                if (txtLogin.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập, mật khẩu không được để trống!!!", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mlogin = txtLogin.Text;
                Program.password = txtPassword.Text;
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
                if (Program.KetNoi() == 0) return;
                Program.mChinhanh = cmbChiNhanh.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;

                String strLenh = "EXEC SP_DANGNHAP_NVSGD '" + Program.mlogin + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Tài khoản của bạn không có quyền truy cập vào hệ thống!!", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();

                Program.frmChinh = new formMain();
                Program.frmChinh.Activate();
                Program.frmChinh.Show();
                Program.frmDN.Visible = false;

                
                Program.frmChinh.MaSo.Text = "Mã: " + Program.username;
                Program.frmChinh.HoTen.Text = "Họ và Tên: " + Program.mHoten;
                Program.frmChinh.Nhom.Text = "Nhóm: " + Program.mGroup;
                
            }
            if (rbNDT.Checked == true)
            {
                if (txtLogin.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập nhà đầu tư, mật khẩu không được để trống!!!", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mlogin = txtLogin.Text;
                Program.password = txtPassword.Text;
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
                if (Program.KetNoi() == 0) return;
                Program.mChinhanh = cmbChiNhanh.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;

                String strLenh = "EXEC SP_DANGNHAP_NDT '" + Program.mlogin + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Tài khoản của bạn không có quyền truy cập vào hệ thống!!", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();

                Program.frmChinh = new formMain();
                Program.frmChinh.Activate();
                Program.frmChinh.Show();
                Program.frmDN.Visible = false;

                
                Program.frmChinh.MaSo.Text = "Mã: " + Program.username;
                Program.frmChinh.HoTen.Text = "Họ và Tên: " + Program.mHoten;
                Program.frmChinh.Nhom.Text = "Nhóm: " + Program.mGroup;
              
            }
        }

        private void frmDN_Load(object sender, EventArgs e)
        {
            string chuoiketnoi = "Data Source=DESKTOP-NLR9NQP\\SERVER;Initial Catalog=" + Program.database + ";Integrated Security=True";
            Program.conn.ConnectionString = chuoiketnoi;
            Program.conn.Open();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_PHANMANH");
            Program.bds_dspm.DataSource = dt;
            cmbChiNhanh.DataSource = dt;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = -1;
            cmbChiNhanh.SelectedIndex = 0;
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult choose;
            choose = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Có", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choose == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
