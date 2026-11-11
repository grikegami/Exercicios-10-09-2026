//3- Faça um programa que leia um número inteiro e mostre primeiramente todos os valores ímpares (Na ordem crescente) e depois os valores pares (Na ordem decrescente).

int entrada;

Console.WriteLine("Digite um número inteiro: ");
entrada = int.Parse(Console.ReadLine());

//ordem crescente impares  
for (int i = 0; i < entrada; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine($"Números ímpares até {entrada}: {i}");
    }
}

//ordem decrescente pares
for (int i = entrada; i >= 0; i--)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"Números pares até {entrada}: {i}");
    }
}