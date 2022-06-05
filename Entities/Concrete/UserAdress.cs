
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public  class UserAdress:IEntity
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public bool IsActive { get; set; }
    }
}
