using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals
{
    internal class console_write2
    {
        static void Main (string[] args)
        {
            // put title to your console
            Console.Title = "C# Fundamental | Passionate coder";
            // color on text
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("hallo");
            // color on background 
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("world");
           
            Console.ForegroundColor= ConsoleColor.White;
            Console.BackgroundColor= ConsoleColor.Black;
            
            //wait the key from user to end process
            Console.ReadKey();


        }

    }
}
