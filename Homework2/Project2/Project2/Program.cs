using System;

namespace Project2
{
    class Program
    {
        public static int Min(int[] array) {
            if (array == null) throw new Exception("数组空异常");
            int value = 0;
            bool hasValue = false;
            foreach (int x in array) {
                if (hasValue) { 
                    if (x < value) value = x;
                }
                else {
                    value = x;
                    hasValue = true;
                }
            }
            if (hasValue) return value;
            throw new Exception("没找到");
        }
        public static int Max(int[] array) {
            if (array == null) throw new Exception("数组空异常");
            int value = 0;
            bool hasValue = false;
            foreach (int x in array) {
                if (hasValue)
                {
                    if (x > value)
                        value = x;
                }
                else
                {
                    value = x;
                    hasValue = true;
                }
            }
            if (hasValue) return value;
            throw new Exception("没找到");
        }
        public static double? Average(int[] array)
        {
            if (array == null) throw new Exception("数组空异常");
            long sum = 0;
            long count = 0;
            checked
            {
                foreach(int ? v in array)
                {
                    if (v != null)
                    {
                        sum += v.GetValueOrDefault();
                        count++;
                    }
                }
            }
            if (count > 0 )return (double)sum / count;
            return null;
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 4, 3, 0, -1, 34, 545, 2, 34 };
            int min = Program.Min(array);
            int max = Program.Max(array);
            double? average = Program.Average(array);
            Console.WriteLine("Min:" + min);
            Console.WriteLine("Max:" + max);
            Console.WriteLine("Average:" + average);
            Console.Read();

        }
    }
}
