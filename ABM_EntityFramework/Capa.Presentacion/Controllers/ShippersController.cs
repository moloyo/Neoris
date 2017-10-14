using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa.Entidades.DataFirst;
using Capa.Negocio;

namespace Capa.Presentacion.Controllers
{
    public class ShippersController : Controller
    {
        // GET: Shippers
        public ActionResult Index()
        {
            ShippersNegocio shippersNegocio = new ShippersNegocio();
            List<Shippers> shippers = shippersNegocio.GetShippers();
            return View(shippers);
        }

        // GET: Shippers/Details/5
        public ActionResult Details(int id)
        {
            ShippersNegocio shippersNegocio = new ShippersNegocio();
            Shippers shipper = shippersNegocio.GetOne(id);
            return View(shipper);
        }

        // GET: Shippers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shippers/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Shippers shipper =  new Shippers();
                shipper.CompanyName = collection["CompanyName"];
                shipper.Phone = collection["Phone"];
                ShippersNegocio shippersNegocio = new ShippersNegocio();
                shippersNegocio.AddShipper(shipper);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Shippers/Edit/5
        public ActionResult Edit(int id)
        {
            ShippersNegocio shippersNegocio = new ShippersNegocio();
            Shippers shipper = shippersNegocio.GetOne(id);
            return View(shipper);
        }

        // POST: Shippers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                ShippersNegocio shippersNegocio = new ShippersNegocio();
                Shippers shipper = shippersNegocio.GetOne(id);
                shipper.CompanyName = collection["CompanyName"];
                shipper.Phone = collection["Phone"];
                shippersNegocio.EditarShipper(shipper);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Shippers/Delete/5
        public ActionResult Delete(int id)
        {
            ShippersNegocio shippersNegocio = new ShippersNegocio();
            Shippers shipper = shippersNegocio.GetOne(id);
            return View(shipper);
        }

        // POST: Shippers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                ShippersNegocio shippersNegocio = new ShippersNegocio();
                shippersNegocio.DeleteShipper(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
