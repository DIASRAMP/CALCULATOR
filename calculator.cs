//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
		int a, b;
        int pilihan;

        Console.WriteLine("Pilih menu calculator:");

        Console.WriteLine("1. Penambahan");
        Console.WriteLine("2. Pengurangan");
        Console.WriteLine("3. Perkalian");
        Console.WriteLine("4. Pembagian");

        Console.WriteLine("Input nomor menu[1..4]:");
        pilihan = int.Parse(Console.ReadLine());
		
		if (pilihan == 1)
            {
                Console.WriteLine("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b = ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("hasil penambahan" + a + "+" + b + "=" + penambahan(a, b));
            }

            else if (pilihan == 2)
            {
                Console.WriteLine("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b = ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("hasil pengurangan {0}-{1}={2}", a, b, pengurangan(a, b));
            }

            else if (pilihan == 3)
            {
                Console.WriteLine("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b = ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("hasil pengurangan {0}*{1}={2}", a, b, perkalian(a, b));
            }

            else if (pilihan == 4)
            {
                Console.WriteLine("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b = ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("hasil pengurangan {0}/{1}={2}", a, b, pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
            }
        }

        static int penambahan(int a, int b)
        {
            return a + b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static int pembagian(int a, int b)
        {
            return a / b;
        }        
    }
}