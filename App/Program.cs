using System;
using System.Threading.Tasks;
using StackExchange.Profiling;

namespace App
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var profiler = MiniProfiler.StartNew("My Profiler Name");
            using (profiler.Step("Main Work"))
            {
                // Do some work...
                Console.WriteLine("Hello World!");

                var calc = new Calculator();

                var x = calc.Add(2, calc.Divide(6, 2));

                var d = await calc.LongTask(x);

                Console.WriteLine(d);
            }

            using (profiler.Step("Second Work"))
            {
                // Do some work...
                Console.WriteLine("Hello World!");

                var calc = new Calculator();

                var d = calc.Add(2,3);

                Console.WriteLine(d);
            }

            Console.WriteLine(profiler.RenderPlainText());

        }
    }
}
