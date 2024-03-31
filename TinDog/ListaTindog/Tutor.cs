using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTindog
{
    internal class Tutor
    {
        public string? Nome {  get; set; }

        public List<Pet> Pets;
        public Tutor() { 
            Pets = new List<Pet>();
        }
    }
}
