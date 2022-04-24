
namespace CHUNGKHOANHN
{
    partial class frm_DatLenhBan
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
            System.Windows.Forms.Label giaTranLabel;
            System.Windows.Forms.Label giaSanLabel1;
            System.Windows.Forms.Label giaThamChieuLabel1;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label maTKNHLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label hOTENLabel;
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbMaCP = new System.Windows.Forms.ComboBox();
            this.sP_LAY_MACP_CUA_1NDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new CHUNGKHOANHN.DS();
            this.cmbMaTKNH = new System.Windows.Forms.ComboBox();
            this.sP_LAY_TKNH_NDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seGiaTran = new DevExpress.XtraEditors.SpinEdit();
            this.sP_LAY_GIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seGiaSan = new DevExpress.XtraEditors.SpinEdit();
            this.giaThamChieuSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.btnTongGia = new System.Windows.Forms.Button();
            this.txtTongGia = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cmbLoaiLenh = new System.Windows.Forms.ComboBox();
            this.soHuuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.soHuuTableAdapter = new CHUNGKHOANHN.DSTableAdapters.SoHuuTableAdapter();
            this.tableAdapterManager = new CHUNGKHOANHN.DSTableAdapters.TableAdapterManager();
            this.giaCoPhieuTableAdapter = new CHUNGKHOANHN.DSTableAdapters.GiaCoPhieuTableAdapter();
            this.sP_LAY_GIATableAdapter = new CHUNGKHOANHN.DSTableAdapters.SP_LAY_GIATableAdapter();
            this.giaCoPhieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soHuuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LAY_TKNH_NDTTableAdapter = new CHUNGKHOANHN.DSTableAdapters.SP_LAY_TKNH_NDTTableAdapter();
            this.sP_LAY_MACP_CUA_1NDTTableAdapter = new CHUNGKHOANHN.DSTableAdapters.SP_LAY_MACP_CUA_1NDTTableAdapter();
            this.txtSoLuongKD = new System.Windows.Forms.TextBox();
            giaTranLabel = new System.Windows.Forms.Label();
            giaSanLabel1 = new System.Windows.Forms.Label();
            giaThamChieuLabel1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            maTKNHLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_MACP_CUA_1NDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_TKNH_NDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seGiaTran.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_GIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seGiaSan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaThamChieuSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soHuuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaCoPhieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soHuuBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // giaTranLabel
            // 
            giaTranLabel.AutoSize = true;
            giaTranLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaTranLabel.Location = new System.Drawing.Point(390, 112);
            giaTranLabel.Name = "giaTranLabel";
            giaTranLabel.Size = new System.Drawing.Size(59, 17);
            giaTranLabel.TabIndex = 27;
            giaTranLabel.Text = "Giá Trần";
            // 
            // giaSanLabel1
            // 
            giaSanLabel1.AutoSize = true;
            giaSanLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaSanLabel1.Location = new System.Drawing.Point(390, 80);
            giaSanLabel1.Name = "giaSanLabel1";
            giaSanLabel1.Size = new System.Drawing.Size(54, 17);
            giaSanLabel1.TabIndex = 26;
            giaSanLabel1.Text = "Gía Sàn";
            // 
            // giaThamChieuLabel1
            // 
            giaThamChieuLabel1.AutoSize = true;
            giaThamChieuLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaThamChieuLabel1.Location = new System.Drawing.Point(390, 43);
            giaThamChieuLabel1.Name = "giaThamChieuLabel1";
            giaThamChieuLabel1.Size = new System.Drawing.Size(104, 17);
            giaThamChieuLabel1.TabIndex = 25;
            giaThamChieuLabel1.Text = "Giá Tham Chiếu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(12, 256);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(62, 17);
            label8.TabIndex = 21;
            label8.Text = "Tổng Giá";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(12, 213);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(56, 17);
            label7.TabIndex = 16;
            label7.Text = "Giá Bán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(11, 165);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(94, 17);
            label6.TabIndex = 15;
            label6.Text = "Số Lượng Bán";
            // 
            // maTKNHLabel
            // 
            maTKNHLabel.AutoSize = true;
            maTKNHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maTKNHLabel.Location = new System.Drawing.Point(11, 112);
            maTKNHLabel.Name = "maTKNHLabel";
            maTKNHLabel.Size = new System.Drawing.Size(166, 17);
            maTKNHLabel.TabIndex = 11;
            maTKNHLabel.Text = "Mã Tài Khoản Ngân Hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(11, 66);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(62, 17);
            label5.TabIndex = 10;
            label5.Text = "Cổ Phiếu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(11, 21);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(68, 17);
            label4.TabIndex = 8;
            label4.Text = "Loại Lệnh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(26, 98);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(157, 17);
            label2.TabIndex = 19;
            label2.Text = "Số Cổ Phiếu Có Thể Bán";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(26, 54);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(132, 17);
            hOTENLabel.TabIndex = 16;
            hOTENLabel.Text = "Họ Tên Nhà Đầu Tư";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(408, 470);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(136, 34);
            this.btnLamMoi.TabIndex = 23;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnBan
            // 
            this.btnBan.Location = new System.Drawing.Point(187, 470);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(136, 34);
            this.btnBan.TabIndex = 22;
            this.btnBan.Text = "Bán";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.panelControl1.Controls.Add(this.cmbMaCP);
            this.panelControl1.Controls.Add(this.cmbMaTKNH);
            this.panelControl1.Controls.Add(this.seGiaTran);
            this.panelControl1.Controls.Add(this.seGiaSan);
            this.panelControl1.Controls.Add(this.giaThamChieuSpinEdit);
            this.panelControl1.Controls.Add(this.btnTongGia);
            this.panelControl1.Controls.Add(giaTranLabel);
            this.panelControl1.Controls.Add(giaSanLabel1);
            this.panelControl1.Controls.Add(giaThamChieuLabel1);
            this.panelControl1.Controls.Add(label8);
            this.panelControl1.Controls.Add(this.txtTongGia);
            this.panelControl1.Controls.Add(label7);
            this.panelControl1.Controls.Add(label6);
            this.panelControl1.Controls.Add(this.txtGia);
            this.panelControl1.Controls.Add(this.txtSoLuong);
            this.panelControl1.Controls.Add(maTKNHLabel);
            this.panelControl1.Controls.Add(this.cmbLoaiLenh);
            this.panelControl1.Controls.Add(label5);
            this.panelControl1.Controls.Add(label4);
            this.panelControl1.Location = new System.Drawing.Point(15, 149);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(749, 323);
            this.panelControl1.TabIndex = 21;
            // 
            // cmbMaCP
            // 
            this.cmbMaCP.DataSource = this.sP_LAY_MACP_CUA_1NDTBindingSource;
            this.cmbMaCP.DisplayMember = "MaCP";
            this.cmbMaCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaCP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaCP.FormattingEnabled = true;
            this.cmbMaCP.Location = new System.Drawing.Point(194, 62);
            this.cmbMaCP.Name = "cmbMaCP";
            this.cmbMaCP.Size = new System.Drawing.Size(121, 25);
            this.cmbMaCP.TabIndex = 35;
            this.cmbMaCP.ValueMember = "MaCP";
            this.cmbMaCP.SelectedIndexChanged += new System.EventHandler(this.cmbMaCP_SelectedIndexChanged_2);
            // 
            // sP_LAY_MACP_CUA_1NDTBindingSource
            // 
            this.sP_LAY_MACP_CUA_1NDTBindingSource.DataMember = "SP_LAY_MACP_CUA_1NDT";
            this.sP_LAY_MACP_CUA_1NDTBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMaTKNH
            // 
            this.cmbMaTKNH.DataSource = this.sP_LAY_TKNH_NDTBindingSource;
            this.cmbMaTKNH.DisplayMember = "MaTKNH";
            this.cmbMaTKNH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaTKNH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaTKNH.FormattingEnabled = true;
            this.cmbMaTKNH.Location = new System.Drawing.Point(194, 111);
            this.cmbMaTKNH.Name = "cmbMaTKNH";
            this.cmbMaTKNH.Size = new System.Drawing.Size(121, 25);
            this.cmbMaTKNH.TabIndex = 34;
            this.cmbMaTKNH.ValueMember = "MaTKNH";
            // 
            // sP_LAY_TKNH_NDTBindingSource
            // 
            this.sP_LAY_TKNH_NDTBindingSource.DataMember = "SP_LAY_TKNH_NDT";
            this.sP_LAY_TKNH_NDTBindingSource.DataSource = this.dS;
            // 
            // seGiaTran
            // 
            this.seGiaTran.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_LAY_GIABindingSource, "GiaTran", true));
            this.seGiaTran.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seGiaTran.Enabled = false;
            this.seGiaTran.Location = new System.Drawing.Point(534, 114);
            this.seGiaTran.Name = "seGiaTran";
            this.seGiaTran.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seGiaTran.Properties.Appearance.Options.UseFont = true;
            this.seGiaTran.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seGiaTran.Size = new System.Drawing.Size(100, 24);
            this.seGiaTran.TabIndex = 32;
            // 
            // sP_LAY_GIABindingSource
            // 
            this.sP_LAY_GIABindingSource.DataMember = "SP_LAY_GIA";
            this.sP_LAY_GIABindingSource.DataSource = this.dS;
            // 
            // seGiaSan
            // 
            this.seGiaSan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_LAY_GIABindingSource, "GiaSan", true));
            this.seGiaSan.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seGiaSan.Enabled = false;
            this.seGiaSan.Location = new System.Drawing.Point(534, 79);
            this.seGiaSan.Name = "seGiaSan";
            this.seGiaSan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seGiaSan.Properties.Appearance.Options.UseFont = true;
            this.seGiaSan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seGiaSan.Size = new System.Drawing.Size(100, 24);
            this.seGiaSan.TabIndex = 31;
            // 
            // giaThamChieuSpinEdit
            // 
            this.giaThamChieuSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_LAY_GIABindingSource, "GiaThamChieu", true));
            this.giaThamChieuSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.giaThamChieuSpinEdit.Enabled = false;
            this.giaThamChieuSpinEdit.Location = new System.Drawing.Point(534, 40);
            this.giaThamChieuSpinEdit.Name = "giaThamChieuSpinEdit";
            this.giaThamChieuSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giaThamChieuSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.giaThamChieuSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.giaThamChieuSpinEdit.Size = new System.Drawing.Size(100, 24);
            this.giaThamChieuSpinEdit.TabIndex = 30;
            // 
            // btnTongGia
            // 
            this.btnTongGia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongGia.Location = new System.Drawing.Point(342, 209);
            this.btnTongGia.Name = "btnTongGia";
            this.btnTongGia.Size = new System.Drawing.Size(107, 28);
            this.btnTongGia.TabIndex = 29;
            this.btnTongGia.Text = "Xem Tổng Giá";
            this.btnTongGia.UseVisualStyleBackColor = true;
            this.btnTongGia.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTongGia
            // 
            this.txtTongGia.Enabled = false;
            this.txtTongGia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongGia.Location = new System.Drawing.Point(194, 252);
            this.txtTongGia.Name = "txtTongGia";
            this.txtTongGia.Size = new System.Drawing.Size(121, 25);
            this.txtTongGia.TabIndex = 20;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(194, 209);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(121, 25);
            this.txtGia.TabIndex = 14;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(194, 165);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 25);
            this.txtSoLuong.TabIndex = 13;
            // 
            // cmbLoaiLenh
            // 
            this.cmbLoaiLenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiLenh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiLenh.FormattingEnabled = true;
            this.cmbLoaiLenh.Items.AddRange(new object[] {
            "LO",
            "MB"});
            this.cmbLoaiLenh.Location = new System.Drawing.Point(194, 17);
            this.cmbLoaiLenh.Name = "cmbLoaiLenh";
            this.cmbLoaiLenh.Size = new System.Drawing.Size(121, 25);
            this.cmbLoaiLenh.TabIndex = 9;
            // 
            // soHuuBindingSource
            // 
            this.soHuuBindingSource.DataMember = "SoHuu";
            this.soHuuBindingSource.DataSource = this.dS;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Đặt Lệnh Bán";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(187, 51);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(245, 20);
            this.txtHoTen.TabIndex = 17;
            // 
            // soHuuTableAdapter
            // 
            this.soHuuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangPhiTableAdapter = null;
            this.tableAdapterManager.ChiTietBangPhiTableAdapter = null;
            this.tableAdapterManager.ChiTietQuyDinhTableAdapter = null;
            this.tableAdapterManager.CongTyChungKhoanTableAdapter = null;
            this.tableAdapterManager.CoPhieuTableAdapter = null;
            this.tableAdapterManager.GiaCoPhieuTableAdapter = this.giaCoPhieuTableAdapter;
            this.tableAdapterManager.LenhDatTableAdapter = null;
            this.tableAdapterManager.LenhKhopTableAdapter = null;
            this.tableAdapterManager.LoaiLenhTableAdapter = null;
            this.tableAdapterManager.NganHangTableAdapter = null;
            this.tableAdapterManager.NhaDauTuTableAdapter = null;
            this.tableAdapterManager.NhanVienSGDTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.QuyDinhTableAdapter = null;
            this.tableAdapterManager.SanGiaoDichTableAdapter = null;
            this.tableAdapterManager.SoHuuTableAdapter = this.soHuuTableAdapter;
            this.tableAdapterManager.TaiKhoanNganHangTableAdapter = null;
            this.tableAdapterManager.TrangThaiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CHUNGKHOANHN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // giaCoPhieuTableAdapter
            // 
            this.giaCoPhieuTableAdapter.ClearBeforeFill = true;
            // 
            // sP_LAY_GIATableAdapter
            // 
            this.sP_LAY_GIATableAdapter.ClearBeforeFill = true;
            // 
            // giaCoPhieuBindingSource
            // 
            this.giaCoPhieuBindingSource.DataMember = "GiaCoPhieu";
            this.giaCoPhieuBindingSource.DataSource = this.dS;
            // 
            // soHuuBindingSource1
            // 
            this.soHuuBindingSource1.DataMember = "FK_SoHuu_GiaCoPhieu";
            this.soHuuBindingSource1.DataSource = this.giaCoPhieuBindingSource;
            // 
            // sP_LAY_TKNH_NDTTableAdapter
            // 
            this.sP_LAY_TKNH_NDTTableAdapter.ClearBeforeFill = true;
            // 
            // sP_LAY_MACP_CUA_1NDTTableAdapter
            // 
            this.sP_LAY_MACP_CUA_1NDTTableAdapter.ClearBeforeFill = true;
            // 
            // txtSoLuongKD
            // 
            this.txtSoLuongKD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_LAY_MACP_CUA_1NDTBindingSource, "SoLuong", true));
            this.txtSoLuongKD.Enabled = false;
            this.txtSoLuongKD.Location = new System.Drawing.Point(209, 95);
            this.txtSoLuongKD.Name = "txtSoLuongKD";
            this.txtSoLuongKD.Size = new System.Drawing.Size(121, 25);
            this.txtSoLuongKD.TabIndex = 25;
            this.txtSoLuongKD.TextChanged += new System.EventHandler(this.txtSoLuongKD_TextChanged);
            // 
            // frm_DatLenhBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 524);
            this.Controls.Add(this.txtSoLuongKD);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.txtHoTen);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DatLenhBan";
            this.Text = "frm_DatLenhBan";
            this.Load += new System.EventHandler(this.frm_DatLenhBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_MACP_CUA_1NDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_TKNH_NDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seGiaTran.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_GIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seGiaSan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaThamChieuSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soHuuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaCoPhieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soHuuBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnBan;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnTongGia;
        private System.Windows.Forms.TextBox txtTongGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DS dS;
        private System.Windows.Forms.BindingSource soHuuBindingSource;
        private DSTableAdapters.SoHuuTableAdapter soHuuTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sP_LAY_GIABindingSource;
        private DSTableAdapters.SP_LAY_GIATableAdapter sP_LAY_GIATableAdapter;
        private DevExpress.XtraEditors.SpinEdit seGiaTran;
        private DevExpress.XtraEditors.SpinEdit seGiaSan;
        private DevExpress.XtraEditors.SpinEdit giaThamChieuSpinEdit;
        private System.Windows.Forms.ComboBox cmbLoaiLenh;
        private DSTableAdapters.GiaCoPhieuTableAdapter giaCoPhieuTableAdapter;
        private System.Windows.Forms.BindingSource giaCoPhieuBindingSource;
        private System.Windows.Forms.BindingSource soHuuBindingSource1;
        private System.Windows.Forms.BindingSource sP_LAY_TKNH_NDTBindingSource;
        private DSTableAdapters.SP_LAY_TKNH_NDTTableAdapter sP_LAY_TKNH_NDTTableAdapter;
        private System.Windows.Forms.ComboBox cmbMaTKNH;
        private System.Windows.Forms.BindingSource sP_LAY_MACP_CUA_1NDTBindingSource;
        private DSTableAdapters.SP_LAY_MACP_CUA_1NDTTableAdapter sP_LAY_MACP_CUA_1NDTTableAdapter;
        private System.Windows.Forms.ComboBox cmbMaCP;
        private System.Windows.Forms.TextBox txtSoLuongKD;
    }
}