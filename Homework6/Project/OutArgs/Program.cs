using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutArgs {
  class Program {
    static void Main(string[] args) {
      int num1 = 10;
      int num2 = 20;
      Calculate(num1, num2, out int result1, out int result2);
      Console.WriteLine($"{result1},{result2}");
    }

    static void Calculate(int a,int b,out int x,out int y) {
      Console.WriteLine(x);
      x = a - b;
      y = a + b;
    }
  }
}
