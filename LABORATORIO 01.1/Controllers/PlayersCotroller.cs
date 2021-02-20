using LABORATORIO_01._1.Models;
using LABORATORIO_01._1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.IO;

namespace LABORATORIO_01._1.Controllers
{
    public class PlayersCotroller : Controller
    {
        public static List<PlayerM> playerslist = new List<PlayerM>();
        // GET: Jugadores
        public ActionResult Index()
        {
            ViewBag.UniqueList = playerslist;
            return View();
        }
        //CREATE
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(IformCollection player)
        {

        }
    }
}
