using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DAL;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Product> GetALlProduct();

        [OperationContract]
        void Add1PR(Product product);

        [OperationContract]
        void Del1PR(Product product);

        [OperationContract]
        void UpdateProduct(Product product);

        [OperationContract]
        List<Order> GetAllOrders();

        [OperationContract]
        void Add1Order(Order order);

        [OperationContract]
        void Del1Order(Order order);

        [OperationContract]
        void UpdateOrder(Order order);

        [OperationContract]
        List<Order_Detail> GetAllOrderDetails();

        [OperationContract]
        void Add1OrderDetail(Order_Detail orderDetail);

        [OperationContract]
        void DelOrderDetail(Order_Detail orderDetail);

        [OperationContract]
        void Update1OrderDetail(Order_Detail orderDetail);
    }
}
