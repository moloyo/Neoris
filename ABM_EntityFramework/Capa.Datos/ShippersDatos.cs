using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Entidades.DataFirst;

namespace Capa.Datos
{
    public class ShippersDatos
    {
        public ShippersDatos()
        {
                            
        }

        public List<Shippers> GetShippers()
        {
            using (NorthwindModel northwind = new NorthwindModel())
            {
                List<Shippers> listShippers = northwind.Shippers.ToList();
                return listShippers;
            }
        }

        public Shippers GetOne(int id)
        {
            using (NorthwindModel northwind = new NorthwindModel())
            {
                return northwind.Shippers.FirstOrDefault(s => s.ShipperID == id);
            }
        }

        public void AddShipper(Shippers shipper)
        {
            using (NorthwindModel northwind = new NorthwindModel())
            {
                northwind.Shippers.Add(shipper);
                northwind.SaveChanges();
            }
        }

        public void EditarShipper(Shippers shipper)
        {
            using (NorthwindModel northwind = new NorthwindModel())
            {
                Shippers shipDelete = northwind.Shippers.FirstOrDefault(s => s.ShipperID == shipper.ShipperID);
                northwind.Shippers.Remove(shipDelete);
                northwind.Shippers.Add(shipper);
                northwind.SaveChanges();
            }
        }

        public void DeleteShipper(int id)
        {
            using (NorthwindModel northwind = new NorthwindModel())
            {
                Shippers shipDelete = northwind.Shippers.FirstOrDefault(s => s.ShipperID == id);
                northwind.Shippers.Remove(shipDelete);
                northwind.SaveChanges();
            }
        }
    }
}
