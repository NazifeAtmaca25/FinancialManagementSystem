using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financal_Management_System.model
{
    public class OrderModel
    {
        public int Order_ID { get; set; }
        public int Daily_Amount { get; set; }
        public DateTime Dates { get; set; }
    }
}
