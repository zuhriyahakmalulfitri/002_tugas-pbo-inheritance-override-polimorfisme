using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu utama = new Menu();
            utama.menu();
            Console.ReadLine();
        }
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

            PersegiPanjang pp = new PersegiPanjang();

            Console.WriteLine("3. Menghitung Persegi Panjang");
            Console.Write("Panjang : ");
            pp.panjang = (int.Parse(Console.ReadLine()));
            Console.Write("Lebar   : ");
            pp.lebar = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Luas    = {0} cm", pp.hitungLuas());
            Console.WriteLine("Keliling   = {0} cm", pp.hitungKeliling());
            Console.WriteLine();

            Segitiga s = new Segitiga();

            Console.WriteLine("4. Menghitung Segitiga");
            Console.Write("Alas   : ");
            s.alas = (int.Parse(Console.ReadLine()));
            Console.Write("Tinggi : ");
            s.tinggi = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Luas   = {0} cm", s.luas_segitiga());
        }

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

    class Persegi : BangunDatar
    {
        private double s;

        public double sisi
        {
            get { return s; }
            set { s = value; }
        }

        public override double hitungLuas()
        {
            _hitung = s * s;
            return _hitung;
        }

        public override double hitungKeliling()
        {
            _hitung = s * 4;
            return _hitung;
        }

    }

    class Lingkaran : BangunDatar
    {
        private double r, luas;

        public double jarijari
        {
            get { return r; }
            set
            {
                r = value;
            }
        }

        public override double hitungLuas()
        {
            luas = 3.14 * r * r;
            return luas;
        }
        public override double hitungKeliling()
        {
            float k = (float)(2 * Math.PI * r);
            return k;
        }
    }

    class PersegiPanjang : BangunDatar
    {
        private float p, l, luas;

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

        public override double hitungLuas()
        {
            luas = p * l;
            return luas;
        }
        public override double hitungKeliling()
        {
            float k = 2 * panjang + 2 * lebar;
            return k;
        }
    }

    class Segitiga
    {
        private float a, t, luas;

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

        public float luas_segitiga()
        {
            luas = (a * t) / 2;
            return luas;
        }
    }
}