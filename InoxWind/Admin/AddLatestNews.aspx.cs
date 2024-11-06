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
    public partial class AddLatestNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private bool Checkvalidation()
        {
            bool _vall = false;
            if (string.IsNullOrEmpty(txtnewsContent.Text))
            {
                lblErrornewscontent.Text = "Enter the news content.";
                _vall = true;
            }

            //if (!ftpDocUpload.HasFile)
            //{
            //    lblerroruDoc.Text = "Please select a file.";
            //    _vall = true;
            //}
            if (string.IsNullOrEmpty(txtnewlink.Text))
            {
                lblerrorNewsLink.Text = "Enter the news url.";
                _vall = true;
            }

            return _vall;

        }
        private void Clearall()
        {
            lblErrornewscontent.Text = "";
            lblerrorNewsLink.Text = "";
        }
        protected void btSubmit_Click(object sender, EventArgs e)
        {
            Clearall();
            if (!Checkvalidation())
            {

                var fileExtension = Path.GetExtension(fileuploadlatestnew.PostedFile.FileName)?.ToLower();
                string ImageName = fileuploadlatestnew.PostedFile.FileName.Split('.')[0] + "_" + DateTime.Now.Ticks.ToString() + fileExtension;

                BusinessLogic.BusinessObjectModel.LatestNews latestNews = new BusinessLogic.BusinessObjectModel.LatestNews();
                latestNews.NewsContent = txtnewsContent.Text;
                latestNews.NewsLink = txtnewlink.Text;
                latestNews.NewsImage = ImageName;
                int result = LatestNewsController.InsertLatestNews(latestNews);
                if (result > 0)
                {
                    if (!Directory.Exists(Server.MapPath("~/WebsiteImages")))
                    {
                        Directory.CreateDirectory(Server.MapPath("~/WebsiteImages"));
                    }
                    string path = Path.Combine(Server.MapPath("~/WebsiteImages"), ImageName);
                    fileuploadlatestnew.PostedFile.SaveAs(path);

                    Response.Redirect("/Admin/LatestNews.aspx");
                }
            }
            else { return; }

        }
    }
}