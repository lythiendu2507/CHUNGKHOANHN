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
    public partial class frmCoPhieu : Form
    {
        public int vitri;
        public frmCoPhieu()
        {
            InitializeComponent();
        }

        private void coPhieuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coPhieuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmCoPhieu_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.CoPhieu' table. You can move, or remove it, as needed.
            this.coPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.coPhieuTableAdapter.Fill(this.dS.CoPhieu);
            EnableForm();
        }

        private void DisableForm()
        {
            coPhieuGridControl.Enabled = false;
            btnThem.Enabled =  btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            txtMaCP.Enabled = seSoLuong.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtWeb.Enabled
                = txtSDT.Enabled = txtFax.Enabled = txtTenCP.Enabled = txtEmail.Enabled = true;
        }

        private void EnableForm()
        {
            coPhieuGridControl.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            txtMaCP.Enabled = seSoLuong.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtWeb.Enabled
                = txtSDT.Enabled = txtFax.Enabled = txtTenCP.Enabled = txtEmail.Enabled = false;
        }


        private void maCPLabel_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = coPhieuBindingSource.Position;
            coPhieuBindingSource.AddNew();
            DisableForm();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa cổ phiếu này??", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    coPhieuBindingSource.RemoveCurrent();
                    this.coPhieuTableAdapter.Update(this.dS.CoPhieu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa cổ phiếu!!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            coPhieuBindingSource.CancelEdit();
            EnableForm();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.coPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.coPhieuTableAdapter.Fill(this.dS.CoPhieu);
            EnableForm();
            MessageBox.Show("Reload trang thành công!!!", "", MessageBoxButtons.OK);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaCP.Text.Trim() == "")
            {
                MessageBox.Show("Mã cổ phiếu không được để trống!!!", "", MessageBoxButtons.OK);
                txtMaCP.Focus();
                return;
            }
            if (txtTenCP.Text.Trim() == "")
            {
                MessageBox.Show("Tên cổ phiếu không được để trống!!!", "", MessageBoxButtons.OK);
                txtTenCP.Focus();
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
            try
            {
                ((DataRowView)coPhieuBindingSource[coPhieuBindingSource.Position])["MaSGD"] = "HNX";
                //((DataRowView)lOPTINCHIBindingSource[lOPTINCHIBindingSource.Position])["MAGV"] = Program.username;
                coPhieuBindingSource.EndEdit();
                coPhieuBindingSource.ResetCurrentItem();

                this.coPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.coPhieuTableAdapter.Update(this.dS.CoPhieu);
                MessageBox.Show("Đã ghi thành công!!!", " ", MessageBoxButtons.OK);
                coPhieuBindingSource.Position = vitri;
                EnableForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi " + ex.Message, "", MessageBoxButtons.OK);
                this.coPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.coPhieuTableAdapter.Fill(this.dS.CoPhieu);
            }
        }
    }
}
