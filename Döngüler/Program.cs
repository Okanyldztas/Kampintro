﻿using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            //array - dizi 

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı","Programlamaya başlangıç için temel kurs","Java" };



            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");
            
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
