using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo {
  class Program {
    static void Main(string[] args) {
      string str1 = "hello," +2018+1+"!";
      string str2 = "hello," + (2018+1) + "!";
      string str3 = @"c:\windows\system";
      string str4 = "c:\\windows\\system";
      string str5 = @"Jim says,""he can reach home in six minutes"".";
      string str6 = @"We can set a string value for a string variable
      with such a ""NextLine"" char.";

      Console.WriteLine(str1);
      Console.WriteLine(str2);
      Console.WriteLine(str3);
      Console.WriteLine(str4);
      Console.WriteLine(str5);
      Console.WriteLine(str6);

      bool b1 = (str3 == str4);
      bool b2 = (str3.Equals(str4));
      Console.WriteLine(b1+","+b2);

      char a = "Hello"[1];
      Console.WriteLine($"{a}");
    }
  }
}
