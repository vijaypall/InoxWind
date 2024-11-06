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
    public partial class EditNews : System.Web.UI.Page
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
            BusinessLogic.BusinessObjectModel.NewsRoom newsRoom = NewsRoomController.GetRecordById(Id);
            ddlPartnerType.SelectedValue = newsRoom.NewsType.ToString();
            txtnewsdate.Text = newsRoom.NewsDATE;
            txtParticulars.Text = newsRoom.ParticularsORNewspaper;
            OldFileName = newsRoom.NewsDoc;
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
        public void Clearall()
        {
            lblErrorpartner.Text = "";
            lblerroruDoc.Text = "";
            lblnewserror.Text = "";
            lblnewserror.Text = "";
        }
        protected void btSubmit_Click(object sender, EventArgs e)
        {
            Clearall();

            if (!Checkvalidation())
            {

                DateTime currentDate = DateTime.Now;
                int Year = currentDate.Year;
                int Month = currentDate.Month;
                string DBPath = "";
                // BusinessLogic.BusinessObjectModel.NewsRoom newsRoom1 = NewsRoomController.GetRecordById(Convert.ToInt32(QueryStringParam["Id"]));
                BusinessLogic.BusinessObjectModel.NewsRoom newsRoom = new BusinessLogic.BusinessObjectModel.NewsRoom();
                newsRoom.NewsType = ddlPartnerType.SelectedValue;
                newsRoom.ParticularsORNewspaper = txtParticulars.Text;
                newsRoom.NewsDATE = txtnewsdate.Text;
                newsRoom.Id = Convert.ToInt32(QueryStringParam["Id"]);
                if (ftpDocUpload.HasFile)
                {
                    DBPath = Path.Combine(("/uploads/" + Year + "/" + Month + "/"), ftpDocUpload.PostedFile.FileName);
                    newsRoom.NewsDoc = DBPath;
                }
                newsRoom.NewsDoc = DBPath;
                int result = NewsRoomController.UpdateRecord(newsRoom);
                if (result > 0)
                {
                    if (!Directory.Exists(Server.MapPath("~/uploads/" + Year + "/" + Month)))
                    {
                        Directory.CreateDirectory(Server.MapPath("~/uploads/" + Year + "/" + Month));
                    }
                    string ppp = Path.Combine(Server.MapPath("~/uploads/" + Year + "/" + Month), ftpDocUpload.PostedFile.FileName);
                    ftpDocUpload.PostedFile.SaveAs(ppp);

                    //string domainname = Server.MapPath( Convert.ToString(newsRoom1.NewsDoc));
                    //if (System.IO.File.Exists(domainname))
                    //{
                    //    System.IO.File.Delete(domainname);
                    //}
                    Response.Redirect("News.aspx");
                }
            }
            else { return; }

        }
    }
}