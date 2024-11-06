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
    public partial class AddPartners : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private bool Checkvalidation()
        {
            bool _vall = false;
            if (ddlPartnerType.SelectedValue == "0")
            {
                lblErrorpartner.Text = "Please select partner type.";
                _vall = true;
            }
            if (!ftpBannerUpload.HasFile)
            {
                lblerroruploadlogo.Text = "Please select partner logo.";
                _vall = true;
            }
            return _vall;

        }
        private void Clearall()
        { lblErrorpartner.Text = ""; lblerroruploadlogo.Text = ""; }
        protected void btSubmit_Click(object sender, EventArgs e)
        {
            Clearall();
            if (!Checkvalidation())
            {
                var fileExtension = Path.GetExtension(ftpBannerUpload.PostedFile.FileName)?.ToLower();
                string ImageName = ftpBannerUpload.PostedFile.FileName.Split('.')[0] + "_" + DateTime.Now.Ticks.ToString() + fileExtension;
                BusinessLogic.BusinessObjectModel.Partner Partner = new BusinessLogic.BusinessObjectModel.Partner();
                Partner.PartnerName = txtpartnerName.Text;
                Partner.PartnerType = ddlPartnerType.SelectedItem.Text;
                Partner.PartnerImage = ImageName;
                int result = PartnerController.InsertPartner(Partner);
                if (result > 0)
                {
                    if (!Directory.Exists(Server.MapPath("~/WebsiteImages")))
                    {
                        Directory.CreateDirectory(Server.MapPath("~/WebsiteImages"));
                    }
                    string path = Path.Combine(Server.MapPath("~/WebsiteImages"), ImageName);
                    ftpBannerUpload.PostedFile.SaveAs(path);
                    Response.Redirect("/Admin/Partners.aspx");
                }
            }
            else { return; }
        }
    }
}