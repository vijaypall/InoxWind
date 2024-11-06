using BusinessLogic.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InoxWind.Admin
{
    public partial class AddDailyNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void Clearall()
        {
            lblerrorchannel.Text = "";
            lblErrorNewshading.Text = "";
            lblErrorNewshading.Text = "";
            lblerrorNewsLink.Text = "";
            chkmediapoup.Checked = false;
            lblErrorNewContent.Text = "";
        }
        private bool Checkvalidation()
        {
            bool _vall = false;
            if (string.IsNullOrEmpty(txtchannel.Text))
            {
                lblerrorchannel.Text = "Enter the channel name.";
                _vall = true;
            }
            if (string.IsNullOrEmpty(txtNewsHeading.Text))
            {
                lblErrorNewshading.Text = "Enter the news heading.";
                _vall = true;
            }
            if (string.IsNullOrEmpty(txtnewscontent.Text))
            {
                lblErrorNewContent.Text = "Enter the news contents.";
                _vall = true;
            }
            if (string.IsNullOrEmpty(txtNeewLink.Text))
            {
                lblerrorNewsLink.Text = "Enter the new url.";
                _vall = true;
            }
            if (!ftpDailNews.HasFile)
            {
                lblerroruploadlogo.Text = "Upload the news image.";
                _vall = true;
            }
            return _vall;

        }
        protected void btSubmit_Click(object sender, EventArgs e)
        {
            Clearall();
            if (!Checkvalidation())
            {
                var fileExtension = Path.GetExtension(ftpDailNews.PostedFile.FileName)?.ToLower();
                string ImageName = ftpDailNews.PostedFile.FileName.Split('.')[0] + "_" + DateTime.Now.Ticks.ToString() + fileExtension;
                BusinessLogic.BusinessObjectModel.DailyNews dailyNews = new BusinessLogic.BusinessObjectModel.DailyNews();
                dailyNews.ChannelName = txtchannel.Text;
                dailyNews.NewsContent = txtnewscontent.Text;
                dailyNews.NewsHeading = txtNewsHeading.Text;
                dailyNews.NewsContent = txtchannel.Text;
                dailyNews.NewsLink = txtNeewLink.Text; ;
                dailyNews.OpenMediaPopup = chkmediapoup.Checked;
                int result = DailyNewsController.InsertDailyNews(dailyNews);
                if (result > 0)
                {
                    if (!Directory.Exists(Server.MapPath("~/WebsiteImages")))
                    {
                        Directory.CreateDirectory(Server.MapPath("~/WebsiteImages"));
                    }
                    string path = Path.Combine(Server.MapPath("~/WebsiteImages"), ImageName);
                    ftpDailNews.PostedFile.SaveAs(path);

                    Response.Redirect("/Admin/DailyNews.aspx");
                }
            }
            else { return; }


        }
    }
}