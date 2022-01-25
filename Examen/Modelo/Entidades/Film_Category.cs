using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.entidades
{
    public class Film_Category
    { 
        public int filmID { get; set; }
        public int categoryID { get; set; }
        public string lastUpdate { get; set; }


        public Film Film { get; set; }
        public Category Category { get; set; }

    }
}
