using System;

namespace MyNameSpace {
    class Sample {}

    class Orang {
        // similar kategori = 'orang'
        public static string Kategori = "orang";

        // similar // Constructor
        // def __init__(self, argument):
		//     self.method = argument 
        public string Nama;

        public Orang(string nama) {
            Nama = nama;
        }

        public void Aksi1() {
            Console.WriteLine("AKSI 1");
        }
    }

    class Bayi : Orang {
        public Bayi() : base("default nama"){

        }

        public void Aksi2()
        {
            Console.WriteLine("minum");
        }
    }

    public class Lingkaran {
        private double radius;
        public const double Pi = 3.14;

        public Lingkaran(double radius=1) {
            this.radius = radius;
        }

        public double Area() {
            // rumus: (x*x) * Pi
            return Math.Pow(radius, 2) * Pi;
        }

        public double GetRadius() {
            return radius;
        }

        public void SetRadius(double newRadius) {
            radius = newRadius;
        }

        public double Radius{
            get { 
                return radius; 
            }
        }


    }

    class OOPExample {
        public void Process() {
            Console.WriteLine("OOP EXAMPLE -------------------------------------");
            Sample x = new Sample();
            Console.WriteLine(x.GetType()); // MyNameSpace.Sample

            Orang orang1 = new Orang("Jaka Prima Maulana");
            Console.WriteLine(orang1.Nama);
            Console.WriteLine(Orang.Kategori);

            // inheritance
            Bayi orang2 = new Bayi();
            orang2.Aksi1();
            orang2.Aksi2();
            Console.WriteLine(orang2.Nama);


            // lingkaran class
            Lingkaran lingkaranInstance = new Lingkaran(10);
            Console.WriteLine(lingkaranInstance.Area());
            Console.WriteLine(lingkaranInstance.Radius);

            lingkaranInstance.SetRadius(20);
            Console.WriteLine(lingkaranInstance.Area());
            Console.WriteLine(lingkaranInstance.Radius);

        }
    }
}