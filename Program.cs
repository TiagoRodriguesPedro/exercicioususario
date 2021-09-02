using System;

namespace exercicioususario
{
    class Program
    { 
         static void Main(string[] args)
        { 
            string nomeUsuario;

            Console.WriteLine("Digite o seu  nome!");
            nomeUsuario =Console.ReadLine();

            Console.WriteLine($"Ola, {nomeUsuario}");
        }
    }
}
