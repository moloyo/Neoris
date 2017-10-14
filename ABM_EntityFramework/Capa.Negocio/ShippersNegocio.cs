using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Entidades.DataFirst;
using Capa.Datos;

namespace Capa.Negocio
{
    public class ShippersNegocio
    {
        ShippersDatos shippersDatos = new ShippersDatos();
        public ShippersNegocio()
        {

        }
        public List<Shippers> GetShippers()
        {
            return shippersDatos.GetShippers();
        }

        public Shippers GetOne(int id)
        {
            return shippersDatos.GetOne(id);
        }

        public void AddShipper(Shippers shipper)
        {
            shippersDatos.AddShipper(shipper);
        }

        public void EditarShipper(Shippers shipper)
        {
            shippersDatos.EditarShipper(shipper);
        }

        public void DeleteShipper(int id)
        {
            shippersDatos.DeleteShipper(id);
        }
    }
}
