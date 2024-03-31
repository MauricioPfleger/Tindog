// c# = portugol
// string = cadeia
// double = real
// int = inteiro
// char = caracter
// bool = logico

string[] tutor = { "Mauricio", "Emilly", "Israel", "Arthur", "Henrique" };
int[] idadeTutor = { 31, 13, 18, 12, 12 };
string[] pet = { "Ted", "Billy", "Bolinha", "Frajola", "Luk" };
int[] idadePet = { 1, 2, 3, 4, 5 };
double[] peso = { 6.5, 4, 3.5, 6, 3.3 };

int i;
string busca;

Console.WriteLine("BEM VINDO AO TINDOG");

Console.WriteLine("*******************************************");

Console.WriteLine("Informe o nome do tutor para buscar informações");
busca = Console.ReadLine();

for (i = 0; i < 5; i++)
{
    if (tutor[i] == busca)
    {
        Console.WriteLine($"Cadastro da posição: {i + 1}");
        Console.WriteLine($"Tutor: {tutor[i]}");
        Console.WriteLine($"Idade do Tutor: {idadeTutor[i]}");
        Console.WriteLine($"Pet: {pet[i]}");
        Console.WriteLine($"Idade do Pet: {idadePet[i]}");
        Console.WriteLine($"Peso: {peso[i]}");
        Console.WriteLine("-------------------------");
    }
}