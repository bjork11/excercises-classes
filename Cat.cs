using System;

namespace excercises_classes
{
    //Del 2
    public class Cat
    {
        private string name;
        private int age;
        private string race;
        private string color;

        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get
            {
                int currentAge = age + 1;
                return currentAge;
            }
            set
            {
                age = value;
            }
        }

            public string Race
            {
                get;
                set;
            }

        public void Fetch()
        {
            Console.WriteLine("Är du dum i huvudet? Jag är en katt, jag jagar inte bollar");
        }

        public void Mjau()
        {
            if (age > 10)
            {
                Console.WriteLine(Name + " är för gammal och kan inte längre jama");
            }
            else
            {
                Console.WriteLine("MJAU!");
            }
        }
        public Cat(string newName)
        {
            Name = "namnlös";
            Age = 0;
            Race = "okänd";
            color ="okänd";
        }
    }
}