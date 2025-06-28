// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string texto, texto2, completo, subtexto,palabra;
int longitud;
Console.WriteLine("Ingrese el texto:");
texto = Console.ReadLine();
longitud = texto.Trim().Length;
Console.WriteLine($"La Longitud del texto es:{longitud}");
Console.WriteLine("Ingrese el segundo texto:");
texto2 = Console.ReadLine();
completo = string.Concat(texto, texto2);
Console.WriteLine($"{completo}");
subtexto = texto.Substring(0, 4);
Console.WriteLine($"El subtexto es:{subtexto}");
foreach (char letra in texto)
{
    Console.WriteLine($"{letra}\n");
}
Console.WriteLine("Ingrese la Palabra:");
palabra = Console.ReadLine();
if (texto.ToLower().Contains(palabra.ToLower()))
{
    Console.WriteLine("La Palabra Si se encuentra");
}
else
{
    Console.WriteLine("La Palabra NO se encuentra");
}
Console.WriteLine($"En mayusculas: {texto.ToUpper()}");
Console.WriteLine($"En minusculas: {texto.ToLower()}");
Console.WriteLine("Ingrese una cadena separada por ; :");
string cadena = Console.ReadLine();
foreach (string cosa in cadena.Split(';'))
{
    Console.WriteLine($"{cosa}\n");
}
