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
    public partial class infrastructure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindHtmlEditor();
            }
        }

        private void BindHtmlEditor()
        {
            DataTable dtEditior = HtmlEditorController.GetRecordList();

            DataRow[] rowEditior = dtEditior.Select("PageName='Infrastructure'  and Isactive=True ");
            Array.Sort(rowEditior, (x, y) => Comparer<int>.Default.Compare((int)x["ID"], (int)y["ID"]));
            // int checkevenodd = 0;
            StringBuilder SbEditor = new StringBuilder();
            foreach (DataRow row in rowEditior)
            {
                string path = CommonClass.BaseDomain.GetBaseDomain(Request) + "/WebsiteImages/" + row["SideImage"].ToString();
                SbEditor.Append(@"<div class='pointer-box mcontainer'><div class='col-lg-6 col-md-6 col-sm-12 pointercontent'> <div class='w80 margin-center'> <div class='common-headings'>" + row["HtmlText"].ToString() + "</div> </div> </div> <div class='col-lg-6 col-md-6 col-sm-12 stats-image'><img src='" + path + "' alt='' /> </div></div>");
            }
            mcontainer.InnerHtml = SbEditor.ToString();
        }
    }
}