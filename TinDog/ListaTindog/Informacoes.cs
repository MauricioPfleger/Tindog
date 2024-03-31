using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ListaTindog
{
    internal class Informacoes
    {
        string[] NomesTutores =
        {
            "Mauricio",
            "Israel",
            "Emilly",
            "Henrique",
            "Arthur",
            "Marye",
            "Ana",
            "Pedro",
            "Beatriz",
            "Gustavo",
            "Larissa",
            "João",
            "Maria",
            "Leonardo",
            "Juliana",
            "Daniel",
            "Carolina",
            "Felipe",
            "Fernanda",
            "Rafael",
            "Natália",
            "Vinícius",
            "Camila",
            "Diego",
            "Amanda",
            "Thiago",
            "Mariana",
            "Bruno",
            "Julia",
            "Mauricio"
        };

        string[] NomesPets =
        {
            "Max",
            "Bela",
            "Thor",
            "Luna",
            "Buddy",
            "Lola",
            "Rocky",
            "Daisy",
            "Charlie",
            "Lucy",
            "Bailey",
            "Molly",
            "Toby",
            "Sadie",
            "Bear",
            "Sophie",
            "Duke",
            "Zoe",
            "Cooper",
            "Maggie",
            "Riley",
            "Chloe",
            "Jackson",
            "Coco",
            "Jake",
            "Roxy",
            "Tucker",
            "Penny",
            "Ollie",
            "Mia"
        };

        Pet.Racas[] RacasPet =
        {
            Pet.Racas.Poodle,
            Pet.Racas.Bulldog_Frances,
            Pet.Racas.Border_Collie,
            Pet.Racas.Beagle,
            Pet.Racas.Caramelo,
            Pet.Racas.Poodle,
            Pet.Racas.Bulldog_Frances,
            Pet.Racas.Border_Collie,
            Pet.Racas.Beagle,
            Pet.Racas.Caramelo,
            Pet.Racas.Poodle,
            Pet.Racas.Bulldog_Frances,
            Pet.Racas.Border_Collie,
            Pet.Racas.Beagle,
            Pet.Racas.Caramelo,
            Pet.Racas.Poodle,
            Pet.Racas.Bulldog_Frances,
            Pet.Racas.Border_Collie,
            Pet.Racas.Beagle,
            Pet.Racas.Caramelo,
            Pet.Racas.Poodle,
            Pet.Racas.Bulldog_Frances,
            Pet.Racas.Border_Collie,
            Pet.Racas.Beagle,
            Pet.Racas.Caramelo,
            Pet.Racas.Poodle,
            Pet.Racas.Bulldog_Frances,
            Pet.Racas.Border_Collie,
            Pet.Racas.Beagle,
            Pet.Racas.Caramelo
        };

        int[] IdadesPets =
        {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            21,
            22,
            23,
            24,
            25,
            26,
            27,
            28,
            29,
            30
        };

        double[] PesosPets =
        {
            4.5,
            4.5,
            4.5,
            4.5,
            4.5,
            5.5,
            5.5,
            5.5,
            5.5,
            5.5,
            6,
            6,
            6,
            6,
            6,
            6.8,
            6.8,
            6.8,
            6.8,
            6.8,
            7,
            7,
            7,
            7,
            7,
            7.5,
            7.5,
            7.5,
            7.5,
            7.5
        };

        public List<Tutor> Tutores;
        public Informacoes()
        {
            Tutores = new List<Tutor>();
        }

        public void CarregarInformacoes()
        {
            for (int i = 0; i < 30; i++)
            {
                bool novo = false;
                var pet = new Pet();
                pet.Nome = NomesPets[i];
                pet.Idade = IdadesPets[i];
                pet.Peso = PesosPets[i];
                pet.Raca = RacasPet[i];

                var tutor = Tutores.FirstOrDefault(p => p.Nome == NomesTutores[i]);
                if (tutor == null)
                {  
                    novo = true;
                    tutor = new Tutor();
                    tutor.Nome = NomesTutores[i];
                }

                tutor.Pets.Add(pet);
                if (novo)
                {
                    Tutores.Add(tutor);
                }
                
            }
        }
    }
}
