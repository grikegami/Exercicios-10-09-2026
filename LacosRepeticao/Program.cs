int contador = 10;

while (contador != 0)
{
    Console.WriteLine(contador);
    contador--;
    Thread.Sleep(1000);
}
Console.WriteLine("Happy new year!");

contador = 10;
do
{
    Console.WriteLine(contador);
    contador--;
    Thread.Sleep(1000);

} while (contador != 0);
Console.WriteLine("Happy new year!");

for (contador = 10; contador != 0; contador--)
{
    Console.WriteLine(contador);
    Thread.Sleep(1000);
}
Console.WriteLine("Happy new year!");
