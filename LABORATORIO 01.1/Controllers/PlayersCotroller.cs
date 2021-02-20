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
        //public ActionResult Create()
        //{
        //    PlayerM NewPlayer = new PlayerM();
        //    NewPlayer.Name = player["Name"];
        //    NewPlayer.LastN = player["LastN"];
        //    NewPlayer.Club = player["Club"];
        //    NewPlayer.Position = player["Position"];
        //    NewPlayer.Income = player["Income"];
        //    playerslist.Add(NewPlayer);
        //    ViewBag.UniqueList = playerslist;
        //    return View("Index");
        //}
        //EDIT
        




        public ActionResult CreateFile(FormCollection collection)
        {
            StreamReader streamReader = new StreamReader(collection["path"]);
            var playerslist = (streamReader.ReadToEnd()).Split('\r');

            for (int i = 0; i < playerslist.Length; i++)
            {
                if (playerslist[i][0] == '\r')
                {
                    playerslist[i] = playerslist[i].Substring(i);
                }

            }

            foreach (var details in playerslist)
            {
                var detailsList = details.Split(',');
                PlayerM player1 = new PlayerM
                {
                    Name = detailsList[0],
                    LastN = detailsList[1],
                    Club = detailsList[2],
                    Position = detailsList[3],
                    Income = Convert.ToInt32(detailsList[4]),
                    ID = Convert.ToInt32(detailsList[5])
                };
                //Storage.Instance.playerList.AddFirst(jugador1);
            }
            return RedirectToAction("Index");      
        }

    } 
}
