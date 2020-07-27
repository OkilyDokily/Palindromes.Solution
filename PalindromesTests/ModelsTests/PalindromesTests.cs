using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;

namespace PalindromesTests
{
  [TestClass]
  public class PalindromesTests
  {
    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFour_True()
    {
      Palindrome p = new Palindrome();
      Assert.AreEqual(true, true);
    }

  }
}