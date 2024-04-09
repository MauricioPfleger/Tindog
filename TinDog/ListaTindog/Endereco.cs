using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static ListaTindog.Pet;

namespace ListaTindog
{
    internal class Endereco: Brasil
    {
        public string? Rua {  get; set; }
        public int Numero { get; set; }
        public string? Cidade { get; set; }
        public Estados Estado { get; set; }

        public static string ToDisplayString(Estados estado)
        {
            switch (estado)
            {
                case Estados.Amapa:
                    return "Amapá";
                case Estados.Ceara:
                    return "Ceará";
                case Estados.Goias:
                    return "Goiás";
                case Estados.Maranhao:
                    return "Maranhão";
                case Estados.Para:
                    return "Pará";
                case Estados.Paraiba:
                    return "Paraíba";
                case Estados.Parana:
                    return "Paraná";
                case Estados.Piaui:
                    return "Piauí";
                case Estados.Rondonia:
                    return "Rondônia";
                case Estados.Sao_Paulo:
                    return "São Paulo";

                default:
                    return estado.ToString().Replace("_", " ");
            }
        }
    }
}
