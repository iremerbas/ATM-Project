using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_Uygulamasi
{
    internal class Banka:Abstract
    {
        public int customerId { get; set; }
        public double CommissionAmount { get; set; }
    }
}
