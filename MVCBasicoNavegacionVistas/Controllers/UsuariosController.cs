using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasicoNavegacionVistas.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListaUsuarios()
        {
            List<string> listUsuarios = new List<string>();
            listUsuarios.Add("Fernando");
            listUsuarios.Add("Gustavo");
            listUsuarios.Add("Carlos");
            listUsuarios.Add("Alfredo");
            listUsuarios.Add("Felipe");
            listUsuarios.Add("Roman");
            listUsuarios.Add("Ricardo");

            //ViewBag.ListaUsuarios=listUsuarios;
            //TempData["listaUsuarios"]=listUsuarios;
            Session["listaUsuarios"] = listUsuarios;


            return View(listUsuarios);

        }
        [HttpPost]
        public ActionResult ListaUsuarios(string selUsuarios)
        {
            ViewBag.Nombre=selUsuarios;
            //List<string> listUsuarios = (List<string>)TempData["listaUsuarios"];
            List<string> listUsuarios = (List<string>)Session["listaUsuarios"];

            return View(listUsuarios);

        }
    }
}