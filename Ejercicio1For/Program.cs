Console.Write("Ingrese el número 1: ");
int numero1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el número 2: ");
int numero2 = int.Parse(Console.ReadLine());

int resultado = Multiplicar(numero1, numero2);

Console.WriteLine("El producto es:" +resultado+ "");

int Multiplicar(int a, int b)
{
    int resultado = 0;

    if (a < 0 && b < 0)
    {
        a = -a;
        b = -b;
    }

    for (int i = 0; i < Math.Abs(b); i++)
    {
        resultado = resultado + a;
    }

    return resultado;
}