
namespace CHUNGKHOANHN
{
    partial class Frm_BaoCaoLietKeNDT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label hOTENLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNDT = new System.Windows.Forms.TextBox();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.dS = new CHUNGKHOANHN.DS();
            this.sP_LAY_HOTEN_NDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LAY_HOTEN_NDTTableAdapter = new CHUNGKHOANHN.DSTableAdapters.SP_LAY_HOTEN_NDTTableAdapter();
            this.tableAdapterManager = new CHUNGKHOANHN.DSTableAdapters.TableAdapterManager();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnHoTenNDT = new System.Windows.Forms.Button();
            hOTENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_HOTEN_NDTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NĐT :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaNDT
            // 
            this.txtMaNDT.Location = new System.Drawing.Point(183, 116);
            this.txtMaNDT.Name = "txtMaNDT";
            this.txtMaNDT.Size = new System.Drawing.Size(100, 26);
            this.txtMaNDT.TabIndex = 1;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(347, 116);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(96, 26);
            this.btnBaoCao.TabIndex = 2;
            this.btnBaoCao.Text = "In Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_LAY_HOTEN_NDTBindingSource
            // 
            this.sP_LAY_HOTEN_NDTBindingSource.DataMember = "SP_LAY_HOTEN_NDT";
            this.sP_LAY_HOTEN_NDTBindingSource.DataSource = this.dS;
            // 
            // sP_LAY_HOTEN_NDTTableAdapter
            // 
            this.sP_LAY_HOTEN_NDTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangPhiTableAdapter = null;
            this.tableAdapterManager.ChiTietBangPhiTableAdapter = null;
            this.tableAdapterManager.ChiTietQuyDinhTableAdapter = null;
            this.tableAdapterManager.CongTyChungKhoanTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CoPhieuTableAdapter = null;
            this.tableAdapterManager.GiaCoPhieuTableAdapter = null;
            this.tableAdapterManager.LenhDatTableAdapter = null;
            this.tableAdapterManager.LenhKhopTableAdapter = null;
            this.tableAdapterManager.LoaiLenhTableAdapter = null;
            this.tableAdapterManager.NganHangTableAdapter = null;
            this.tableAdapterManager.NhaDauTuTableAdapter = null;
            this.tableAdapterManager.NhanVienSGDTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.QuyDinhTableAdapter = null;
            this.tableAdapterManager.SanGiaoDichTableAdapter = null;
            this.tableAdapterManager.SoHuuTableAdapter = null;
            this.tableAdapterManager.TaiKhoanNganHangTableAdapter = null;
            this.tableAdapterManager.TrangThaiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CHUNGKHOANHN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(73, 44);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(136, 19);
            hOTENLabel.TabIndex = 5;
            hOTENLabel.Text = "Họ Tên Nhà Đầu Tư";
            // 
            // txtHoTen
            // 
            this.txtHoTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_LAY_HOTEN_NDTBindingSource, "HOTEN", true));
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(238, 41);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(261, 26);
            this.txtHoTen.TabIndex = 6;
            // 
            // btnHoTenNDT
            // 
            this.btnHoTenNDT.Location = new System.Drawing.Point(534, 41);
            this.btnHoTenNDT.Name = "btnHoTenNDT";
            this.btnHoTenNDT.Size = new System.Drawing.Size(96, 26);
            this.btnHoTenNDT.TabIndex = 7;
            this.btnHoTenNDT.Text = "Hiện Tên NDT";
            this.btnHoTenNDT.UseVisualStyleBackColor = true;
            this.btnHoTenNDT.Click += new System.EventHandler(this.btnHoTenNDT_Click);
            // 
            // Frm_BaoCaoLietKeNDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 227);
            this.Controls.Add(this.btnHoTenNDT);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.txtMaNDT);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_BaoCaoLietKeNDT";
            this.Text = "Frm_BaoCaoLietKeNDT";
            this.Load += new System.EventHandler(this.Frm_BaoCaoLietKeNDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_HOTEN_NDTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNDT;
        private System.Windows.Forms.Button btnBaoCao;
        private DS dS;
        private System.Windows.Forms.BindingSource sP_LAY_HOTEN_NDTBindingSource;
        private DSTableAdapters.SP_LAY_HOTEN_NDTTableAdapter sP_LAY_HOTEN_NDTTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnHoTenNDT;
    }
}