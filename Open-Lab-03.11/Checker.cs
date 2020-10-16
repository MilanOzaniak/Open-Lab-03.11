using System;
using System.Linq;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            var rstr = string.Join("", str.ToLower().Reverse());
            return rstr == str;
        } 
    }
}
