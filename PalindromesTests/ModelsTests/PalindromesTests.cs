using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;

namespace PalindromesTests
{
  [TestClass]
  public class PalindromesTests
  {
    [TestMethod]
    public void PalindromeTest_TestsIfPalindrome_True()
    {
      Assert.AreEqual(true, Palindrome.PalindromeTest("radar"));
    }
    [TestMethod]
    public void PalindromeTest_TestsIfPalindrome_False()
    {
      Assert.AreEqual(false, Palindrome.PalindromeTest("cabin"));
    }

  }
}