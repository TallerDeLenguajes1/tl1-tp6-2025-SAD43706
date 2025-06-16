// See https://aka.ms/new-console-template for more information
int operacion, num1, num2;
string numOp,nume1,nume2,deno;
char status = 's';
do
{
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
            Console.WriteLine($"{suma(num1, num2)}");
            break;
        case 2:
            Console.WriteLine($"{resta(num1, num2)}");
            break;
        case 3:
            Console.WriteLine($"{multiplicacion(num1, num2)}");
            break;
        case 4:
            Console.WriteLine($"{division(num1, num2)}");
            break;
        default:
            break;
    }
    Console.WriteLine("Desea realizar otra operacion(s/n)");
    status = Console.ReadLine();
} while (status == 's');


float division(int num1,int num2)
{
    if (num2 == 0)
    {
        Console.WriteLine("!!EL DENOMINADOR NO PUEDE SER 0!!");
        do
        {
            Console.WriteLine("Igrese nuevamente el denominador:");
            deno = Console.ReadLine();
            bool test4 = int.TryParse(deno, out num2);
            if (!test4)
            {
                Console.WriteLine("Ingrese un Numero Valido");
            }
        } while (num2 == 0);
    }
    return num1 / (float)num2;
}
int multiplicacion(int num1, int num2)
{
    return num1 * num2;
}
int resta(int num1,int num2)
{
    return num1 - num2;
}
int suma(int num1,int num2)
{
        return num1 + num2;
}