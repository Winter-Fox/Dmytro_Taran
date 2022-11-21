using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Knowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Taks 1 ###");
            List<object> list = Task1.GetIntegersFromList(new List<object>() { 1, 2, 'a', 'b' });
            list.ForEach(i => Console.Write("{0} ", i));

            Console.WriteLine("\n\n### Taks 2 ###");
            Console.WriteLine(Task2.FirstNonRepeatingLetter(new string("sTreSS")));

            Console.WriteLine("\n### Taks 3 ###");
            Console.WriteLine(Task3.DigitalRoot(132189));

            Console.WriteLine("\n### Taks 4 ###");
            Console.WriteLine(Task4.FindTargetSum(new int[] { 1, 3, 6, 2, 2, 0, 4, 5 }, 5));

            Console.WriteLine("\n### Taks 5 ###");
            string s = "Fired:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            Console.WriteLine(Task5.SortGuestList(s));
        }
    }
}
