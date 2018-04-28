using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Product> GetAllProduct();
        [OperationContract]
        void AddProduct(Product product);
        [OperationContract]
        void DeleteProduct(int id);
        [OperationContract]
        void UpdateProduct(Product product);
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
    }
}
