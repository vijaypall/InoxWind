using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic.Controller;

namespace InoxWind.Admin
{
    public partial class AddBanner1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Clearall();
            if (!Checkvalidation())
            {
                var fileExtension = Path.GetExtension(ftpBannerUpload.PostedFile.FileName)?.ToLower();
                string ImageName = ftpBannerUpload.PostedFile.FileName.Split('.')[0] + "_" + DateTime.Now.Ticks.ToString() + fileExtension;
                BusinessLogic.BusinessObjectModel.Banner Banner = new BusinessLogic.BusinessObjectModel.Banner();
                Banner.BannerOrder = Convert.ToInt32(DDlBannerOrder.SelectedValue);
                //Banner.PopupHeading = txtpopupheading.Text;
                Banner.PopupContent = hdHtmleditor.Value;
                Banner.ReadmoreUrl = txthref.Text;
                Banner.BannerImage = ImageName;
                int result = BannersController.InsertBanner(Banner);
                if (result > 0)
                {
                    if (!Directory.Exists(Server.MapPath("~/WebsiteImages")))
                    {
                        Directory.CreateDirectory(Server.MapPath("~/WebsiteImages"));
                    }
                    string path = Path.Combine(Server.MapPath("~/WebsiteImages"), ImageName);
                    ftpBannerUpload.PostedFile.SaveAs(path);
                    Response.Redirect("Banner.aspx");
                }
            }
            else { return; }
        }

        private void Clearall()
        {
            lblerrorBannerOrder.Text = "";
            lblerrorUpload.Text = "";
        }
    }
}