using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.entidades
{
    public class address
    {
        public int address_id { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public DateTime district  { get; set; }
        public int city_id { get; set; }
        public string postal_code{ get; set; }
        public string phone { get; set; }
        public string last_update { get; set; }
       



        

    }
}
