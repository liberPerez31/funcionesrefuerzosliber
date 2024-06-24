using System;

class Progra
{
    static Random random = new Random();

    static int LanzarDado()
    {
        return random.Next(1, 7); // Genera un número entre 1 y 6
    }

    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            int dado1 = LanzarDado();
            int dado2 = LanzarDado();

            Console.WriteLine($"Dado 1: {dado1} | Dado 2: {dado2}");

            Console.Write("¿Quieres volver a lanzar? (s/n): ");
            string respuesta = Console.ReadLine();

            continuar = (respuesta.ToLower() == "s");
        }

        Console.WriteLine("¡Gracias por jugar!");
    }
}
