using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Entidades.DataFirst;
using Capa.Negocio;

namespace Capa.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            ShippersNegocio shippersNegocio = new ShippersNegocio();
            List<Shippers> shippers = shippersNegocio.GetShippers();
            foreach (Shippers shipper in shippers)
            {
                Console.WriteLine(shipper.CompanyName);
            }
            Console.ReadKey();
        }
    }
}
