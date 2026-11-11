int valorInteiro;

Console.WriteLine("Digite o valor inteiro: ");
valorInteiro = int.Parse(Console.ReadLine());

bool condicao;

if (valorInteiro <= 0)
{
    Console.WriteLine("O valor digitado não é válido. Digite um número inteiro maior que zero.");
    condicao = false;
}
else if (valorInteiro > 0 && valorInteiro == 1)
{
    Console.WriteLine("O valor digitado não é um número primo. ");
    condicao = false;
}
else if (valorInteiro > 1)
{
    for (int i = 2; i < valorInteiro; i++)
    {
        if (valorInteiro % i == 0)
        {
            Console.WriteLine("O valor digitado não é um número primo. ");
            condicao = false;
            break;
        }
    }
}
else
{
    Console.WriteLine("O valor digitado é um número primo. ");
    condicao = true;
}
