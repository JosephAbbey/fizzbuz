using System;

public static class Program {
  public static int n = 100;

  public static void Main() {
    for (int i = 1; i <= n; i++) {
      string o = "";
      if (i % 3 == 0) { o += "fizz"; }
      if (i % 5 == 0) { o += "buzz"; }
      if (o == "") { o = i.ToString(); }
      Console.WriteLine(o);
    }
  }
}
