using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Entidades.DataFirst;

namespace Capa.Datos
{
    public class CategoriesDatos
    {
        public CategoriesDatos()
        {
                            
        }

        public List<Categories> GetCategories()
        {
            using (NorthwindModel northwind = new NorthwindModel())
            {
                List<Categories> listCategories = northwind.Categories.ToList();
                return listCategories;
            }
        }

        public Categories GetOne(int id)
        {
            using (NorthwindModel northwind = new NorthwindModel())
            {
                return northwind.Categories.FirstOrDefault(s => s.CategoryID == id);
            }
        }

        public void AddCategorie(Categories shipper)
        {
            using (NorthwindModel northwind = new NorthwindModel())
            {
                northwind.Categories.Add(shipper);
                northwind.SaveChanges();
            }
        }

        public void EditarCategorie(Categories categ)
        {
            using (NorthwindModel northwind = new NorthwindModel())
            {
                DeleteCategorie(categ.CategoryID);
                AddCategorie(categ);
                northwind.SaveChanges();
            }
        }

        public void DeleteCategorie(int id)
        {
            using (NorthwindModel northwind = new NorthwindModel())
            {
                Categories shipDelete = northwind.Categories.FirstOrDefault(s => s.CategoryID == id);
                northwind.Categories.Remove(shipDelete);
                northwind.SaveChanges();
            }
        }
    }
}
