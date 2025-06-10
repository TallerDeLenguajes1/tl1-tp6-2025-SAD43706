// See https://aka.ms/new-console-template for more information
int operacion;
string numOp;
int status=1;
do
{

    Console.WriteLine("Ingrese la operacion que desea Realizar");
    numOp = Console.ReadLine();
    bool test = int.TryParse(numOp, out operacion);
    if (!test)
    {
        Console.WriteLine("Ingrese un Numero Valido");
    }
} while (operacion <= 0 || operacion >= 5);
