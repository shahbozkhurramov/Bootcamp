using System;
using System.Linq;
namespace Name
{
    class Program{
        static void Main(string[] args){
            string[] input= Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var ints=input.Select(i=>{int son= int.Parse(i);Console.WriteLine(son);return son;}).ToList();
            
        }
    }
    
}
