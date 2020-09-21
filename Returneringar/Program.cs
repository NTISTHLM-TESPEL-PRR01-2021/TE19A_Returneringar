using System;

namespace Returneringar
{
  class Program
  {
    static void Main(string[] args)
    {
      // int i = 20;
      // while (i > 0)
      // {
      //   Hello();
      //   i--;
      // }
      int points = 0;

      int test = Hello();
      
      points += test;

      Console.WriteLine(points);

      Console.ReadLine();
    }

    static int Hello()
    {
      // string s = "hej";
      // Console.WriteLine("HELLO!!!");

      string g = Console.ReadLine();
      if (g == "r")
      {
        return 1;
      }
      else
      {
        return 2;
      }
    }

  }
}
