int N;
double soma=0;

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine("digite os 10 numeros: ");
    N = int.Parse(Console.ReadLine());
    soma = soma + N;
    Console.WriteLine("a soma e de " + soma);
}
