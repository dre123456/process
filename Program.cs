using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstApp
{    я тут ау

   public class listMeter
    {
        public long MeasuringAddingProcessAdd (List<int> lMetter) //<-здесь подчеркивает MeasuringAddingProcessAdd пишет что ошибка не все ветви кода возвращают значение.
        {

            
            long start = System.Diagnostics.Milliseconds();
            MessageBox.Show("");
            sw.Stop();
            MessageBox.Show((sw.ElapsedMilliseconds / 100.0).ToString());

            long start = System.currentTimeMillis();
            for (int i = 0; i <= 10000000; i++)
            {
                lMetter.add(0);
            }
            long end = System.currentTimeMillis();
            return end - start;
        }

    }
    
    
     class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> a = new LinkedList<int>(); //<--и тут подчеркивеет
            listMeter o1 = new listMeter();
            System.Console.WriteLine("LinkedList TimeMillisAdd=" + o1.MeasuringAddingProcessAdd(a));
            /* System.Console.WriteLine("LinkedList TimeMillisGet=" + o1.MeasuringAddingProcessGet(a));
               System.Console.WriteLine("LinkedList TimeMillisGet=" + o1.MeasuringAddingProcessRemove(a));*/
            System.Console.WriteLine();
        }
    }
}