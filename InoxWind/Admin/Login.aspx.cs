using BusinessLogic.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InoxWind.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        DateTime Dt = new DateTime();
        string SendEmailOtp = "123456";
        protected void Page_Load(object sender, EventArgs e)
        { 

        }
        private void ClearMsg()
        {
            lblerroremail.Text = "";
            lblerrorpassword.Text = "";
            lblInvalidLogin.Text = "";
        }
      private  static string GenerateOtp()
        {
            Random random = new Random();
            // Generate a number between 100000 and 999999
            return random.Next(100000, 1000000).ToString();
        }
        private void SendEail(BusinessLogic.BusinessObjectModel.Login  login)
        {
            // string smtpServer = "smtp.your-email-provider.com"; // Replace with your SMTP server
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587; // Common ports: 587 for TLS, 465 for SSL
            string senderEmail = "anamikapal73@gmail.com"; // Replace with your email
            string senderPassword = "5555@123"; // Replace with your email password 
            string subject = "Your One-Time Password (OTP) for Login";
            string body = "Your OTP is: ["+ login.Password + "]"; // Replace with your OTP generation logic
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(senderEmail);
                    mail.To.Add(login.EmailId);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = false; // Set to true if you're sending HTML content

                    using (SmtpClient smtp = new SmtpClient(smtpServer, smtpPort))
                    {
                        smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                        smtp.EnableSsl = true; // Enable SSL if your server requires it
                        smtp.Send(mail);
                    }
                }

                //Console.WriteLine("Email sent successfully!");
            }
            catch
            {
                lblInvalidLogin.Text = "The mail could not be sent. Please contact the administrator.";
            }
        }

        protected void btnGenerateOtp_Click(object sender, EventArgs e)
        {
            ClearMsg();
            if (!string.IsNullOrEmpty(txtEmailId.Text))
            {
                BusinessLogic.BusinessObjectModel.Login login = LoginController.GetLoginEmailDetail(txtEmailId.Text);
                if (login.EmailId != null) {
                  SendEmailOtp=  GenerateOtp();
                  login.Password = SendEmailOtp;
                  SendEail(login);
                    Dt = DateTime.Now;
                }
            }
            else { lblerroremail.Text = "Enter the Email Id."; }
        }

        private bool Checkvalidation()
        {
            ClearMsg();
            bool _vall = false;
            if (string.IsNullOrEmpty(txtEmailId.Text))
            {
                lblerroremail.Text = "Enter Email Id.";
                _vall = true;
            }
            if (string.IsNullOrEmpty(txtpassword.Text))
            {
                lblerrorpassword.Text = "Enter OTP";
                _vall = true;
            }
            return _vall;

        }
        public void ClearSession()
        {
            Session["LoginId"] = null;
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Checkvalidation())
            {
                ClearSession();

                //TimeSpan difference = DateTime.Now - Dt;
                //if (difference.Minutes <= 10)
                //{
                    if (SendEmailOtp == txtpassword.Text)
                    {
                        BusinessLogic.BusinessObjectModel.Login login = LoginController.GetLoginEmailDetail(txtEmailId.Text);
                        if (!string.IsNullOrEmpty(login.EmailId))
                        {
                            var request = HttpContext.Current.Request;
                            login.LoginIP = request.UserHostAddress;
                            login.LoginBrowser = request.UserAgent;
                            int result = LoginController.UpdateLogin(login);
                            if (result > 0)
                            {
                                Session["LoginId"] = login.LoginId;
                                Response.Redirect("~/Admin/Default.aspx");

                            }
                            else { lblInvalidLogin.Text = "Login failed due to a technical issue. Please contact the administrator."; }
                        }
                        else { lblInvalidLogin.Text = "Incorrect email ID. Login failed!"; }
                    }
                    else { lblInvalidLogin.Text = "The OTP has expired. Please enter a valid OTP."; return; }
                //}
                //else { lblInvalidLogin.Text = "Invalid OTP."; }
            }
            else { return; }
        }
    }
}