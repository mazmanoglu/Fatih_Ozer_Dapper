using DapperLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperLibrary.Models
{
    public class Campus : ICampus
    {
        public int CampusNr { get; set; }
        public string Naam { get; set; }
        public string Straat { get; set; }
        public string HuisNr { get; set; }
        public string PostCode { get; set; }
        public string Gemeente { get; set; }

        public override string ToString()
        {
            return $"{Naam}";
        }
    }
}
