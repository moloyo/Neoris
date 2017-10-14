using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa.Entidades.DataFirst;
using Capa.Negocio;

namespace Capa.Presentacion.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            CategoriesNegocio categoriesNegocio = new CategoriesNegocio();
            List<Categories> categories = categoriesNegocio.GetCategories();
            return View(categories);
        }

        // GET: Categories/Details/5
        public ActionResult Details(int id)
        {
            CategoriesNegocio categoriesNegocio = new CategoriesNegocio();
            Categories categorie = categoriesNegocio.GetOne(id);
            return View(categorie);
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Categories categorie = new Categories();
                categorie.CategoryName = collection["CategoryName"];
                categorie.Description = collection["Description"];
                CategoriesNegocio categoriesNegocio = new CategoriesNegocio();
                categoriesNegocio.AddCategorie(categorie);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(int id)
        {
            CategoriesNegocio categoriesNegocio = new CategoriesNegocio();
            Categories categorie = categoriesNegocio.GetOne(id);
            return View(categorie);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                CategoriesNegocio categoriesNegocio = new CategoriesNegocio();
                Categories categorie = categoriesNegocio.GetOne(id);
                categorie.CategoryName = collection["CategoryName"];
                categorie.Description = collection["Description"];
                categorie.Picture = null;
                categoriesNegocio.EditarCategorie(categorie);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int id)
        {
            CategoriesNegocio categoriesNegocio = new CategoriesNegocio();
            Categories categorie = categoriesNegocio.GetOne(id);
            return View(categorie);
        }

        // POST: Categories/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                CategoriesNegocio categoriesNegocio = new CategoriesNegocio();
                categoriesNegocio.DeleteCategorie(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
