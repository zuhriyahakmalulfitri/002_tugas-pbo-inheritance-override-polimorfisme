using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfisme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu utama = new Menu();
            utama.menu();
            Console.ReadLine();
        }

        class Menu
        {
            public void menu()
            {
                Console.WriteLine("PROGRAM MENGHITUNG LUAS DAN KELILING BANGUN DATAR");

                Console.WriteLine();

                Persegi p = new Persegi();

                Console.WriteLine("1. Menghitung Persegi");
                Console.Write("Sisi : ");
                p.sisi = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Luas = {0} cm", p.hitungLuas());
                Console.WriteLine("Keliling = {0} cm", p.hitungKeliling());
                Console.WriteLine();

                Lingkaran l = new Lingkaran();

                Console.WriteLine("2. Menghitung Lingkaran");
                Console.Write("Jari-Jari : ");
                l.jarijari = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Luas       = {0} cm", l.hitungLuas());
                Console.WriteLine("Keliling   = {0} cm", l.hitungKeliling());
                Console.WriteLine();

                Segitiga s = new Segitiga();

                Console.WriteLine("3. Menghitung Segitiga");
                Console.Write("Alas   : ");
                s.alas = (int.Parse(Console.ReadLine()));
                Console.Write("Tinggi : ");
                s.tinggi = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Luas   = {0} cm", s.hitungLuas());
                Console.Write("Sisi : ");
                s.sisi2 = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Keliling   = {0} cm", s.hitungKeliling());
                Console.ReadKey();
            }

            public abstract class BangunDatar
            {
                public double _hitung;

                public double Hitung
                {
                    get { return _hitung; }
                    set { _hitung = value; }
                }

                public abstract double hitungLuas();

                public abstract double hitungKeliling();
            }

            public class Persegi : BangunDatar
            {
                private double s;

                public double sisi
                {
                    get { return s; }
                    set { s = value; }
                }

                public Persegi()
                {
                    this.sisi = sisi;
                }

                public override double hitungLuas()
                {
                    return this.sisi * this.sisi;
                }
                public override double hitungKeliling()
                {
                    return this.sisi * 4;
                }
            }

            public class Segitiga
            {
                private float a, t, x;

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
                public float sisi2
                {
                    get { return x; }
                    set
                    {
                        x = value;
                    }
                }

                public Segitiga()
                {
                    this.alas = alas;
                    this.tinggi = tinggi;
                }
                public float hitungLuas()
                {
                    return this.alas * this.tinggi / 2;
                }
                public float hitungKeliling()
                {
                    return this.sisi2 + this.sisi2 + this.sisi2;
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
                public Lingkaran()
                {
                    this.jarijari = r;
                }

                public override double hitungLuas()
                {
                    return (float)(Math.PI * r * r);
                }

                public override double hitungKeliling()
                {
                    return (float)(2 * Math.PI * r);
                }
            }
        }
    }
}