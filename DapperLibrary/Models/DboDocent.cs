using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperLibrary.Models
{
    public class DboDocent : IDboDocent
    {
        public int DocentNr { get; set; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public decimal Wedde { get; set; }
        public Campus CampusNr { get; set; }

        public override string ToString()
        {
            return $"{Voornaam} {Familienaam}";
        }
    }
}
