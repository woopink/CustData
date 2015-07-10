using Cust.Models;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cust.Reports
{
    public partial class CustView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            客戶資料Entities db = new 客戶資料Entities();
              
            this.ReportViewer1.Reset();
            this.ReportViewer1.LocalReport.Dispose();
            this.ReportViewer1.LocalReport.DataSources.Clear();

            var  dt = db.CustView.ToList();
            ReportDataSource datasource = new ReportDataSource("Dataset1",dt);

            this.ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Reports/Cust.rdlc");
            this.ReportViewer1.LocalReport.DataSources.Add(datasource);
            this.ReportViewer1.LocalReport.Refresh();
        }
    }
}