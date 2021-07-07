using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class ProductExt : Product
    {
        string categoryDesc;
        string companyCountry;

        public ProductExt(int i) : base(i)
        {
            categoryDesc = SqlConnect.GetInfo($"SELECT TOP (1) Description FROM [Storage].[dbo].[Products] RIGHT JOIN [Storage].[dbo].[Categories] ON CategoryName = Category WHERE id = {i}");
            companyCountry = SqlConnect.GetInfo($"SELECT TOP(1) [Country] FROM [Storage].[dbo].[Products] RIGHT JOIN [Storage].[dbo].[Companies] ON CompanyName = Company WHERE id = {i}");
        }

        public ProductExt(int i, DateTime dateFrom, DateTime dateTo) : base(i, dateFrom, dateTo)
        {
            categoryDesc = SqlConnect.GetInfo($"SELECT TOP (1) Description FROM [Storage].[dbo].[Products] RIGHT JOIN [Storage].[dbo].[Categories] ON CategoryName = Category WHERE id = {i} and Date >= '{dateFrom}' AND Date <= '{dateTo}'");
            companyCountry = SqlConnect.GetInfo($"SELECT TOP(1) [Country] FROM [Storage].[dbo].[Products] RIGHT JOIN [Storage].[dbo].[Companies] ON CompanyName = Company WHERE id = {i} and Date >= '{dateFrom}' AND Date <= '{dateTo}'");
        }

        public ProductExt(int i, DateTime dateFrom, DateTime dateTo, string status) : base(i, dateFrom, dateTo, status)
        {
            categoryDesc = SqlConnect.GetInfo($"SELECT TOP (1) Description FROM [Storage].[dbo].[Products] RIGHT JOIN [Storage].[dbo].[Categories] ON CategoryName = Category WHERE id = {i} and Date >= '{dateFrom}' AND Date <= '{dateTo}' AND Status = '{status}'");
            companyCountry = SqlConnect.GetInfo($"SELECT TOP(1) [Country] FROM [Storage].[dbo].[Products] RIGHT JOIN [Storage].[dbo].[Companies] ON CompanyName = Company WHERE id = {i} and Date >= '{dateFrom}' AND Date <= '{dateTo}' AND Status = '{status}'");
        }
        public ProductExt(int i, string status) : base(i, status)
        {
            categoryDesc = SqlConnect.GetInfo($"SELECT TOP (1) Description FROM [Storage].[dbo].[Products] RIGHT JOIN [Storage].[dbo].[Categories] ON CategoryName = Category WHERE id = {i} AND Status = '{status}'");
            companyCountry = SqlConnect.GetInfo($"SELECT TOP(1) [Country] FROM [Storage].[dbo].[Products] RIGHT JOIN [Storage].[dbo].[Companies] ON CompanyName = Company WHERE id = {i} AND Status = '{status}'");
        }

        public string CategoryDesc
        {
            get { return categoryDesc; }
        }
        public string CompanyCountry
        {
            get { return companyCountry; }
        }
        public static List<ProductExt> GetProductExts()
        {
            var list = new List<ProductExt>();
            int length = GetIds() + 1;
            for (int i = 1; i < length; i++)
            {
                try
                {
                    list.Add(new ProductExt(i));
                }
                catch
                {
                    length++;
                }
            }
            return list;
        }
        public static List<ProductExt> GetProductExtsDate(DateTime dateFrom, DateTime dateTo)
        {
            var list = new List<ProductExt>();
            int length = GetIdsReportDate(dateFrom, dateTo) + 1;
            for (int i = 1; i < length; i++)
            {
                try
                {
                    list.Add(new ProductExt(i, dateFrom, dateTo));
                }
                catch
                {
                    length++;
                }
            }
            return list;
        }
        public static List<ProductExt> GetProductExtsDateStatus(DateTime dateFrom, DateTime dateTo, string status)
        {
            var list = new List<ProductExt>();
            int length = GetIdsReportDateStatus(dateFrom, dateTo, status) + 1;
            for (int i = 1; i < length; i++)
            {
                try
                {
                    list.Add(new ProductExt(i, dateFrom, dateTo, status));
                }
                catch
                {
                    length++;
                }
            }
            return list;
        }
        public static List<ProductExt> GetProductExtsStatus(string status)
        {
            var list = new List<ProductExt>();
            int length = GetIdsReportStatus(status) + 1;
            for (int i = 1; i < length; i++)
            {
                try
                {
                    list.Add(new ProductExt(i, status));
                }
                catch
                {
                    length++;
                }
            }
            return list;
        }
        private static int GetIds()
        {
            return Convert.ToInt32(SqlConnect.GetInfo("SELECT count(id) FROM [Storage].[dbo].[Products]"));
        }

        private static int GetIdsReportDate(DateTime dateFrom, DateTime dateTo)
        {
            return Convert.ToInt32(SqlConnect.GetInfo($"SELECT count(id) FROM [Storage].[dbo].[Products] WHERE Date >= '{dateFrom}' AND Date <= '{dateTo}'"));
        }

        private static int GetIdsReportDateStatus(DateTime dateFrom, DateTime dateTo, string status)
        {
            return Convert.ToInt32(SqlConnect.GetInfo($"SELECT count(id) FROM [Storage].[dbo].[Products] WHERE Date >= '{dateFrom}' AND Date <= '{dateTo}' AND Status = '{status}'"));
        }

        private static int GetIdsReportStatus(string status)
        {
            return Convert.ToInt32(SqlConnect.GetInfo($"SELECT count(id) FROM [Storage].[dbo].[Products] WHERE Status = '{status}'"));
        }

        public static void SortByDate(List<ProductExt> productToSort)
        {
            productToSort.Sort(delegate (ProductExt prd1, ProductExt prd2) { return String.Compare(prd1.Date.ToString(), prd2.Date.ToString()); });
        }

        public static void SortByStatus(List<ProductExt> productToSort)
        {
            productToSort.Sort(delegate (ProductExt prd1, ProductExt prd2) { return String.Compare(prd1.Status.ToString(), prd2.Status.ToString()); });
        }
    }
}
