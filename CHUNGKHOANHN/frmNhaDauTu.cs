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
    public partial class frmNhaDauTu : Form
    {
        public int vitri;
        public frmNhaDauTu()
        {
            InitializeComponent();
        }

        private void nhaDauTuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhaDauTuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmNhaDauTu_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.CongTyChungKhoan' table. You can move, or remove it, as needed.
            this.congTyChungKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.congTyChungKhoanTableAdapter.Fill(this.dS.CongTyChungKhoan);
            
            // TODO: This line of code loads data into the 'dS.TaiKhoanNganHang' table. You can move, or remove it, as needed.
            this.taiKhoanNganHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanNganHangTableAdapter.Fill(this.dS.TaiKhoanNganHang);
            // TODO: This line of code loads data into the 'dS.NhaDauTu' table. You can move, or remove it, as needed.
            this.nhaDauTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhaDauTuTableAdapter.Fill(this.dS.NhaDauTu);

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["MaNDT"].ToString().Trim() == "")
            {
                MessageBox.Show("Mã nhà đầu tư không được để trống!!!", "", MessageBoxButtons.OK);
                
                return;
            }
            if (((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["CMND/Passport"].ToString().Trim() == "")
            {
                MessageBox.Show("CMND/Passport không được để trống!!!", "", MessageBoxButtons.OK);
                
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
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["MaNDT"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["Ho"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["Ten"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["Phai"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["NgaySinh"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["NoiSinh"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["DiaChi"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["Email"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["SDT"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["CMND/Passport"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["NgayCap"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["QuocGia"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["MKGiaoDich"] = "HNX";
                ((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["MKDatLenh"] = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MKDatLenh").ToString(); ;
                ((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["MaCTCK"] = txtMaCTCK.Text;

                //((DataRowView)lOPTINCHIBindingSource[lOPTINCHIBindingSource.Position])["MAGV"] = Program.username;
                nhaDauTuBindingSource.EndEdit();
                nhaDauTuBindingSource.ResetCurrentItem();

                this.nhaDauTuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhaDauTuTableAdapter.Update(this.dS.NhaDauTu);
                MessageBox.Show("Đã ghi thành công!!!", " ", MessageBoxButtons.OK);
                nhaDauTuBindingSource.Position = vitri;
                taiKhoanNganHangGridControl.Enabled = btnThemNDT.Enabled = btnReloadNDT.Enabled = btnSuaNDT.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi " + ex.Message, "", MessageBoxButtons.OK);
                this.nhaDauTuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhaDauTuTableAdapter.Fill(this.dS.NhaDauTu);
            }
        }

        private void btnThemNDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = nhaDauTuBindingSource.Position;
            nhaDauTuBindingSource.AddNew();
            taiKhoanNganHangGridControl.Enabled = false;
        }

        private void btnThemTKNH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = taiKhoanNganHangBindingSource.Position;
            taiKhoanNganHangBindingSource.AddNew();
            nhaDauTuGridControl.Enabled = false;
        }

        private void btnXoaNDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhà đầu tư này??", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    nhaDauTuBindingSource.RemoveCurrent();
                    this.nhaDauTuTableAdapter.Update(this.dS.NhaDauTu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhà đầu tư !!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnXoaTKNH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tài khoản ngân hàng này??", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    taiKhoanNganHangBindingSource.RemoveCurrent();
                    this.taiKhoanNganHangTableAdapter.Update(this.dS.TaiKhoanNganHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa tài khoản ngân hàng !!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnPhucHoiNDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nhaDauTuBindingSource.CancelEdit();
            taiKhoanNganHangGridControl.Enabled = true;
        }

        private void btnPhucHoiTKNH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            taiKhoanNganHangBindingSource.CancelEdit();
            nhaDauTuGridControl.Enabled = true;
        }

        private void btnReloadNDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nhaDauTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhaDauTuTableAdapter.Fill(this.dS.NhaDauTu);
            MessageBox.Show("Reload thành công!!!"," ", MessageBoxButtons.OK);
        }

        private void btnReloadTKNH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.taiKhoanNganHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanNganHangTableAdapter.Fill(this.dS.TaiKhoanNganHang);
            MessageBox.Show("Reload thành công!!"," ", MessageBoxButtons.OK);
        }

        private void btnGhiTKNH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((DataRowView)taiKhoanNganHangBindingSource[taiKhoanNganHangBindingSource.Position])["MaTKNH"].ToString().Trim() == "")
            {
                MessageBox.Show("Mã tài khoản ngân hàng không được để trống!!!", "", MessageBoxButtons.OK);

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
               
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["Ho"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["Ten"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["Phai"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["NgaySinh"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["NoiSinh"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["DiaChi"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["Email"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["SDT"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["CMND/Passport"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["NgayCap"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["QuocGia"] = "HNX";
                //((DataRowView)nhaDauTuBindingSource[nhaDauTuBindingSource.Position])["MKGiaoDich"] = "HNX";
                ((DataRowView)taiKhoanNganHangBindingSource[taiKhoanNganHangBindingSource.Position])["MaNH"] = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MaNH").ToString(); 
                ((DataRowView)taiKhoanNganHangBindingSource[taiKhoanNganHangBindingSource.Position])["MaNDT"] = 
                    gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNDT").ToString();

                //((DataRowView)lOPTINCHIBindingSource[lOPTINCHIBindingSource.Position])["MAGV"] = Program.username;
                MessageBox.Show(((DataRowView)taiKhoanNganHangBindingSource[taiKhoanNganHangBindingSource.Position])["MaNDT"].ToString(),
                    ((DataRowView)taiKhoanNganHangBindingSource[taiKhoanNganHangBindingSource.Position])["MaNH"].ToString()+""+
                    ((DataRowView)taiKhoanNganHangBindingSource[taiKhoanNganHangBindingSource.Position])["SoDu"].ToString());
                taiKhoanNganHangBindingSource.EndEdit();
                taiKhoanNganHangBindingSource.ResetCurrentItem();

                this.taiKhoanNganHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanNganHangTableAdapter.Update(this.dS.TaiKhoanNganHang);
                MessageBox.Show("Đã ghi thành công!!!", " ", MessageBoxButtons.OK);
                taiKhoanNganHangBindingSource.Position = vitri;
                nhaDauTuGridControl.Enabled = btnThemTKNH.Enabled = btnReloadTKNH.Enabled = btnSuaTKNH.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi " + ex.Message, "", MessageBoxButtons.OK);
                this.taiKhoanNganHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanNganHangTableAdapter.Fill(this.dS.TaiKhoanNganHang);
            }
        }
    }
}
