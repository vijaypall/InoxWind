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
    public abstract class ProductProvider
    {
        public static ProductProvider _instance = null;
        static ProductProvider()
        {
            if (_instance == null)
                _instance = (ProductProvider)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["Product"].ToString()));
        }
        public abstract int DeleteProduct(Product product);
        public abstract Product GetProductById(int Id);
        public abstract DataTable GetProductList();
        public abstract int InsertProduct(Product product);
        public abstract int UpdateProduct(Product product);
        public abstract DataSet GetProductmasterList();

        public abstract DataTable GetProductTecDataList(int PID);
        public abstract DataTable GetProductTecItemList(int PID,int TecDataID);
    }
}
