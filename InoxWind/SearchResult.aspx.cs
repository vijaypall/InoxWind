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
    public partial class SearchResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["searchtext"] == null) { Response.Redirect("Default.aspx"); }
                else
                {
                    lblSearchText.Text = Session["searchtext"].ToString();
                    BindData();
                }
            }
        }

        private void BindData()
        {
            DataTable dataTable = new DataTable();
            dataTable = SearchController.GetSearchByText(Session["searchtext"].ToString());
            TotalSearch.Text = dataTable.Rows.Count.ToString();
            StringBuilder Sb = new StringBuilder();
            string thead = @"<table id='example' style='width:100%'><thead><tr><th></th></tr></thead><tbody>";
            Sb.Append(thead);
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string PageName = dataTable.Rows[i]["PageName"].ToString();
                    string PageUrl = dataTable.Rows[i]["pageUrl"].ToString();
                    string HighlightedText = dataTable.Rows[i]["HighlightedText"].ToString();
                    //search text also 
                    Sb.Append("<tr><td><h6><a href ='" + PageUrl + "' > " + PageName + "</a></h6><p><b>"+ Session["searchtext"].ToString() + "&nbsp;</b>" + HighlightedText + "</p></td></tr>");

                }
            }
            string HeadEnd = "</tbody></table>";
            Sb.Append(HeadEnd);
            PouplateData.InnerHtml = Sb.ToString();
        }
    }
}