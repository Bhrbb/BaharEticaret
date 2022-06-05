using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public UserAdress userAdress { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public decimal TotalProductPrice { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual  List<OrderPayment> OrderPayments { get; set; }
        public virtual List<OrderProducts>OrderProducts { get; set; }


    }
}
