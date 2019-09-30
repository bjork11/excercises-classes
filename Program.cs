using System;

namespace excercises_classes
{

    class Program
    {
        static void Main(string[] args)
        {
            Dog minHund = new Dog();
            minHund.name = "Nova";
            minHund.age = 8;
            minHund.tired = true;
            minHund.color = "svart";
            minHund.race = "En jävla massa aka blandras";

            minHund.Fetch();
            minHund.Bark();

            Console.WriteLine(minHund.name + " är " + minHund.age + " år gammal.");
            Console.WriteLine("Ras: " + minHund.race + "\nFärg: " + minHund.color);
        }
    }
}
