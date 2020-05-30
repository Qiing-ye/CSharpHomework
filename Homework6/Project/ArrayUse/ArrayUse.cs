using System;
class ArrayUse {
  public static void Main() {
    InitializeArray();
    MultiDimensionArray();
    JaggedArray();
  }

  private static void InitializeArray() {
    int[] a1;
    a1 = new int[3];
    a1[0] = 1; a1[1] = 2; a1[2] = 3;

    int[] a2 = new int[] { 1, 2, 3 };
    int[] a3 = { 1, 2, 3 };

    DateTime[] days = {
      new DateTime(2020,1,1),
      new DateTime(2020,1,2),
      new DateTime(2020,2,20)
    };

  }

  private static void MultiDimensionArray() {
    int[,] a1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
    int[,,] a2 = new int[10, 20, 30];

    Console.WriteLine($"a1的总长度：" + a1.Length);
    Console.WriteLine($"a2的总长度：" + a2.Length);
    for (int i = 0; i < a2.Rank; i++) {
      Console.WriteLine($"a2第{i+1}维的长度："+a2.GetLength(i));
    }
  }


  private static void JaggedArray() {
    byte[][] scores = new byte[5][]; // 交错数组

    for (int i = 0; i < scores.Length; i++) {
      scores[i] = new byte[i + 3];
    }

    Console.WriteLine("数组维度："+scores.Rank); // 维度为1
    Console.WriteLine("数组长度：" + scores.Length); // 长度为5

    for (int i = 0; i < scores.Length; i++) {
      for (int j = 0; j < scores[i].Length; j++) {
        Console.Write(" " + scores[i][j]);
      }
      Console.WriteLine("");
    }
  }
}
