using System;
using System.Linq;

namespace homework.Solutions
{
    class Lab5
    {
        public void Problem1(){
            int k=int.Parse(Console.ReadLine());
            Console.WriteLine(k>0 && k<41?"indoor activity":"outdoor activity");
        }
        public void Problem2(){
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            int a=Math.Max(ints[0], ints[1]),b=Math.Min(ints[0], ints[1]);
            Console.WriteLine(Math.Pow(b,2)==a?b.ToString()+"*"+b.ToString()+"="+a.ToString():"none");
        }
        public void Problem3(){
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(Math.Max(ints[0], ints[1]));
        }
        public void Problem4(){
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            ints.Sort();
            Console.WriteLine("{0} {1}",ints[2],ints[0]);
        }
        public void Problem5(){
            int n=int.Parse(Console.ReadLine());
            if(n%2==0 && n%3==0 && n%5==0) Console.WriteLine("A");
            else if(n%2==0 && n%3==0) Console.WriteLine("B");
            else if(n%2==0 && n%5==0) Console.WriteLine("C");
            else if(n%5==0 && n%3==0) Console.WriteLine("D");
            else if(n%2==0 || n%3==0 || n%5==0) Console.WriteLine("E");
            else Console.WriteLine("N");
        }
        public void Problem6(){
            int n=int.Parse(Console.ReadLine());
            if((n%100!=0 && n%4==0) || (n%400==0)) Console.WriteLine("Leap Year");
            else Console.WriteLine("Normal Year");
        }
        public void Problem7(){
            int n=int.Parse(Console.ReadLine()),c=3;
            while(c>0){
                int a=int.Parse(Console.ReadLine());
                if(a==n){
                    Console.WriteLine("CORRECT");
                    break;
                }
                else if(a>n) Console.WriteLine("DOWN");
                else 
                    Console.WriteLine("UP");
                c--;
            }
        }
        public void Problem8(){
            char ch=char.Parse(Console.ReadLine());
            if(Char.IsLetter(ch))
                Console.WriteLine(ch<='Z'?Convert.ToChar(ch+32):Convert.ToChar(ch-32));
            else Console.WriteLine("none");
        }
        public void Problem9(){
            int s=0,d=0; 
            var a=Console.ReadLine().Split().Select(int.Parse).ToList(); 
            var a1=Console.ReadLine().Split().Select(int.Parse).ToList();
            if(a1[0]==a[0]){ s++; } 
            else if(a1[0]==a[1]){ d++; } 
            else if(a1[0]==a[2]){ d++; } 
            if(a1[1]==a[1]){ s++; } 
            else if(a1[1]==a[0]){ d++; } 
            else if(a1[1]==a[2]){ d++; } 
            if(a1[2]==a[2]){ s++; } 
            else if(a1[2]==a[0]){ d++; } 
            else if(a1[2]==a[1]){ d++; } 
            Console.WriteLine("{0}S{1}B", s,d);
        }
        public void Problem10(){
            var s=Console.ReadLine();
            System.Data.DataTable table = new System.Data.DataTable();
            Console.WriteLine(table.Compute(s, String.Empty));
        }
        public void Problem11(){
            int n=int.Parse(Console.ReadLine()),m=int.Parse(Console.ReadLine());
            string[] wen={"Americano","Caffe Latte","Lemon Tea"};
            Console.WriteLine($"{wen[n-1]}\n{(m-600+n*100)/500} {(m-600+n*100)%500/100}");
        }
        public void Problem12(){
            int n=int.Parse(Console.ReadLine());
            if(n==1) Problem4();
            else if(n==2) Problem9();
            else Problem10();
        }
        public void Problem13(){
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            if(ints[0]+ints[1]>100) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
        public void Problem14(){
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            ints.Sort();
            if(Math.Pow(ints[0], 2)+Math.Pow(ints[1], 2)==Math.Pow(ints[2], 2)) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
        public void Problem15(){
            var c=Console.ReadLine();
            if(c=="-" || c=="+" || c=="*" || c=="/" || c=="%") Console.WriteLine("true");
            else Console.WriteLine("false");
        }
        public void Problem16(){
            int son=int.Parse(Console.ReadLine());
            var mes=son switch 
            {
                1=>$"bir",
                0=>$"nol",
                2=>$"ikki",
                3=>$"uch",
                4=>$"to'rt",
                5=>$"besh",
                6=>$"olti",
                7=>$"yetti",
                8=>$"sakkiz",
                9=>$"to'qqiz",
                _=>$"bpshqa"
            };
            Console.WriteLine(mes);
        }
        public void Problem17(){
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            int a=ints[0],b=ints[1],c;
            if(a>=1)
            {
                if(b>=45)
                {
                c=b-45;
                a=a;
                }
                else
                {
                c=b+15;
                a=a-1;
                }
            }
            else{
                if(b>=45)
                {
                c=b-45;
                a=a;
                }
                else
                {
                c=b+15;
                a=23;
                }  
            }
            Console.WriteLine($"{a} {c}");
        }
        public void Problem18(){
            int n=int.Parse(Console.ReadLine());
            if(n>=90) Console.WriteLine("A");
            else if(n>=80) Console.WriteLine("B");
            else if(n>=70) Console.WriteLine("C");
            else if(n>=60) Console.WriteLine("D");
            else Console.WriteLine("F");
        }
        public void Problem19(){
            int a=int.Parse(Console.ReadLine());
            if(a>=3000 && a<=1000000){
                if(a % 1000 >= 500) Console.WriteLine((a/1000)*1000+1000);
                else Console.WriteLine((a/1000)*1000);
            }
        }
        public void Problem20(){
            var a=Console.ReadLine();
            if((a[0]>='A' && a[0]<='Z') || (a[0]>='a' && a[0]<='z')) Console.WriteLine("1");
            else Console.WriteLine("0");
        }
        public void Problem21(){
            int a=int.Parse(Console.ReadLine());
            if(a%2==0) Console.WriteLine("even");
            else Console.WriteLine("odd");
        }

    }
}