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
    public abstract class ProductImageProvider
    {
        public static ProductImageProvider _instance = null;
        static ProductImageProvider()
        {
            if (_instance == null)
                _instance = (ProductImageProvider)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["ProductImage"].ToString()));
        }
        public abstract int DeleteProductImage(ProductImage productImage);
        public abstract ProductImage GetProductImageById(int Id);
        public abstract DataTable GetProductImageList();
        public abstract int InsertProductImage(ProductImage productImage);
        public abstract int UpdateProductImage(ProductImage productImage);
    }
}
