// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string texto,texto2,completo,subtexto;
int longitud;
Console.WriteLine("Ingrese el texto:");
texto = Console.ReadLine();
longitud = texto.lenght;
Console.WriteLine($"La Longitud del texto es:{longitud}");
Console.WriteLine("Ingrese el segundo texto:");
texto2 = Console.ReadLine();
completo = string.Concat(texto, texto2);
Console.WriteLine($"{completo}");
subtexto = texto.Subtring(0, 4);
Console.WriteLine($"El subtexto es:{completo}");

