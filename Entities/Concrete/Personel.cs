 using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Personel:IEntity
    {
        //CUSTOM MAPPING ILE ALAKALI
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
    }
}
