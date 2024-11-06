using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.BusinessObjectModel;
using BusinessLogic.DataAccessLayer.Providers;

namespace BusinessLogic.Controller
{
    public static class QualityCertificateController
    {
        public static DataTable GetCertificateList() { return DbProvider.QualityCertificate.GetCertificateList(); }
        public static int InsertCertificate(QualityCertificate certificate) { return DbProvider.QualityCertificate.InsertCertificate(certificate); }
        public static int DeleteCertificate(QualityCertificate certificate) { return DbProvider.QualityCertificate.DeleteCertificate(certificate); }
        public static QualityCertificate GetCertificateById(int Id) { return DbProvider.QualityCertificate.GetCertificateById(Id); }
        public static int UpdateCertificate(QualityCertificate certificate) { return DbProvider.QualityCertificate.UpdateCertificate(certificate); }
    }
}
