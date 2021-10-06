using System;
using System.Linq;
namespace homework.Solutions
{
    class Lab2
    {
        public void Problem1(){
            Console.WriteLine("222222\n2    2\n2    2\n222222");
        }
        public void Problem2(){
            Console.WriteLine("   A\n  A A\n A   A\nA A A A");
        }
        public void Problem3(){
            Console.Write("Enter month: ");
            var month=Console.ReadLine();
            Console.Write("Enter date: ");
            var date=Console.ReadLine();
            int month1=int.Parse(month), date1=int.Parse(date);
            Console.WriteLine("Birthdate is " + month1.ToString("00")+"-"+date1.ToString("00"));
            Console.Write("Enter month and date: ");
            string[] input =Console.ReadLine().Split();
            var ints=input.Select(i=> int.Parse(i)).ToList();
            Console.WriteLine("Birthdate is " + ints[0].ToString("00")+"-"+ints[1].ToString("00"));
        }
        public void Problem4(){
            var number=Console.ReadLine();
            Console.WriteLine(number+number+number+number+number+number+"\n"+number+"    "+ number+"\n" +number+"    "+number+ "\n"+number+number+number+number+number+number);
        }
        public void Problem5()
        {
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat Sun");
            Console.WriteLine("  5   6   7   8   9  10  11  12");
        }
        public void Problem6(){
            var number=Console.ReadLine();
            int n=int.Parse(number);
            Console.Write(number+"*1={0}",n*1);
            Console.Write(number+"*2={0}",n*2);
            Console.Write(number+"*3={0}",n*3);
            Console.Write(number+"*4={0}",n*4);
            Console.Write(number+"*5={0}",n*5);
            Console.Write(number+"*6={0}",n*6);
            Console.Write(number+"*7={0}",n*7);
            Console.Write(number+"*8={0}",n*8);
            Console.WriteLine(number+"*9={0}",n*9);
        }
        public void Problem7(){
            Console.WriteLine("1!=1\n2!=2\n3!=6\n4!=24\n5!=120");
        }
        public void Problem8(){
            int a=0,b=1,c=1;
            for(int i=0;i<=6;i++){
                Console.WriteLine(c);
                a=b;
                b=c;
                c=a+b;
            }
        }

    }
}