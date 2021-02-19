using LABORATORIO_01._1.Helper; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LABORATORIO_01._1.Models
{
    public class PlayerM
    {
        public string Name { get; set; }
        public string LastN { get; set; }
        public string Position { get; set;}
        public int Income { get; set; }
        public string Club { get; set; }
        public bool Save()
        {
            try
            {
                Storage.Instance.Playerslist.Add(this);
                return true;
            }
            catch 
            {

                return false; 
            }
        }
    }
}