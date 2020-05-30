using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefArgs {
  class Program {
    static void Main(string[] args) {
      int myScore=100;
      int yourScore=60;
      swap(ref myScore, ref yourScore);
      Console.WriteLine($"{myScore},{yourScore}");
    }

    static void swap(ref int myScore, ref int yourScore) {
      int temp = myScore;
      myScore = yourScore;
      yourScore = temp;
    }
  }
}
