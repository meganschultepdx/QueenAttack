using System;
using System.Collections.Generic;

namespace QueenAttack
{
  public class QueenAttack
  {
    public bool QueenAttackAnalyzer(int queenX, int queenY, int opponentX, int opponentY)
    {
      if (queenX == opponentX)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
