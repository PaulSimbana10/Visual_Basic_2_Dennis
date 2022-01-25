using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.entidades
{
    public class Film
    {
        public int filmID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime releaseYear  { get; set; }
        public int LanguageID { get; set; }
        public string rentalDuration { get; set; }
        public string rentalRate { get; set; }
        public string length { get; set; }
        public decimal replacementCost { get; set; }
        public string rating { get; set; }
        public string lastUpdate { get; set; }
        public string specialFeatures { get; set; }
        public string fullText { get; set; }



        public List<Language> Language { get; set; }

    }
}
