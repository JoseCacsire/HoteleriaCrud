using Microsoft.AspNetCore.Mvc;

using BD_HOTELERIA.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BD_HOTELERIA.Controllers
{
	public class ConsultasController : Controller
	{

		HOTELERIA_SQLContext bd = new HOTELERIA_SQLContext();

		public IActionResult usuario_reservaciones(int idUsuario = 0)
		{
			var listado = bd.Usuario_Por_Reservaciones.FromSqlRaw<usuario_por_reservaciones>($"pa_usuarios_por_reservaciones {idUsuario}").ToList();
			ViewBag.LISTA_USUARIOS = new SelectList(bd.Usuarios.ToList(), "IdUsuario", "Nombre");

			decimal SumaPrecios = 0;
			foreach (var i in listado) { SumaPrecios += i.precio; }
			ViewBag.SUMAPRECIOS = SumaPrecios;
			ViewBag.TOTAL = listado.Count();
			return View(listado);
		}

		public ActionResult HabitacionDetalles(int id) 
		{
			Habitacion habitacion = bd.Habitacions.Find(id);
			return View(habitacion);
		}
		public IActionResult servicio_gastos (int idServicio = 0)
		{
			var listado = bd.Servicio_Por_Gastos.FromSqlRaw<servicio_por_gastos>($"pa_servicio_por_gastos {idServicio}").ToList();
			ViewBag.LISTA_SERVICIOS = new SelectList(bd.Servicios.ToList(), "IdServicio", "Descripcion");

			decimal SumaPrecios = 0;
			foreach (var i in listado) { SumaPrecios += i.total; }
			ViewBag.SUMAPRECIOS = SumaPrecios;
			ViewBag.TOTAL = listado.Count();
			return View(listado);
		}
		public ActionResult UsuarioDetalles(int id)
		{
			Usuario usuario = bd.Usuarios.Include(h => h.IdPaisNavigation).Where(i => i.IdUsuario.Equals(id)).ToList().First();
			return View(usuario);
		}
		public IActionResult habitaciones_piso_tipo(int idTipoHabitacion = 0, int piso = 0)
		{
			var listado = bd.Habitaciones_Piso_Tipos.FromSqlRaw<habitaciones_piso_tipo>($"pa_habitaciones_piso_tipo {idTipoHabitacion}, {piso}").ToList();
			ViewBag.LISTA_TIPOHABITACIONES = new SelectList(bd.TipoHabitacions.ToList(), "IdTipoHabitacion", "Categoria");
			ViewBag.PISOS = new SelectList(new List<int>() {1,2,3,4,5,6,7,8,9,10});
			ViewBag.TOTAL = listado.Count();
			return View(listado);
		}
		public IActionResult reservaciones_caras(int idTipoHabitacion = 0, int precio = 0)
		{
			var listado = bd.Reservaciones_Caras.FromSqlRaw<reservaciones_caras>($"pa_reservaciones_caras {idTipoHabitacion}, {precio}").ToList();
			ViewBag.LISTA_TIPOHABITACIONES = new SelectList(bd.TipoHabitacions.ToList(), "IdTipoHabitacion", "Categoria");
			ViewBag.TOTAL = listado.Count();
			return View(listado);
		}
	}
}
