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
    public partial class EditDailyNews : System.Web.UI.Page
    {
        Dictionary<string, object> QueryStringParam = new Dictionary<string, object>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string encryptedData = Request.QueryString["data"];
            if (!string.IsNullOrEmpty(encryptedData))
            {
                try
                {
                    QueryStringParam = CommonClass.QueryStringHelper.Decrypt(encryptedData);

                }
                catch
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('URL Tampered.'); window.location.href ='Login'", true);
                }
            }
            if (!IsPostBack)
            {
                FillValue(Convert.ToInt32(QueryStringParam["Id"]));
            }

        }
        private void FillValue(int Id)
        {
            BusinessLogic.BusinessObjectModel.DailyNews dailyNews = DailyNewsController.GetDailyNewsById(Id);
            txtchannel.Text = dailyNews.ChannelName;
            txtnewscontent.Text = dailyNews.NewsContent;
            txtNewsHeading.Text = dailyNews.NewsHeading;
            txtNeewLink.Text = dailyNews.NewsLink;
            chkmediapoup.Checked = dailyNews.OpenMediaPopup;

        }
        private void Clearall()
        {
            lblerrorchannel.Text = "";
            lblErrorNewshading.Text = "";
            lblErrorNewshading.Text = "";
            lblerrorNewsLink.Text = "";
            chkmediapoup.Checked = false;
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
                BusinessLogic.BusinessObjectModel.DailyNews latestNews = new BusinessLogic.BusinessObjectModel.DailyNews();
                latestNews.NewsContent = txtnewscontent.Text;
                latestNews.NewsLink = txtNeewLink.Text;
                latestNews.NewsHeading = txtNewsHeading.Text;
                latestNews.OpenMediaPopup = chkmediapoup.Checked;
                latestNews.ChannelName = txtchannel.Text;
                latestNews.NewsLink = txtNeewLink.Text;

                latestNews.Id = Convert.ToInt32(QueryStringParam["Id"]);
                if (ftpDailNews.HasFile)
                {
                    latestNews.NewsImage = ImageName;
                }
                int result = DailyNewsController.UpdateDailyNews(latestNews);
                if (result > 0)
                {
                    if (!Directory.Exists(Server.MapPath("~/WebsiteImages")))
                    {
                        Directory.CreateDirectory(Server.MapPath("~/WebsiteImages"));
                    }
                    string path = Path.Combine(Server.MapPath("~/WebsiteImages"), ImageName);
                    ftpDailNews.PostedFile.SaveAs(path);

                    Response.Redirect("DailyNews.aspx");
                }
            }
            else { return; }
        }
    }
}