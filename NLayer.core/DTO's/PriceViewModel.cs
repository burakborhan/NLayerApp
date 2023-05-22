using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTO_s
{
    public class PriceViewModel : BaseDTO
    {
        public decimal CurrentPrice { get; set; }
        public decimal OldPrice { get; set; }
        public decimal OldPrice2 { get; set; }
        public decimal OldPrice3 { get; set; }
        public decimal OldPrice4 { get; set; }
    }
}
