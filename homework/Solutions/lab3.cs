using System;
using System.Linq;

namespace homework.Solutions
{
    class Lab3
    {
        public void Problem1(){
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine(n);
            Console.WriteLine(n);
        }
        public void Problem2(){
            Console.Write("Width: ");
            int w=int.Parse(Console.ReadLine());
            Console.Write("Height: ");
            int h=int.Parse(Console.ReadLine());
            Console.WriteLine(w*h);
            Console.Write("Width: ");
            float we=float.Parse(Console.ReadLine());
            Console.Write("Height: ");
            float he=float.Parse(Console.ReadLine());
            Console.WriteLine((we*he).ToString("0.00"));
        }
        public void Problem3(){
            float n=float.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(n));
        }
        public void Problem4(){
            Console.Write("Input Lowercase: ");
            var l=Console.ReadLine();
            Console.WriteLine("Uppercase-> {0}",l.ToUpper());
            Console.Write("Input Uppercase: ");
            var u=Console.ReadLine();
            Console.WriteLine("Lowercase-> {0}",u.ToLower());
        }
    }
}