using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_Uygulamasi
{
    internal class Process : Abstract
    {
        public int CustomerId { get; set; }
        public int ProcessTypeId { get; set; }
        public int Amount { get; set; } //İşlem Tutarı
    }
}
