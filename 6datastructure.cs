using System;

namespace MyNameSpace {
    class DataStructureExample {
        public void Process() {
            Console.WriteLine("DATA STRUCTURE SECTION ------------------------------------------------");
            // ------------------------------------------------------------- type
            Console.WriteLine(typeof(int)); // int

            // ------------------------------------------------------------- list
            // append / tambah item di akhir list
            List<int> a = new List<int> { 1, 2, 3, 4, 5 };
            a.Add(6); //[1,2,3,4,5,6]
            Console.WriteLine(a);

            // extend / tambah semua item dalam list
            List<int> b = new List<int> { 1, 2 };
            List<int> c = new List<int> { 3, 4 };
            b.AddRange(c); //[1,2,3,4]
            Console.WriteLine(b);

            // insert / tambah value pada spesifik index tertentu
            List<int> d = new List<int> { 1, 2, 3 };
            d.Insert(1, 10); // 1,10,2,3

            // remove /hapus index yang berisi value
            List<int> e = new List<int> { 1, 2, 3, 4 };
            e.Remove(3); // 1,2,4

            // pop / hapus value pada spesifik index kalo ga ada index dihapus yang terakhir
            List<int> f = new List<int> { 1, 2, 3, 4 };
            f.RemoveAt(1); // 1,3,4

            // cek ada di index keberapa
            List<int> g = new List<int> { 1, 2, 3, 4 };
            Console.WriteLine(g.IndexOf(3)); // 2

            // cek ada berapa jumlah value yang sama
            List<int> h = new List<int> { 1, 2, 3, 4, 4, 4 };
            Console.WriteLine(h.Count(x => x == 4)); // 3

            // sort / mengurutkan
            List<int> i = new List<int> { 1, 3, 2, 3, 5, 6, 8, 6 };
            i.Sort(); // 1,2,3,3,5,6,6,8

            // reverse / dibalik
            List<int> j = new List<int> { 1, 2, 3, 4, 5 };
            j.Reverse(); // 5,4,3,2,1

            // // -------------------------------------------------------------  set
            // // masukin dengan value yang unique value yang sama ga akan masuk
            // HashSet<int> x = new HashSet<int>();
            // x.Add(1);
            // x.Add(2);
            // x.Add(1);
            // foreach (var item in x)
            // {
            //     Console.WriteLine(item); // 1,2
            // }

            // // functional programming
            // // filter
            // Func<int, bool> fFilter = x => x % 3 == 0 || x % 5 == 0;
            // var filtered = Enumerable.Range(2, 23).Where(fFilter);
            // Console.WriteLine(string.Join(", ", filtered));

            // // map
            // Func<int, int> fMap = x => x * x * x;
            // var mapped = Enumerable.Range(1, 10).Select(fMap);
            // Console.WriteLine(string.Join(", ", mapped));

            // // list comprehension // memahami list
            // // cara 1
            // List<int> aList = new List<int>();
            // for (int x = 0; x < 10; x++)
            // {
            //     aList.Add(x * x);
            // }
            // Console.WriteLine(string.Join(", ", aList));

            // // cara 2
            // List<int> bList = Enumerable.Range(0, 10).Select(x => x * x).ToList();
            // Console.WriteLine(string.Join(", ", bList));

            // // cara 3 jika ada if
            // var cList = (from x in new[] { 1, 2, 3 }
            //             from y in new[] { 3, 1, 4 }
            //             where x != y
            //             select new { x, y }).ToList();
            // Console.WriteLine(string.Join(", ", cList.Select(pair => $"({pair.x}, {pair.y})")));
        }
    }
}