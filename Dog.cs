using System;

namespace excercises_classes
{
    //Del 1
    public class Dog
    {
        public string name;
        public int age;
        public string race;
        public string color;

        public bool tired;

        public void Fetch()
        {
            if (tired)
            {
                Console.WriteLine("Nej jag orkar inte hämta bollen, jag är trött.");
            }
            else
            {
                Console.WriteLine("BOOOOOOOOOOOOOOOLL!!");
            }
        }

        public void Bark()
        {
            if (age < 1)
            {
                Console.WriteLine("Hunden är för liten för att skälla!");
            }
            else
            {
                Console.WriteLine("VOFF VOFF!");
            }
        }
    }
}