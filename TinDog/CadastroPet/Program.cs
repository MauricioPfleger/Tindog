// See https://aka.ms/new-console-template for more information

// Variáveis
using CadastroPet;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] nomeTutor = new string[10] { "Mauricio", "Emilly", "Israel", "Arthur", "Henrique", "Marye", "Maria", "Junior", "Isa", "Pedro" };
        string[] nomePet = new string[10] { "Ted", "Salsicha", "Bolinha", "Avatar", "Floquinho", "Frajola", "Luk", "Miau", "Chico", "Leco" };
        int[] idadeTutor = new int[10] { 31, 13, 18, 12, 12, 17, 45, 35, 22, 27 };
        int[] idadePet = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        double[] peso = new double[10] { 6.5, 7.5, 8.5, 9.5, 10.5, 11.5, 12.5, 13.5, 14.5, 15.5 };
        List<Tutor> listaTutores = new List<Tutor>();
        Pet pet;
        Tutor tutor;

        int i;

        Console.WriteLine("BEM VINDO AO TINDOG");

        // Armazenando todos os registros na lista
        for (i = 0; i < 10; i++)
        {
            tutor = listaTutores.FirstOrDefault(x => x.Nome == nomeTutor[i]);
            if (tutor != null)
            {
                pet = new Pet();
                pet.Nome = nomePet[i];
                pet.Idade = idadeTutor[i];
                pet.Peso = peso[i];
                tutor.Pets.Add(pet);
            }
            else
            {
                tutor = new Tutor();
                tutor.Nome = nomeTutor[i];
                tutor.Idade = idadeTutor[i];
                pet = new Pet();
                pet.Nome = nomePet[i];
                pet.Idade = idadePet[i];
                pet.Peso = peso[i];
                tutor.Pets.Add(pet);
                listaTutores.Add(tutor);
            }
        }

        Console.WriteLine("********************************");

        Console.WriteLine("Digite o nome do tutor para buscar seus pets:");
        BuscarAnimaisPeloNomeTutor(Console.ReadLine());

        void BuscarAnimaisPeloNomeTutor(string nomeTutor)
        {
            var tutor = listaTutores.FirstOrDefault(x => x.Nome == nomeTutor);
            if (tutor == null)
                Console.WriteLine("Tutor não encontrado!");
            else
            {
                Console.WriteLine($"Pets do: {tutor.Nome}");
                Console.WriteLine();
                foreach (var pet in tutor.Pets)
                {
                    Console.WriteLine($"Pet: {pet.Nome}");
                    Console.WriteLine($"Idade: {pet.Idade}");
                    Console.WriteLine($"Peso: {pet.Peso}");
                    Console.WriteLine("-------------------------");
                }
            }
        }
    }
}