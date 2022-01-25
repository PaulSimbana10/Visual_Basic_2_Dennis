using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.entidades
{
    public class payment
    {

        public int payment_id { get; set; }
        public int customer_id { get; set; }
        public string staff_id { get; set; }
        public string rental_id { get; set; }
        public string amount { get; set; }

        public string paymentdate { get; set; }


      
    }
}
