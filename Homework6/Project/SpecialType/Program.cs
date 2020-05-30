using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialType {
  class Program {
    static void Main(string[] args) {
      var v1 = 1 + 2;
      Console.WriteLine(v1.GetType());
      //v1 = 1.2; //ERROR
      int? v2=null;
      if (v2.HasValue) {
        Console.WriteLine(v2);
      }
      
    }
  }
}
