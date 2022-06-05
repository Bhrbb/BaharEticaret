using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Brand { get; set; }
        public int ModelId { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Tax { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
        public int Discount { get; set; }

    }
}
