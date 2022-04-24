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
    public partial class frmNhanVien : Form
    {
        public int vitri;
      
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.CongTyChungKhoan' table. You can move, or remove it, as needed.
            this.congTyChungKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.congTyChungKhoanTableAdapter.Fill(this.dS.CongTyChungKhoan);
          
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            EnableForm();
        }
        private void DisableForm()
        {
            nhanVienGridControl.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            txtMaNV.Enabled = ceDaNghiViec.Enabled = cePhai.Enabled = txtHo.Enabled = txtTen.Enabled 
                = txtSDT.Enabled = deNgaySinh.Enabled= txtDiaChi.Enabled =  true;
        }

        private void EnableForm()
        {
            nhanVienGridControl.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            txtMaNV.Enabled = ceDaNghiViec.Enabled = cePhai.Enabled = txtHo.Enabled = txtTen.Enabled
                = txtSDT.Enabled = deNgaySinh.Enabled = txtDiaChi.Enabled = false;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = nhanVienBindingSource.Position;
            nhanVienBindingSource.AddNew();
            DisableForm();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên này??", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    nhanVienBindingSource.RemoveCurrent();
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên!!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống!!!", "", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được để trống!!!", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống!!!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }


            //string strLenh = " DECLARE @result int " +
            //        "EXEC @result = sp_ktLopTinChi '" + cmbNienKhoa.Text + "', '" + int.Parse(cmbHocKy.Text) + "','" + cmbMaMH.SelectedValue.ToString() + "', '" + int.Parse(cmbNhom.Text)
            //        + "' " + "SELECT 'result' = @result";

            //Program.myReader = Program.ExecSqlDataReader(strLenh);
            //if (Program.myReader == null) return;
            //Program.myReader.Read();

            //int result = int.Parse(Program.myReader.GetValue(0).ToString());
            //Program.myReader.Close();
            //int positionTenLopTC = lOPTINCHIBindingSource.Find("MAMH", cmbMaMH.Text);
            //MessageBox.Show(cmbMaMH.SelectedValue.ToString());
            //if (result == 1)
            //{
            //    MessageBox.Show("Lớp tín chỉ đã tồn tại", "", MessageBoxButtons.OK);
            //    return;
            //    this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            //    this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            //}
            MessageBox.Show(txtMaCTCK.Text);
            try
            {
                ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["MACTCK"] = txtMaCTCK.Text;
                //((DataRowView)lOPTINCHIBindingSource[lOPTINCHIBindingSource.Position])["MAGV"] = Program.username;
                nhanVienBindingSource.EndEdit();
                nhanVienBindingSource.ResetCurrentItem();

                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                MessageBox.Show("Đã ghi thành công!!!", " ", MessageBoxButtons.OK);
                nhanVienBindingSource.Position = vitri;
                EnableForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm ghi" + ex.Message, "", MessageBoxButtons.OK);
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nhanVienBindingSource.CancelEdit();
            EnableForm();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = nhanVienBindingSource.Position;
            DisableForm();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            EnableForm();
            MessageBox.Show("Reload trang thành công!!!", "", MessageBoxButtons.OK);
        }
    }
}
