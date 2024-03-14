using System;

namespace MyNameSpace {
    class NumberExample {
        public void Process() {
            Console.WriteLine("NUMBER EXAMPLE -------------------------");
            // number
            // operator +, -, *, /
            Console.WriteLine(2 + 2);           // 4
            Console.WriteLine(50 - 5 * 6);      // 20
            Console.WriteLine((50 - 5.0 * 6) / 4); // 5.0
            Console.WriteLine(8 / 5.0);         // 1.6 kalo mau float harus pake .0 kalo ga di akan jadi int
            Console.WriteLine(17 / 3);          // 5 (int)
            Console.WriteLine(17 / 3.0);        // 5.66666 float
            Console.WriteLine((int)(17 / 3.0)); // 5 membuang bagian pecahan
            Console.WriteLine(17 % 3);          // 2 modules sisa hasil bagi 3*5 17-15 = 2

            Console.WriteLine(Math.Pow(2, 3));  // pangkat/power 2*2*2 = 8

            // execute data terakhir tersimpan dalam variable _
            double lastResult = 8;

            Console.WriteLine(lastResult);

            double a = 17 / 3.0;
            Console.WriteLine(Math.Round(lastResult, 2)); // 5.67 mengambil berapa desimal dibelakang .
            Console.WriteLine("A", a);
        }
    }
}
