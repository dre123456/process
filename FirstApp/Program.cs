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
        public void MeasuringAddingProcessAdd(List<int> lMetter)
        {


            Stopwatch ProcessTime = new Stopwatch();
            ProcessTime.Start();
            for (int i = 0; i <= 10000000; i++)
            {
                lMetter.Add(0);
            }
            ProcessTime.Stop();
            Console.WriteLine(ProcessTime.Elapsed);
        }

      
    }




    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<int> a = new LinkedList<int>();
            listMeter o1 = new listMeter();
            System.Console.WriteLine("LinkedList TimeMillisAdd=" + o1.MeasuringAddingProcessAdd(a));
            /* System.Console.WriteLine("LinkedList TimeMillisGet=" + o1.MeasuringAddingProcessGet(a));
               System.Console.WriteLine("LinkedList TimeMillisGet=" + o1.MeasuringAddingProcessRemove(a));*/
            System.Console.WriteLine();
        }
    }
}
 