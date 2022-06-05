using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class OrderPayment:IEntity
    {
        public int OrderId { get; set; }
        public int OrderType { get; set; }
        public decimal Price { get; set; }
        public string Bank { get; set; }


    }
    public enum _OrderType
    {
        Havale=0,
        KrediKLartı=1
    }
}
