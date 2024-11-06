using BusinessLogic.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InoxWind
{
    public partial class products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindProductImage1();
                BindProductImage2();
                BindTecDataProduct1();
                BindTecDataProduct2();
            }

        }
        private void BindProductImage1()
        {
            StringBuilder SbProductImage1 = new StringBuilder();
            try
            {
                DataTable dtproductimage1 = ProductImageController.GetProductImageList();
                DataRow[] rowProductimage1 = dtproductimage1.Select("PID=1 and Isactive=True ");
                Array.Sort(rowProductimage1, (x, y) => Comparer<int>.Default.Compare((int)x["ID"], (int)y["ID"]));

                foreach (DataRow row in rowProductimage1)
                {
                    string path = CommonClass.BaseDomain.GetBaseDomain(Request) + "/WebsiteImages/" + row["SideImage"].ToString();
                    SbProductImage1.Append(@"<div class='w90 margin-center prodabtflex'><div class='col-lg-6 col-md-6 col-sm-12 image-side'><img src ='" + path + "'  alt = '' /></div><div class='col-lg-6 col-md-6 col-sm-12 about-side'><div class='mcontainer common-headings'>" + row["HtmlText"].ToString() + "</div></div> </div>");
                }
            }
            catch { }
            DivProduct1Image.InnerHtml = SbProductImage1.ToString();


        }
        private void BindProductImage2()
        {
            StringBuilder SbProductImage2 = new StringBuilder();
            try
            {
                DataTable dtproductimage2 = ProductImageController.GetProductImageList();
                DataRow[] rowProductimage2 = dtproductimage2.Select("PID=2 and Isactive=True ");
                Array.Sort(rowProductimage2, (x, y) => Comparer<int>.Default.Compare((int)x["ID"], (int)y["ID"]));

                foreach (DataRow row in rowProductimage2)
                {
                    string path = CommonClass.BaseDomain.GetBaseDomain(Request) + "/WebsiteImages/" + row["SideImage"].ToString();
                    SbProductImage2.Append(@"<div class='w90 margin-center prodabtflex'><div class='col-lg-6 col-md-6 col-sm-12 image-side'><img src ='" + path + "'  alt = '' /></div><div class='col-lg-6 col-md-6 col-sm-12 about-side'><div class='mcontainer common-headings'>" + row["HtmlText"].ToString() + "</div></div> </div>");
                }
            }
            catch { }
            DivProduct2Image.InnerHtml = SbProductImage2.ToString();
        }
        private void BindTecDataProduct1()
        {
            StringBuilder SbtechData1 = new StringBuilder();
            try
            {
                int PID = 1;
                StringBuilder sbItem = new StringBuilder();
                DataTable dtTechdata1 = ProductController.GetProductTecDataList(PID);

                if (dtTechdata1.Rows.Count > 0)
                {
                    for (int i = 0; i < dtTechdata1.Rows.Count; i++)
                    {
                        int TecDataID = Convert.ToInt32(dtTechdata1.Rows[i]["TecDataID"].ToString());
                        DataTable dtTechIteam1 = ProductController.GetProductTecItemList(PID, TecDataID);
                        if (dtTechIteam1.Rows.Count > 0)
                        {
                            sbItem.Clear();
                            for (int j = 0; j < dtTechIteam1.Rows.Count; j++)
                            {
                                sbItem.Append("<tr><td>" + dtTechIteam1.Rows[j]["TechItemDesc"].ToString() + "</td><td>" + dtTechIteam1.Rows[j]["TecItemValue"].ToString() + "</td></tr>");
                            }
                        }
                        SbtechData1.Append(@"<div class='spec - acc mcontainer'><div class='spec-acc-title' data-id='spec1" + i.ToString() + "'> <p>" + dtTechdata1.Rows[i]["TechDataDesc"].ToString() + "</p><svg xmlns ='http://www.w3.org/2000/svg' width= '48' height= '48' viewBox= '0 0 48 48' fill= 'none'><path d='M16 20L24 28L32 20' stroke= '#2E2F34' stroke-width= '1.4' stroke-linecap= 'round' stroke-linejoin= 'round' /></svg></div><div class='spec-content' id='spec1" + i.ToString() + "'><table><tbody>" + sbItem.ToString() + "</tbody ></table></div></div>");
                    }
                }
            }catch { }
            DivProduct1Data.InnerHtml = SbtechData1.ToString();
        }
        private void BindTecDataProduct2()
        {
            StringBuilder SbtechData1 = new StringBuilder();
            try
            {
                int PID = 2;
                StringBuilder sbItem = new StringBuilder();
                DataTable dtTechdata1 = ProductController.GetProductTecDataList(PID);

                if (dtTechdata1.Rows.Count > 0)
                {
                    for (int i = 0; i < dtTechdata1.Rows.Count; i++)
                    {
                        int TecDataID = Convert.ToInt32(dtTechdata1.Rows[i]["TecDataID"].ToString());
                        DataTable dtTechIteam1 = ProductController.GetProductTecItemList(PID, TecDataID);
                        if (dtTechIteam1.Rows.Count > 0)
                        {
                            sbItem.Clear();
                            for (int j = 0; j < dtTechIteam1.Rows.Count; j++)
                            {
                                sbItem.Append("<tr><td>" + dtTechIteam1.Rows[j]["TechItemDesc"].ToString() + "</td><td>" + dtTechIteam1.Rows[j]["TecItemValue"].ToString() + "</td></tr>");
                            }
                        }
                        SbtechData1.Append(@"<div class='spec - acc mcontainer'><div class='spec-acc-title' data-id='spec11" + i.ToString() + "'> <p>" + dtTechdata1.Rows[i]["TechDataDesc"].ToString() + "</p><svg xmlns ='http://www.w3.org/2000/svg' width= '48' height= '48' viewBox= '0 0 48 48' fill= 'none'><path d='M16 20L24 28L32 20' stroke= '#2E2F34' stroke-width= '1.4' stroke-linecap= 'round' stroke-linejoin= 'round' /></svg></div><div class='spec-content' id='spec11" + i.ToString() + "'><table><tbody>" + sbItem.ToString() + "</tbody ></table></div></div>");
                    }
                }
            }catch { }
            DivProduct2Data.InnerHtml = SbtechData1.ToString();
        }
    }
}