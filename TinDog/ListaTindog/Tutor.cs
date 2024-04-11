using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTindog
{
    internal class Tutor {
        internal enum Generos
        {
             Feminino,
             Masculino
        }
    
        public string? Nome { get; set; }

        public int Idade { get; set; }

        public string Sobrenome { get; set; }

        public int Numero { get; set; }

        public Generos Genero { get; set; }

        public Endereco Endereco { get; set; }

        public List<Pet> Pets;

        public Tutor() { 
            Pets = new List<Pet>();
            Endereco = new Endereco();
        }
    
    }
}
