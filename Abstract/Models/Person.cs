using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Models
{
    public abstract class Person
    {
        public string _name { get; set; }
        public string _surname { get; set; }
        public abstract int _age { get; set; }


    }
}
