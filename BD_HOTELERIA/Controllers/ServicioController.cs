using BD_HOTELERIA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace BD_HOTELERIA.Controllers
{
    public class ServicioController : Controller
    {
		HOTELERIA_SQLContext bd = new HOTELERIA_SQLContext();

		// GET: ServicioController
		public ActionResult ServicioListado(int?page)
        {
			var listado = bd.Servicios.Include(h => h.IdTipoServicioNavigation).Where(i => i.Eliminado.Equals(0)).ToList();

			return View(listado.ToPagedList(page ?? 1, 10));
		}

        // GET: ServicioController/Details/5
        public ActionResult ServicioDetalles(int id)
        {
			Servicio servicio = bd.Servicios.Include(h => h.IdTipoServicioNavigation).Where(i => i.IdServicio.Equals(id)).ToList().First();
			return View(servicio);
		}

        // GET: ServicioController/Create
        public ActionResult ServicioGrabar()
        {
			Servicio servicio = new Servicio();
			ViewBag.TIPOSERVICIOS = new SelectList(bd.TipoServicios.ToList(), "IdTipoServicio", "NombreServicio");
			ViewBag.MENSAJE = "";
			return View(servicio);
		}

        // POST: ServicioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ServicioGrabar(Servicio servicio)
        {

			if (ModelState.IsValid)
			{
				bd.Servicios.Add(servicio);
				bd.SaveChanges();
				ViewBag.MENSAJE = "SERVICIO REGISTRADO CORRECTAMENTE";
			}
			ViewBag.TIPOSERVICIOS = new SelectList(bd.TipoServicios.ToList(), "IdTipoServicio", "NombreServicio");

			return View();

		}

        // GET: ServicioController/Edit/5
        public ActionResult ServicioEditar(int id)
        {
            Servicio servicio = bd.Servicios.Find(id);
			ViewBag.TIPOSERVICIOS = new SelectList(bd.TipoServicios.ToList(), "IdTipoServicio", "NombreServicio");
			ViewBag.MENSAJE = "";
			return View(servicio);
		}

        // POST: ServicioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ServicioEditar(int id, Servicio servicio)
        {

			bd.Entry(servicio).State = EntityState.Modified;
			bd.SaveChanges();
			ViewBag.MENSAJE = "Servicio : " + servicio.IdServicio + " actualizado correctamente";
			ViewBag.TIPOSERVICIOS = new SelectList(bd.TipoServicios.ToList(), "IdTipoServicio", "NombreServicio");
			return View();

		}

        // GET: ServicioController/Delete/5	
        public ActionResult ServicioEliminar(int id)
        {
			Servicio servicio = null;
			try { servicio = bd.Servicios.Include(h => h.IdTipoServicioNavigation).Where(i => i.IdServicio.Equals(id)).ToList().First(); }catch {}
			return View(servicio);
		}

        // POST: ServicioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ServicioEliminar(int id, IFormCollection collection)
        {
			Servicio servicio = bd.Servicios.Find(id);
			servicio.Eliminado = 1;
			bd.SaveChanges();
			return Redirect("~/Servicio/ServicioListado");

		}
    }
}
