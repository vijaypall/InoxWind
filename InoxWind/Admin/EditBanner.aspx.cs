using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic.Controller;
using BusinessLogic.BusinessObjectModel;
using System.IO;

namespace InoxWind.Admin
{
    public partial class EditBanner1 : System.Web.UI.Page
    {
        string OldFileName = string.Empty;
        Dictionary<string, object> QueryStringParam = new Dictionary<string, object>();
        protected void Page_Load(object sender, EventArgs e)
        {

            string encryptedData = Request.QueryString["data"];
            if (!string.IsNullOrEmpty(encryptedData))
            {
                try
                {
                    QueryStringParam = CommonClass.QueryStringHelper.Decrypt(encryptedData);
                    if (QueryStringParam.Count > 0)
                    {

                    }
                }
                catch
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('URL Tampered.'); window.location.href ='Login'", true);
                }
            }
            if (!IsPostBack)
            { FillValue(Convert.ToInt32(QueryStringParam["Id"])); }

        }
        public void FillValue(int Id)
        {
            BusinessLogic.BusinessObjectModel.Banner banner = BannersController.GetBannerById(Id);
            DDlBannerOrder.SelectedValue = banner.BannerOrder.ToString();
            editor1.InnerHtml = banner.PopupContent;
            txthref.Text = banner.ReadmoreUrl;
            OldFileName = banner.BannerImage;

        }
        private bool Checkvalidation()
        {
            bool _vall = false;
            if (DDlBannerOrder.SelectedValue == "0")
            {
                lblerrorBannerOrder.Text = "Please select a banner order";
                _vall = true;
            }
            if (!ftpBannerUpload.HasFile)
            {
                lblerrorUpload.Text = "Please upload a banner.";
                _vall = true;
            }
            return _vall;

        }
        private void Clearall()
        {
            lblerrorBannerOrder.Text = "";
            lblerrorUpload.Text = "";
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Clearall();
            if (!Checkvalidation())
            {
                var fileExtension = Path.GetExtension(ftpBannerUpload.PostedFile.FileName)?.ToLower();
                string ImageName = ftpBannerUpload.PostedFile.FileName.Split('.')[0] + "_" + DateTime.Now.Ticks.ToString() + fileExtension;
                BusinessLogic.BusinessObjectModel.Banner Banner = new BusinessLogic.BusinessObjectModel.Banner();
                Banner.BannerOrder = Convert.ToInt32(DDlBannerOrder.SelectedValue);

                Banner.PopupContent = hdHtmleditor.Value;
                Banner.ReadmoreUrl = txthref.Text;
                Banner.BannerImage = ImageName;
                Banner.Id = Convert.ToInt32(QueryStringParam["Id"]);
                int result = BannersController.UpdateBanner(Banner);
                if (result > 0)
                {
                    if (!Directory.Exists(Server.MapPath("~/WebsiteImages")))
                    {
                        Directory.CreateDirectory(Server.MapPath("~/WebsiteImages"));
                    }
                    string path = Path.Combine(Server.MapPath("~/WebsiteImages"), ImageName);
                    ftpBannerUpload.PostedFile.SaveAs(path);
                    if (System.IO.File.Exists(Path.Combine(Server.MapPath("~/WebsiteImages"), OldFileName)))
                    {
                        System.IO.File.Delete(Path.Combine(Server.MapPath("~/WebsiteImages"), OldFileName));
                    }
                    Response.Redirect("Banner.aspx");
                }
            }
            else { return; }

        }
    }
}