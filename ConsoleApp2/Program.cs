using System;
using System.IO;
using System.Linq;


namespace Chains
{

    class Program
    {

        static bool ChangePossible(string s1, string s2)
        {
            for (var i = 0; i < 20; i++)
            {
                var character = ((char)(i + 65));
                if ((s2.Count(f => f == character)) >= (s1.Count(f => f == character)))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("No match here...");
                    return false;
                }
            }
            Console.WriteLine("It's a match!");
            return true;
        }



        static void Main(string[] args)
        {
            ChangePossible("ABACCACAT", "CACABBAATCCAA");
            ChangePossible("ABACCADCADT", "CACABBAADTCCAA");
            ChangePossible("EBEEBE", "EB");
        }
    }
}

