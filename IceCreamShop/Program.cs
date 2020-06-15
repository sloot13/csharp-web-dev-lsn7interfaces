using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            foreach (Cone f in availableCones)
            {
                Console.WriteLine(f);
            }
            availableFlavors.Sort(new FlavorComparer());
            availableCones.Sort(new ConeComparer());
            foreach (Cone f in availableCones)
            {
                Console.WriteLine(f);
            }

        }   
    }
}
