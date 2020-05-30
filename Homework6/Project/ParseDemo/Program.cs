using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseDemo {
  class Program {
    static void Main(string[] args) {
      String str = Console.ReadLine();
      Parse(str);
      ConvertStr(str);
      TryParse(str);
    }

    private static void Parse(string str) {
      Console.WriteLine("Parse(str):");
      try {
        int num = int.Parse(str);
        Console.WriteLine(num);
      }catch (Exception e) {
        Console.WriteLine("解析错误:" + e.Message);
      }
    }

    private static void ConvertStr(string str) {
      Console.WriteLine("ConvertStr(str):");
      try {
        int num = Convert.ToInt32(str);
        Console.WriteLine(num);
      }catch (Exception e) {
        Console.WriteLine("解析错误:" + e.Message);
      }
    }

    private static void TryParse(string str) {
      Console.WriteLine("TryParse(str):");
      if (int.TryParse(str, out int num)) {
        Console.WriteLine(num);
      }else {
        Console.WriteLine("解析错误！" );
      }
    }
  }
}
