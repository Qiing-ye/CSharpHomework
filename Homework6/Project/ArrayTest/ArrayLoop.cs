using System;
public class ArrayLoop {
  public static void Main(string[] args) {
    int i;
    int[] a = new int[5];

    for (i = 0; i < a.Length; i++) { 
      a[i] = i;
    }

    foreach (int num in a) { 
      Console.WriteLine(num);
    }

    Array.ForEach(a,num => Console.WriteLine(num));

  }
}
