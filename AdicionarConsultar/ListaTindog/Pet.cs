using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ListaTindog
{
    internal class Pet
    {
        internal enum Racas
        {
            Labrador_Retriever = 1,
            Golden_Retriever = 2,
            Bulldog_Ingles = 3,
            Bulldog_Frances = 4,
            Beagle = 5,
            Poodle = 6 ,
            Boxer = 7,
            Dachshund_Teckel = 8,
            Yorkshire_Terrier = 9,
            Chihuahua = 10,
            Pastor_Alemao = 11,
            Husky_Siberiano = 12,
            Shih_Tzu = 13,
            Rottweiler = 14,
            Border_Collie = 15,
            Cocker_Spaniel = 16,
            Doberman_Pinscher = 17,
            Great_Dane_Dogue_Alemao = 18,
            Maltese = 19,
            Pug = 20,
            Cavalier_King_Charles_Spaniel = 21,
            Bichon_Frise = 22,
            Boston_Terrier = 23,
            Australian_Shepherd = 24,
            Staffordshire_Bull_Terrier = 25,
            Caramelo = 26
        }

        public string? Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public Racas Raca {  get; set; }
        public Pet() { }
    }
}
