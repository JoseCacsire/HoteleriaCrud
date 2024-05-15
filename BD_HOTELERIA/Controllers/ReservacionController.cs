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
    public class ReservacionController : Controller
    {
		HOTELERIA_SQLContext bd = new HOTELERIA_SQLContext();
		// GET: ReservacionController
		public ActionResult ReservacionListado(int?page)
        {
			var listado = bd.Reservacions.Include(h => h.IdHabitacionNavigation)
                .Include(j => j.IdUsuarioNavigation).Where(i => i.Eliminado.Equals(0)).ToList().OrderBy(i => i.IdReservacion);

			return View(listado.ToPagedList(page ?? 1, 10));
		}

        // GET: ReservacionController/Details/5
        public ActionResult ReservacionDetalles(int id)
        {
			Reservacion reservacion = null;
			try { reservacion = bd.Reservacions.Include(h => h.IdHabitacionNavigation).Include(j => j.IdUsuarioNavigation).Where(i => i.IdReservacion.Equals(id)).ToList().First(); } catch { }
			return View(reservacion);
		}

        // GET: ReservacionController/Create
        public ActionResult ReservacionGrabar()
        {
			Reservacion reservacion = new Reservacion();

			ViewBag.USUARIOS = new SelectList(bd.Usuarios.ToList(), "IdUsuario", "Nombre");
			ViewBag.HABITACIONES = new SelectList(bd.Habitacions.ToList(), "IdHabitacion", "NumeroHabitacion");
			ViewBag.MENSAJE = "";
			return View(reservacion);
		}

        // POST: ReservacionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ReservacionGrabar(Reservacion reservacion)
        {
			if (ModelState.IsValid)
			{
				bd.Reservacions.Add(reservacion);
				bd.SaveChanges();
				ViewBag.MENSAJE = "RESERVACION REGISTRADA CORRECTAMENTE";
			}
			ViewBag.USUARIOS = new SelectList(bd.Usuarios.ToList(), "IdUsuario", "Nombre");
			ViewBag.HABITACIONES = new SelectList(bd.Habitacions.ToList(), "IdHabitacion", "NumeroHabitacion");

			return View();
		}

        // GET: ReservacionController/Edit/5
        public ActionResult ReservacionEditar(int id)
        {
			Reservacion reservacion = bd.Reservacions.Find(id);

			ViewBag.USUARIOS = new SelectList(bd.Usuarios.ToList(), "IdUsuario", "Nombre");
			ViewBag.HABITACIONES = new SelectList(bd.Habitacions.ToList(), "IdHabitacion", "NumeroHabitacion");
			ViewBag.MENSAJE = "";
			return View(reservacion);
		}

        // POST: ReservacionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ReservacionEditar(int id, Reservacion reservacion)
        {
			bd.Entry(reservacion).State = EntityState.Modified;
			bd.SaveChanges();
			ViewBag.MENSAJE = "Reservacion : " + reservacion.IdReservacion + " actualizada correctamente";
			ViewBag.USUARIOS = new SelectList(bd.Usuarios.ToList(), "IdUsuario", "Nombre");
			ViewBag.HABITACIONES = new SelectList(bd.Habitacions.ToList(), "IdHabitacion", "NumeroHabitacion");
			return View();
		}

        // GET: ReservacionController/Delete/5
        public ActionResult ReservacionEliminar(int id)
        {
			Reservacion reservacion = null;
			try { reservacion = bd.Reservacions.Include(h => h.IdHabitacionNavigation).Include(j => j.IdUsuarioNavigation).Where(i => i.IdReservacion.Equals(id)).ToList().First(); } catch { }
			return View(reservacion);
		}

        // POST: ReservacionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ReservacionEliminar(int id, IFormCollection collection)
        {
			Reservacion reservacion = bd.Reservacions.Find(id);
			reservacion.Eliminado = 1;
			bd.SaveChanges();
			return Redirect("~/Reservacion/ReservacionListado");
		}
    }
}
