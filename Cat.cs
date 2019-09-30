using System;

namespace excercises_classes
{
    public class Cat
    {
        private string name;
        private int age;
        private string race;
        private string color;

        private void Fetch()
        {
            Console.WriteLine("Är du dum i huvudet? Jag är en katt, jag jagar inte bollar");
        }

        private void Mjau()
        {
            if(age > 10)
            {
                Console.WriteLine(name + " är för gammal och kan inte längre jama");
            }
            else{
                Console.WriteLine("MJAU!");
            }
        }
    }
}