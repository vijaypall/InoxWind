using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using BusinessLogic.BusinessObjectModel;
using BusinessLogic.Controller;

namespace InoxWind
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    [System.Web.Script.Services.ScriptService]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod(enableSession: true)]
        public string BannerDelete(string id, string __RequestVerificationToken)
        {
            if (HttpContext.Current.Session["csrfToken"] != null)
            {
                if (HttpContext.Current.Session["csrfToken"].ToString() != __RequestVerificationToken)
                {
                    return "Invalid request token.";
                }
            }
            else { return "Invalid request token."; }
            try
            {
                BusinessLogic.BusinessObjectModel.Banner Banner = BannersController.GetBannerById(Convert.ToInt32(id));
                if (Banner.Id == 0) { return "Item not found."; }
                int rowsAffected = BannersController.DeleteBanner(Banner);
                if (rowsAffected > 0)
                {
                    return "success";
                }
                else
                {
                    return "Item not found or could not be deleted.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }

        }

        [WebMethod(enableSession: true)]
        public string PartnerDelete(string id, string __RequestVerificationToken)
        {
            if (HttpContext.Current.Session["PartnerToken"] != null)
            {
                if (HttpContext.Current.Session["PartnerToken"].ToString() != __RequestVerificationToken)
                {
                    return "Invalid request token.";
                }
            }
            else { return "Invalid request token."; }
            try
            {
                BusinessLogic.BusinessObjectModel.Partner partner = PartnerController.GetBannerById(Convert.ToInt32(id));
                if (partner == null) { return "Item not found."; }
                int rowsAffected = PartnerController.DeletePartner(partner);
                if (rowsAffected > 0)
                {
                    return "success";
                }
                else
                {
                    return "Item not found or could not be deleted.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }

        }
        [WebMethod(enableSession: true)]
        public string CertiicateDelete(string id, string __RequestVerificationToken)
        {
            if (HttpContext.Current.Session["CertificateToken"] != null)
            {
                if (HttpContext.Current.Session["CertificateToken"].ToString() != __RequestVerificationToken)
                {
                    return "Invalid request token.";
                }
            }
            else { return "Invalid request token."; }
            try
            {
                BusinessLogic.BusinessObjectModel.QualityCertificate certificate = QualityCertificateController.GetCertificateById(Convert.ToInt32(id));
                if (certificate == null) { return "Item not found."; }
                int rowsAffected = QualityCertificateController.DeleteCertificate(certificate);
                if (rowsAffected > 0)
                {
                    return "success";
                }
                else
                {
                    return "Item not found or could not be deleted.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }

        }

        //
        [WebMethod(enableSession: true)]
        public string EditorDelete(string id, string __RequestVerificationToken)
        {
            if (HttpContext.Current.Session["HtmlEditorToken"] != null)
            {
                if (HttpContext.Current.Session["HtmlEditorToken"].ToString() != __RequestVerificationToken)
                {
                    return "Invalid request token.";
                }
            }
            else { return "Invalid request token."; }
            try
            {
                BusinessLogic.BusinessObjectModel.HtmlEditor htmlEditor = HtmlEditorController.GetRecordById(Convert.ToInt32(id));
                if (htmlEditor == null) { return "Item not found."; }
                int rowsAffected = HtmlEditorController.DeleteRecord(htmlEditor);
                if (rowsAffected > 0)
                {
                    return "success";
                }
                else
                {
                    return "Item not found or could not be deleted.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }

        }

        //
        [WebMethod(enableSession: true)]
        public string ActiveInactiveLatesNews(string id, string __RequestVerificationToken)
        {
            if (HttpContext.Current.Session["LatestNewsToken"] != null)
            {
                if (HttpContext.Current.Session["LatestNewsToken"].ToString() != __RequestVerificationToken)
                {
                    return "Invalid request token.";
                }
            }
            else { return "Invalid request token."; }
            try
            {
                BusinessLogic.BusinessObjectModel.LatestNews LatestNews = LatestNewsController.GetLatestNewsById(Convert.ToInt32(id));
                if (LatestNews.Id == 0) { return "Item not found."; }
                int rowsAffected = LatestNewsController.DeleteLatestNews(LatestNews);
                if (rowsAffected > 0)
                {
                    return "success";
                }
                else
                {
                    return "Item not found or could not be deleted.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }

        }
        //

        [WebMethod(enableSession: true)]
        public string DeleteNews(string id, string __RequestVerificationToken)
        {
            if (HttpContext.Current.Session["NewsToken"] != null)
            {
                if (HttpContext.Current.Session["NewsToken"].ToString() != __RequestVerificationToken)
                {
                    return "Invalid request token.";
                }
            }
            else { return "Invalid request token."; }
            try
            {
                BusinessLogic.BusinessObjectModel.NewsRoom LatestNews = NewsRoomController.GetRecordById(Convert.ToInt32(id));
                if (LatestNews.Id == 0) { return "Item not found."; }
                int rowsAffected = NewsRoomController.DeleteRecord(LatestNews);
                if (rowsAffected > 0)
                {
                    return "success";
                }
                else
                {
                    return "Item not found or could not be deleted.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }

        }

        [WebMethod(enableSession: true)]
        public string DeleteLeader(string id, string __RequestVerificationToken)
        {
            if (HttpContext.Current.Session["LeaderToken"] != null)
            {
                if (HttpContext.Current.Session["LeaderToken"].ToString() != __RequestVerificationToken)
                {
                    return "Invalid request token.";
                }
            }
            else { return "Invalid request token."; }
            try
            {
                BusinessLogic.BusinessObjectModel.Leader leader = LeaderController.GetLeaderById(Convert.ToInt32(id));
                if (leader.Id == 0) { return "Item not found."; }
                int rowsAffected = LeaderController.DeleteLeader(leader);
                if (rowsAffected > 0)
                {
                    return "success";
                }
                else
                {
                    return "Item not found or could not be deleted.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }

        }

        [WebMethod(enableSession: true)]
        public string WebsiteSearchresult(string searchtext, string __RequestVerificationToken)
        {
            try
            {
                Session["searchtext"] = searchtext;
                //DataTable dataTable = new DataTable();
                //dataTable = SearchController.GetSearchByText(searchtext);
                //StringBuilder Sb = new StringBuilder();
                //if (dataTable.Rows.Count > 0)
                //{
                //    for (int i = 0; i < dataTable.Rows.Count; i++)
                //    {
                //        string PageName = dataTable.Rows[i]["PageName"].ToString();
                //        string PageUrl = dataTable.Rows[i]["pageUrl"].ToString();
                //        string HighlightedText = dataTable.Rows[i]["HighlightedText"].ToString();
                //        //search text also 

                //    }
                //}
                return "success";

            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }

        }

        [WebMethod(enableSession: true)]
        public string MilestonesDelete(string id, string __RequestVerificationToken)
        {
            if (HttpContext.Current.Session["MilestonesToken"] != null)
            {
                if (HttpContext.Current.Session["MilestonesToken"].ToString() != __RequestVerificationToken)
                {
                    return "Invalid request token.";
                }
            }
            else { return "Invalid request token."; }
            try
            {
                BusinessLogic.BusinessObjectModel.Milestones milestones = MilestonesController.GetMilestonesById(Convert.ToInt32(id));
                if (milestones.Id == 0) { return "Item not found."; }
                int rowsAffected = MilestonesController.DeleteMilestones(milestones);
                if (rowsAffected > 0)
                {
                    return "success";
                }
                else
                {
                    return "Item not found or could not be deleted.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }

        }

        [WebMethod]
        public List<NewsRoom> GetNews(int Id, string NewsType)
        {
            return NewsRoomController.GetPressReleased(Id, NewsType);
        }
        //
        [WebMethod(enableSession: true)]
        public string DailyNewsDelete(string id, string __RequestVerificationToken)
        {
            if (HttpContext.Current.Session["DailyNewsToken"] != null)
            {
                if (HttpContext.Current.Session["DailyNewsToken"].ToString() != __RequestVerificationToken)
                {
                    return "Invalid request token.";
                }
            }
            else { return "Invalid request token."; }
            try
            {
                BusinessLogic.BusinessObjectModel.DailyNews dailyNews = DailyNewsController.GetDailyNewsById(Convert.ToInt32(id));
                if (dailyNews.Id == 0) { return "Item not found."; }
                int rowsAffected = DailyNewsController.DeleteDailyNews(dailyNews);
                if (rowsAffected > 0)
                {
                    return "success";
                }
                else
                {
                    return "Item not found or could not be deleted.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }

        }
        //GetDailyNews

        [WebMethod]
        public List<DailyNews> GetDailyNews(int Id)
        {
            return DailyNewsController.GetPressDalilyNews(Id);
        }
        [WebMethod(enableSession: true)]
        public string ProductImageDelete(string id, string __RequestVerificationToken)
        {
            if (HttpContext.Current.Session["ProductImageToken"] != null)
            {
                if (HttpContext.Current.Session["ProductImageToken"].ToString() != __RequestVerificationToken)
                {
                    return "Invalid request token.";
                }
            }
            else { return "Invalid request token."; }
            try
            {
                BusinessLogic.BusinessObjectModel.ProductImage productImage = ProductImageController.GetProductImageById(Convert.ToInt32(id));
                if (productImage == null) { return "Item not found."; }
                int rowsAffected = ProductImageController.DeleteProductImage(productImage);
                if (rowsAffected > 0)
                {
                    return "success";
                }
                else
                {
                    return "Item not found or could not be deleted.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }

        }

        [WebMethod(enableSession: true)]
        public string ProductDataDelete(string id, string __RequestVerificationToken)
        {
            if (HttpContext.Current.Session["ProductDataToken"] != null)
            {
                if (HttpContext.Current.Session["ProductDataToken"].ToString() != __RequestVerificationToken)
                {
                    return "Invalid request token.";
                }
            }
            else { return "Invalid request token."; }
            try
            {
                BusinessLogic.BusinessObjectModel.Product product = ProductController.GetProductById(Convert.ToInt32(id));
                if (product == null) { return "Item not found."; }
                int rowsAffected = ProductController.DeleteProduct(product);
                if (rowsAffected > 0)
                {
                    return "success";
                }
                else
                {
                    return "Item not found or could not be deleted.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }

        }

        [WebMethod(enableSession: true)]
        public string OpeningDelete(string id, string __RequestVerificationToken)
        {
            if (HttpContext.Current.Session["OpeningToken"] != null)
            {
                if (HttpContext.Current.Session["OpeningToken"].ToString() != __RequestVerificationToken)
                {
                    return "Invalid request token.";
                }
            }
            else { return "Invalid request token."; }
            try
            {
                BusinessLogic.BusinessObjectModel.Career career = CareersController.GetCareerbyId(Convert.ToInt32(id));
                if (career.Id == 0) { return "Item not found."; }
                int rowsAffected = CareersController.DeleteCareer(career);
                if (rowsAffected > 0)
                {
                    return "success";
                }
                else
                {
                    return "Item not found or could not be deleted.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }

        }
    }
}
