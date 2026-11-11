//2 - Faça um programa que leia um número inteiro, esse número é a posição até onde a sequência fibonacci será exibida.


int entrada, a = 0, b = 1, c;

Console.WriteLine("Digite um número inteiro: ");
entrada = int.Parse(Console.ReadLine());

for (int i = 0; i < entrada; i++)
{
    Console.Write($"{a} + {b} = ");
    c = a + b;
    a = b;
    b = c;
    Console.WriteLine(c);
}
