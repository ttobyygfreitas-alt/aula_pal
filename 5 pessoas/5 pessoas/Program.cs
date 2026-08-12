int idade;
double qntd=0;
for (int i = 0; i <= 5; i++)
{

    Console.WriteLine("digite a idade das 5 pessoas: ");
    idade = int.Parse(Console.ReadLine());

    if (idade >= 18)
    {
        qntd = qntd + 1;
    }
}
Console.WriteLine("a quantidade de pessoas maiores de idade e de " + qntd);