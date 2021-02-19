using LABORATORIO_01._1.Models;
using LABORATORIO_01._1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LABORATORIO_01._1.Controllers
{
    public class PlayersCotroller : Controller
    {
        // GET: Jugadores
        public ActionResult Index()
        {
            return View();
        }

        // GET: Jugadores/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Jugadores/Create
        public ActionResult Create()
        {
            return View(); 
        }

        // POST: Jugadores/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var player = new PlayerM
                {
                    Name = collection["Name"],
                    LastN = collection["Last Name"],
                    Position = collection["Position"],
                    Income = int.Parse(collection["Income"]),
                    Club = collection["Club"],
                };
                if (player.Save())
                {
                    return (RedirectToAction("Index"));
                }
                else
                {
                    return View(player);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Jugadores/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

       /* [HttpGet]
        public ActionResult Edit(int ID)
        {
            PlayerM player = new PlayerM();
            Dataplayer dataplay = new Dataplayer(); 
        }*/

        // POST: Jugadores/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Jugadores/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Jugadores/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
