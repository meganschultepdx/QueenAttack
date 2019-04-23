using System;

namespace QueenAttack
{
    class MainClass
    {
        public static void Main()
        {
          QueenAttack testQueenAttack = new QueenAttack();
          Console.WriteLine("Enter the queen's X axis");
          int queenX = int.Parse(Console.ReadLine());
          Console.WriteLine("Enter the queen's Y axis");
          int queenY = int.Parse(Console.ReadLine());
          Console.WriteLine("Enter the opponent's X axis");
          int opponentX = int.Parse(Console.ReadLine());
          Console.WriteLine("Enter the opponent's Y axis");
          int opponentY = int.Parse(Console.ReadLine());
        }
    }
}
