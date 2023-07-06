using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] str = new string[5] {"Gaurav","Yash","Jayesh","Pratik","Manoj"};
            //string[] str1 = new string[3] { "Ram", "Sachin", "Santosh" };

            //foreach (string str2 in str) 
            //{ 
            //    Console.WriteLine(str2);
            //}
            //Array.Sort(str);
            //Console.WriteLine("---------After Sort------");
            //foreach (string str2 in str)
            //{
            //    Console.WriteLine(str2);
            //}
            //Array.Reverse(str);
            //Console.WriteLine("-------After Reverse------");
            //foreach (string str2 in str)
            //{
            //    Console.WriteLine(str2);
            //}
            //Array.Copy(str, 0, str1, 1, 2);
            //Console.WriteLine("-----After Copy------");
            //foreach (string str2 in str1)
            //{
            //    Console.WriteLine(str2);
            //}


            //int[,] arr = new int[3, 3];
            //for(int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j =0; j <arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter value for [arr{0},{1}]");
            //        arr[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //int[,] arr1 = new int[3, 3];
            //for(int i=0; i < arr1.GetLength(0); i++)
            //{
            //    for(int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"enter value for arr1[{0},{1}]");
            //        arr[i,j]= Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for(int i =0; i < arr1.GetLength(0); i++)
            //{
            //    for(int j=0;j<arr1.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + arr1[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            //ArrayList list = new ArrayList();
            //list.Add(10);
            //list.Add("Gaurav");
            //list.Add(77.77);

            //string s = list[1].ToString();
            //int a = (int)list[0];
            //double d = (double)list[1];

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}


            //Arraylist example
            //int[]arr =new int[] {10,20,30};
            //int[] arr2 = new int[8];
            //ArrayList list = new ArrayList();

            //list.Add(11);
            //list.Add(35);
            //list.Add(19);

            //list.Insert(0, 1);
            //list.Insert(2, 200);


            //list.AddRange(arr);

            //list.Sort();
            //list.Reverse();

            //list.CopyTo(arr2);


            //list.Remove(200);
            //list.RemoveAt(1);
            //list.RemoveRange(0, 2);

            //bool res=list.Contains(200);
            //Console.WriteLine(res);

            //Console.WriteLine("No of element in present collection is " + list.Count);


            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //STACK
            
            Stack stack = new Stack();
            stack.Push(19);
            stack.Push("Hello");
            stack.Push(70);

            stack.Pop();

            //Console.WriteLine($"first element in stack {stack.Peek()}");
            //Console.WriteLine($"Total element in stack {stack.Count}");

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            // QUEUE

            Queue queue = new Queue();
            queue.Enqueue(25);
            queue.Enqueue("Namaste");
            queue.Enqueue(18);

            queue.Dequeue();

            //Console.WriteLine($"first element in queue is {queue.Peek()}");
            //Console.WriteLine($"Total elements in queue is {queue.Count}");



            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}


            //HASHTABLE

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1,"President");
            //hashtable.Add(2, "Prime Minister");
            //hashtable.Add(3, "Cabinet Minister");

            //hashtable.Remove(3);

            //foreach(DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key + " "+ item.Value);
            //}















        }
    }
}
