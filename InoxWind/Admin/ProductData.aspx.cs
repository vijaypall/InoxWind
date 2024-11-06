using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic.Controller;

namespace InoxWind.Admin
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Session["ProductDataToken"] = Guid.NewGuid().ToString();
                BindData();
            }
        }
        private void BindData()
        {
            DataTable dataTable = new DataTable();
            dataTable = ProductController.GetProductList();
            StringBuilder Sb = new StringBuilder();
            string StrHead = @"<table class='table table-striped table-bordered table-hover'id='example'  border='1' runat='server'><thead>
            <tr>
            <th>Product Name</th> 
            <th>Technical Data</th>
             <th>Technical Item</th>
            <th class='hidden-480'>Technical Value</th>
 <th class='hidden-480'>Product Image</th>
            <th>Status</th>
             <th>Action</th>
            </tr> 
            </thead>
            <tbody id='tableBody' runat='server'>";
            Sb.Append(StrHead);
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string EncriptQS = CommonClass.QueryStringHelper.Encrypt("Id=" + dataTable.Rows[i]["ID"].ToString());
                    string DonloadImage = CommonClass.BaseDomain.GetBaseDomain(Request) + "/WebsiteImages/" + dataTable.Rows[i]["Image"].ToString();
                    string Status = "Active";
                    if (!Convert.ToBoolean(dataTable.Rows[i]["IsActive"]))
                    {
                        Status = "In-Active";
                        Sb.Append("<tr><td>" + dataTable.Rows[i]["ProductDesc"].ToString() + "</td><td>" + dataTable.Rows[i]["TechDataDesc"].ToString() + "</td><td>" + dataTable.Rows[i]["TechItemDesc"].ToString() + "</td><td>" + dataTable.Rows[i]["TecItemValue"].ToString() + "</td><td><a href='" + DonloadImage + "' download>Download</a></td><td>" + Status + "</td>  <td> <div class='hidden-sm hidden-xs action-buttons'><a class='gray' style='color:gray' /><i class='ace-icon fa fa-pencil bigger-130'></i></a> <a class='green' attr-href-data='In-Active'  onclick=\"deleteItem('" + dataTable.Rows[i]["ID"] + "','Active')\" /> <i class='ace-icon fa fa-check bigger-130'></i> </a> </div> </td> </tr>");
                    }
                    else
                    {
                        Sb.Append("<tr><td>" + dataTable.Rows[i]["ProductDesc"].ToString() + "</td><td>" + dataTable.Rows[i]["TechDataDesc"].ToString() + "</td><td>" + dataTable.Rows[i]["TechItemDesc"].ToString() + "</td><td>" + dataTable.Rows[i]["TecItemValue"].ToString() + "</td><td><a href='" + DonloadImage + "' download>Download</a></td><td>" + Status + "</td> <td> <div class='hidden-sm hidden-xs action-buttons'><a class='blue' onclick=\"EditItem('" + HttpUtility.HtmlEncode(EncriptQS) + "')\" /><i class='ace-icon fa fa-pencil bigger-130'></i></a> <a class='red' attr-href-data='Active' onclick=\"deleteItem('" + dataTable.Rows[i]["ID"] + "','In-Active')\" /> <i class='ace-icon fa fa-times bigger-130'></i> </a> </div> </td> </tr>");
                    }
                }
            }
            string HeadEnd = "</tbody></table>";
            Sb.Append(HeadEnd);
            PopulateTable.InnerHtml = Sb.ToString();
        }
    }
}