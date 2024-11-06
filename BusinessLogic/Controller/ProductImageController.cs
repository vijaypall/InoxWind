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
    public static class ProductImageController
    {
        public static int DeleteProductImage(ProductImage productImage) { return DbProvider.ProductImage.DeleteProductImage(productImage); }
        public static ProductImage GetProductImageById(int Id) { return DbProvider.ProductImage.GetProductImageById(Id); }
        public static DataTable GetProductImageList() { return DbProvider.ProductImage.GetProductImageList(); }
        public static int InsertProductImage(ProductImage productImage) { return DbProvider.ProductImage.InsertProductImage(productImage); }
        public static int UpdateProductImage(ProductImage productImage) { return DbProvider.ProductImage.UpdateProductImage(productImage); }
    }
}
