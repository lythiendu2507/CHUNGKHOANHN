using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace CHUNGKHOANHN
{
    public partial class BaoCaoLietKeCoPhieuNDT : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoLietKeCoPhieuNDT( string MaNDT)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MaNDT;
            this.sqlDataSource1.Fill();
        }
        //public BaoCaoLietKeCoPhieuNDT() {}

    }
}
