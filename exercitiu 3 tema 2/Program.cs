﻿using System;

namespace MyFirstProgram2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int media = 0;
            int suma = 0;
            int i;
            for (i = 0; i <= n; i = i + 2)
            {
                suma = i + i;
                media = suma / i;

            }
            Console.Write(media);
            Console.ReadLine();




        }
    }//Să se scrie un program care citeşte de la tastatură un şir de n numere naturale şi determină media aritmetică a celor pare, n fiind citit de la tastatura

}
