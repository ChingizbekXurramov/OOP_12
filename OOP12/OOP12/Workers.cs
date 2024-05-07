using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP12
{
    internal class Workers
    {
        private string name;
        private int age;
        private int experience;

        public Workers(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >=15 && value <= 100)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Error!!!!!!!!!!.    Vvedite vozrast ot 15 do 100.");
                }
            }
        }

        public int Experience
        {
            get { return experience; }
            set
            {
                if (value >= 0)
                {
                    experience = value;
                }
                else
                {
                    Console.WriteLine("Error!!!!!!!!!. vvedite polojiteknoy znachiniya .");
                }
            }
        }
    }
}
