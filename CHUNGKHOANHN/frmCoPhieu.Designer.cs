
namespace CHUNGKHOANHN
{
    partial class frmCoPhieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoPhieu));
            System.Windows.Forms.Label maCPLabel;
            System.Windows.Forms.Label tenCTLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label websiteLabel;
            System.Windows.Forms.Label soLuongCPLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dS = new CHUNGKHOANHN.DS();
            this.coPhieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coPhieuTableAdapter = new CHUNGKHOANHN.DSTableAdapters.CoPhieuTableAdapter();
            this.tableAdapterManager = new CHUNGKHOANHN.DSTableAdapters.TableAdapterManager();
            this.coPhieuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.coPhieuBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.coPhieuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaCP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongCP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMaCP = new DevExpress.XtraEditors.TextEdit();
            this.txtTenCP = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtFax = new DevExpress.XtraEditors.TextEdit();
            this.txtWeb = new DevExpress.XtraEditors.TextEdit();
            this.seSoLuong = new DevExpress.XtraEditors.SpinEdit();
            maCPLabel = new System.Windows.Forms.Label();
            tenCTLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            websiteLabel = new System.Windows.Forms.Label();
            soLuongCPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coPhieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coPhieuBindingNavigator)).BeginInit();
            this.coPhieuBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coPhieuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoLuong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload});
            this.barManager1.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1067, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 588);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1067, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 564);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1067, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 564);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 1;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage1")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage1")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage1")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage1")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(soLuongCPLabel);
            this.panelControl1.Controls.Add(this.seSoLuong);
            this.panelControl1.Controls.Add(websiteLabel);
            this.panelControl1.Controls.Add(this.txtWeb);
            this.panelControl1.Controls.Add(faxLabel);
            this.panelControl1.Controls.Add(this.txtFax);
            this.panelControl1.Controls.Add(sDTLabel);
            this.panelControl1.Controls.Add(this.txtSDT);
            this.panelControl1.Controls.Add(emailLabel);
            this.panelControl1.Controls.Add(this.txtEmail);
            this.panelControl1.Controls.Add(diaChiLabel);
            this.panelControl1.Controls.Add(this.txtDiaChi);
            this.panelControl1.Controls.Add(tenCTLabel);
            this.panelControl1.Controls.Add(this.txtTenCP);
            this.panelControl1.Controls.Add(maCPLabel);
            this.panelControl1.Controls.Add(this.txtMaCP);
            this.panelControl1.Controls.Add(this.coPhieuGridControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1067, 552);
            this.panelControl1.TabIndex = 4;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coPhieuBindingSource
            // 
            this.coPhieuBindingSource.DataMember = "CoPhieu";
            this.coPhieuBindingSource.DataSource = this.dS;
            // 
            // coPhieuTableAdapter
            // 
            this.coPhieuTableAdapter.ClearBeforeFill = true;
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
            // coPhieuBindingNavigator
            // 
            this.coPhieuBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.coPhieuBindingNavigator.BindingSource = this.coPhieuBindingSource;
            this.coPhieuBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coPhieuBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.coPhieuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.coPhieuBindingNavigatorSaveItem});
            this.coPhieuBindingNavigator.Location = new System.Drawing.Point(0, 576);
            this.coPhieuBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coPhieuBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coPhieuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coPhieuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coPhieuBindingNavigator.Name = "coPhieuBindingNavigator";
            this.coPhieuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coPhieuBindingNavigator.Size = new System.Drawing.Size(1067, 25);
            this.coPhieuBindingNavigator.TabIndex = 5;
            this.coPhieuBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // coPhieuBindingNavigatorSaveItem
            // 
            this.coPhieuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.coPhieuBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("coPhieuBindingNavigatorSaveItem.Image")));
            this.coPhieuBindingNavigatorSaveItem.Name = "coPhieuBindingNavigatorSaveItem";
            this.coPhieuBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.coPhieuBindingNavigatorSaveItem.Text = "Save Data";
            this.coPhieuBindingNavigatorSaveItem.Click += new System.EventHandler(this.coPhieuBindingNavigatorSaveItem_Click);
            // 
            // coPhieuGridControl
            // 
            this.coPhieuGridControl.DataSource = this.coPhieuBindingSource;
            this.coPhieuGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.coPhieuGridControl.Location = new System.Drawing.Point(339, 2);
            this.coPhieuGridControl.MainView = this.gridView1;
            this.coPhieuGridControl.MenuManager = this.barManager1;
            this.coPhieuGridControl.Name = "coPhieuGridControl";
            this.coPhieuGridControl.Size = new System.Drawing.Size(726, 548);
            this.coPhieuGridControl.TabIndex = 0;
            this.coPhieuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaCP,
            this.colTenCT,
            this.colDiaChi,
            this.colEmail,
            this.colSDT,
            this.colFax,
            this.colWebsite,
            this.colSoLuongCP,
            this.colMaSGD});
            this.gridView1.GridControl = this.coPhieuGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMaCP
            // 
            this.colMaCP.FieldName = "MaCP";
            this.colMaCP.Name = "colMaCP";
            this.colMaCP.OptionsColumn.ReadOnly = true;
            this.colMaCP.Visible = true;
            this.colMaCP.VisibleIndex = 0;
            // 
            // colTenCT
            // 
            this.colTenCT.FieldName = "TenCT";
            this.colTenCT.Name = "colTenCT";
            this.colTenCT.OptionsColumn.ReadOnly = true;
            this.colTenCT.Visible = true;
            this.colTenCT.VisibleIndex = 1;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsColumn.ReadOnly = true;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 2;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.ReadOnly = true;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.OptionsColumn.ReadOnly = true;
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 4;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.ReadOnly = true;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 5;
            // 
            // colWebsite
            // 
            this.colWebsite.FieldName = "Website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.OptionsColumn.ReadOnly = true;
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 6;
            // 
            // colSoLuongCP
            // 
            this.colSoLuongCP.FieldName = "SoLuongCP";
            this.colSoLuongCP.Name = "colSoLuongCP";
            this.colSoLuongCP.OptionsColumn.ReadOnly = true;
            this.colSoLuongCP.Visible = true;
            this.colSoLuongCP.VisibleIndex = 7;
            // 
            // colMaSGD
            // 
            this.colMaSGD.FieldName = "MaSGD";
            this.colMaSGD.Name = "colMaSGD";
            // 
            // maCPLabel
            // 
            maCPLabel.AutoSize = true;
            maCPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maCPLabel.Location = new System.Drawing.Point(12, 64);
            maCPLabel.Name = "maCPLabel";
            maCPLabel.Size = new System.Drawing.Size(86, 17);
            maCPLabel.TabIndex = 1;
            maCPLabel.Text = "Mã Cổ Phiếu";
            maCPLabel.Click += new System.EventHandler(this.maCPLabel_Click);
            // 
            // txtMaCP
            // 
            this.txtMaCP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.coPhieuBindingSource, "MaCP", true));
            this.txtMaCP.Location = new System.Drawing.Point(124, 61);
            this.txtMaCP.MenuManager = this.barManager1;
            this.txtMaCP.Name = "txtMaCP";
            this.txtMaCP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCP.Properties.Appearance.Options.UseFont = true;
            this.txtMaCP.Size = new System.Drawing.Size(161, 24);
            this.txtMaCP.TabIndex = 2;
            // 
            // tenCTLabel
            // 
            tenCTLabel.AutoSize = true;
            tenCTLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenCTLabel.Location = new System.Drawing.Point(9, 117);
            tenCTLabel.Name = "tenCTLabel";
            tenCTLabel.Size = new System.Drawing.Size(89, 17);
            tenCTLabel.TabIndex = 3;
            tenCTLabel.Text = "Tên Cổ Phiếu";
            // 
            // txtTenCP
            // 
            this.txtTenCP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.coPhieuBindingSource, "TenCT", true));
            this.txtTenCP.Location = new System.Drawing.Point(124, 114);
            this.txtTenCP.MenuManager = this.barManager1;
            this.txtTenCP.Name = "txtTenCP";
            this.txtTenCP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCP.Properties.Appearance.Options.UseFont = true;
            this.txtTenCP.Size = new System.Drawing.Size(161, 24);
            this.txtTenCP.TabIndex = 4;
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diaChiLabel.Location = new System.Drawing.Point(12, 170);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(53, 17);
            diaChiLabel.TabIndex = 5;
            diaChiLabel.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.coPhieuBindingSource, "DiaChi", true));
            this.txtDiaChi.Location = new System.Drawing.Point(124, 163);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(161, 24);
            this.txtDiaChi.TabIndex = 6;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(12, 230);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 17);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.coPhieuBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(124, 223);
            this.txtEmail.MenuManager = this.barManager1;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(161, 24);
            this.txtEmail.TabIndex = 8;
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sDTLabel.Location = new System.Drawing.Point(12, 288);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(38, 17);
            sDTLabel.TabIndex = 9;
            sDTLabel.Text = "SDT:";
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.coPhieuBindingSource, "SDT", true));
            this.txtSDT.Location = new System.Drawing.Point(124, 281);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Size = new System.Drawing.Size(161, 24);
            this.txtSDT.TabIndex = 10;
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            faxLabel.Location = new System.Drawing.Point(17, 339);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(33, 17);
            faxLabel.TabIndex = 11;
            faxLabel.Text = "Fax:";
            // 
            // txtFax
            // 
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.coPhieuBindingSource, "Fax", true));
            this.txtFax.Location = new System.Drawing.Point(124, 332);
            this.txtFax.MenuManager = this.barManager1;
            this.txtFax.Name = "txtFax";
            this.txtFax.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Properties.Appearance.Options.UseFont = true;
            this.txtFax.Size = new System.Drawing.Size(161, 24);
            this.txtFax.TabIndex = 12;
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            websiteLabel.Location = new System.Drawing.Point(12, 389);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(58, 17);
            websiteLabel.TabIndex = 13;
            websiteLabel.Text = "Website:";
            // 
            // txtWeb
            // 
            this.txtWeb.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.coPhieuBindingSource, "Website", true));
            this.txtWeb.Location = new System.Drawing.Point(124, 382);
            this.txtWeb.MenuManager = this.barManager1;
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeb.Properties.Appearance.Options.UseFont = true;
            this.txtWeb.Size = new System.Drawing.Size(161, 24);
            this.txtWeb.TabIndex = 14;
            // 
            // soLuongCPLabel
            // 
            soLuongCPLabel.AutoSize = true;
            soLuongCPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soLuongCPLabel.Location = new System.Drawing.Point(12, 431);
            soLuongCPLabel.Name = "soLuongCPLabel";
            soLuongCPLabel.Size = new System.Drawing.Size(90, 17);
            soLuongCPLabel.TabIndex = 15;
            soLuongCPLabel.Text = "So Luong CP:";
            // 
            // seSoLuong
            // 
            this.seSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.coPhieuBindingSource, "SoLuongCP", true));
            this.seSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSoLuong.Location = new System.Drawing.Point(124, 424);
            this.seSoLuong.MenuManager = this.barManager1;
            this.seSoLuong.Name = "seSoLuong";
            this.seSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seSoLuong.Properties.Appearance.Options.UseFont = true;
            this.seSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seSoLuong.Size = new System.Drawing.Size(161, 24);
            this.seSoLuong.TabIndex = 16;
            // 
            // frmCoPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.coPhieuBindingNavigator);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCoPhieu";
            this.Text = "frmCoPhieu";
            this.Load += new System.EventHandler(this.frmCoPhieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coPhieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coPhieuBindingNavigator)).EndInit();
            this.coPhieuBindingNavigator.ResumeLayout(false);
            this.coPhieuBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coPhieuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoLuong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingNavigator coPhieuBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource coPhieuBindingSource;
        private DS dS;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton coPhieuBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DSTableAdapters.CoPhieuTableAdapter coPhieuTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SpinEdit seSoLuong;
        private DevExpress.XtraEditors.TextEdit txtWeb;
        private DevExpress.XtraEditors.TextEdit txtFax;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtTenCP;
        private DevExpress.XtraEditors.TextEdit txtMaCP;
        private DevExpress.XtraGrid.GridControl coPhieuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCT;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongCP;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSGD;
    }
}