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
    public partial class AddNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool Checkvalidation()
        {
            bool _vall = false;
            if (ddlPartnerType.SelectedValue == "0")
            {
                lblErrorpartner.Text = "Please select news type.";
                _vall = true;
            }
            if (ftpDocUpload.HasFile)
            {
                if (System.IO.Path.GetExtension(ftpDocUpload.FileName).ToLower() != ".pdf")
                {
                    lblerroruDoc.Text = "Please upload valid news document in PDF format.";
                    _vall = true;
                }
            }
            else
            {
                lblerroruDoc.Text = "Please upload news document.";
                _vall = true;
            }
            if (string.IsNullOrEmpty(txtParticulars.Text))
            {
                lblerrorParticulars.Text = "Please enter particulars/newspaper.";
                _vall = true;
            }
            if (string.IsNullOrEmpty(txtnewsdate.Text))
            {
                lblnewserror.Text = "Please enter news date.";
                _vall = true;
            }
            return _vall;

        }
        private void Clearall()
        {
            lblErrorpartner.Text = ""; lblerroruDoc.Text = ""; lblerroruDoc.Text = ""; lblerrorParticulars.Text = ""; lblnewserror.Text = "";
        }
        protected void btSubmit_Click(object sender, EventArgs e)
        {
            Clearall();
            if (!Checkvalidation())
            {
                DateTime currentDate = DateTime.Now;
                int Year = currentDate.Year;
                int Month = currentDate.Month;
                // string domainname = CommonClass.BaseDomain.GetBaseDomain(Request);
                string DBPath = Path.Combine(("/uploads/" + Year + "/" + Month + "/"), ftpDocUpload.PostedFile.FileName);

                var fileExtension = Path.GetExtension(ftpDocUpload.PostedFile.FileName)?.ToLower();
                string ImageName = ftpDocUpload.PostedFile.FileName.Split('.')[0] + "_" + DateTime.Now.Ticks.ToString() + fileExtension;
                BusinessLogic.BusinessObjectModel.NewsRoom newsroom = new BusinessLogic.BusinessObjectModel.NewsRoom();
                newsroom.NewsDATE = txtnewsdate.Text;
                newsroom.NewsType = ddlPartnerType.SelectedItem.Text;

                newsroom.ParticularsORNewspaper = txtParticulars.Text;
                newsroom.NewsDoc = DBPath;
                int result = NewsRoomController.InsertRecord(newsroom);
                if (result > 0)
                {
                    if (!Directory.Exists(Server.MapPath("~/uploads/" + Year + "/" + Month)))
                    {
                        Directory.CreateDirectory(Server.MapPath("~/uploads/" + Year + "/" + Month));
                    }
                    string ppp = Path.Combine(Server.MapPath("~/uploads/" + Year + "/" + Month), ftpDocUpload.PostedFile.FileName);
                    ftpDocUpload.PostedFile.SaveAs(ppp);

                    Response.Redirect("/Admin/News.aspx");
                }
            }
            else { return; }

        }
    }
}