using BusinessLogic.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InoxWind
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        private void ClearAll()
        {
            lblErroName.Text = "";
            lblErrorEmail.Text = "";
            lblerroMobile.Text = "";
            lblErrorDesc.Text = "";
            lblNatture.Text = "";
        }
        private bool Checkvalidation()
        {
            bool _vall = false;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblErroName.Text = "Enter your full name";
                _vall = true;
            }
            if (string.IsNullOrEmpty(txtemail.Text))
            {
                lblErrorEmail.Text = "Enter your email";
                _vall = true;
            }
            else
            {
                string result = IsValidEmail(txtemail.Text);
                if (!string.IsNullOrEmpty(result))
                {
                    lblErrorEmail.Text = result;
                    _vall = true;
                }
            }
            if (string.IsNullOrEmpty(txtMobileNo.Text))
            {
                lblerroMobile.Text = "Enter your mobile number";
                _vall = true;
            }
            else
            {
                string result = ValidateMobileNumber(txtMobileNo.Text);
                if (!string.IsNullOrEmpty(result))
                {
                    lblerroMobile.Text = result;
                    _vall = true;
                }
            }
            if (ddlNatureEnquiry.SelectedValue == "0")
            {
                lblNatture.Text = "Nature of Enquiry";
                _vall = true;
            }
            if (string.IsNullOrEmpty(txtdescription.Text))
            {
                lblErrorDesc.Text = "Type your queries, concerns or feedback";
                _vall = true;
            }
            return _vall;

        }
        private string ValidateMobileNumber(string mobileNumber)
        {
            string result = string.Empty;
            if (mobileNumber.Length != 10 || !long.TryParse(mobileNumber, out _))
            {
                result = "Enter a valid mobile number with 10 digits.";

            }
            if (mobileNumber[0] < '6')
            {
                result = "Esnter valid mobile number.";

            }
            return result;
        }
        private string IsValidEmail(string email)
        {
            string result = string.Empty;
            // Regular expression for validating an email address
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, pattern))
            {
                result = "Enter valid email.";

            }
            return result;
        }


        protected void btnsendEnquire_Click(object sender, EventArgs e)
        {
            ClearAll();
            if (!Checkvalidation())
            {
                var response = Request.Form["g-recaptcha-response"];
                var secretKey = "6LdKhWwqAAAAAIl6Wtik0VeGeC_XDJT_sbH2WY2D"; // Replace with your secret key

                using (var client = new WebClient())
                {
                    var result = client.DownloadString($"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={response}");
                    dynamic jsonData = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

                    if (jsonData.success == "true")
                    {
                        //ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('Sucess')", true);

                        //var fileExtension = Path.GetExtension(ftpBannerUpload.PostedFile.FileName)?.ToLower();
                        //string ImageName = ftpBannerUpload.PostedFile.FileName.Split('.')[0] + "_" + DateTime.Now.Ticks.ToString() + fileExtension;
                        BusinessLogic.BusinessObjectModel.ContactEnquiry contactEnquiry = new BusinessLogic.BusinessObjectModel.ContactEnquiry();
                        contactEnquiry.FullName = txtName.Text;
                        contactEnquiry.EmailId = txtemail.Text;
                        contactEnquiry.MobileNo = txtMobileNo.Text;
                        contactEnquiry.NatureOfEnquiry = ddlNatureEnquiry.SelectedValue;
                        contactEnquiry.Description = txtdescription.Text;
                        int result1 = ContactEnquiryController.InsertContact(contactEnquiry);
                        if (result1 > 0)
                        {
                            ClearAll();
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('Thank you for contacting us. We appreciate your inquiry and will respond soon')", true);
                        }

                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('Please verify that you are not a robot.')", true);
                    }
                }
            }
        }
    }
}