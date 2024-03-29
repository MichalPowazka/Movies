﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public abstract class EntityBase<T>
    {
        public T Id {get; set;}
        public DateTime CreateDate { get; set;}
        public DateTime ModifyDate { get; set; }
    }
}
