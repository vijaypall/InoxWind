using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataAccessLayer.Providers
{
    public static class DbProvider
    {
        public static AccountProvider Account
        {
            get
            {
                return AccountProvider._instance;
            }
        }
        public static HeaderImageProvider HeaderImage
        {
            get
            {
                return HeaderImageProvider._instance;
            }
        }
        public static CareerProvider Career
        {
            get
            {
                return CareerProvider._instance;
            }
        }
        public static BannerProvider Banner
        {
            get
            {
                return BannerProvider._instance;
            }
        }
        public static PartnerProvider Partner
        {
            get
            {
                return PartnerProvider._instance;
            }
        }
        public static QualityCertificateProvider QualityCertificate
        {
            get
            {
                return QualityCertificateProvider._instance;
            }
        }
        public static HtmlEditorProvider HtmlEditor
        {
            get
            {
                return HtmlEditorProvider._instance;
            }
        }
        public static LoginProvider Login
        {
            get
            {
                return LoginProvider._instance;
            }
        }
        public static SearchProvider Search
        {
            get
            {
                return SearchProvider._instance;
            }
        }
        public static NewsRoomProvider NewsRoom
        {
            get
            {
                return NewsRoomProvider._instance;
            }
        }
        public static ContactEnquiryProvider ContactEnquiry
        {
            get
            {
                return ContactEnquiryProvider._instance;
            }
        }
        public static LatestNewsProvider LatestNews
        {
            get
            {
                return LatestNewsProvider._instance;
            }
        }
        public static MilestonesProvider Milestones
        {
            get
            {
                return MilestonesProvider._instance;
            }
        }
        public static DailyNewsProvider DailyNews
        {
            get
            {
                return DailyNewsProvider._instance;
            }
        }
        public static LeaderProvider Leader
        {
            get
            {
                return LeaderProvider._instance;
            }
        }
        public static ProductProvider Product
        {
            get
            {
                return ProductProvider._instance;
            }
        }
        public static ProductImageProvider ProductImage
        {
            get
            {
                return ProductImageProvider._instance;
            }
        }
    }
}
