using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBoxDemo
{
    class Program
    {
        //"Main" method acs as our program's .exe file ("executable" or "entry point"). This is the file we double click on to start any program.
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to your Tool Box!"); //can type cw and TAB TAB to consolewriteline
            Console.WriteLine("You can either hit \"Y\" then ENTER to continue, or hit \"N\" then ENTER to clear the console and continue.");

            string UserResponse = Console.ReadLine();
            if(UserResponse== "Y")
            {
                KeyToContinue();
            }
            else if(UserResponse == "N")
            {
                keyToContinueWithClearConsole();
            }
            else
            {
                Console.WriteLine("Not sure friend, but I'm gonna close the program when you hit ENTER");
            }
            Console.ReadLine(); //to copy a line of code, just press anywhere in that line and CTRL + C to copy the entire line

            //Functions are methods written outside of a custom class
            //Methods are functions written inside of a custom class


            //Functions below:
            //1 - Write a function 
            void KeyToContinue() //we do not need access modifier (static, public, etc.) at the beginning because its a function not a method
            {
            Console.WriteLine("Hit ENTER to clear the console and continue on with the code...");
            Console.ReadLine();
            }

            void ClearConsole()
            {
                Console.Clear(); //Clears everything from the window
                Console.WriteLine("Congratulations! You've cleared the console!");
            }

            void keyToContinueWithClearConsole()
            {
                KeyToContinue();
                ClearConsole();
            }
        }
    }
}
