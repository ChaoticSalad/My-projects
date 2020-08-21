using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class Product
    {
        int id;
        string name;
        string status;
        string date;
        int quantity;
        string category;
        string company;

        public Product(int i, string column, string condition)
        {
            id = i;
            name = SqlConnect.GetInfo($"SELECT TOP (1) [ProductName] FROM [Storage].[dbo].[Products] WHERE id = {i} AND {column} = '{condition}'");
            status = SqlConnect.GetInfo($"SELECT TOP (1) [Status] FROM [Storage].[dbo].[Products] WHERE id = {i} AND {column} = '{condition}'");
            date = SqlConnect.GetInfo($"SELECT TOP (1) [Date] FROM [Storage].[dbo].[Products] WHERE id = {i} AND {column} = '{condition}'");
            quantity = Convert.ToInt32(SqlConnect.GetInfo($"SELECT TOP (1) [Quantity] FROM [Storage].[dbo].[Products] WHERE id = {i} AND {column} = '{condition}'"));
            category = SqlConnect.GetInfo($"SELECT TOP (1) [CategoryName] FROM [Storage].[dbo].[Products] WHERE id = {i} AND {column} = '{condition}'");
            company = SqlConnect.GetInfo($"SELECT TOP (1) [CompanyName] FROM [Storage].[dbo].[Products] WHERE id = {i} AND {column} = '{condition}'");
        }

        public Product(int i)
        {
            id = i;
            name = SqlConnect.GetInfo($"SELECT TOP (1) [ProductName] FROM [Storage].[dbo].[Products] WHERE id = {i}");
            status = SqlConnect.GetInfo($"SELECT TOP (1) [Status] FROM [Storage].[dbo].[Products] WHERE id = {i}");
            date = SqlConnect.GetInfo($"SELECT TOP (1) [Date] FROM [Storage].[dbo].[Products] WHERE id = {i}");
            quantity = Convert.ToInt32(SqlConnect.GetInfo($"SELECT TOP (1) [Quantity] FROM [Storage].[dbo].[Products] WHERE id = {i}"));
            category = SqlConnect.GetInfo($"SELECT TOP (1) [CategoryName] FROM [Storage].[dbo].[Products] WHERE id = {i}");
            company = SqlConnect.GetInfo($"SELECT TOP (1) [CompanyName] FROM [Storage].[dbo].[Products] WHERE id = {i}");
        }

        public Product (string name, string status, DateTime date, int quantity, string category, string company)
        {
            SqlConnect.ChangeSomeArr($"INSERT INTO [Storage].[dbo].[products] (ProductName, Status, Date, Quantity, CategoryName, CompanyName) VALUES ('{name}', '{status}', '{date}', {quantity}, '{category}', '{company}')");
            id = Convert.ToInt32(SqlConnect.GetInfo($"SELECT MAX(id) FROM [Storage].[dbo].[Products]"));
            this.name = SqlConnect.GetInfo($"SELECT TOP (1) [ProductName] FROM [Storage].[dbo].[Products] WHERE id = {id}");
            this.status = SqlConnect.GetInfo($"SELECT TOP (1) [Status] FROM [Storage].[dbo].[Products] WHERE id = {id}");
            this.date = SqlConnect.GetInfo($"SELECT TOP (1) [Date] FROM [Storage].[dbo].[Products] WHERE id = {id}");
            this.quantity = Convert.ToInt32(SqlConnect.GetInfo($"SELECT TOP (1) [Quantity] FROM [Storage].[dbo].[Products] WHERE id = {id}"));
            this.category = SqlConnect.GetInfo($"SELECT TOP (1) [CategoryName] FROM [Storage].[dbo].[Products] WHERE id = {id}");
            this.company = SqlConnect.GetInfo($"SELECT TOP (1) [CompanyName] FROM [Storage].[dbo].[Products] WHERE id = {id}");
        }

        public Product(int i, DateTime dateFrom, DateTime dateTo)
        {
            id = i;
            name = SqlConnect.GetInfo($"SELECT TOP (1) [ProductName] FROM [Storage].[dbo].[Products] WHERE id = {i} and Date >= '{dateFrom}' AND Date <= '{dateTo}'");
            status = SqlConnect.GetInfo($"SELECT TOP (1) [Status] FROM [Storage].[dbo].[Products] WHERE id = {i} and Date >= '{dateFrom}' AND Date <= '{dateTo}'");
            date = SqlConnect.GetInfo($"SELECT TOP (1) [Date] FROM [Storage].[dbo].[Products] WHERE id = {i}");
            quantity = Convert.ToInt32(SqlConnect.GetInfo($"SELECT TOP (1) [Quantity] FROM [Storage].[dbo].[Products] WHERE id = {i} and Date >= '{dateFrom}' AND Date <= '{dateTo}'"));
            category = SqlConnect.GetInfo($"SELECT TOP (1) [CategoryName] FROM [Storage].[dbo].[Products] WHERE id = {i} and Date >= '{dateFrom}' AND Date <= '{dateTo}'");
            company = SqlConnect.GetInfo($"SELECT TOP (1) [CompanyName] FROM [Storage].[dbo].[Products] WHERE id = {i} and Date >= '{dateFrom}' AND Date <= '{dateTo}'");
        }
        public Product(int i, DateTime dateFrom, DateTime dateTo, string status)
        {
            id = i;
            name = SqlConnect.GetInfo($"SELECT TOP (1) [ProductName] FROM [Storage].[dbo].[Products] WHERE id = {i} and Date >= '{dateFrom}' AND Date <= '{dateTo}' AND Status = '{status}'");
            this.status = SqlConnect.GetInfo($"SELECT TOP (1) [Status] FROM [Storage].[dbo].[Products] WHERE id = {i} and Date >= '{dateFrom}' AND Date <= '{dateTo}' AND Status = '{status}'");
            date = SqlConnect.GetInfo($"SELECT TOP (1) [Date] FROM [Storage].[dbo].[Products] WHERE id = {i} and Date >= '{dateFrom}' AND Date <= '{dateTo}' AND Status = '{status}'");
            quantity = Convert.ToInt32(SqlConnect.GetInfo($"SELECT TOP (1) [Quantity] FROM [Storage].[dbo].[Products] WHERE id = {i} and Date >= '{dateFrom}' AND Date <= '{dateTo}' AND Status = '{status}'"));
            category = SqlConnect.GetInfo($"SELECT TOP (1) [CategoryName] FROM [Storage].[dbo].[Products] WHERE id = {i} and Date >= '{dateFrom}' AND Date <= '{dateTo}' AND Status = '{status}'");
            company = SqlConnect.GetInfo($"SELECT TOP (1) [CompanyName] FROM [Storage].[dbo].[Products] WHERE id = {i} and Date >= '{dateFrom}' AND Date <= '{dateTo}' AND Status = '{status}'");
        }

        public Product(int i, string status)
        {
            id = i;
            name = SqlConnect.GetInfo($"SELECT TOP (1) [ProductName] FROM [Storage].[dbo].[Products] WHERE id = {i} AND Status = '{status}'");
            this.status = SqlConnect.GetInfo($"SELECT TOP (1) [Status] FROM [Storage].[dbo].[Products] WHERE id = {i} AND Status = '{status}'");
            date = SqlConnect.GetInfo($"SELECT TOP (1) [Date] FROM [Storage].[dbo].[Products] WHERE id = {i} AND Status = '{status}'");
            quantity = Convert.ToInt32(SqlConnect.GetInfo($"SELECT TOP (1) [Quantity] FROM [Storage].[dbo].[Products] WHERE id = {i} AND Status = '{status}'"));
            category = SqlConnect.GetInfo($"SELECT TOP (1) [CategoryName] FROM [Storage].[dbo].[Products] WHERE id = {i} AND Status = '{status}'");
            company = SqlConnect.GetInfo($"SELECT TOP (1) [CompanyName] FROM [Storage].[dbo].[Products] WHERE id = {i} AND Status = '{status}'");
        }

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public int Quantity
        {
            get { return quantity; }
        }

        public string Status
        {
            get { return status; }
        }

        public string Date
        {
            get { return date; }
        }
        public string Category
        {
            get { return category; }
        }

        public string Company
        {
            get { return company; }
        }
        public static List<Product> GetProductsMod(string column, string condition)
        {
            var list = new List<Product>();
            int length = GetIdsMod(column, condition) + 1;
            for (int i = 1; i < length; i++)
            {
                try
                {
                    list.Add(new Product(i, column, condition));
                }
                catch
                {
                    length++;
                }
            }
            return list;
        }
        private static int GetIdsMod(string column, string condition)
        {
            return Convert.ToInt32(SqlConnect.GetInfo($"SELECT count(id) FROM [Storage].[dbo].[Products] where [{column}] = '{condition}'"));
        }

        public static void SellProduct(int id)
        {
            SqlConnect.ChangeSomeArr($"UPDATE [Storage].[dbo].[products] SET status = 'Sold' WHERE  id = {id}");
        }
    }
}
