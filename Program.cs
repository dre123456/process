using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using FirstApp;

namespace FirstApp
{
    public class listMeter
    {
        public long MeasuringAddingProcessAdd(List<int> lMetter)
        {

            Stopwatch myStopwatch = new Stopwatch();
            myStopwatch.Start();
            for (int i = 0; i <= 10000000; i++)
                lMetter.Add(0);
            myStopwatch.Stop();
            TimeSpan ts = myStopwatch.Elapsed;
            long elapsedTime = ts.Milliseconds;
            return elapsedTime;


        }

        public long MeasuringAddingProcessGet(List<int> lMetter)
        {

            Stopwatch myStopwatch = new Stopwatch();
            myStopwatch.Start();
            for (int i = 0; i <= 10000000; i++)
                lMetter.BinarySearch(0);
            myStopwatch.Stop();
            TimeSpan ts = myStopwatch.Elapsed;
            long elapsedTime = ts.Milliseconds;
            return elapsedTime;
        }

               public long MeasuringAddingProcessRemove(List<int> lMetter)
                        {

                            Stopwatch myStopwatch = new Stopwatch();
                            myStopwatch.Start();
            for (int i = 0; i <= 10000000; i++)
               if (i == 10000000)
              {
                    lMetter.Remove(i);
               }
                            myStopwatch.Stop();
                            TimeSpan ts = myStopwatch.Elapsed;
                            long elapsedTime = ts.Milliseconds;
                            return elapsedTime;
                        }
                }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>(new LinkedList<int>());
            listMeter o1 = new listMeter();
            System.Console.WriteLine("LinkedList TimeMillisAdd=" + o1.MeasuringAddingProcessAdd(a));
            System.Console.WriteLine("LinkedList TimeMillisGet=" + o1.MeasuringAddingProcessGet(a));
            System.Console.WriteLine("LinkedList TimeMillisRemove=" + o1.MeasuringAddingProcessRemove(a));
            System.Console.ReadKey();
        }
    }
}
