using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic.BusinessObjectModel;
using BusinessLogic.Controller;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Data.SqlClient;
using System.Web.Services;
using System.Web.Script.Services;
using HtmlAgilityPack;

namespace InoxWind.Admin
{
    public partial class Banner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["csrfToken"] = Guid.NewGuid().ToString();
                BindData();
            }

        }

        private void BindData()
        {
            DataTable dataTable = new DataTable();
            dataTable = BannersController.GetBannerList();
            StringBuilder Sb = new StringBuilder();
            string StrHead = @"<table class='table table-striped table-bordered table-hover' id='example'  border='1' runat='server'><thead>
            <tr>
            <th>Banner Order</th>
             <th> Banner Image </th> 
            <th>  <i class='bigger-110 hidden-480'></i> Banner Content</th> 
            <th class='hidden-480'>Read More Url</th>       <th>Status</th>

<th style='width:80px'>Action</th>
            </tr> 
            </thead>
            <tbody id='tableBody' runat='server'>";
            Sb.Append(StrHead);
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string Html = string.Empty;
                    if (!string.IsNullOrEmpty(dataTable.Rows[i]["PopupContent"].ToString()))
                    {

                        var htmlDoc = new HtmlDocument();
                        htmlDoc.LoadHtml(dataTable.Rows[i]["PopupContent"].ToString());
                        if (htmlDoc.DocumentNode.InnerText.Length > 100)
                        {
                            Html = htmlDoc.DocumentNode.InnerText.Substring(0, 100) + "...";
                        }
                        else { Html = htmlDoc.DocumentNode.InnerText; }

                    }

                    string EncriptQS = CommonClass.QueryStringHelper.Encrypt("Id=" + dataTable.Rows[i]["ID"].ToString());
                    string Status = "Active";
                    if (!Convert.ToBoolean(dataTable.Rows[i]["IsActive"]))
                    {
                        Status = "In-Active";
                        Sb.Append("<tr><td>" + dataTable.Rows[i]["BannerOrder"].ToString() + "</td><td>" + dataTable.Rows[i]["BannerImage"].ToString() + "</td><td>" + Html + "</td><td>" + dataTable.Rows[i]["ReadmoreUrl"].ToString() + "</td> <td>" + Status + "</td><td>  <div class='hidden-sm hidden-xs action-buttons'><a class='gray' style='color:gray' /><i class='ace-icon fa fa-pencil bigger-130'></i></a> <a class='green' attr-href-data='In-Active'  onclick=\"deleteItem('" + dataTable.Rows[i]["ID"] + "','Active')\" /> <i class='ace-icon fa fa-check bigger-130'></i> </a> </div></td> </tr>");
                    }
                    else
                    {
                        Sb.Append("<tr><td>" + dataTable.Rows[i]["BannerOrder"].ToString() + "</td><td>" + dataTable.Rows[i]["BannerImage"].ToString() + "</td><td>" + Html + "</td><td>" + dataTable.Rows[i]["ReadmoreUrl"].ToString() + "</td> <td>" + Status + "</td><td>  <div class='hidden-sm hidden-xs action-buttons'><a class='blue' onclick=\"EditItem('" + HttpUtility.HtmlEncode(EncriptQS) + "')\" /><i class='ace-icon fa fa-pencil bigger-130'></i></a> <a class='red' onclick=\"deleteItem('" + dataTable.Rows[i]["ID"] + "','In-Active')\"  /> <i class='ace-icon fa fa-times bigger-130'></i> </a> </div> </td> </tr>");

                    }
                }
            }
            string HeadEnd = "</tbody></table>";
            Sb.Append(HeadEnd);
            PopulateTable.InnerHtml = Sb.ToString();
        }

    }
}