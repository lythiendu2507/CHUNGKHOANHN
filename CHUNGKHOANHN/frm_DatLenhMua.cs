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
    public partial class frm_DatLenhMua : Form
    {
        public frm_DatLenhMua()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
          //  try
            //{
           //     this.sP_LAY_HOTEN_NDTTableAdapter.Fill(this.dS.SP_LAY_HOTEN_NDT, mANDTToolStripTextBox.Text);
          //  }
         //   catch (System.Exception ex)
          //  {
          //      System.Windows.Forms.MessageBox.Show(ex.Message);
         //   }

        }

        private void frm_DatLenhMua_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GiaCoPhieu' table. You can move, or remove it, as needed.
            this.giaCoPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.giaCoPhieuTableAdapter.Fill(this.dS.GiaCoPhieu);
            
            // TODO: This line of code loads data into the 'dS.CoPhieu' table. You can move, or remove it, as needed.
            this.coPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.coPhieuTableAdapter.Fill(this.dS.CoPhieu);
            try
            {
                this.sP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTTableAdapter.Fill(this.dS.SP_LAY_SODUTIEN_MOINGANHANG_CUA_NDT, Program.username);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtHoTen.Text = Program.mHoten;
            
        }

        private void cmbLoaiLenh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maCPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
           // try
            //{
           //     this.sP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTTableAdapter.Fill(this.dS.SP_LAY_SODUTIEN_MOINGANHANG_CUA_NDT, mANDTToolStripTextBox.Text);
           // }
           // catch (System.Exception ex)
           // {
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
           // }

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            //try
            //{
            //    this.sP_LAY_GIATableAdapter.Fill(this.dS.SP_LAY_GIA, mACPToolStripTextBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(nGAYToolStripTextBox.Text, typeof(System.DateTime))))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void cmbMaCp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.sP_LAY_GIATableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_GIATableAdapter.Fill(this.dS.SP_LAY_GIA, cmbMaCp.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float gia = float.Parse(txtGia.Text);
            float giaTran = float.Parse(seGiaTran.Text);
            float giaSan = float.Parse(seGiaSan.Text);
            if( gia > giaTran || gia < giaSan)
            {
                MessageBox.Show("Giá tiền mua cổ phiếu không được lớn hơn giá trần và nhỏ hơn giá sàn!!!", "", MessageBoxButtons.OK);
                    
                txtGia.Focus();
            }
            else if (gia > float.Parse(txtSoTienKD.Text))
            {
                MessageBox.Show("Số dư tài khoản của bạn không đủ để thực hiện giao dịch!!!", "", MessageBoxButtons.OK);

                txtGia.Focus();
            }
            else
            {
                float tongiga = float.Parse(txtSoLuong.Text) * float.Parse(txtGia.Text);
                txtTongGia.Text = tongiga.ToString();

            }
            
        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            float tongGia = float.Parse(txtTongGia.Text);
            if (tongGia > float.Parse(txtSoTienKD.Text))
            {
                MessageBox.Show("Tài khoản ngân hàng của bạn không đủ tiền để thực hiện giao dịch!!!", "", MessageBoxButtons.OK);
                txtGia.Focus();
            }
            else
            {
                string strLenh = "EXEC LINK0.CHUNGKHOANHN.DBO.SP_KHOPLENH_LO '" + cmbMaCp.Text + "', '" + cmbMaTKNH.Text + "','" + "M" + "'," + txtSoLuong.Text + "," + txtGia.Text;

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
            }
            if (Program.myReader == null) return;
            Program.conn.Close();
        }

        private void cmbMaTKNH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
