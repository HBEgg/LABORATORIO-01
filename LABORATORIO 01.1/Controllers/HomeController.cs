using LABORATORIO_01._1.Models;
using LABORATORIO_01._1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO; 

namespace LABORATORIO_01._1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new List<PlayerM>());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase datafile)
        {
            List<PlayerM> players = new List<PlayerM>();
            string Pathfile = string.Empty;
            if (Pathfile != null)
            {
                string direction = Server.MapPath("~/Data/");
                if (!Directory.Exists(direction))
                {
                    Directory.CreateDirectory(direction);
                }
                Pathfile = direction + Path.GetFileName(datafile.FileName);
                string fileextension = Path.GetExtension(datafile.FileName);
                datafile.SaveAs(Pathfile);
                string fileinfo = System.IO.File.ReadAllText(Pathfile);
                foreach (string row in fileinfo.Split('\n'))
                {
                    if (!string.IsNullOrEmpty(row))
                    {
                        players.Add(new PlayerM
                        {
                            Name = row.Split(',')[0],
                            LastN = row.Split(',')[1],
                            Position = row.Split(',')[2],
                            Income = Convert.ToInt32(row.Split(',')[3]),
                            Club = row.Split(',')[4],
                        });
                    }
                }
            }
            return View(players); 
        }
    } 
}