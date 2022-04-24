using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CHUNGKHOANHN
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {

            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmCoPhieu));
            if (frm != null) frm.Activate();
            else
            {
                frmCoPhieu f = new frmCoPhieu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_3(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn đăng xuất ?", "Thông báo !", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                this.Hide();

                Program.frmDN.Visible = true;
            }
        }

        private void btnDSNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            btnChiTietKhopLenh.Enabled = btnDanhMucCP.Enabled = btnDangKy.Enabled = btnDSNV.Enabled
                = btnLenhBan.Enabled = btnLenhMua.Enabled = btnLietKeSoLuongGiaTri.Enabled = btnNhaDauTu.Enabled
                = btnSaoKeLenhKhop.Enabled = btnSoDu.Enabled = btnTinhGiaThamChieu.Enabled = true;
            if(Program.mGroup == "SoGD")
            {
                btnLenhBan.Enabled = btnLenhMua.Enabled = btnDSNV.Enabled = btnNhaDauTu.Enabled = false;
            }
            else if(Program.mGroup == "CongTy")
            {
                btnDanhMucCP.Enabled = btnTinhGiaThamChieu.Enabled = btnLenhBan.Enabled = btnLenhMua.Enabled = false;
            }
            else if(Program.mGroup == "NhaDauTu")
            {
                btnDanhMucCP.Enabled = btnDangKy.Enabled = btnDSNV.Enabled
               
               = btnNhaDauTu.Enabled = btnTinhGiaThamChieu.Enabled = false;
            }
        }

        private void btnNhaDauTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhaDauTu));
            if (frm != null) frm.Activate();
            else
            {
                frmNhaDauTu f = new frmNhaDauTu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSoDu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(frm_TraCuuSoDu));
            if (frm != null) frm.Activate();
            else
            {
                frm_TraCuuSoDu f = new frm_TraCuuSoDu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLenhMua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_DatLenhMua));
            if (frm != null) frm.Activate();
            else
            {
                frm_DatLenhMua f = new frm_DatLenhMua();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLietKeSoLuongGiaTri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frm_BaoCaoLietKeNDT));
            if (frm != null) frm.Activate();
            else
            {
                Frm_BaoCaoLietKeNDT f = new Frm_BaoCaoLietKeNDT();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLenhBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_DatLenhBan));
            if (frm != null) frm.Activate();
            else
            {
                frm_DatLenhBan f = new frm_DatLenhBan();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
