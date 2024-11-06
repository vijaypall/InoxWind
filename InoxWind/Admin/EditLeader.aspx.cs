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
    public partial class EditLeader : System.Web.UI.Page
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
        public void FillValue(int Id)
        {
            BusinessLogic.BusinessObjectModel.Leader leader = LeaderController.GetLeaderById(Id);
            ddlCategory.SelectedValue = leader.Category;
            chkopenpoup.Checked = leader.OpenPopup;
            if (leader.OpenPopup) { htmleditor.Visible = true; }
            editor1.InnerHtml = leader.PopupContent;
            txtDesignation.Text = leader.Designation;
            txtName.Text = leader.Name;
            txtlinkedin.Text = leader.LinkedinUrl;
        }
        private void Clearall()
        {
            lblErrorCategoy.Text = "";
            lblErrortxname.Text = "";
            lblErrorDesignation.Text = "";
            lblerrortxtlinkedin.Text = "";
            lblerrorftpprofileimg.Text = "";
        }
        private bool Checkvalidation()
        {
            bool _vall = false;
            if (ddlCategory.SelectedValue == "0")
            {
                lblErrorCategoy.Text = "Please select a category.";
                _vall = true;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblErrortxname.Text = "Please enter the name.";
                _vall = true;
            }
            if (string.IsNullOrEmpty(txtDesignation.Text))
            {
                lblErrorDesignation.Text = "Please enter the designation.";
                _vall = true;
            }
            //if (string.IsNullOrEmpty(txtlinkedin.Text))
            //{
            //    lblerrortxtlinkedin.Text = "Please enter the linkedin url.";
            //    _vall = true;
            //}
            if (!ftpprofileimg.HasFile)
            {
                lblerrorftpprofileimg.Text = "Please select a profile image";
                _vall = true;
            }
            return _vall;

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Clearall();
            if (!Checkvalidation())
            {

                var fileExtension = Path.GetExtension(ftpprofileimg.PostedFile.FileName)?.ToLower();
                string ImageName = ftpprofileimg.PostedFile.FileName.Split('.')[0] + "_" + DateTime.Now.Ticks.ToString() + fileExtension;
                BusinessLogic.BusinessObjectModel.Leader leader = new BusinessLogic.BusinessObjectModel.Leader();
                leader.Name = txtName.Text;
                leader.Designation = txtDesignation.Text;
                leader.Category = ddlCategory.SelectedValue;
                leader.LinkedinUrl = txtlinkedin.Text;
                leader.OpenPopup = chkopenpoup.Checked;
                leader.PopupContent = hdHtmleditor.Value;
                leader.ProfileImage = ImageName;
                leader.Id = Convert.ToInt32(QueryStringParam["Id"]);
                int result = LeaderController.UpdateLeader(leader);
                if (result > 0)
                {
                    if (ftpprofileimg.HasFile)
                    {
                        if (!Directory.Exists(Server.MapPath("~/WebsiteImages")))
                        {
                            Directory.CreateDirectory(Server.MapPath("~/WebsiteImages"));
                        }
                        string path = Path.Combine(Server.MapPath("~/WebsiteImages"), ImageName);
                        ftpprofileimg.PostedFile.SaveAs(path);
                    }
                    Response.Redirect("Leader.aspx");
                }
            }
            else { return; }
        }
    }
}