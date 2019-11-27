using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Palindrom
    {
        public string IsPalindrom(string a)
        {
            a = a.Replace(" ", "").ToLower();
            if (a.Equals(new string(a.ToCharArray().Reverse().ToArray())))
            {
                return a.Substring(0, a.Length / 2);
            }
            return "Not polindrom";
        }
        public string IsPalindromWithLoop(string str)
        {
            str = str.Replace(" ", "").ToLower();
            int len = str.Length;
            for (int i = 0; i < len / 2; ++i)
            {
                if (str[i] == str[len - i - 1])
                {
                    continue;
                }
                else
                {
                    return "Not palindrom";
                }
            }
            return str.Substring(0, str.Length / 2);
        }

    }
}
