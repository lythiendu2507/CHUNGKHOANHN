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
    public partial class frm_DatLenhBan : Form
    {
        public frm_DatLenhBan()
        {
            InitializeComponent();
        }

        private void soHuuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.soHuuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frm_DatLenhBan_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            try
            {
                this.sP_LAY_TKNH_NDTTableAdapter.Fill(this.dS.SP_LAY_TKNH_NDT, Program.username);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            try
            {
                this.sP_LAY_MACP_CUA_1NDTTableAdapter.Fill(this.dS.SP_LAY_MACP_CUA_1NDT, Program.username);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            // TODO: This line of code loads data into the 'dS.GiaCoPhieu' table. You can move, or remove it, as needed.
            this.giaCoPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.giaCoPhieuTableAdapter.Fill(this.dS.GiaCoPhieu);

           
            this.soHuuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.soHuuTableAdapter.Fill(this.dS.SoHuu);
            txtHoTen.Text = Program.mHoten;

        }

        private void cmbMaCp_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
             //   this.sP_LAY_GIATableAdapter.Fill(this.dS.SP_LAY_GIA, mACPToolStripTextBox.Text);
           // }
           // catch (System.Exception ex)
           // {
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float gia = float.Parse(txtGia.Text);
            float giaTran = float.Parse(seGiaTran.Text);
            float giaSan = float.Parse(seGiaSan.Text);
            if (gia > giaTran || gia < giaSan)
            {
                MessageBox.Show("Giá tiền mua cổ phiếu không được lớn hơn giá trần và nhỏ hơn giá sàn!!!", "", MessageBoxButtons.OK);

                txtGia.Focus();
            }
            else if (float.Parse(txtSoLuong.Text) > float.Parse(txtSoLuongKD.Text))
            {
                MessageBox.Show("Số dư cổ phiếu của bạn không đủ để thực hiện giao dịch!!!", "", MessageBoxButtons.OK);

                txtGia.Focus();
            }
            else
            {
                float tongiga = float.Parse(txtSoLuong.Text) * float.Parse(txtGia.Text);
                txtTongGia.Text = tongiga.ToString();

            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
           
            if (float.Parse(txtSoLuong.Text) > float.Parse(txtSoLuongKD.Text))
            {
                MessageBox.Show("Số dư cổ phiếu của bạn không đủ  để thực hiện giao dịch!!!", "", MessageBoxButtons.OK);
                txtSoLuong.Focus();
            }
            else
            {
                string strLenh = "EXEC LINK0.CHUNGKHOANHN.DBO.SP_KHOPLENH_LO '" + cmbMaCP.Text + "', '" + cmbMaTKNH.Text + "','" + "B" + "'," + txtSoLuong.Text + "," + txtGia.Text;

                try
                {
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    if (Program.myReader != null)
                    {
                        Program.myReader.Read();
                        Int32 ret = Program.myReader.GetInt32(0);
                        //MessageBox.Show(ret.ToString());
                        MessageBox.Show("Đặt lệnh thành công, số cổ phiếu khớp là:  " + ret.ToString(), "Thông báo", MessageBoxButtons.OK);

                    }


                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                    MessageBox.Show("Lỗi đặt lệnh!\n" + ex.Message, "Thông báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Program.myReader == null) return;
                Program.conn.Close();
            }
        }

        private void cmbMaCP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
           // try
           // {
           //     this.sP_LAY_TKNH_NDTTableAdapter.Fill(this.dS.SP_LAY_TKNH_NDT, mANDTToolStripTextBox.Text);
          //  }
          //  catch (System.Exception ex)
           // {
           //     System.Windows.Forms.MessageBox.Show(ex.Message);
           // }

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            //try
            //{
           //     this.sP_LAY_TKNH_NDTTableAdapter.Fill(this.dS.SP_LAY_TKNH_NDT, mANDTToolStripTextBox.Text);
            //}
           // catch (System.Exception ex)
           // {
           //     System.Windows.Forms.MessageBox.Show(ex.Message);
           // }

        }

        private void fillToolStripButton_Click_3(object sender, EventArgs e)
        {
           

        }

        private void cmbMaCP_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            try
            {
                this.sP_LAY_GIATableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_GIATableAdapter.Fill(this.dS.SP_LAY_GIA, cmbMaCP.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSoLuongKD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
