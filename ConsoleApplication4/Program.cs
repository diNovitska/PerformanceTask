using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 7, 8, 9, 1, 2, 8, 10, 2, 11, 5, 4, 4,3 };
            string textToVerify = "А роза упала на лапу Азора";
            Palindrom p = new Palindrom();
            Console.WriteLine(p.IsPalindromWithLoop(textToVerify));
            Console.WriteLine(p.IsPalindrom(textToVerify));

            Dublication d = new Dublication();
            Console.WriteLine(string.Join(" ", d.DublicatesMoveToEnd(list)));
            Console.WriteLine(string.Join(" ", d.JustOneDublicateMoveToEnd(list)));
            

            Console.ReadKey();
        }

    }
}
