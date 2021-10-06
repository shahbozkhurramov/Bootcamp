using System;
using System.Linq;
namespace homework.Solutions
{
    class Lab6{
        public void Problem1(){
            int k=int.Parse(Console.ReadLine());
            for(int i=1;i<=k;i++){
                if(k%i==0) Console.Write($"{i} ");
            }
        }
        public void Problem2(){
            int n=int.Parse(Console.ReadLine());
            int k=int.Parse(Console.ReadLine());
            while(n!=k){
                if(n<k) Console.WriteLine($"{k}>");
                else Console.WriteLine($"{k}<");
                k=int.Parse(Console.ReadLine());
            }
        }
        public void Problem3(){
            var ints=Console.ReadLine().Split().Select(int.Parse).ToList();
            int i=0,c=0;
            while(ints[i]!=0){
                c+=ints[i];
                i++;
            }
            Console.WriteLine(c);
        }
        public void Problem4(){
            for(int i=2;i<=10;i++){
                int count=1;
                Console.Write($"{i}!=1");
                for(int j=2;j<=i;j++){
                    Console.Write($"*{j}");
                    count*=j;
                }
                Console.WriteLine($"={count}");
            }
        }
        public void Problem5(){
            var arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            int a=arr[0], b=arr[1];
            while (a != 0 && b != 0)
                if (a > b) a %= b;
                else b %= a;
            Console.WriteLine(a|b);
        }
        public void Problem6(){
            for(int i=0;i<5;i++){
                for(int j=1;j<5-i;j++) Console.Write(" ");
                for(int j=0;j<=i;j++) Console.Write("*");
                for(int j=0;j<i;j++) Console.Write("*");
                Console.WriteLine();
            }
            for(int i=0;i<4;i++){
                for(int j=0;j<=i;j++) Console.Write(" ");
                for(int j=0;j<4-i;j++) Console.Write("*");
                for(int j=1;j<4-i;j++) Console.Write("*");
                Console.WriteLine();
            }
        }
        public void Problem7(){
            for(int i=1;i<=10;i++){
                for(int j=i;j<10+i;j++){
                    Console.Write($"{j%10} ");
                }
                Console.WriteLine();
            }
        }
        public void Problem8(){
            int n=int.Parse(Console.ReadLine()), count=0;
            for(int i=3;i<n;i++){
                count+=i.ToString().Count(f => (f == '3'));
            }
            Console.WriteLine(count);
        }
        public void Problem9(){
            int n=1;
            int a=int.Parse(Console.ReadLine());
            for(int k=1;k<=a;k++){
                for(int j=1;j<=a-k;j++) Console.Write(" ");
                for(int c=1; c<=k;c++)
                {
                if(n==10) n=0;
                Console.Write($"{n} ");                
                n++;
                }
                Console.WriteLine();
            }
        }
        public void Problem10(){
            int a=int.Parse(Console.ReadLine());
            while(a>=10){
                a=a.ToString().Sum(c => c - '0');
            }
            Console.WriteLine(a);
        }
        public void Problem11(){
            for(int i=1;i<=6;i++){
                for(int j=1;j<=6;j++){
                    for(int k=1;k<=6;k++){
                        if(i+j+k==10) Console.WriteLine($"{i} {j} {k}");
                    }
                }
            }
        }
        public void Problem12(){
            int a=int.Parse(Console.ReadLine()), count=0;
            for(int i=1;i<=a;i++){
                count+=i;
            }
            Console.WriteLine(count);
        }
        public void Problem13(){
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            float len=ints.Count();
            int sum=0,count=0;
            float aver=0;
            for(int i=0;i<len;i++){
                if(ints[i]<0) break;
                sum+=ints[i];
                aver+=ints[i];
                count++;
            }
            Console.WriteLine($"{sum} {(aver/len).ToString("0.00")} {len}");
        }


    }
}