
namespace CHUNGKHOANHN
{
    partial class frm_DatLenhMua
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label maTKNHLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label giaThamChieuLabel1;
            System.Windows.Forms.Label giaSanLabel1;
            System.Windows.Forms.Label giaTranLabel;
            this.dS = new CHUNGKHOANHN.DS();
            this.sP_LAY_HOTEN_NDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LAY_HOTEN_NDTTableAdapter = new CHUNGKHOANHN.DSTableAdapters.SP_LAY_HOTEN_NDTTableAdapter();
            this.tableAdapterManager = new CHUNGKHOANHN.DSTableAdapters.TableAdapterManager();
            this.coPhieuTableAdapter = new CHUNGKHOANHN.DSTableAdapters.CoPhieuTableAdapter();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLoaiLenh = new System.Windows.Forms.ComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.seGiaTran = new DevExpress.XtraEditors.SpinEdit();
            this.sP_LAY_GIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seGiaSan = new DevExpress.XtraEditors.SpinEdit();
            this.giaThamChieuSpinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.cmbMaCp = new System.Windows.Forms.ComboBox();
            this.giaCoPhieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTongGia = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cmbMaTKNH = new System.Windows.Forms.ComboBox();
            this.sP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coPhieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.sP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTTableAdapter = new CHUNGKHOANHN.DSTableAdapters.SP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTTableAdapter();
            this.txtSoTienKD = new System.Windows.Forms.TextBox();
            this.sP_LAY_GIATableAdapter = new CHUNGKHOANHN.DSTableAdapters.SP_LAY_GIATableAdapter();
            this.giaCoPhieuTableAdapter = new CHUNGKHOANHN.DSTableAdapters.GiaCoPhieuTableAdapter();
            hOTENLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            maTKNHLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            giaThamChieuLabel1 = new System.Windows.Forms.Label();
            giaSanLabel1 = new System.Windows.Forms.Label();
            giaTranLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_HOTEN_NDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seGiaTran.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_GIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seGiaSan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaThamChieuSpinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaCoPhieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coPhieuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(12, 70);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(132, 17);
            hOTENLabel.TabIndex = 2;
            hOTENLabel.Text = "Họ Tên Nhà Đầu Tư";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 114);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(197, 17);
            label2.TabIndex = 5;
            label2.Text = "Số Tiền Dư Được Phép Đầu Tư";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(438, 116);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 17);
            label3.TabIndex = 7;
            label3.Text = "VND";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(11, 165);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(66, 17);
            label6.TabIndex = 15;
            label6.Text = "Số Lượng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(12, 213);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(28, 17);
            label7.TabIndex = 16;
            label7.Text = "Giá";
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
            this.tableAdapterManager.CoPhieuTableAdapter = this.coPhieuTableAdapter;
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
            // coPhieuTableAdapter
            // 
            this.coPhieuTableAdapter.ClearBeforeFill = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_LAY_HOTEN_NDTBindingSource, "HOTEN", true));
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(173, 67);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(245, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đặt Lệnh Mua";
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
            this.cmbLoaiLenh.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiLenh_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(giaTranLabel);
            this.panelControl1.Controls.Add(this.seGiaTran);
            this.panelControl1.Controls.Add(giaSanLabel1);
            this.panelControl1.Controls.Add(this.seGiaSan);
            this.panelControl1.Controls.Add(giaThamChieuLabel1);
            this.panelControl1.Controls.Add(this.giaThamChieuSpinEdit1);
            this.panelControl1.Controls.Add(this.cmbMaCp);
            this.panelControl1.Controls.Add(label8);
            this.panelControl1.Controls.Add(this.txtTongGia);
            this.panelControl1.Controls.Add(label7);
            this.panelControl1.Controls.Add(label6);
            this.panelControl1.Controls.Add(this.txtGia);
            this.panelControl1.Controls.Add(this.txtSoLuong);
            this.panelControl1.Controls.Add(maTKNHLabel);
            this.panelControl1.Controls.Add(this.cmbMaTKNH);
            this.panelControl1.Controls.Add(this.cmbLoaiLenh);
            this.panelControl1.Controls.Add(label5);
            this.panelControl1.Controls.Add(label4);
            this.panelControl1.Location = new System.Drawing.Point(1, 165);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(673, 323);
            this.panelControl1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(342, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 28);
            this.button1.TabIndex = 29;
            this.button1.Text = "Xem Tổng Giá";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.seGiaTran.Location = new System.Drawing.Point(503, 109);
            this.seGiaTran.Name = "seGiaTran";
            this.seGiaTran.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seGiaTran.Properties.Appearance.Options.UseFont = true;
            this.seGiaTran.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seGiaTran.Size = new System.Drawing.Size(120, 24);
            this.seGiaTran.TabIndex = 28;
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
            this.seGiaSan.Location = new System.Drawing.Point(503, 77);
            this.seGiaSan.Name = "seGiaSan";
            this.seGiaSan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seGiaSan.Properties.Appearance.Options.UseFont = true;
            this.seGiaSan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seGiaSan.Size = new System.Drawing.Size(120, 24);
            this.seGiaSan.TabIndex = 27;
            // 
            // giaThamChieuSpinEdit1
            // 
            this.giaThamChieuSpinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_LAY_GIABindingSource, "GiaThamChieu", true));
            this.giaThamChieuSpinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.giaThamChieuSpinEdit1.Enabled = false;
            this.giaThamChieuSpinEdit1.Location = new System.Drawing.Point(503, 40);
            this.giaThamChieuSpinEdit1.Name = "giaThamChieuSpinEdit1";
            this.giaThamChieuSpinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giaThamChieuSpinEdit1.Properties.Appearance.Options.UseFont = true;
            this.giaThamChieuSpinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.giaThamChieuSpinEdit1.Size = new System.Drawing.Size(120, 24);
            this.giaThamChieuSpinEdit1.TabIndex = 26;
            // 
            // cmbMaCp
            // 
            this.cmbMaCp.DataSource = this.giaCoPhieuBindingSource;
            this.cmbMaCp.DisplayMember = "MaCP";
            this.cmbMaCp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaCp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaCp.FormattingEnabled = true;
            this.cmbMaCp.Location = new System.Drawing.Point(194, 66);
            this.cmbMaCp.Name = "cmbMaCp";
            this.cmbMaCp.Size = new System.Drawing.Size(121, 25);
            this.cmbMaCp.TabIndex = 22;
            this.cmbMaCp.ValueMember = "MaCP";
            this.cmbMaCp.SelectedIndexChanged += new System.EventHandler(this.cmbMaCp_SelectedIndexChanged);
            // 
            // giaCoPhieuBindingSource
            // 
            this.giaCoPhieuBindingSource.DataMember = "GiaCoPhieu";
            this.giaCoPhieuBindingSource.DataSource = this.dS;
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
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(194, 165);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 25);
            this.txtSoLuong.TabIndex = 13;
            // 
            // cmbMaTKNH
            // 
            this.cmbMaTKNH.DataSource = this.sP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTBindingSource;
            this.cmbMaTKNH.DisplayMember = "MaTKNH";
            this.cmbMaTKNH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaTKNH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaTKNH.FormattingEnabled = true;
            this.cmbMaTKNH.Location = new System.Drawing.Point(194, 112);
            this.cmbMaTKNH.Name = "cmbMaTKNH";
            this.cmbMaTKNH.Size = new System.Drawing.Size(121, 25);
            this.cmbMaTKNH.TabIndex = 12;
            this.cmbMaTKNH.ValueMember = "MaTKNH";
            this.cmbMaTKNH.SelectedIndexChanged += new System.EventHandler(this.cmbMaTKNH_SelectedIndexChanged);
            // 
            // sP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTBindingSource
            // 
            this.sP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTBindingSource.DataMember = "SP_LAY_SODUTIEN_MOINGANHANG_CUA_NDT";
            this.sP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTBindingSource.DataSource = this.dS;
            // 
            // coPhieuBindingSource
            // 
            this.coPhieuBindingSource.DataMember = "CoPhieu";
            this.coPhieuBindingSource.DataSource = this.dS;
            // 
            // btnMua
            // 
            this.btnMua.Location = new System.Drawing.Point(73, 478);
            this.btnMua.Name = "btnMua";
            this.btnMua.Size = new System.Drawing.Size(136, 34);
            this.btnMua.TabIndex = 12;
            this.btnMua.Text = "Mua";
            this.btnMua.UseVisualStyleBackColor = true;
            this.btnMua.Click += new System.EventHandler(this.btnMua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(272, 478);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(136, 34);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // sP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTTableAdapter
            // 
            this.sP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTTableAdapter.ClearBeforeFill = true;
            // 
            // txtSoTienKD
            // 
            this.txtSoTienKD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTBindingSource, "SOTIENKHADUNGCONLAI", true));
            this.txtSoTienKD.Enabled = false;
            this.txtSoTienKD.Location = new System.Drawing.Point(226, 108);
            this.txtSoTienKD.Name = "txtSoTienKD";
            this.txtSoTienKD.Size = new System.Drawing.Size(192, 25);
            this.txtSoTienKD.TabIndex = 15;
            // 
            // sP_LAY_GIATableAdapter
            // 
            this.sP_LAY_GIATableAdapter.ClearBeforeFill = true;
            // 
            // giaCoPhieuTableAdapter
            // 
            this.giaCoPhieuTableAdapter.ClearBeforeFill = true;
            // 
            // frm_DatLenhMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 588);
            this.Controls.Add(this.txtSoTienKD);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnMua);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.txtHoTen);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DatLenhMua";
            this.Text = "frm_DatLenhMua";
            this.Load += new System.EventHandler(this.frm_DatLenhMua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_HOTEN_NDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seGiaTran.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_GIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seGiaSan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaThamChieuSpinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaCoPhieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coPhieuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource sP_LAY_HOTEN_NDTBindingSource;
        private DSTableAdapters.SP_LAY_HOTEN_NDTTableAdapter sP_LAY_HOTEN_NDTTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.CoPhieuTableAdapter coPhieuTableAdapter;
        private System.Windows.Forms.ComboBox cmbLoaiLenh;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnMua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.BindingSource coPhieuBindingSource;
        private System.Windows.Forms.BindingSource sP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTBindingSource;
        private DSTableAdapters.SP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTTableAdapter sP_LAY_SODUTIEN_MOINGANHANG_CUA_NDTTableAdapter;
        private System.Windows.Forms.ComboBox cmbMaTKNH;
        private System.Windows.Forms.TextBox txtSoTienKD;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.BindingSource sP_LAY_GIABindingSource;
        private DSTableAdapters.SP_LAY_GIATableAdapter sP_LAY_GIATableAdapter;
        private System.Windows.Forms.TextBox txtTongGia;
        private System.Windows.Forms.BindingSource giaCoPhieuBindingSource;
        private DSTableAdapters.GiaCoPhieuTableAdapter giaCoPhieuTableAdapter;
        private System.Windows.Forms.ComboBox cmbMaCp;
        private DevExpress.XtraEditors.SpinEdit seGiaTran;
        private DevExpress.XtraEditors.SpinEdit seGiaSan;
        private DevExpress.XtraEditors.SpinEdit giaThamChieuSpinEdit1;
        private System.Windows.Forms.Button button1;
    }
}