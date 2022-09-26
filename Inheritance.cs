using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM MENGHITUNG LUAS DAN KELILING BANGUN DATAR");

            Console.WriteLine();

            BangunDatar bangunDatar = new BangunDatar();

            Persegi p = new Persegi();
            p.sisi = 2;

            Lingkaran l = new Lingkaran();
            l.jarijari = 22;

            PersegiPanjang pp = new PersegiPanjang();
            pp.panjang = 8;
            pp.lebar = 4;

            Segitiga s = new Segitiga();
            s.alas = 12;
            s.tinggi = 8;

            bangunDatar.luas();
            bangunDatar.keliling();

            p.luas();
            p.keliling();

            l.luas();
            l.keliling();

            pp.luas();
            pp.keliling();

            s.luas();
            s.keliling();
        }

        public class BangunDatar
        {
            internal float luas()
            {
                Console.WriteLine("Menghitung luas bangun datar");
                return 0;
            }

            internal float keliling()
            {
                Console.WriteLine("Menghitung keliling bangun datar");
                return 0;
            }
        }

        public class Persegi : BangunDatar
        {
            private double s;
            public double sisi
            {
                get { return s; }
                set { s = value; }
            }
        }

        public class Lingkaran : BangunDatar
        {
            private double r;

            public double jarijari
            {
                get { return r; }
                set
                {
                    r = value;
                }
            }

        }

        public class PersegiPanjang : BangunDatar
        {
            private float p, l;

            public float panjang
            {
                get { return p; }
                set
                {
                    p = value;
                }
            }

            public float lebar
            {
                get { return l; }
                set
                {
                    l = value;
                }
            }
        }

        public class Segitiga : BangunDatar
        {
            private float a, t;

            public float alas
            {
                get { return a; }
                set
                {
                    a = value;
                }
            }

            public float tinggi
            {
                get { return t; }
                set
                {
                    t = value;
                }
            }
        }
    }
}