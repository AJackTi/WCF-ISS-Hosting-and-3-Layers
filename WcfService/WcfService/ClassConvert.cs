using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Objects_Temp;

namespace WcfService
{
    public static class ClassConvert
    {
        public static Product_Temp ConvertToProduct_Temp(Product product)
        {
            Product_Temp product_temp = new Product_Temp();
            product_temp.ProductID = product.ProductID;
            product_temp.ProductName = product.ProductName;
            product_temp.UnitPrice = product.UnitPrice;
            product_temp.UnitInStock = product.UnitInStock;
            product_temp.ProductType = product.ProductType;
            return product_temp;
        }

        public static Customer_Temp ConvertToCustomer_Temp(Customer customer)
        {
            Customer_Temp customer_temp = new Customer_Temp();
            customer_temp.CustomerID = customer.CustomerID;
            customer_temp.ContactName = customer.ContactName;
            customer_temp.Address = customer.Address;
            customer_temp.Phone = customer.Phone;
            customer_temp.UserID = customer.UserID;
            return customer_temp;
        }

        public static Employee_Temp ConvertToEmployee_Temp(Employee employee)
        {
            Employee_Temp employee_temp = new Employee_Temp();
            employee_temp.EmployeeID = employee.EmployeeID;
            employee_temp.EmployeeName = employee.EmployeeName;
            employee_temp.UserID = employee.UserID;
            return employee_temp;
        }

        public static Login_Temp ConvertToLogin_Temp(Login login)
        {
            Login_Temp login_temp = new Login_Temp();
            login_temp.UserID = login.UserID;
            login_temp.UserName = login.UserName;
            login_temp.Password = login.Password;
            return login_temp;
        }

        public static Order_Detail_Temp ConvertToOrderDetail_Temp(OrderDetail orderdetail)
        {
            Order_Detail_Temp order_detail_temp = new Order_Detail_Temp();
            order_detail_temp.OrderID = orderdetail.OrderID;
            order_detail_temp.ProductID = orderdetail.ProductID;
            order_detail_temp.UnitPrice = orderdetail.UnitPrice;
            order_detail_temp.Quantity = orderdetail.Quantity;
            return order_detail_temp;
        }

        public static Order_Temp ConvertToOrder_Temp(Order order)
        {
            Order_Temp order_temp = new Order_Temp();
            order_temp.OrderID = order.OrderID;
            order_temp.CustomerID = order.CustomerID;
            order_temp.EmployeeID = order.EmployeeID;
            order_temp.OrderDate = order.OrderDate;
            return order_temp;
        }
    }
}