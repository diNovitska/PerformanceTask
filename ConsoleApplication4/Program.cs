using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() {7, 8, 9, 1, 2, 8, 10, 2, 11, 5, 4, 4,3 };
            string textToVerify = "А роза упала на лапу Азора";
            Palindrom p = new Palindrom();
            Console.WriteLine(p.IsPalindromWithLoop(textToVerify));
            Console.WriteLine(p.IsPalindrom(textToVerify));

            Dublication d = new Dublication();
            Console.WriteLine(string.Join(" ", d.DublicateLinq(list)));
            Console.WriteLine(string.Join(" ", d.Dublicates(list)));
            

            Console.ReadKey();
        }

    }
}
