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