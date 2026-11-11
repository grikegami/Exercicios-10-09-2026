int valor;
int contador = 0;
int resultado;

Console.WriteLine("Digite um valor inteiro: ");
valor = int.Parse(Console.ReadLine());

while (contador <= 10)
{
    resultado = valor * contador;
    Console.WriteLine($"{valor} x {contador} = {resultado}");
    contador++;
}