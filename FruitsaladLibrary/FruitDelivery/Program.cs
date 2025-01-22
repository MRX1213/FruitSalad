using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitsaladLibrary;

namespace FruitDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Strawberry sweetStrawberry = new Strawberry("Bright red", 15.0, true, true, 9);
            Strawberry sourStrawberry = new Strawberry("Light red", 10.0, false, false, 4);
            // Creating a Fruit Salad
            var salad = new FruitSalad(new List<Fruit> { sweetStrawberry, sourStrawberry }, 3);
            // Testing ToStrings()
            Console.WriteLine(salad.ToString());
            salad.Add(new Strawberry("Dark Red", 20.0, true, true, 10));
            Console.WriteLine(salad.ToString());
            // Testing Servings
            Console.WriteLine(salad.Serve());
            Console.WriteLine(salad.Serve());
            Console.WriteLine(salad.Serve());
            Console.WriteLine(salad.Serve());
        }
    }
}
