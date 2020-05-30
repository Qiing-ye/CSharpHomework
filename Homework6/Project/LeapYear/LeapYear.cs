using System;
public class LeapYear {
  public static void Main() {
    char c = '\\';
    Console.Write("Input a year:");
    string s = Console.ReadLine();
    if (int.TryParse(s, out int year)) {
      if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
        Console.WriteLine(year + " is a leap year.");
      }
      else {
        Console.WriteLine(year + " is not a leap year.");
      }
    }else {
      Console.Write("Invalid input!");
    }
  }
}
