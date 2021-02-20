using LABORATORIO_01._1.Helper; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using LABORATORIO_01._1.Controllers;
using LABORATORIO_01._1.Models;

namespace LABORATORIO_01._1.Models
{
    public class PlayerM :IComparable
    {
        public int ID { get; set; }
        static int Id;
        public string Name { get; set; }
        public string LastN { get; set; }
        [Required]
        public string Position { get; set;}
        public int Income { get; set; }
        public string Club { get; set; }
        public PlayerM()
        {
            Id++;
            ID = Id;
        }
        
        public static Comparison<PlayerM> FindById = delegate (PlayerM player1, PlayerM player2)
        {
            return player1.CompareTo(player2);
        };
        public static Comparison<PlayerM> FindByIncome = delegate (PlayerM player1, PlayerM player2)
        {
            return player1.CompareTo(player2);
        };
        public int CompareTo(object obj)
        {
            var comparer = ((PlayerM)obj).ID;
            return comparer < 1 ? 1 : comparer == Income ? 0 : -1;
        }
    }
}