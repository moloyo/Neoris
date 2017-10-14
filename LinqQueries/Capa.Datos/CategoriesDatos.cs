using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Entidades.Northwind;

namespace Capa.Datos
{
    public class CategoriesDatos
    {
        public List<Categories> GetAll()
        {
            using (NorthwindModel northwind = new NorthwindModel())
            {
                return northwind.Categories.ToList();
            }
        }
    }
}
