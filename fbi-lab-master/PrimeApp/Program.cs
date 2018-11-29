using System;

namespace PrimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var srv = new Prime.Services.PrimeService();

            var prim = srv.PrimeName("Vlad Lukyanenko otlichnik,Sasha Stupin");

            Console.WriteLine($"PrimeName: {prim}");

            Console.ReadLine();
        }
    }
}
