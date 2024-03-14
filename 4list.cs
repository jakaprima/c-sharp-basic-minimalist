using System;

namespace MyNameSpace {
    class ListExample{
        public void Process() {
            Console.WriteLine("LIST EXAMPLE -------------------------");
            // List
            Console.WriteLine("range menjadi list");
            List<int> rangeList = new List<int>(Enumerable.Range(0, 4)); // output: [0, 1, 2, 3]
            Console.WriteLine($"[{string.Join(", ", rangeList)}]");

            // Concatenate
            List<int> array = new List<int> { 1, 2, 3, 4 };
            List<int> concatenatedList = array.Concat(new List<int> { 5, 6, 7, 8, 9, 10 }).ToList(); // [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
            Console.WriteLine($"[{string.Join(", ", concatenatedList)}]");

            // Mutable (dapat diubah)
            List<int> array2 = new List<int> { 2, 4, 8, 17 };
            array2[3] = 16;
            Console.WriteLine($"[{string.Join(", ", array2)}]"); // [2, 4, 8, 16]

            // Append / tambah data di akhir item
            List<int> array3 = new List<int> { 2, 4, 8 };
            array3.Add((int)Math.Pow(2, 4));
            Console.WriteLine($"[{string.Join(", ", array3)}]"); // [2, 4, 8, 16]

            // Slices / potong
            List<int> array4 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            array4.RemoveRange(2, 3); // dari index 2 5-2 = 3 hapus 3 data
            Console.WriteLine($"[{string.Join(", ", array4)}]"); // [1, 2, 6, 7, 8]

            array4.Reverse();
            Console.WriteLine($"[{string.Join(", ", array4)}]"); // [8, 7, 6, 2, 1]

            List<int> array5 = new List<int> { 4, 2, 1, 5, 6, 7, 4 };
            array5.Sort();
            Console.WriteLine($"[{string.Join(", ", array5)}]"); // [1, 2, 4, 4, 5, 6, 7]

            List<int> l1 = new List<int> { 1, 2, 1, 2, 1 };
            List<int> l2 = new List<int> { 3, 4, 3, 4, 3 };

            List<List<int>> array6 = new List<List<int>> { l1, l2 }; // matrix
            Console.WriteLine($"[{string.Join(", ", array6[0])}]");
        }
    }
}