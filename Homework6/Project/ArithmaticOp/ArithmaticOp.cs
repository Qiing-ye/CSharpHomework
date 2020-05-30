using System;
public class ArithmaticOp {
  public static void Main() {
    Division();
    Reminder();
    SplitNumber();
    Overflow();
  }

  //计算溢出问题
  private static void Overflow() {
    int a = int.MaxValue;
    int b = 3;
    Console.WriteLine(a + b);  // output: -2147483646
    try {
      int r = checked(a + b);
    }catch (OverflowException) {
      Console.WriteLine($"Overflow occurred when adding {a} to {b}.");
    }

    double c = 1.0 / 0.0;
    Console.WriteLine(c);                    // output: Infinity
    Console.WriteLine(double.IsInfinity(c)); // output: True
    Console.WriteLine(double.MaxValue + double.MaxValue); // output: Infinity
    double d = 0.0 / 0.0;
    Console.WriteLine(d);                // output: NaN
    Console.WriteLine(double.IsNaN(d));  // output: True
  }

  //取多位数的各个位的数字
  private static void SplitNumber() {
    int m = 145;
    for (int n = m; n > 0; n = n / 10) {
      Console.WriteLine(n % 10);
    }
  }

  //取余c=a%b，c符号与a相同，|c|等于|a| - n * |b|
  private static void Reminder() {
    Console.WriteLine(5 % 4);   // output: 1
    Console.WriteLine(5 % -4);  // output: 1
    Console.WriteLine(-5 % 4);  // output: -1
    Console.WriteLine(-5 % -4); // output: -1
    Console.WriteLine(-5.2f % 2.0f); // output: -1.2
    Console.WriteLine(5.9 % 3.1);    // output: 2.8
  }

  //除法 
  private static void Division() {
    Console.WriteLine(13 / 5);    // output: 2
    Console.WriteLine(-13 / 5);   // output: -2
    Console.WriteLine(13 / -5);   // output: -2
    Console.WriteLine(-13 / -5);  // output: 2
    Console.WriteLine(13 / 5.0);  // output: 2.6
    int a = 13;
    int b = 5;
    Console.WriteLine((double)a / b);  // output: 2.6
    Console.WriteLine(16.8f / 4.1f);   // output: 4.097561
    Console.WriteLine(16.8d / 4.1d);   // output: 4.09756097560976
  }
}
