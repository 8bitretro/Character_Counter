using System;
using System.Collections;

namespace Character_Counter
{
    class Program
    {
        static void Main(string[] args)
        {

            string appname = "Character Counter";
            string author = "8bitretro";

            Console.WriteLine(appname + " by " + author);
            Console.WriteLine();

            Console.WriteLine("Enter a string of text...");
            string text = Console.ReadLine();
            Console.WriteLine();

            int textLength = text.Length;
            Console.WriteLine("The number of characters in the text is : {0}", textLength);


            Console.ReadLine();
            


            
            






        }
    }
}
