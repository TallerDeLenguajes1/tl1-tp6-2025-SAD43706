// See https://aka.ms/new-console-template for more information
using System;
int operacion;
float num1,num2,num3;
string numOp,nume1,nume2,deno,nume3;
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
    } while (operacion <= 4 || operacion >= 13);
    if (operacion<=6)
    {
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
        }  while (!int.TryParse(nume1, out num1) && !int.TryParse(nume2, out num2));
    }else
    {
        do
        {
            Console.WriteLine("Ingrese el Numero:");
            nume3 = Console.ReadLine();
            float.TryParse(nume3, out num3);
            if (!float.TryParse(nume3, out num3))
            {
                Console.WriteLine("☺ INGRESE UN NUMERO ☺");
            }
        } while (!float.TryParse(nume3, out num3));
    }
    
    switch (operacion)
    {
        case 5:
            Console.WriteLine($"{maximo(num1,num2)}");
            break;
        case 6:
            Console.WriteLine($"{minimo(num1,num2)}");
            break;
        case 7:
            Console.WriteLine($"{valorAbs(num3)}");
            break;
        case 8:
            Console.WriteLine($"{cuadrado(num3)}");
            break;
        case 9:
            Console.WriteLine($"{raiz(num3)}");
            break;
        case 10:
            Console.WriteLine($"{seno(num3)}");
            break;
        case 11:
            Console.WriteLine($"{coseno(num3)}");
            break;
        case 12:
            Console.WriteLine($"{parteEnt(num3)}");
            break;
        default:
            break;
    }
    Console.WriteLine("Desea realizar otra operacion(s/n)");
    status = Console.ReadLine();
} while (status == 's');


float valorAbs(float num3)
{
    return Math.Abs(num3);
}
float cuadrado(float num3)
{
    return Math.Pow(num3,2);
}
float raiz(float num3)
{
    return Math.Sqrt(num3);
}
float seno(float num3)
{
    return Math.sin(num3);
}
float coseno(float num3)
{
    return Math.Cos(num3);
}
int parteEnt()
{
    return (int)num3;
}
float maximo(float max1,float max2)
{
    if (max1 > max2)
    {
        return printf("El maximo es: %f", max1);
    }
    else
    {
        return printf("El maximo es: %f", max2);
    }
}
float minimo(float min1,float min2)
{
    if (max1 < max2)
    {
        return printf("El minimo es: %f", max1);
    }
    else
    {
        return printf("El minimo es: %f", max2);
    }
}