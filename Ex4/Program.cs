//4 - Faça um programa que leia um número inteiro e mostre todos os números primos até ele, inclusive ele se for primo.

//Declaração de variáveis
int valorInteiro;

//Entrada de dados
Console.WriteLine("Digite o valor inteiro: ");
valorInteiro = int.Parse(Console.ReadLine());
Console.Clear();

//Declaração de variáveis
int numeroAuxiliar = valorInteiro;
bool validador;

//Lógica para verificar se o número é primo e já imprimir os números primos encontrados
while (numeroAuxiliar > 0)
{
    int contador = 0;

    for (int divisor = numeroAuxiliar; divisor > 0; divisor--)
    {
        if (numeroAuxiliar % divisor == 0)
        {
            contador++;
        }
    }

    if (contador == 2)
    {
        validador = true;
    }else
    {
        validador = false;
    }

    if (validador)
    {
        Console.WriteLine(numeroAuxiliar + " ===== (OK)");
    }

    numeroAuxiliar--;
}