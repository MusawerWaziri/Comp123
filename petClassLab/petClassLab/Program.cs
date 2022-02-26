using System;
using petClassLab.Models;
using System.Collections.Generic;

namespace petClassLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet cat = new Pet("Tom",12, "Hates Jerry");
            Pet dog = new Pet("Scooby", 7, "Cool");
            Pet cat2 = new Pet("Garfield", 10, "Loves lasagna");
            Pet bird = new Pet("Tweety", 3, "Very small");

            List<Pet> pets = new List<Pet>();
            pets.Add(cat);
            pets.Add(dog);
            pets.Add(cat2);
            pets.Add(bird);

            cat.SetOwner("Bob");
            cat.Train();
            dog.Train();
            cat2.SetOwner("Jim");

            Console.WriteLine("All Pets");
            foreach(object Pet in pets)
            {
                Console.WriteLine($"{Pet}");
            }

            Console.Write("Enter an owner's name: ");
            string name = Console.ReadLine();
            foreach(Pet pet in pets)
            {
                if (pet.Owner == name)
                {
                    Console.WriteLine("They own the following: ");
                    Console.WriteLine($"{pet}");
                    break;
                }
                else
                {
                    Console.WriteLine("They are not an owner");
                    break;
                }
            }
        }
    }
}
