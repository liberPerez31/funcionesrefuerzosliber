using System;

class Programm
{
    static bool EsPrimo(int numero)
    {
        if (numero < 2)
            return false;

        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
                return false; // No es primo
        }

        return true; // Es primo
    }

    static void Main()
    {
        Console.Write("Ingresa el número máximo del rango: ");
        int maximo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Números primos encontrados:");

        for (int num = 2; num <= maximo; num++)
        {
            if (EsPrimo(num))
                Console.Write(num + " ");
        }

        Console.WriteLine();
    }
}
