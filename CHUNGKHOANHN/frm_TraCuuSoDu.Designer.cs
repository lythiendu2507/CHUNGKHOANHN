
namespace CHUNGKHOANHN
{
    partial class frm_TraCuuSoDu
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTenNDT = new DevExpress.XtraEditors.TextEdit();
            this.sP_LAY_HOTEN_NDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new CHUNGKHOANHN.DS();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.txtMaNDT = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.gc_SoDuMoiNganHang = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcSoDuTien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.gcSoDuCP = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sP_LAY_HOTEN_NDTTableAdapter = new CHUNGKHOANHN.DSTableAdapters.SP_LAY_HOTEN_NDTTableAdapter();
            this.tableAdapterManager = new CHUNGKHOANHN.DSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenNDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_HOTEN_NDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SoDuMoiNganHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSoDuTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSoDuCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.txtHoTenNDT);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.btnTraCuu);
            this.panelControl1.Controls.Add(this.txtMaNDT);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1067, 100);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Nhà Đầu Tư";
            // 
            // txtHoTenNDT
            // 
            this.txtHoTenNDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_LAY_HOTEN_NDTBindingSource, "HOTEN", true));
            this.txtHoTenNDT.Enabled = false;
            this.txtHoTenNDT.Location = new System.Drawing.Point(205, 57);
            this.txtHoTenNDT.Name = "txtHoTenNDT";
            this.txtHoTenNDT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenNDT.Properties.Appearance.Options.UseFont = true;
            this.txtHoTenNDT.Size = new System.Drawing.Size(255, 24);
            this.txtHoTenNDT.TabIndex = 4;
            // 
            // sP_LAY_HOTEN_NDTBindingSource
            // 
            this.sP_LAY_HOTEN_NDTBindingSource.DataMember = "SP_LAY_HOTEN_NDT";
            this.sP_LAY_HOTEN_NDTBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ Tên Nhà Đầu Tư";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Location = new System.Drawing.Point(545, 12);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(106, 29);
            this.btnTraCuu.TabIndex = 1;
            this.btnTraCuu.Text = "Tra Cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // txtMaNDT
            // 
            this.txtMaNDT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNDT.Location = new System.Drawing.Point(205, 12);
            this.txtMaNDT.Name = "txtMaNDT";
            this.txtMaNDT.Size = new System.Drawing.Size(255, 25);
            this.txtMaNDT.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.gc_SoDuMoiNganHang);
            this.panelControl2.Controls.Add(this.gcSoDuTien);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 100);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1067, 315);
            this.panelControl2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Dư Tiền Của Nhà Đầu Tư";
            // 
            // gc_SoDuMoiNganHang
            // 
            this.gc_SoDuMoiNganHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_SoDuMoiNganHang.Location = new System.Drawing.Point(2, 2);
            this.gc_SoDuMoiNganHang.MainView = this.gridView3;
            this.gc_SoDuMoiNganHang.Name = "gc_SoDuMoiNganHang";
            this.gc_SoDuMoiNganHang.Size = new System.Drawing.Size(1063, 185);
            this.gc_SoDuMoiNganHang.TabIndex = 1;
            this.gc_SoDuMoiNganHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gc_SoDuMoiNganHang;
            this.gridView3.Name = "gridView3";
            // 
            // gcSoDuTien
            // 
            this.gcSoDuTien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcSoDuTien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcSoDuTien.Location = new System.Drawing.Point(2, 162);
            this.gcSoDuTien.MainView = this.gridView1;
            this.gcSoDuTien.Name = "gcSoDuTien";
            this.gcSoDuTien.Size = new System.Drawing.Size(1063, 151);
            this.gcSoDuTien.TabIndex = 0;
            this.gcSoDuTien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcSoDuTien;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.label3);
            this.panelControl3.Controls.Add(this.gcSoDuCP);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 415);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1067, 297);
            this.panelControl3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Dư Cổ Phiếu Của Nhà Đầu Tư";
            // 
            // gcSoDuCP
            // 
            this.gcSoDuCP.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcSoDuCP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcSoDuCP.Location = new System.Drawing.Point(2, 2);
            this.gcSoDuCP.MainView = this.gridView2;
            this.gcSoDuCP.Name = "gcSoDuCP";
            this.gcSoDuCP.Size = new System.Drawing.Size(1063, 290);
            this.gcSoDuCP.TabIndex = 0;
            this.gcSoDuCP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcSoDuCP;
            this.gridView2.Name = "gridView2";
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
            // frm_TraCuuSoDu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_TraCuuSoDu";
            this.Text = "frm_TraCuuSoDu";
            this.Load += new System.EventHandler(this.frm_TraCuuSoDu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenNDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_HOTEN_NDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SoDuMoiNganHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSoDuTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSoDuCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.TextBox txtMaNDT;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gcSoDuTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gcSoDuCP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DS dS;
        private System.Windows.Forms.BindingSource sP_LAY_HOTEN_NDTBindingSource;
        private DSTableAdapters.SP_LAY_HOTEN_NDTTableAdapter sP_LAY_HOTEN_NDTTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txtHoTenNDT;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gc_SoDuMoiNganHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
    }
}