using BusinessLogic.BusinessObjectModel;
using BusinessLogic.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InoxWind
{
    public partial class press_release : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    BindGrid();
            //}

        } 
        private void BindGrid()
        {
            DataTable dataTable = new DataTable();
            dataTable = NewsRoomController.GetRecordList();
            DataRow[] rowEditior = dataTable.Select("Isactive=True and NewsType='Press Releases'");
            StringBuilder Sb = new StringBuilder();
            string StrHead = @"<table><tbody><tr><th>Particulars</th><th>Date</th></tr>";
            string foot = " </tbody></table>";
            Sb.Append(StrHead);
            foreach (DataRow row in rowEditior)
            { 
                    string domainname = CommonClass.BaseDomain.GetBaseDomain(Request) + Convert.ToString(row["NewsDoc"]);
                    Sb.Append("<tr onclick =\"window.open('" +domainname+ "')\"><td><i class=\"bi bi-file-earmark-text\" style='font-size:18px;color:#0154A4'></i>" + row["ParticularsORNewspaper"].ToString() + "</td><td><i class=\"bi bi-calendar4\"  style='font-size:18px;color:#0154A4'></i> " + row["NewsDate"].ToString() + "</td> </tr>");

                 
            }
            Sb.Append(foot);
            Populatetable.InnerHtml = Sb.ToString();
        }
    }
}