using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Ventus
{
    class Program
    {
        static void Main()
        {
            List<Producto> list;
            list = Test1();
            list = Test2();

            var list2 = new List<string>();
            list2.Add("1");
            list2.Add("2");
            list2.Add("3");
            list2.Add("4");
            list2.Add("5");
            list2.Add("6");
            //var a = Array.ConvertAll(o.ToArray(), Convert.ToInt32);
            var a = list2.Select(o => Convert.ToInt32(o)).ToArray();
            
            //var sum = 0;
            //foreach (var x in a)
            //{
            //    sum += x;
            //}
            Console.WriteLine(a.Sum());
            Console.WriteLine(a.All(o => o < 10));
            Console.WriteLine(a.Any(o => o % 4 == 0));
            Console.WriteLine(a.Count(o => o % 2 == 0));
        }

        private static List<Producto> Test1()
        {
            var ds = Query();
            var list = new List<Producto>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var item = new Producto();
                item.ID = (int)dr["ProductID"];
                item.Name = (string)dr["ProductName"];
                item.CategoryID = (int)dr["CategoryID"];
                item.Price = (decimal)dr["UnitPrice"];
                list.Add(item);
            }
            return list;
        }

        private static List<Producto> Test2()
        {
            var ds = Query();
            var list = (from DataRow dr in ds.Tables[0].Rows
                        select new Producto
                        {
                            ID = (int)dr["ProductID"],
                            Name = (string)dr["ProductName"],
                            CategoryID = (int)dr["CategoryID"],
                            Price = (decimal)dr["UnitPrice"]
                        }).ToList();
            return list;
        }

        private static DataSet Query()
        {
            var cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            var cn = new SqlConnection(cs);
            cn.Open();
            var da = new SqlDataAdapter("SELECT * FROM Products", cn);
            var ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            return ds;
        }
    }
}
