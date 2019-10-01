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

            Console.WriteLine("Nog om min hund, här kommer katten istället!");
            Console.WriteLine("----------------------------------------------");

            Cat minKatt = new Cat("Gurra");
            minKatt.Name = "Kattfan";
            minKatt.Age = 11;
            minKatt.Race = "Gustav(aka tjock och lat)";
            //Går ej att nå då variablen är private och jag inte gjort någon get;set;
            //minKatt.color = "svart";

            Console.WriteLine(minKatt.Name + " är av rasen: " + minKatt.Race + " Han är en gammal katt på " + minKatt.Age + " år.");
            minKatt.Fetch();
            minKatt.Mjau();
            Console.WriteLine("----------------------------------------------");
            
            Cat testKatt = new Cat("TESTA EN KONSTRUKTOR");
            Console.WriteLine(testKatt.Name + " | " + testKatt.Age + " | " + testKatt.Race);
            testKatt.Mjau();
        }
    }
}
