using ListaTindog;

Informacoes informacoes = new Informacoes();
informacoes.CarregarInformacoes();

var busca = "";
Console.WriteLine("Digite o nome do tutor que deseja buscar as informações: ");
busca = Console.ReadLine();

var tutor = informacoes.Tutores.FirstOrDefault(tutor => tutor.Nome == busca);
if (tutor == null)
{
    Console.WriteLine("Tutor não econtrado!");
}
else
{
    Console.WriteLine($"Pets do {tutor.Nome}");
    Console.WriteLine();
    foreach (var pet in tutor.Pets)
    {
        Console.WriteLine($"Nome do pet: {pet.Nome}");
        Console.WriteLine($"Idade do pet: {pet.Idade}");
        Console.WriteLine($"Peso do pet: {pet.Peso}");
        Console.WriteLine("-----------------------------");
    }
    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine();
}

