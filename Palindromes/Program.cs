using System;
using Palindromes.Models;
namespace Palindromes
{
    public class Program
    {
        public static void Main(){
            Console.WriteLine("Enter a word.");
            string s = Console.ReadLine();
        
            if (Palindrome.PalindromeTestWithoutReverse(s)){
                Console.WriteLine("That is a palindrome.");
            }
            else{
                 Console.WriteLine("That is not a palindrome.");
            }
        }

    }
}