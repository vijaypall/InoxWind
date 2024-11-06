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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindBanner();
                BindHtmlEditor();
                BindMileStones();
                BindLatestNews();
            }

        }
        private void BindLatestNews()
        {
            DataTable dtLatestNew = LatestNewsController.GetLatestNewsLastFive();
            StringBuilder SbLatestNew = new StringBuilder();
            DataRow[] rowMileStones = dtLatestNew.Select("Isactive=True");
            foreach (DataRow row in rowMileStones)
            {
                string KnowMore = "#";
                if (!string.IsNullOrEmpty(row["NewsLink"].ToString()))
                { KnowMore = row["NewsLink"].ToString(); }
                string NewsDate = Convert.ToDateTime(row["CreatedDate"]).ToString("MMMM dd, yyyy");
                if (!string.IsNullOrEmpty(row["NewsImage"].ToString()))
                {
                    SbLatestNew.Append(@"<div class='swiper-slide'><div class='news-card mcontainer'> <img src ='" + row["NewsImage"].ToString() + "'alt='' /> <div class='news-cards-details mcontainer'><div class='news-date-box mcontainer'> <p class='news-art-title'> NEWS ARTICLE</p><p class='news-date'> <i class='bi bi-calendar4'  style='font-size:16px; color:black'></i> " + NewsDate + " </p></div> <h5> " + row["NewsContent"].ToString() + "</h5><a href = '" + KnowMore + "' target='_blank' title='Know More' class='main-button'><span>Know More</span></a> </div>  </div> </div>");
                }
                else
                {
                    SbLatestNew.Append(@"<div class='swiper-slide'><div class='news-card mcontainer'> <img src ='assets/images/news1.png' alt='' /><div class='news-cards-details mcontainer'><div class='news-date-box mcontainer'> <p class='news-art-title'> NEWS ARTICLE </p><p class='news-date'> <i class='bi bi-calendar4'  style='font-size:16px; color:black'></i>" + NewsDate + "  </p></div> <h5> " + row["NewsContent"].ToString() + "</h5>  <a href = '" + KnowMore + "'  target='_blank' title='Know More' class='main-button'><span>Know More</span></a> </div>  </div> </div>");
                }
            }
            populateLatestNews.InnerHtml = SbLatestNew.ToString();
        }
        private void BindMileStones()
        {
            DataTable dtMileStones = MilestonesController.GetMilestonesList();
            DataRow[] rowMileStones = dtMileStones.Select("Isactive=True");
            Array.Sort(rowMileStones, (x, y) => Comparer<int>.Default.Compare((int)x["ID"], (int)y["ID"]));
            StringBuilder SbMileStones = new StringBuilder();
            foreach (DataRow row in rowMileStones)
            {
                SbMileStones.Append(@"<div class='col-lg-3 col-md-3 col-sm-6 col-6 count-cardmbox'><div class='counter-box'><h4>" + row["MilestonesValue"].ToString() + "</h4> <p>" + row["MilestonesName"].ToString() + " </p> </div></div>");
            }
            populateMileStone.InnerHtml = SbMileStones.ToString();
        }

        private string GetBaseDomain()
        {
            string baseDomain = Request.ServerVariables["HTTP_HOST"];
            string protocol = Request.IsSecureConnection ? "https://" : "http://";
            return protocol + baseDomain;
        }
        private void BindBanner()
        {
            DataTable dataTable = new DataTable();
            dataTable = BannersController.GetBannerList();

            DataRow[] rowEditior = dataTable.Select("Isactive=True");
            Array.Sort(rowEditior, (x, y) => Comparer<int>.Default.Compare((int)x["ID"], (int)y["ID"]));

            StringBuilder Sb = new StringBuilder();
            foreach (DataRow row in rowEditior)
            {
                string path = GetBaseDomain() + "/WebsiteImages/" + row["BannerImage"].ToString();

                if (!string.IsNullOrEmpty(row["PopupContent"].ToString()))
                {
                    Sb.Append(@"<div class='swiper-slide banner-img'> <img src='" + path + "' alt=''   style='height: 550px; width: 1440px'/><div class='banner-content'>" + Convert.ToString(row["PopupContent"]) + "<a href = '" + Convert.ToString(row["ReadmoreUrl"]) + "' title='Know More' class='main-button'><span>Know More</span></a></div></div>");

                }
                else
                {
                    Sb.Append(@"<div class='swiper-slide banner-img'> <img src='" + path + "' alt=''   style='height: 550px; width: 1440px'/><div class='banner-content'>" + Convert.ToString(row["PopupContent"]) + "</div></div>");
                }

            }
            string HeadEnd = "</tbody></table>";
            Sb.Append(HeadEnd);
            BannerDIVSwiperWrapper.InnerHtml = Sb.ToString();
        }
        private void BindHtmlEditor()
        {
            DataTable dtEditior = HtmlEditorController.GetRecordList();
            DataRow[] rowEditior = dtEditior.Select("PageName='HomePage'  and Isactive=True");
            Array.Sort(rowEditior, (x, y) => Comparer<int>.Default.Compare((int)x["ID"], (int)y["ID"]));
            int checkevenodd = 0;
            StringBuilder SbEditor = new StringBuilder();
            foreach (DataRow row in rowEditior)
            {
                string path = GetBaseDomain() + "/WebsiteImages/" + row["SideImage"].ToString();
                if (checkevenodd == 0)
                {
                    if (!string.IsNullOrEmpty(row["KnowMoreLink"].ToString()))
                    {
                        SbEditor.Append(@"<div class='w90 margin-center row'>  <div class='col-lg-6 col-md-6 col-sm-12 col-12 grp-img'> <img src = '" + path + "' alt='' /></div><div class='col-lg-6 col-md-6 col-sm-12 col-12 grp-text'><div class='mcontainer common-headings'> " + row["HtmlText"].ToString() + "<a href='" + row["KnowMoreLink"].ToString() + "' title='Know More' class='main-button'><span>Know More</span></a> </div></div></div>");
                    }
                    else
                    {
                        SbEditor.Append(@"<div class='w90 margin-center row'>  <div class='col-lg-6 col-md-6 col-sm-12 col-12 grp-img'> <img src = '" + path + "' alt='' /></div><div class='col-lg-6 col-md-6 col-sm-12 col-12 grp-text'><div class='mcontainer common-headings'> " + row["HtmlText"].ToString() + "</div></div></div>");
                    }
                    checkevenodd = 1;
                }
                else if (checkevenodd == 1)
                {

                    if (!string.IsNullOrEmpty(row["KnowMoreLink"].ToString()))
                    {
                        SbEditor.Append(@"<div class='w90 margin-center row'><div class='col-lg-6 col-md-6 col-sm-12 col-12 grp-text'><div class='mcontainer common-headings'> " + row["HtmlText"].ToString() + "<a href='" + row["KnowMoreLink"].ToString() + "' title='Know More' class='main-button'><span>Know More</span></a> </div></div>  <div class='col-lg-6 col-md-6 col-sm-12 col-12 grp-img'> <img src = '" + path + "' alt='' /></div></div>");
                    }
                    else
                    {
                        SbEditor.Append(@"<div class='w90 margin-center row'><div class='col-lg-6 col-md-6 col-sm-12 col-12 grp-text'><div class='mcontainer common-headings'> " + row["HtmlText"].ToString() + "</div></div>  <div class='col-lg-6 col-md-6 col-sm-12 col-12 grp-img'> <img src = '" + path + "' alt='' /></div></div>");
                    }
                    checkevenodd = 0;
                }
            }
            idHomeEditor.InnerHtml = SbEditor.ToString();
        }

    }
}