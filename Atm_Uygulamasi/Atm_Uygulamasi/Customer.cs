using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_Uygulamasi
{
    internal class Customer:Abstract
    {
        public int CustomerNumber { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public int ErrorPasswordEntryCount { get; set; }
        public bool Status { get; set; }
        public double Balance { get; set; }
        public int customerTypeId { get; set; }
        public bool openClose { get; set; }
    }
}
