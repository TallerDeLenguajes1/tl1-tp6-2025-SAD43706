// See https://aka.ms/new-console-template for more information
int operacion, num1, num2, suma, resta, multi;
float divi;
string numOp,nume1,nume2;
char status = 's';
do
{

    Console.WriteLine("Ingrese la operacion que desea Realizar");
    numOp = Console.ReadLine();
    bool test1 = int.TryParse(numOp, out operacion);
    if (!test1)
    {
        Console.WriteLine("Ingrese un Numero Valido");
    }
} while (operacion <= 0 || operacion >= 5);
do
{
    Console.WriteLine("Ingrese los Numeros:");
    nume1 = Console.ReadLine();
    nume2 = Console.ReadLine();
    int.TryParse(nume1, out num1);
    int.TryParse(nume2, out num2);
    if (!int.TryParse(nume1, out num1) && !int.TryParse(nume2, out num2))
    {
        Console.WriteLine("☺ INGRESE NUMEROS ☺");
    }
} while (!int.TryParse(nume1, out num1) && !int.TryParse(nume2, out num2));

switch (operacion)
{
    case 1:
        suma = num1 + num2;
        Console.WriteLine($"La suma de {num1} + {num2} es igual a {suma}");
        break;
    case 2:
        resta = num1 - num2;
        break;
    case 3:
        break;
    case 4:
        break;
    default:
        break;
}