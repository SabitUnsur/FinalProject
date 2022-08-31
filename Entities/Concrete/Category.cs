using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //Çıplak Class kalmamalı
    public class Category:IEntity
    {   public int Categoryıd { get; set; }
        public string CategoryName { get; set; } 
    }
}
