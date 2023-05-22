using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Price : BaseEntity
    {

        public decimal Prices { get; set; }
        public Product Product { get; set; }
    }
}
