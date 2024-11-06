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
    public partial class AddQualityCertificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private bool Checkvalidation()
        {
            bool _vall = false;
            if (ftpBannerUpload.HasFile)
            {
                if (System.IO.Path.GetExtension(ftpBannerUpload.FileName).ToLower() != ".pdf")
                {
                    lblerroruploadlogo.Text = "Please upload a valid Quality Certificate in PDF format.";
                    _vall = true;
                }

            }
            else
            {
                lblerroruploadlogo.Text = "Please upload the Quality Certificate.";
                _vall = true;
            }
            if (string.IsNullOrEmpty(txtCertificateContent.Text))
            {
                lblContentError.Text = "Please enter the certificate content.";
                _vall = true;
            }
            return _vall;

        }
        private void Clearall()
        { lblerroruploadlogo.Text = ""; lblContentError.Text = ""; }
        protected void btSubmit_Click(object sender, EventArgs e)
        {
            Clearall();
            if (!Checkvalidation())
            {
                DateTime currentDate = DateTime.Now;
                int Year = currentDate.Year;
                int Month = currentDate.Month;
                // string domainname = CommonClass.BaseDomain.GetBaseDomain(Request);
                string DBPath = Path.Combine(("/uploads/" + Year + "/" + Month), ftpBannerUpload.PostedFile.FileName);
                //string FullFilePath = Path.Combine(Server.MapPath("~/uploads/" + Year + "/" + Month), ftpBannerUpload.PostedFile.FileName);
                //  var fileExtension = Path.GetExtension(ftpBannerUpload.PostedFile.FileName)?.ToLower();
                //  string ImageName = ftpBannerUpload.PostedFile.FileName.Split('.')[0] + "_" + DateTime.Now.Ticks.ToString() + fileExtension;
                BusinessLogic.BusinessObjectModel.QualityCertificate certificate = new BusinessLogic.BusinessObjectModel.QualityCertificate();
                certificate.CertificateName = txtCertificateContent.Text;
                certificate.CertificateImage = DBPath;
                int result = QualityCertificateController.InsertCertificate(certificate);
                if (result > 0)
                {

                    if (!Directory.Exists(Server.MapPath("~/uploads/" + Year + "/" + Month)))
                    {
                        Directory.CreateDirectory(Server.MapPath("~/uploads/" + Year + "/" + Month));
                    }
                    string ppp = Path.Combine(Server.MapPath("~/uploads/" + Year + "/" + Month), ftpBannerUpload.PostedFile.FileName);
                    ftpBannerUpload.PostedFile.SaveAs(ppp);
                    Response.Redirect("/Admin/Qualitycertificate.aspx");
                }
            }
            else { return; }
        }
    }
}