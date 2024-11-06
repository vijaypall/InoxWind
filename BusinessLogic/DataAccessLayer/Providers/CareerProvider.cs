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
    public abstract class CareerProvider
    {
        public static CareerProvider _instance = null;
        static CareerProvider()
        {
            if (_instance == null)
                _instance = (CareerProvider)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["Career"].ToString()));
        }
        public abstract DataTable GetCareerList();
        public abstract int InsertCareer(Career Career);
        public abstract int UpdateCareer(Career Career);
        public abstract int DeleteCareer(Career Career);
        public abstract Career GetCareerbyId(int Id); 
    }
}
