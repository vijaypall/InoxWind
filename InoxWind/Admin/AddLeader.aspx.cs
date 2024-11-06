﻿using BusinessLogic.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InoxWind.Admin
{
    public partial class AddLeader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                int result = LeaderController.InsertLeader(leader);
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