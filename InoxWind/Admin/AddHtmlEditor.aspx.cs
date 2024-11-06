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
    public partial class AddHtmlEditor1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private bool Checkvalidation()
        {
            bool _vall = false;
            if (DdlPageSelect.SelectedValue == "0")
            {
                lblPageSelecterror.Text = "Please select a Page.";
                _vall = true;
            }
            //if (!FileUploader.HasFile)
            //{
            //    lblerrorUpload.Text = "Upload Side Image Required";
            //    _vall = true;
            //}
            return _vall;

        }
        private void Clearall()
        {
            lblPageSelecterror.Text = ""; 
        }
        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            Clearall();
            if (!Checkvalidation())
            {
                string ImageName = string.Empty;
                BusinessLogic.BusinessObjectModel.HtmlEditor htmlEditor = new BusinessLogic.BusinessObjectModel.HtmlEditor();
                htmlEditor.PageName = DdlPageSelect.SelectedValue;
                htmlEditor.HtmlText = hdHtmleditor.Value;
                htmlEditor.KnowMoreLink = txtKnowMore.Text;
                if (FileUploader.HasFile)
                {
                    var fileExtension = Path.GetExtension(FileUploader.PostedFile.FileName)?.ToLower();
                    ImageName = FileUploader.PostedFile.FileName.Split('.')[0] + "_" + DateTime.Now.Ticks.ToString() + fileExtension;
                    htmlEditor.SideImage = ImageName;
                }
                htmlEditor.SideImage = ImageName;
                int result = HtmlEditorController.InsertRecord(htmlEditor);
                if (result > 0)
                {
                    if (FileUploader.HasFile)
                    {
                        if (!Directory.Exists(Server.MapPath("~/WebsiteImages")))
                        {
                            Directory.CreateDirectory(Server.MapPath("~/WebsiteImages"));
                        }
                        string path = Path.Combine(Server.MapPath("~/WebsiteImages"), ImageName);
                        FileUploader.PostedFile.SaveAs(path);
                    }
                    Response.Redirect("HtmlEditor.aspx");
                }
            }
            else { return; }

        }
    }
}