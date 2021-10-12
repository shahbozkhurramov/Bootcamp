
using static System.Console;
using System.Linq;
using homework.Solutions;
namespace homework
{
    class Program
    {
        static void Main()
        {
            // var lab2s=new Lab2();
            // var lab3=new Lab3();
            // var lab4=new Lab4();
            // var lab5 = new Lab5();
            // var lab6=new Lab6();
            int t=int.Parse(ReadLine());
            for(int i=0;i<t;i++){
                var ints=ReadLine().Split().Select(int.Parse).ToList();
                var prince=new Prince(ints[0], ints[1], ints[2], ints[3]);
                int n=int.Parse(ReadLine()),count=0;
                for(int j=0;j<n;j++){
                    var cs=ReadLine().Split().Select(int.Parse).ToList();
                    if(prince.Cross(cs[0], cs[1],cs[2])) count++;
                }
                WriteLine(count);
            }
        }
    }
}

// t=int(input())
// for i in range(t):
//   x1,y1,x2,y2=map(int, input().split())
//   shahzoda=Prince(x1,y1,x2,y2)
//   n=int(input())
//   count=0
//   for j in range(n):
//     cx,cy,r=map(int, input().split())
//     if shahzoda.kes(cx,cy,r):
//       count+=1
//   print(count)