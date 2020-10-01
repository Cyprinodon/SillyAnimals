using SillyAnimals.Subjects;
using System;

namespace SillyAnimals.Main
{
    class Program
    {
        static void Main()
        {
            var lion = new Animal("lion", "dindon");
            Console.WriteLine("Salut, royaume des animaux !");
            Console.WriteLine(lion.PresentSelf());
            Console.WriteLine("Au revoir, royaume des animaux !");
            Console.ReadKey();
        }
    }
}
