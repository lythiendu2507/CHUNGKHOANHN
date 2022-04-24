using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CHUNGKHOANHN
{
    public partial class frm_TraCuuSoDu : Form
    {
        DataTable dt_SoDuTien = new DataTable();
        DataTable dt_SoDuCP = new DataTable();
        DataTable dt_SoDu_MoiNH = new DataTable();
        public frm_TraCuuSoDu()
        {
            InitializeComponent();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if(Program.mGroup == "CongTy")
            {
                try
                {
                    this.sP_LAY_HOTEN_NDTTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_LAY_HOTEN_NDTTableAdapter.Fill(this.dS.SP_LAY_HOTEN_NDT, txtMaNDT.Text);
                                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            String strlenh = "EXEC SP_LAY_SODUTIEN_NDT '" + txtMaNDT.Text + "'";
            dt_SoDuTien = Program.ExecSqlDataTable(strlenh);
            gcSoDuTien.DataSource = dt_SoDuTien;

            String strlenh1 = "EXEC SP_LAY_SODUCP_NDT '" + txtMaNDT.Text + "'";
            dt_SoDuCP = Program.ExecSqlDataTable(strlenh1);
            gcSoDuCP.DataSource = dt_SoDuCP;

            String strlenh3 = "EXEC SP_LAY_SODUTIEN_MOINGANHANG_CUA_NDT '" + txtMaNDT.Text + "'";
            dt_SoDu_MoiNH = Program.ExecSqlDataTable(strlenh3);
            gc_SoDuMoiNganHang.DataSource = dt_SoDu_MoiNH;

        }

        private void frm_TraCuuSoDu_Load(object sender, EventArgs e)
        {
            if(Program.mGroup == "NhaDauTu")
            {
                txtMaNDT.Text = Program.username;
                txtMaNDT.Enabled = false;
                txtHoTenNDT.Text = Program.mHoten;
            }

           
            btnTraCuu.PerformClick();

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           // try
           // {
             //   this.sP_LAY_HOTEN_NDTTableAdapter.Fill(this.dS.SP_LAY_HOTEN_NDT, mANDTToolStripTextBox.Text);
           // }
           // catch (System.Exception ex)
           // {
           //     System.Windows.Forms.MessageBox.Show(ex.Message);
           // }

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
