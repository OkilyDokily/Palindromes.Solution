using System;
namespace Palindromes.Models
{
    public class Palindrome
    {
        public static bool PalindromeTest(string str){
            char[] ca = str.ToCharArray();
            Array.Reverse<char>(ca);
            string ns = new string(ca);
            return str == ns;
        }

         public static bool PalindromeTestWithoutReverse(string str){
            string es = "";
            for(int i = (str.Length - 1); i >=0;i--){
                es += str.Substring(i,1);
            }
            return str == es;
        }
    }
}