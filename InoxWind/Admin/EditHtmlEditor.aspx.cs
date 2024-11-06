using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic.BusinessObjectModel;
using BusinessLogic.Controller;

namespace InoxWind.Admin
{
    public partial class EditHtmlEditor1 : System.Web.UI.Page
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
        public void FillValue(int Id)
        {
            BusinessLogic.BusinessObjectModel.HtmlEditor htmlEditor = HtmlEditorController.GetRecordById(Id);
            DdlPageSelect.SelectedValue = htmlEditor.PageName.ToString();
            editor1.InnerHtml = htmlEditor.HtmlText;
            OldFileName = htmlEditor.SideImage;
            txtKnowMore.Text = htmlEditor.KnowMoreLink;
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
                htmlEditor.Id = Convert.ToInt32(QueryStringParam["Id"]);
                htmlEditor.KnowMoreLink = txtKnowMore.Text;
                if (FileUploader.HasFile)
                {
                    var fileExtension = Path.GetExtension(FileUploader.PostedFile.FileName)?.ToLower();
                    ImageName = FileUploader.PostedFile.FileName.Split('.')[0] + "_" + DateTime.Now.Ticks.ToString() + fileExtension;
                    htmlEditor.SideImage = ImageName;
                }
                htmlEditor.SideImage = ImageName;
                int result = HtmlEditorController.UpdateRecord(htmlEditor);
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
                    if (System.IO.File.Exists(Path.Combine(Server.MapPath("~/WebsiteImages"), OldFileName)))
                    {
                        System.IO.File.Delete(Path.Combine(Server.MapPath("~/WebsiteImages"), OldFileName));
                    }
                    Response.Redirect("HtmlEditor.aspx");
                }
            }
            else { return; }

        }
    }
}