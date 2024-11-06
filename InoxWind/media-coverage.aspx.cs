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
    public partial class media_coverage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { BindLatestNews(); }
        }

        private void BindLatestNews()
        {
            DataTable dtLatestNew = LatestNewsController.GetLatestNewsLastFive();
            StringBuilder SbLatestNew = new StringBuilder();
            DataRow[] rowMileStones = dtLatestNew.Select("Isactive=True");
            foreach (DataRow row in rowMileStones)
            {
                SbLatestNew.Append(@"<div class='media-card latest-card'><p class='card-time'>"+row["TimeAgo"].ToString() +"</p><a href = '" + row["NewsLink"].ToString() + "' title= '' target='_blank' >" + row["NewsContent"].ToString() + "</a></div>");
            }
            populateLatestNews.InnerHtml = SbLatestNew.ToString();
        }
    }
}