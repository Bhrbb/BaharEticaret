﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
    }
}