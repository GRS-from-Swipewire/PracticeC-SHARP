using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_SHARP
{
    internal class StackPractice
    {
        public StackPractice()
        {
            Stack<int> var = new Stack<int>();
            var.Push(1);
            var.Push(2);
            var.Push(3);
            var.Push(4);
            var.Push(5);
            var.Pop();
            var.Peek();
            Console.WriteLine("Stack elements:");
            foreach(int ele in var)
            {
                Console.WriteLine(ele);
            } 

            Queue<int> var1 = new Queue<int>();
            var1.Enqueue(1);
            var1.Enqueue(2);
            var1.Enqueue(3);
            var1.Enqueue(4);
            var1.Enqueue(5);
            var1.Peek();
            Console.WriteLine("Queue elements:");
            foreach (int ele in var1)
            {
                Console.WriteLine(ele);
            }

            Dictionary<int, string> var2 = new Dictionary<int, string>();
            /*var2.Add(1, "asd");
            var2.Add(2, "asdf");
            var2.Add(3, "asdfg");
            var2.Add(4, "asdfgh");*/
            Console.WriteLine("Number of key pairs want to input: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i< n; i++)
            {
                Console.WriteLine($"Enter value{i}");
                var2.Add(i, Console.ReadLine());
            }
            Console.WriteLine("Values:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(var2[i]);
            }
        }
    }
}
