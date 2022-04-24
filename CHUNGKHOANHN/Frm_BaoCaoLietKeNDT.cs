using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;


namespace CHUNGKHOANHN
{
    public partial class Frm_BaoCaoLietKeNDT : Form
    {
        public Frm_BaoCaoLietKeNDT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //this.txtHoTenNDT.Connection.ConnectionString = Program.connstr;

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            
            BaoCaoLietKeCoPhieuNDT report = new BaoCaoLietKeCoPhieuNDT(txtMaNDT.Text);
            report.lblMaNDT.Text = txtMaNDT.Text;
            report.lblHoTenNDT.Text = txtHoTen.Text;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void Frm_BaoCaoLietKeNDT_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "NhaDauTu")
            {
                txtMaNDT.Text = Program.username;
                txtHoTen.Text = Program.mHoten;
                txtMaNDT.Enabled = false;
                btnHoTenNDT.Enabled = false;
            }
            else
            {
                txtMaNDT.Enabled = true;
                btnHoTenNDT.Enabled = true;
               
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            //try
           // {
             //   this.sP_LAY_HOTEN_NDTTableAdapter.Fill(this.dS.SP_LAY_HOTEN_NDT, mANDTToolStripTextBox.Text);
            //}
           // catch (System.Exception ex)
           // {
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
           // }

        }

        private void btnHoTenNDT_Click(object sender, EventArgs e)
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
    }
}
