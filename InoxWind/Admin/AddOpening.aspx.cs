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
    public partial class AddOpening : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private bool Checkvalidation()
        {
            bool _vall = false;
            if (string.IsNullOrEmpty(txtPositionName.Text))
            {
                lblPositionNameError.Text = "Please enter the postition name.";
                _vall = true;
            }
            if (string.IsNullOrEmpty(txtLocation.Text))
            {
                lblLocationError.Text = "Please enter the location.";
                _vall = true;
            }
            if (string.IsNullOrEmpty(txtMinimumQual.Text))
            {
                lbltxtMinimumQualError.Text = "Please enter the minimum qualification.";
                _vall = true;
            }
            if (fileCarrerDoc.HasFile)
            {
                if (System.IO.Path.GetExtension(fileCarrerDoc.FileName).ToLower() != ".pdf")
                {
                    lblcarrerDocumentError.Text = "Please upload a valid carrer document in PDF format.";
                    _vall = true;
                }

            }
            else
            {
                lblcarrerDocumentError.Text = "Please upload the carrer document.";
                _vall = true;
            }

            return _vall;

        }
        private void Clearall()
        {
            lblPositionNameError.Text = "";
            lblLocationError.Text = "";
            lblcarrerDocumentError.Text = "";
            lbltxtMinimumQualError.Text = "";
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Clearall();
            if (!Checkvalidation())
            {
                //  var fileExtension = Path.GetExtension(fileCarrerDoc.PostedFile.FileName)?.ToLower();
                //    string ImageName = fileCarrerDoc.PostedFile.FileName.Split('.')[0] + "_" + DateTime.Now.Ticks.ToString() + fileExtension;

                string ImageName = DateTime.Now.Ticks.ToString() + "_" + fileCarrerDoc.PostedFile.FileName;

                string DBPath = Path.Combine(("/uploads/Job/"), ImageName);

                BusinessLogic.BusinessObjectModel.Career career = new BusinessLogic.BusinessObjectModel.Career();
                career.PositionName = txtPositionName.Text;
                career.Location = txtLocation.Text;
                career.RequireQualification = txtMinimumQual.Text;
                career.DetailPdf = DBPath;
                int result = CareersController.InsertCareer(career);
                if (result > 0)
                {

                    if (!Directory.Exists(Server.MapPath("~/uploads/Job")))
                    {
                        Directory.CreateDirectory(Server.MapPath("~/uploads/Job"));
                    }
                    string ppp = Path.Combine(Server.MapPath("~/uploads/Job"), ImageName);
                    fileCarrerDoc.PostedFile.SaveAs(ppp);
                    Response.Redirect("/Admin/Opening.aspx");
                }
            }
            else { return; }
        }
    }
}