using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Entidades.Northwind;

namespace Capa.Datos
{
    public class OrderDatos
    {
        public List<Orders> GetAll()
        {
            using (NorthwindModel northwind = new NorthwindModel())
            {
                return northwind.Orders.ToList();
            }
        }
    }
}
