//5- Faça um programa que leia um número inteiro e exiba o seu cálculo fatorial e o resultado.

Console.WriteLine("Digite um número inteiro: ");
int numeroInteiro = int.Parse(Console.ReadLine());

long fatorial = numeroInteiro;

for (int i = numeroInteiro - 1; i > 0; i--)
{
    fatorial = fatorial * i;
}
Console.WriteLine($"O fatorial de {numeroInteiro} é {fatorial}");