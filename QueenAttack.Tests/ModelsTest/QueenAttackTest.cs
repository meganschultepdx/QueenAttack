using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenAttackTest
  {
    [TestMethod]
    public void QueenAttackAnalyzer_XAxisComparison_True()
    {
      QueenAttack testQueenAttack = new QueenAttack();
      Assert.AreEqual(true, testQueenAttack.QueenAttackAnalyzer(1, 2, 1, 4));
    }

    [TestMethod]
    public void QueenAttackAnalyzer_YAxisComparison_True()
    {
      QueenAttack testQueenAttack = new QueenAttack();
      Assert.AreEqual(true, testQueenAttack.QueenAttackAnalyzer(1, 2, 3, 2));
    }
    [TestMethod]
    public void QueenAttackAnalyzer_DiagAxisComparison_True()
    {
      QueenAttack testQueenAttack = new QueenAttack();
      Assert.AreEqual(true, testQueenAttack.QueenAttackAnalyzer(10, 9, 3, 2));
    }
  }
}
