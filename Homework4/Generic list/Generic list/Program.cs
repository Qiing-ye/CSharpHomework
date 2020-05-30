using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_list
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> n = this.head;
            while (n != null)
            {
                action(n.Data);
                n = n.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }

            //逐个打印
            intlist.ForEach(m => Console.WriteLine(m));
            /*
            //总和
            int sum = 0;
            intlist.ForEach(m => { sum += m; });
            Console.WriteLine($"总和:{sum}");
            //最大
            int max = 0;
            intlist.ForEach(m => { if (max < m) max = m; });
            Console.WriteLine($"最大值:{max}");
            //最小
            int min = 0;
            intlist.ForEach(m => { if (min > m) min = m; });
            Console.WriteLine($"最小值:{min}");*/
            int sum = 0;
            int max = 0;
            int min = 0;
            Action<int> act = (m => sum += m);
            act += (m => { if (max < m) max = m; });
            act += (m => { if (min > m) min = m; });
            Console.WriteLine($"总和:{sum}");
            Console.WriteLine($"最大值:{max}");
            Console.WriteLine($"最小值:{min}");
            Console.ReadKey();
        }
    }
}
