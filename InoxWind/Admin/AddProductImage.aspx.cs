using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic.Controller;

namespace InoxWind.Admin
{
    public partial class AddProductImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDropdown();
            }
        }

        private void BindDropdown()
        {
            DataSet ds = ProductController.GetProductmasterList();
            DdlProduct.DataSource = ds.Tables[0];
            DdlProduct.DataTextField = "ProductDesc";
            DdlProduct.DataValueField = "Id";
            DdlProduct.DataBind();
            DdlProduct.Items.Insert(0, new ListItem("Select", "0"));

        }
        private void Clearall()
        {
            lblProductError.Text = "";
            lblProductimageError.Text = "";
            lblhtmleditor.Text = "";
        }
        private bool Checkvalidation()
        {
            bool _vall = false;
            if (DdlProduct.SelectedValue == "0")
            {
                lblProductError.Text = "Please select a product";
                _vall = true;
            }
            if (!fileProductimage.HasFile)
            {
                lblProductimageError.Text = "Please upload the product image.";
                _vall = true;
            }
            if (string.IsNullOrEmpty(hdHtmleditor.Value))
            {
                lblhtmleditor.Text = "Please enter the product description";
                _vall = true;
            }
            return _vall;

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Clearall();
            if (!Checkvalidation())
            {
                var fileExtension = Path.GetExtension(fileProductimage.PostedFile.FileName)?.ToLower();
                string ImageName = fileProductimage.PostedFile.FileName.Split('.')[0] + "_" + DateTime.Now.Ticks.ToString() + fileExtension; 
                BusinessLogic.BusinessObjectModel.ProductImage productImage = new BusinessLogic.BusinessObjectModel.ProductImage();
                productImage.PID = Convert.ToInt32(DdlProduct.SelectedValue);
                productImage.HtmlText = hdHtmleditor.Value;
                productImage.SideImage = ImageName;
                int result = ProductImageController.InsertProductImage(productImage);
                if (result > 0)
                {
                    if (fileProductimage.HasFile)
                    {
                        if (!Directory.Exists(Server.MapPath("~/WebsiteImages")))
                        {
                            Directory.CreateDirectory(Server.MapPath("~/WebsiteImages"));
                        }
                        string path = Path.Combine(Server.MapPath("~/WebsiteImages"), ImageName);
                        fileProductimage.PostedFile.SaveAs(path);
                    }
                    Response.Redirect("ProductImage.aspx");
                }
            }
            else { return; }

        }
    }
}