using System;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Please enter a number");
    string StringUserNumber = Console.ReadLine();
    int UserNumber = int.Parse(StringUserNumber);
    for (int i = 1; i <= UserNumber; i++)
    {
      if (i % 5 == 0 && i % 3 == 0)
      {
        Console.WriteLine("ping-pong");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else if (i % 3 == 0)
      {
        Console.WriteLine("ping");
      } 
      else
      {
        Console.WriteLine(i);
      }
    }
  }
}