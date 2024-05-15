using BD_HOTELERIA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace BD_HOTELERIA.Controllers
{
	public class HabitacionController : Controller
	{

		HOTELERIA_SQLContext bd = new HOTELERIA_SQLContext();
		// GET: HabitacionController
		public ActionResult HabitacionListado(int?page)
		{
			var listado = bd.Habitacions.Include(h => h.IdTipoHabitacionNavigation).Where(i => i.Eliminado.Equals(0)).ToList();

			return View(listado.ToPagedList(page ?? 1,10));

		}

		// GET: HabitacionController/Details/5
		public ActionResult HabitacionDetalles(int id)
		{
			Habitacion habitacion = bd.Habitacions.Find(id);
			return View(habitacion);
		}

		// GET: HabitacionController/Create
		public ActionResult HabitacionGrabar()
		{
			Habitacion habitacion = new Habitacion();

			ViewBag.ESTADOS = new SelectList(new List<string>() {"DISPONIBLE","RESERVADO","OCUPADO"});
			ViewBag.TIPOHABITACIONES = new SelectList(bd.TipoHabitacions.ToList(),"IdTipoHabitacion","Categoria");
			ViewBag.MENSAJE = "";
			return View(habitacion);
		}

		// POST: HabitacionController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult HabitacionGrabar(Habitacion habitacion)
		{
			if (ModelState.IsValid) 
			{
				bd.Habitacions.Add(habitacion);
				bd.SaveChanges();
				ViewBag.MENSAJE = "HABITACION REGISTRADA CORRECTAMENTE";				
			}
			ViewBag.ESTADOS = new SelectList(new List<string>() { "DISPONIBLE", "RESERVADO", "OCUPADO" });
			ViewBag.TIPOHABITACIONES = new SelectList(bd.TipoHabitacions.ToList(), "IdTipoHabitacion", "Categoria");

			return View();
		}

		// GET: HabitacionController/Edit/5
		public ActionResult HabitacionEditar(int id)
		{
			Habitacion habitacion = bd.Habitacions.Find(id);
			ViewBag.ESTADOS = new SelectList(new List<string>() { "DISPONIBLE", "RESERVADO", "OCUPADO" });
			ViewBag.TIPOHABITACIONES = new SelectList(bd.TipoHabitacions.ToList(), "IdTipoHabitacion", "Categoria");
			ViewBag.MENSAJE = "";	
			return View(habitacion);
		}

		// POST: HabitacionController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult HabitacionEditar(int id, Habitacion habitacion)
		{
			bd.Entry(habitacion).State = EntityState.Modified;
			bd.SaveChanges();
			ViewBag.MENSAJE = "Habitacion : " + habitacion.IdHabitacion + " actualizada correctamente";
			ViewBag.ESTADOS = new SelectList(new List<string>() { "DISPONIBLE", "RESERVADO", "OCUPADO" });
			ViewBag.TIPOHABITACIONES = new SelectList(bd.TipoHabitacions.ToList(), "IdTipoHabitacion", "Categoria");
			return View();
		}

		// GET: HabitacionController/Delete/5
		public ActionResult HabitacionEliminar(int id)
		{
			Habitacion habitacion = bd.Habitacions.Find(id);
			return View(habitacion);
		}

		// POST: HabitacionController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult HabitacionEliminar(int id, IFormCollection collection)
		{
			Habitacion habitacion = bd.Habitacions.Find(id);
			habitacion.Eliminado = 1;
			bd.SaveChanges();
			return Redirect("~/Habitacion/HabitacionListado");
		}
	}
}
