using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.entidades
{
    public class Film_Actor
    {

        public int actorID { get; set; }
        public int filmID { get; set; }
        public string lastUpdate { get; set; }


        public Film Film { get; set; }
        public Actor Actor { get; set; }
    }
}
