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
        string[] SobrenomesTutores =
        {
            "Pfleger", 
            "Souza", 
            "Silva", 
            "Queiroz", 
            "Santos", 
            "Vissovati", 
            "Fabris", 
            "Nardelli", 
            "Mundi", 
            "Marques", 
            "Fernandes", 
            "Junior", 
            "Jacques", 
            "Lionel", 
            "Juari", 
            "Fonseca", 
            "Danielo", 
            "Kairo", 
            "Pavonsk", 
            "Vera", 
            "Aparecida", 
            "Adrano", 
            "Schultz", 
            "Hardt", 
            "Vitória", 
            "Tibum", 
            "Yohr", 
            "Wesley", 
            "Alvez", 
            "Rato", 
            "Dionisio"
        };
        int[] IdadesTutores =
        {
            15,
            25,
            35,
            45,
            55,
            65,
            75,
            85,
            90,
            12,
            14,
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
        Tutor.Generos[] GenerosTutor =
        {
            Tutor.Generos.Masculino,
            Tutor.Generos.Masculino,
            Tutor.Generos.Feminino,
            Tutor.Generos.Masculino,
            Tutor.Generos.Feminino,
            Tutor.Generos.Masculino,
            Tutor.Generos.Feminino,
            Tutor.Generos.Masculino,
            Tutor.Generos.Feminino,
            Tutor.Generos.Masculino,
            Tutor.Generos.Feminino,
            Tutor.Generos.Masculino,
            Tutor.Generos.Feminino,
            Tutor.Generos.Masculino,
            Tutor.Generos.Feminino,
            Tutor.Generos.Masculino,
            Tutor.Generos.Feminino,
            Tutor.Generos.Masculino,
            Tutor.Generos.Feminino,
            Tutor.Generos.Masculino,
            Tutor.Generos.Feminino,
            Tutor.Generos.Masculino,
            Tutor.Generos.Feminino,
            Tutor.Generos.Masculino,
            Tutor.Generos.Feminino,
            Tutor.Generos.Masculino,
            Tutor.Generos.Feminino,
            Tutor.Generos.Masculino,
            Tutor.Generos.Feminino,
            Tutor.Generos.Masculino
        };
        int[] NumerosTutores =
        { 
            3652827,
            3652829,
            5326527,
            8364536,
            4875562,
            3265547,
            4755687,
            8745646,
            7864674,
            5738992,
            7434689,
            8936456,
            6934877,
            6873887,
            9847474,
            1361462,
            4637826,
            2876543,
            8765843,
            3892563,
            2636578,
            1987566,
            2847846,
            7854676,
            3744573,
            7835546,
            1947465,
            4984345,
            9876554,
            3456589,
            2637885

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

        Pet.Generos[] GenerosPet =

        {
          Pet.Generos.Macho,
          Pet.Generos.Femea,
          Pet.Generos.Macho,
          Pet.Generos.Femea,
          Pet.Generos.Macho,
          Pet.Generos.Femea,
          Pet.Generos.Macho,
          Pet.Generos.Femea,
          Pet.Generos.Macho,
          Pet.Generos.Femea,
          Pet.Generos.Macho,
          Pet.Generos.Femea,
          Pet.Generos.Macho,
          Pet.Generos.Femea,
          Pet.Generos.Macho,
          Pet.Generos.Femea,
          Pet.Generos.Macho,
          Pet.Generos.Femea,
          Pet.Generos.Macho,
          Pet.Generos.Femea,
          Pet.Generos.Macho,
          Pet.Generos.Femea,
          Pet.Generos.Macho,
          Pet.Generos.Femea,
          Pet.Generos.Macho,
          Pet.Generos.Femea,
          Pet.Generos.Macho,
          Pet.Generos.Femea,
          Pet.Generos.Macho,
          Pet.Generos.Femea

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
        int[] VacinaPet =
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

        bool[] PedigreePet =
        {
            true,
            false,
            true,
            false,
            false,
            true,
            false,
            false,
            false,
            true,
            true,
            false,
            true,
            false,
            false,
            true,
            false,
            false,
            false,
            true,
            true,
            false,
            true,
            false,
            false,
            true,
            false,
            false,
            false,
            true,

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
                pet.Genero = GenerosPet[i];   
                pet.Nome = NomesPets[i];
                pet.Idade = IdadesPets[i];
                pet.Peso = PesosPets[i];
                pet.Raca = RacasPet[i];
                pet.Vacinas = VacinaPet[i];
                pet.Pedigree = PedigreePet[i];

                var tutor = Tutores.FirstOrDefault(p => p.Nome == NomesTutores[i]);
                if (tutor == null)
                {
                    novo = true;
                    tutor = new Tutor();
                    tutor.Nome = NomesTutores[i];
                    tutor.Sobrenome = SobrenomesTutores[i];
                    tutor.Idade = IdadesTutores[i];
                    tutor.Genero = GenerosTutor[i];
                    tutor.Numero = NumerosTutores[i];
                    tutor.Endereco.Rua = "Floriano Peixoto";
                    tutor.Endereco.Numero = 12;
                    tutor.Endereco.Cidade = "Florianópolis";
                    tutor.Endereco.Estado = Brasil.Estados.Santa_Catarina;
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
