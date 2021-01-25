using System;

public static class Program
{
  public static int n = 100;


  public static void Main()
  {
    for (int i = 1; i <= n; i++)
    {
      if (i % 3 == 0)
      {
        if (i % 5 == 0)
        {
          Console.WriteLine("fizzbuz");
        }
        else
        {
          Console.WriteLine("fizz");
        }
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("buz");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
  }
}
