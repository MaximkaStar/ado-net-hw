using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            DataSet shopDatabase = new DataSet("ShopDB");

            DataTable orders = new DataTable("Orders");
            DataTable customers = new DataTable("Customers");
            DataTable employees = new DataTable("Employees");
            DataTable orderDetails = new DataTable("OrderDetails");
            DataTable products = new DataTable("Products");

            shopDatabase.Tables.Add(orders, customers, employees, orderDetails, products);

            DataColumn dataColumn = new DataColumn("Id", Type.GetType("System.Int32"));
            dataColumn.Unique = true; //уникальное значение
            dataColumn.AllowDBNull = false; //не будет принимать null
            dataColumn.AutoIncrement = true; 
            dataColumn.AutoIncrementSeed = 1; //начальное значение
            dataColumn.AutoIncrementStep = 1; //шаг при добавлении новой строки

            DataColumn nameColumn = new DataColumn("Name", Type.GetType("System.String"));
            DataColumn ordersColumn = new DataColumn("Orders", Type.GetType("System.Int32"));
            DataColumn customersColumn = new DataColumn("Customers", Type.GetType("System.String"));
            DataColumn employeesColumn = new DataColumn("Employees", Type.GetType("System.Int32"));
            DataColumn orderDetailsColumn = new DataColumn("Order Details", Type.GetType("System.String"));
            DataColumn productsColumn = new DataColumn("Products", Type.GetType("System.String"));

            ordersColumn.PrimaryKey = new DataColumn[] { ordersColumns["Orders"] };
            customersColumn.PrimaryKey = new DataColumn[] { customersColumns["Customers"] };
            nameColumn.PrimaryKey = new DataColumn[] { nameColumns["Names"] };
            employeesColumn.PrimaryKey = new DataColumn[] { employeesColumns["Employees"] };
            orderDetailsColumn.PrimaryKey = new DataColumn[] { ordersDetailsColumn["Order Detail"] };
            productsColumn.PrimaryKey = new DataColumn[] { productsColumn["Products"] };
        }
    }
}
