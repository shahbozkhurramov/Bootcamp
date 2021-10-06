using System;
using System.Linq;

namespace homework.Solutions
{
    class Lab4
    {
        public void Problem1(){
            int k=int.Parse(Console.ReadLine());
            var n=String.Format("{0:D5}",k);
            for(int i=0;i<4;i++){
                Console.Write(n[i]+"!");
            }
            Console.WriteLine(n[4]);
        }
        public void Problem2(){
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("{0}:{1}:{2}", n/3600, n%3600/60, n%60);
        }
        public void Problem3(){
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine(n/100%10);
        }
        public void Problem4(){
            float n=float.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(n/1000)*1000);
        }
        public void Problem5(){
            float a=float.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(a*a/(4*3.14)));
        }
        public void Problem6(){
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine(a>=20 && a<=30?1:0);
        }
        public void Problem7(){
            char c =char.Parse(Console.ReadLine());
            Console.WriteLine((c>=65 && c<=90)||(c>=97 && c<=122)?1:0);
        }
        public void Problem8(){
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine(a%2==0?"even":"odd");
        }
        public void Problem9(){
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(ints[0]>ints[1]?ints[0]:ints[1]);
        }
        public void Problem10(){
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine("{0}\n{1}", Math.Max(ints[0], ints[1])/Math.Min(ints[0], ints[1]),Math.Max(ints[0], ints[1])%Math.Min(ints[0], ints[1]));
        }

    }
}