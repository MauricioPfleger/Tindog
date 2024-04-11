using ListaTindog;

internal class Program
{
    private static void Main(string[] args)
    {
        var informacoes = new Informacoes();
        informacoes.CarregarInformacoes();

        var busca = "";
        Console.WriteLine("Digite o nome do tutor que deseja buscar as informações: ");
        busca = Console.ReadLine();

        Console.Clear();

        var tutor = informacoes.Tutores.FirstOrDefault(tutor => tutor.Nome == busca);
        if (tutor == null)
        {
            Console.WriteLine("Tutor não econtrado!");
        }
        else
        {
            Console.WriteLine($"Nome e sobrenome do tutor: {tutor.Nome} {tutor.Sobrenome}");
            Console.WriteLine($"Idade do tutor: {tutor.Idade}");
            Console.WriteLine($"Genêro do tutor: {tutor.Genero}");
            Console.WriteLine($"número do tutor; {tutor.Numero}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Endereço do tutor");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Rua: {tutor.Endereco.Rua}");
            Console.WriteLine($"Número: {tutor.Endereco.Numero}");
            Console.WriteLine($"Cidade: {tutor.Endereco.Cidade}");
            Console.WriteLine($"Estado: {Endereco.ToDisplayString(tutor.Endereco.Estado)}");
            Console.WriteLine($"País: {tutor.Endereco.Pais}");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Pets");
            Console.WriteLine("-----------------------------");
            foreach (var pet in tutor.Pets)
            {
                Console.WriteLine($"Nome: {pet.Nome}");
                Console.WriteLine($"Raça: {Pet.ToDisplayString(pet.Raca)}");
                Console.WriteLine($"Idade: {pet.Idade}");
                Console.WriteLine($"Peso: {pet.Peso}");
                Console.WriteLine($"Genêro: {pet.Genero}");
                Console.WriteLine($"Quantidade de vacinas: {pet.Vacinas}");
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine();
            Console.WriteLine("===========================================");
            Console.WriteLine();
        }
    }
}