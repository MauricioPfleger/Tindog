using ListaTindog;

internal class Program
{
    private static void Main(string[] args)
    {
        Informacoes informacoes = new Informacoes();
        informacoes.CarregarInformacoes();

        var busca = "";
        Console.WriteLine("Digite o nome do tutor que deseja buscar as informações: ");
        busca = Console.ReadLine();

        Console.WriteLine(Pet.ToDisplayString(Pet.Racas.Bulldog_Ingles));

        var tutor = informacoes.Tutores.FirstOrDefault(tutor => tutor.Nome == busca);
        if (tutor == null)
        {
            Console.WriteLine("Tutor não econtrado!");
        }
        else
        {
            Console.WriteLine($"Pets do {tutor.Nome}");
            Console.WriteLine($"Idade do tutor: {tutor.Idade}");
            Console.WriteLine();
            foreach (var pet in tutor.Pets)
            {
                Console.WriteLine($"Nome do pet: {pet.Nome}");
                Console.WriteLine($"Raça do pet: {Pet.ToDisplayString(pet.Raca)}");
                Console.WriteLine($"Idade do pet: {pet.Idade}");
                Console.WriteLine($"Peso do pet: {pet.Peso}");
                Console.WriteLine($"Genero do pet: {pet.Genero}");
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine();
            Console.WriteLine("===========================================");
            Console.WriteLine();
        }
    }
}