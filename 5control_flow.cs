using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyNameSpace
{
    class ControlFlowExample
    {
        static int x = 10;

        static int Jaka1()
        {
            int x = 20; // namespace variable
            return x;
        }

        public void Process()
        {
            Console.WriteLine("CONTROL FLOW EXAMPLE -------------------------");

            // Jaka1
            Console.WriteLine(Jaka1()); // 20
            Console.WriteLine(x);      // 10

            x = 10;

            // Jaka
            Jaka();
            Console.WriteLine(x); // 30

            // if
            Console.Write("Input angka: ");
            x = int.Parse(Console.ReadLine()); // input

            if (x < 10)
                Console.WriteLine("x is less than 10");
            else if (x == 30)
                Console.WriteLine("x is equal to 30");
            else
                Console.WriteLine("other");

            // for
            List<string> array1 = new List<string> { "jaka", "prima", "maulana" };
            foreach (string item in array1) {
                Console.WriteLine($"{item} {item.Length}");
            }
                
            // insert in loop at specific index
            List<string> array2 = new List<string>();
            foreach (string w in array1.ToArray()) // copy all elements of array1 for insertion
            {
                if (w.Length > 5)
                    array2.Insert(0, w);
            }
            Console.WriteLine(string.Join(", ", array2));

            // range
            Console.WriteLine(string.Join(", ", Enumerable.Range(0, 5))); // [0, 1, 2, 3, 4]
            Console.WriteLine(string.Join(", ", Enumerable.Range(6, 4))); // 6, 7, 8, 9

            // loop with range
            Console.WriteLine(array1.Count); // 3
            for (int i = 0; i < array1.Count; i++)
                Console.WriteLine($"{i} {array1[i]}");

            // break statement (example: finding factorial)
            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        Console.WriteLine($"{i} = {j} * {i / j}");
                        break;
                    }
                    else
                        Console.WriteLine(i);
                }
            }

            // continue
            for (int number = 1; number < 10; number++)
            {
                if (number % 2 == 0)
                    Console.WriteLine($"{number} is even");
                else
                    Console.WriteLine($"{number} is odd");
            }

            // Fibonacci
            NameFunction(20);

            // default argument
            bool result = Fungsi2("Do you want to exit?");
            Console.WriteLine(result);
            bool result2 = Fungsi2("Do you want to exit?", 2);
            Console.WriteLine(result2);
            bool result3 = Fungsi2("Do you want to exit?", 2, "exit message");
            Console.WriteLine(result3);

            // lambda expression = anonymous func
            Func<int, int> f2 = F(10);
            Console.WriteLine(f2(20)); // 30

            Func<int, int> func1 = (param) => param + param;
            Console.WriteLine(func1(10)); // 20
        }

        static void Jaka()
        {
            x = 30;
        }

        static void NameFunction(int n)
        {
            // Write Fibonacci series up to n
            int a = 0, b = 1;
            while (a < n)
            {
                Console.WriteLine($"{a}, {b}, a+b={a + b}");
                int temp = a;
                a = b;
                b = temp + b;
                Console.WriteLine($"a={a} b={b}");
            }
        }

        static bool Fungsi2(string message, int number = 4, string message2 = "yes or no!")
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "y" || input == "ye" || input == "yes")
                    return true;
                if (input == "n" || input == "no")
                    return false;
                number--;
                if (number < 0)
                    throw new IOException("user error");
                Console.WriteLine(message2);
            }
        }

        // static void F(string arg1, string arg2 = "default arg2 val", string arg3 = "default arg3 val")
        // {
        //     Console.WriteLine(arg1);
        //     Console.WriteLine(arg2);
        //     Console.WriteLine(arg3);
        // }

        static Func<int, int> F(int n)
        {
            return x => x + n;
        }
    }
}
