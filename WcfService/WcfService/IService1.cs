using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MyProperties;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    
    public interface IService1
    {
        [OperationContract]
        List<Product_Temp> GetAllProduct();
        [OperationContract]
        List<Product_Temp> GetProductFromID(int id);
        [OperationContract]
        List<Product_Temp> GetProductFromType(string producttype);
        [OperationContract]
        void AddProduct(ProductsObj productObj);
        [OperationContract]
        void DeleteProduct(int id);
        [OperationContract]
        void UpdateProduct(ProductsObj productObj);
        [OperationContract]
        List<Order> GetAllOrder();
        [OperationContract]
        void AddOrder(Order order);
        [OperationContract]
        void DeleteOrder(int id);
        [OperationContract]
        void UpdateOrder(Order order);
        [OperationContract]
        List<OrderDetail> GetAllOrderDetail();
        [OperationContract]
        void AddOrderDetail(OrderDetail orderdetail);
        [OperationContract]
        void DeleteOrderDetail(int id);
        [OperationContract]
        void UpdateOrderDetail(OrderDetail orderdetail);

        [OperationContract]
        bool CheckLogin(string username, string password);
    }
}
