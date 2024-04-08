using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTindog
{
    internal class Brasil
    {
        public enum Estados {
            Acre,
            Alagoas,
            Amapa,
            Amazonas,
            Bahia,
            Ceara,
            Distrito_Federal,
            Espirito_Santo,
            Goias,
            Maranhao,
            Mato_Grosso,
            Mato_Grosso_do_Sul,
            Minas_Gerais,
            Para,
            Paraiba,
            Parana,
            Pernambuco,
            Piaui,
            Rio_de_Janeiro,
            Rio_Grande_do_Norte,
            Rio_Grande_do_Sul,
            Rondonia,
            Roraima,
            Santa_Catarina,
            Sao_Paulo,
            Sergipe,
            Tocantins
        }

        public string? Pais { get; set; }

        public Brasil() {
            Pais = "Brasil";
        }
    }
}
