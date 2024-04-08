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
            Labrador_Retriever,
            Golden_Retriever,
            Bulldog_Ingles,
            Bulldog_Frances,
            Beagle,
            Poodle,
            Boxer,
            Dachshund_Teckel,
            Yorkshire_Terrier,
            Chihuahua,
            Pastor_Alemao,
            Husky_Siberiano,
            Shih_Tzu,
            Rottweiler,
            Border_Collie,
            Cocker_Spaniel,
            Doberman_Pinscher,
            Great_Dane_Dogue_Alemao,
            Maltese,
            Pug,
            Cavalier_King_Charles_Spaniel,
            Bichon_Frise,
            Boston_Terrier,
            Australian_Shepherd,
            Staffordshire_Bull_Terrier,
            Caramelo
        }

        public string? Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public Racas Raca {  get; set; }


        public Pet() { }

        public static string ToDisplayString(Racas raca)
        {
            switch (raca)
            {
                case Racas.Labrador_Retriever:
                    return "Labrador Retriever";
                case Racas.Golden_Retriever:
                    return "Golden Retriever";
                case Racas.Bulldog_Ingles:
                    return "Bulldog Inglês";
                case Racas.Bulldog_Frances:
                    return "Bulldog Francês";
                case Racas.Beagle:
                    return "Beagle";
                case Racas.Poodle:
                    return "Poodle";
                case Racas.Boxer:
                    return "Boxer";
                case Racas.Dachshund_Teckel:
                    return "Dachshund (Teckel)";
                case Racas.Yorkshire_Terrier:
                    return "Yorkshire Terrier";
                case Racas.Chihuahua:
                    return "Chihuahua";
                case Racas.Pastor_Alemao:
                    return "Pastor Alemão";
                case Racas.Husky_Siberiano:
                    return "Husky Siberiano";
                case Racas.Shih_Tzu:
                    return "Shih Tzu";
                case Racas.Rottweiler:
                    return "Rottweiler";
                case Racas.Border_Collie:
                    return "Border Collie";
                case Racas.Cocker_Spaniel:
                    return "Cocker Spaniel";
                case Racas.Doberman_Pinscher:
                    return "Doberman Pinscher";
                case Racas.Great_Dane_Dogue_Alemao:
                    return "Great Dane (Dogue Alemão)";
                case Racas.Maltese:
                    return "Maltês";
                case Racas.Pug:
                    return "Pug";
                case Racas.Cavalier_King_Charles_Spaniel:
                    return "Cavalier King Charles Spaniel";
                case Racas.Bichon_Frise:
                    return "Bichon Frisé";
                case Racas.Boston_Terrier:
                    return "Boston Terrier";
                case Racas.Australian_Shepherd:
                    return "Pastor Australiano";
                case Racas.Staffordshire_Bull_Terrier:
                    return "Staffordshire Bull Terrier";
                case Racas.Caramelo:
                    return "Caramelo";

                default:
                    return raca.ToString().Replace("_", " ");
            }
        }
    }
}
