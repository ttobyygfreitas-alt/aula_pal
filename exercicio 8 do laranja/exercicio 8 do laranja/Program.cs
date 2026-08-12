string nome, sexo;
int idade;

for (int i = 1; i <= 3; i++)
{
    Console.Write("Digite o nome: ");
    nome = Console.ReadLine();

    Console.Write("Digite a idade: ");
    idade = int.Parse(Console.ReadLine());

    Console.Write("Digite o sexo (M/F): ");
    sexo = Console.ReadLine();

    if ((sexo == "M") && idade >21)
    {
        
     Console.WriteLine("Nome: " + nome);
    }
}