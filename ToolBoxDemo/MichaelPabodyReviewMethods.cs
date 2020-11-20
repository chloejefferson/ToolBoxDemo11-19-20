using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBoxDemo
{
    class MichaelPabodyReviewMethods
    {
        //Write a method that asks the user how old they are and returns their age as an int.
        public int GetAge()
        {
            Console.WriteLine("How old are you?");
            string ageAsString = Console.ReadLine();

            int ageAsInt = int.Parse(ageAsString);
            return ageAsInt;
        }

        //Write a method that takes in a name and outputs a greeting to the user.
        public void TellTheUserHowOldTheyAre(string name)
        {
            int age = GetAge();
            Console.WriteLine($"Hey {name}, you are {age} years old");
        }
    }
}
