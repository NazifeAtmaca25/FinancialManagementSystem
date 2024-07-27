using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financal_Management_System.model
{
    public class FinancialModel
    {
        public int FS_ID { get; set; }
        public DateTime Dates { get; set; }
        public int Gross_Profit { get; set; }
        public int Revenue { get; set; }
        public int Expense { get; set; }
    }
}
