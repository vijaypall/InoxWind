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
    public static class ProductController
    {
        public static int DeleteProduct(Product product) { return DbProvider.Product.DeleteProduct(product); }
        public static Product GetProductById(int Id) { return DbProvider.Product.GetProductById(Id); }
        public static DataTable GetProductList() { return DbProvider.Product.GetProductList(); }
        public static int InsertProduct(Product product) { return DbProvider.Product.InsertProduct(product); }
        public static int UpdateProduct(Product product) { return DbProvider.Product.UpdateProduct(product); }
        public static DataSet GetProductmasterList() { return DbProvider.Product.GetProductmasterList(); }
        public static DataTable GetProductTecDataList(int PID) { return DbProvider.Product.GetProductTecDataList(PID); }
        public static DataTable GetProductTecItemList(int PID, int TecDataID) { return DbProvider.Product.GetProductTecItemList(PID, TecDataID); }
    }
}
