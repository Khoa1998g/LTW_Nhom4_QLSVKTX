using Microsoft.Reporting.WinForms;
using QuanLyKTX.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            List<reportSinhVien> svs = reportSinhVienDAO.Instance.loadListReport();
            this.reportViewer1.LocalReport.ReportPath = "report.rdlc";
            var reportData = new ReportDataSource("DataSet1", svs);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportData);
            this.reportViewer1.RefreshReport();
        }
    }
}
