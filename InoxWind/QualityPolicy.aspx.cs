using BusinessLogic.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InoxWind
{
    public partial class QualityPolicy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["CertificateToken"] = Guid.NewGuid().ToString();
                BindData();
            }

        }
        private void BindData()
        {
            DataTable dataTable = new DataTable();
            dataTable = QualityCertificateController.GetCertificateList(); 
            DataRow[] rows = dataTable.Select("Isactive=True");
            Array.Sort(rows, (x, y) => Comparer<int>.Default.Compare((int)x["ID"], (int)y["ID"]));
            StringBuilder Sb = new StringBuilder();
            foreach (DataRow row in rows)
            {
                string domainname = CommonClass.BaseDomain.GetBaseDomain(Request) + Convert.ToString(row["CertificateImage"]);
                Sb.Append(@"<div class='w33 pdf-card'> <img src='assets/images/pdf-icon.png' alt='' /><div class='pdf-content'><p>" + Convert.ToString(row["CertificateName"]) + " </p> <a href='" + domainname + "' title='Open PDF' target='_blank'  style='color:#212529' /> <i class='bi bi-download' style='font-size:18px'></i></a> </div></div>");
            }

            Divcertificates.InnerHtml = Sb.ToString();
        }

    }
}