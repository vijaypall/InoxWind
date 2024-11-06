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
    public partial class Career : System.Web.UI.Page
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
            StringBuilder Sb = new StringBuilder();
            try
            {
                Sb.Append(@"<table><tbody<tr><th>Position Name </th> <th> Location </th> <th> Minimum Qualification </th><th></th> </tr>");
                DataTable dataTable = new DataTable();
                dataTable = CareersController.GetCareerList();
                DataRow[] rows = dataTable.Select("Isactive=True");
                Array.Sort(rows, (x, y) => Comparer<int>.Default.Compare((int)x["ID"], (int)y["ID"]));

                foreach (DataRow row in rows)
                {
                    string domainname =CommonClass.BaseDomain.GetBaseDomain(Request) + Convert.ToString(row["DetailPdf"]);
                    string EncriptQS = "ApplyNow.aspx?data=" + CommonClass.QueryStringHelper.Encrypt("Id=" + row["ID"].ToString());
                    //Sb.Append("<tr><td>" + row["PositionName"].ToString() + "</td><td>'" + row["Location"].ToString() + "'</td> <td>'" + row["RequireQualification"].ToString() + "'</td><td><a href='" + domainname + "' title="" target='_blank'>View Details</a><a href='ApplyNow.aspx' title='' class='apply-btn'>Apply Now</a> </td></tr>");
                    Sb.Append("<tr><td>" + row["PositionName"].ToString() + "</td><td>" + row["Location"].ToString() + "</td> <td>" + row["RequireQualification"].ToString() + "</td><td><a href='" + domainname + "' title='' target='_blank'>View Details</a><a href='" + HttpUtility.HtmlEncode(EncriptQS) + "' title='' class='apply-btn'>Apply Now</a> </td> </tr>");
                }
            }
            catch
            { }
            finally
            {
                Sb.Append(@"</tbody></table>");
            }

            PoplateTable.InnerHtml = Sb.ToString();
        } 
    }
}