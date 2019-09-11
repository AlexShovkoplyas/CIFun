using System;
using System.Threading.Tasks;

namespace App
{
    public class Calculator
    {
        public decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public decimal Divide(decimal x, decimal y)
        {
            if (y == 0)
            {
                throw new Exception("Divide by zero");
            }

            return x / y;
        }

        public async Task<string> LongTask(decimal x)
        {
            await Task.Delay(1000);

            return x.ToString();
        }
    }
}