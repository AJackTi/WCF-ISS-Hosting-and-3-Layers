using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProperties;

namespace DAL
{
    public class CRUDProducts
    {
        ServiceReference.Service1Client obj; 
        public CRUDProducts()
        {
            obj = new ServiceReference.Service1Client();
        }
        public List<ProductsObj> GetAllProduct()
        {
            List<ProductsObj> data = new List<ProductsObj>();
            foreach(var i in obj.GetAllProduct())
            {
                ProductsObj productsObj = new ProductsObj();
                productsObj.ProductIDObj = i.ProductID;
                productsObj.ProductNameObj = i.ProductName;
                productsObj.UnitPriceObj = i.UnitPrice;
                productsObj.UnitInStockObj = i.UnitInStock;
                productsObj.ProductTypeObj = i.ProductType;
                data.Add(productsObj);
            }
            return data;
        }

        public List<ProductsObj> GetProductFromType(string producttype)
        {
            List<ProductsObj> data = new List<ProductsObj>();
            var listproduct = obj.GetProductFromType(producttype);
            foreach (var i in listproduct)
            {
                ProductsObj productsObj = new ProductsObj();
                productsObj.ProductIDObj = i.ProductID;
                productsObj.ProductNameObj = i.ProductName;
                productsObj.UnitPriceObj = i.UnitPrice;
                productsObj.UnitInStockObj = i.UnitInStock;
                productsObj.ProductTypeObj = i.ProductType;
                data.Add(productsObj);
            }
            return data;
        }

        public List<ProductsObj> GetProductFromID(int id)
        {
            List<ProductsObj> data = new List<ProductsObj>();
            var listproduct = obj.GetProductFromID(id);
            foreach (var i in listproduct)
            {
                ProductsObj productsObj = new ProductsObj();
                productsObj.ProductIDObj = i.ProductID;
                productsObj.ProductNameObj = i.ProductName;
                productsObj.UnitPriceObj = i.UnitPrice;
                productsObj.UnitInStockObj = i.UnitInStock;
                productsObj.ProductTypeObj = i.ProductType;
                data.Add(productsObj);
            }
            return data;
        }

        public void DeleteProduct(int id)
        {
            obj.DeleteProduct(id);
        }

        public void AddProduct(ProductsObj productObj)
        {
            obj.AddProduct(productObj);
        }

        public void UpdateProduct(ProductsObj productObj)
        {
            obj.UpdateProduct(productObj);
        }
    }
}
