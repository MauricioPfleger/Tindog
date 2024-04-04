using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTindog
{
    internal class Tutor {
        internal enum Genero
        {
         Feminino,
         Masculino
        }
    
        public string? Nome { get; set; }

        public int Idade { get; set; }

        public Genero Generos { get; set; }

        public List<Pet> Pets;
        public Tutor() {
            Pets = new List<Pet>();
        }
    
    }
}
