using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.BusinessObjectModel;

namespace BusinessLogic.DataAccessLayer.Providers
{
 public abstract   class QualityCertificateProvider
    {
        public static QualityCertificateProvider _instance = null;
        static QualityCertificateProvider()
        {
            if (_instance == null)
                _instance = (QualityCertificateProvider)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["QualityCertificate"].ToString()));
        }

        public abstract DataTable GetCertificateList();
        public abstract int InsertCertificate(QualityCertificate certificate);
        public abstract int DeleteCertificate(QualityCertificate certificate);
        public abstract QualityCertificate GetCertificateById(int Id);
        public abstract int UpdateCertificate(QualityCertificate certificate);
    }
}
