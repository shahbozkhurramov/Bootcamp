using System;
using System.Linq;
namespace homework.Solutions{
    class Point{
      private int x;
      private int y;
      public Point(int xt,int yt){
        x=xt;
        y=yt;
      }
      public double Distance(double x1,double y1){
        return Math.Sqrt(Math.Pow(x1-x,2)+Math.Pow(y1-y,2));
      }
    }
    class Circle
    {
      private int radius;
      private int x;
      private int y;
      public Circle(int xt,int yt,int radiust){
        radius=radiust;
        x=xt;
        y=yt;
      }
      public bool Isinside(int x1,int x2){
      var markaz=new Point(x,y);
        if(markaz.Distance(x1,x2)<=radius) return true;
        return false;
      }
    }
    class Prince
    {
      private int x1,x2,y1,y2;
      public Prince(int x1t,int y1t,int x2t,int y2t)
      {
        x1=x1t;
        y1=y1t;
        x2=x2t;
        y2=y2t;
      }
      public bool Cross(int x,int y,int r)
      {
        var aylana1=new Circle(x,y,r);
        if(aylana1.Isinside(x1,y1)==aylana1.Isinside(x2,y2)) return false;
        return true;
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