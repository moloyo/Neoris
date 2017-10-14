using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Capa.Entidades.Northwind;
using Capa.Datos;

namespace Capa.Logica
{
    public class QueriesLogica
    {
        readonly CustomersDatos cusDatos = new CustomersDatos();
        readonly ProductsDatos prodDatos = new ProductsDatos();
        readonly OrderDatos orderDatos = new OrderDatos();
        readonly CategoriesDatos catDatos = new CategoriesDatos();
        public QueriesLogica()
        {

        }

        public IEnumerable<Customers> Query1()
        {

            var customers = from c in cusDatos.GetAll()
                            select c;
            return customers;
        }
        public IEnumerable<Products> Query2()
        {

            var products = from p in prodDatos.GetAll()
                           where p.UnitsInStock == 0
                            select p;
            return products;
        }
        public IEnumerable<Products> Query3()
        {

            var products = from p in prodDatos.GetAll()
                           where p.UnitsInStock != 0 && p.UnitPrice > 3
                           select p;
            return products;
        }
        public IEnumerable<Customers> Query4()
        {
            //Acá y en todas las ocasiones se reemplazo "Washinton" por "London" porque no había clientes de esa primer ciudad
            var customers = cusDatos.GetAll().Where(c => c.City == "London");
            return customers;
        }
        public IEnumerable<String> Query5()
        {

            var productsNames = from p in prodDatos.GetAll()
                            select p.ProductName;
            return productsNames;
        }
        public IEnumerable<String> Query6()
        {

            var customers = from c in cusDatos.GetAll()
                            select c.ContactName.ToLower() + " " + c.ContactName.ToUpper();
            return customers;
        }
        public IEnumerable<Object> Query7()
        {

            var customers = from c in cusDatos.GetAll()
                            join o in orderDatos.GetAll()
                            on c.CustomerID equals o.CustomerID
                            where c.City.Equals("London")
                            && DateTime.Compare(new DateTime(1997, 1, 1, 12, 0, 0), (DateTime)o.OrderDate) <= 0
                            select new {c.ContactName , c.City, o.OrderID, o.OrderDate} ;
            return customers;
        }
        public IEnumerable<Customers> Query8()
        {

            var customers = cusDatos.GetAll().Where(c => c.City == "London").Take(3);
            return customers;
        }
        public IEnumerable<Products> Query9()
        {

            var products = prodDatos.GetAll().OrderBy(p => p.ProductName);
            return products;
        }
        public IEnumerable<Products> Query10()
        {

            var products = prodDatos.GetAll().OrderByDescending(p => p.UnitsInStock);
            return products;
        }
        public IEnumerable<Object> Query11()
        {

            var prodCat = from p in prodDatos.GetAll()
                join c in catDatos.GetAll()
                    on p.CategoryID equals c.CategoryID
                select new {p.ProductName, c.CategoryName};
                            
            return prodCat;
        }
        public Products Query12()
        {

            var product = prodDatos.GetAll().First();
            return product;
        }
        public Products Query13()
        {
            //No hay producto con ese ID, se manejo el valor nulo en interfaz
            var product = prodDatos.GetAll().FirstOrDefault(p => p.ProductID == 789);
            return product;
        }
        public IEnumerable<Object> Query14()
        {

            var custOrders = from order in orderDatos.GetAll()
                group order by order.CustomerID
                into orderList
                select new
                {
                    Cliente = orderList.Key,
                    Ordenes = orderList.Count()
                };
                             
            return custOrders.OrderBy(c => c.Cliente);
        }
    }
}
