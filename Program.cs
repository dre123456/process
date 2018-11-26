using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp;

namespace FirstApp
{
    public class listMeter
    {
        public long MeasuringAddingProcessAdd(List<int> lMetter)
        {
           long start = System.Diagnostics.Stopwatch();
            for (int i = 0; i <= 10000000; i++)
         {
             lMetter.Add(0);
         }
            long stop = System.Diagnostics.Stopwatch();
         //Console.WriteLine(ProcessTime.Elapsed);
            return stop-start ;
    }      
    }
    class Program
    {
        static void Main(string[] args){
            List<int> a = new List<int>(new LinkedList<int>());
            listMeter o1 = new listMeter();
            System.Console.WriteLine("LinkedList TimeMillisAdd="+ o1.MeasuringAddingProcessAdd(a));
            /* System.Console.WriteLine("LinkedList TimeMillisGet=" + o1.MeasuringAddingProcessGet(a));
               System.Console.WriteLine("LinkedList TimeMillisGet=" + o1.MeasuringAddingProcessRemove(a));*/
            System.Console.WriteLine();
        }
    }
}
