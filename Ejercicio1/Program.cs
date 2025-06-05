// See https://aka.ms/new-console-template for more information
string s;
Console.WriteLine("Ingrese un numerox:");
s = Console.ReadLine();
int num;
bool resultado =int.TryParse(s, out num);
if (resultado)
{
    if (num > 0)
    {
        float inversion = 1f / num;
        Console.WriteLine($"El resultado de 1/{num}  es:{inversion}");
    }
    else
    {
        Console.WriteLine("Ingrese un numero mayor que 0");
    }
}
else
{
    Console.WriteLine("Entrada no valida");
}
