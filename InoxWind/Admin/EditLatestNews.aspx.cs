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
    public partial class EditLatestNews : System.Web.UI.Page
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
            BusinessLogic.BusinessObjectModel.LatestNews newsRoom = LatestNewsController.GetLatestNewsById(Id);
            newsRoom.Id = newsRoom.Id;
            txtnewsContent.Text = newsRoom.NewsContent;
            txtnewlink.Text = newsRoom.NewsLink;
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
                latestNews.Id = Convert.ToInt32(QueryStringParam["Id"]);
                if (fileuploadlatestnew.HasFile)
                {
                    latestNews.NewsImage = ImageName;
                }
                int result = LatestNewsController.UpdateLatestNews(latestNews);
                if (result > 0)
                {
                    if (!Directory.Exists(Server.MapPath("~/WebsiteImages")))
                    {
                        Directory.CreateDirectory(Server.MapPath("~/WebsiteImages"));
                    }
                    string path = Path.Combine(Server.MapPath("~/WebsiteImages"), ImageName);
                    fileuploadlatestnew.PostedFile.SaveAs(path);

                    Response.Redirect("LatestNews.aspx");
                }
            }
            else { return; }
        }
    }
}