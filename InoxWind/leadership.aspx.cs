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
    public partial class leadership : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateDirector();
                PopulateLeader();
            }
        }



        private void PopulateDirector()
        {
            DataTable dataTable = new DataTable();
            dataTable = LeaderController.GetLeaderList();

            DataRow[] rowEditior = dataTable.Select("Category='Directors' and Isactive=True");
            Array.Sort(rowEditior, (x, y) => Comparer<int>.Default.Compare((int)x["ID"], (int)y["ID"]));

            StringBuilder SbDirector = new StringBuilder();
            foreach (DataRow row in rowEditior)
            {
                string Imagepath = CommonClass.BaseDomain.GetBaseDomain(Request) + "/WebsiteImages/" + row["ProfileImage"].ToString();
                if (Convert.ToBoolean(row["OpenPopup"].ToString()))
                {
                    SbDirector.Append(@"<div class='col-lg-4 col-md-4 col-sm-12 leaderbox'><div class='leadercard linked-card' data-about='" + Server.HtmlEncode(row["PopupContent"].ToString()) + "'><img src = '" + Imagepath + "' alt='' style='height:250px; width:392px' /><div class='leadercontent mcontainer'><div class='leadername-side'><p class='leadername'>" + row["Name"].ToString() + "</p <p>" + row["Designation"].ToString() + " </p> </div> <div class='linked-img'><a href = '" + row["LinkedinUrl"].ToString() + "' title='' target='_blank'><img src ='./assets/images/linkedin.svg' alt='' /></a></div></div></div></div>");

                }
                else
                {
                    SbDirector.Append(@"<div class='col-lg-4 col-md-4 col-sm-12 leaderbox'><div class='leadercard linked-card'><img src = '" + Imagepath + "' alt='' style='height:250px; width:392px' /><div class='leadercontent mcontainer'><div class='leadername-side'><p class='leadername'>" + row["Name"].ToString() + "</p <p>" + row["Designation"].ToString() + " </p> </div> <div class='linked-img'><a href = '" + row["LinkedinUrl"].ToString() + "' title='' target='_blank'><img src ='./assets/images/linkedin.svg' alt='' /></a></div></div></div></div>");
                }
            }
              Divdirector.InnerHtml = SbDirector.ToString();

        }
        private void PopulateLeader()
        {
            DataTable dataTable = new DataTable();
            dataTable = LeaderController.GetLeaderList();

            DataRow[] rowEditior = dataTable.Select("Category='Leaders' and Isactive=True");
            Array.Sort(rowEditior, (x, y) => Comparer<int>.Default.Compare((int)x["ID"], (int)y["ID"]));

            StringBuilder SbLeader = new StringBuilder();
            foreach (DataRow row in rowEditior)
            {
                string Imagepath = CommonClass.BaseDomain.GetBaseDomain(Request) + "/WebsiteImages/" + row["ProfileImage"].ToString();

                SbLeader.Append(@"<div class='col-lg-3 col-md-4 col-sm-12 leaderbox'><div class='leadercard linked-card'> <img src = '"+ Imagepath + "' alt=''   style='height: 180px; width:292px' /> <div class='leadercontent mcontainer'><div class='leadername-side'><p class='leadername'>" + row["Name"].ToString() + "</p>  <p>" + row["Designation"].ToString() + " </p>  </div> <div class='linked-img'>  <a href = '" + row["LinkedinUrl"].ToString() + "' title='' target='_blank'> <img src = './assets/images/linkedin.svg' alt='' />  </a> </div> </div> </div> </div>");
                
            }
            DivPopulateLeader.InnerHtml = SbLeader.ToString();
        }
    }
}