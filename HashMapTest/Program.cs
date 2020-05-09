using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashMapImpl;

namespace HashMapTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            HashMap x = new HashMap();
            Dictionary<String, String> y = new Dictionary<String, String>();
            stopwatch.Start();
            x.insert("Smile", "Now");
            stopwatch.Stop();
            Console.WriteLine("My Hashmap: " + stopwatch.ElapsedTicks);
            stopwatch.Start();
            y.Add("Smile", "Now");
            stopwatch.Stop();
            Console.WriteLine("Default Hashmap: " + stopwatch.ElapsedTicks);

            Console.ReadKey();
        }
    }
}
