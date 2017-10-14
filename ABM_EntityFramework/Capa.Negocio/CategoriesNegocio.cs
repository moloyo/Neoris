using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Entidades.DataFirst;
using Capa.Datos;

namespace Capa.Negocio
{
    public class CategoriesNegocio
    {
        CategoriesDatos categoriesDatos = new CategoriesDatos();
        public CategoriesNegocio()
        {

        }
        public List<Categories> GetCategories()
        {
            return categoriesDatos.GetCategories();
        }

        public Categories GetOne(int id)
        {
            return categoriesDatos.GetOne(id);
        }

        public void AddCategorie(Categories categorie)
        {
            categoriesDatos.AddCategorie(categorie);
        }

        public void EditarCategorie(Categories categorie)
        {
            categoriesDatos.EditarCategorie(categorie);
        }

        public void DeleteCategorie(int id)
        {
            categoriesDatos.DeleteCategorie(id);
        }
    }
}
