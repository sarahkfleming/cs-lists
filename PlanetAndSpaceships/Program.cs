using System;
using System.Collections.Generic;

namespace PlanetAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanets = new List<string>() { "Neptune", "Uranus" };

            planetList.AddRange(lastPlanets);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            Console.WriteLine("------ Rocky Planets ------");

            foreach (string planet in rockyPlanets)
            {
                Console.WriteLine(planet);
            }

            planetList.Remove("Pluto");
            Console.WriteLine("------ Planets without Pluto ------");

            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }
        }
    }
}
