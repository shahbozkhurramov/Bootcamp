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
        public void Problem14(){
            int a=int.Parse(Console.ReadLine());
            double sum=0;
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            for(int i=0;i<a;i++){
                sum+=Math.Pow(ints[i], 3);
            }
            Console.WriteLine(sum);
        }
        public void Problem15(){
            int n=int.Parse(Console.ReadLine());
            for (int i = 1;; i++)
            {
                if (n % i == 0) n/=i;
                else break;
            }
            if (n == 1) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var k = (int)Math.Floor(Math.Sqrt(number));
                
            for (int i = 3; i <= k; i += 2)
                if (number % i == 0)
                    return false;
            return true;        
        }
        public void Problem16(){
            int n=int.Parse(Console.ReadLine());
            while(IsPrime(n)!=true){
                n++;
            }
            Console.WriteLine(n);
        }
        public void Problem17(){
            int n=int.Parse(Console.ReadLine()),x=0,y=0;
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            for(int i=0;i<n;i++){
                if((i+1)%4==1) y+=ints[i];
                else if((i+1)%4==2) x+=ints[i];
                else if((i+1)%4==3) y-=ints[i];
                else x-=ints[i];
            }
            Console.WriteLine($"{x} {y}");
        }
        static int coll(int n)
        {
            int count=0;
            while (n != 1)
            {
                if (n%2 == 1) n=3*n+1;
                else n=n/2;
                count++;
            }
            return count;
        }
        public void Problem18(){
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            if(coll(ints[0])<coll(ints[1])) Console.WriteLine($"{ints[0]} {coll(ints[0])}");
            else Console.WriteLine($"{ints[1]} {coll(ints[1])}");
        }
        public void Problem19(){
            int n=int.Parse(Console.ReadLine());
            int a = 0, b = 1, c=1;  
            for (int i = 2; i < n; i++)  
            {  
                c= a + b; 
                a= b;  
                b= c;  
            }
            Console.WriteLine(c);  
        }
        public void Problem20(){
            int n=int.Parse(Console.ReadLine()),count=0;
            if(n<10) n*=10;
            int temp=n;
            while(true){
                int result = n.ToString().Sum(c => c - '0')%10;
                n=n%10*10+result;
                count++;
                if(n==temp) break;
            }
            Console.WriteLine(count);
        }
        public int rev(int num)
        {
            int result=0;
            while (num>0) 
            {
            result = result*10 + num%10;
            num /= 10;
            }
            return result;
        }
        static bool pal(int n)
        {
            string str=n.ToString();
            int len = str.Length; 
            for(int i = 0; i < len / 2; i++)
            {
                if (str[i] != str[len - i - 1])
                    return false;
            }
            return true;
        }
        public void Problem21(){
            int n=int.Parse(Console.ReadLine()),count=0;
            while(pal(n)==false){
                n+=rev(n);
                count++;
            }
            Console.WriteLine($"{count} {n}");
        }
        int order(int x)
        {
            int n = 0;
            while (x != 0)
            {
                n++;
                x = x / 10;
            }
            return n;
        }
        int power(int x, long y)
        {
            if( y == 0)
                return 1;
            if (y % 2 == 0)
                return power(x, y / 2) *
                    power(x, y / 2);
                        
            return x * power(x, y / 2) *
                    power(x, y / 2);
        }
        public void arm(int x)
        {
            int n=order(x);
            int temp = x, sum = 0;
            while (temp != 0)
            {
                int r = temp % 10;
                sum = sum + power(r, n);
                temp = temp / 10;
            }
            if(sum==x) Console.Write($"{x} ");
            else Console.Write("");
        }
        public void Problem22(){
            int n=int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++){
                arm(i);
            }
        }
        public void Problem23(){
            var c=Console.ReadLine();
            Console.WriteLine(c.Length);
        }
        public void Problem24(){
            int n=int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++){
                for(int j=0;j<=i;j++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}