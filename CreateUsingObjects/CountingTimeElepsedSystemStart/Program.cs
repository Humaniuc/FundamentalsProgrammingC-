using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingTimeElepsedSystemStart
{
    class Program
    {
        static void Main(string[] args)
        {
            long tickCount = Environment.TickCount;
            int days = (int)((tickCount / 86400000 > 0) ? tickCount / 86400000 : 0);
            tickCount -= days * 86400000;
            int hours = (int)((tickCount / 3600000 > 0) ? tickCount / 3600000 : 0);
            tickCount -= hours * 3600000;
            int mins = (int)((tickCount / 60000 > 0) ? tickCount / 60000 : 0);
            tickCount -= mins * 60000;

            Console.WriteLine($"{days} days, {hours} hours and {mins} mins.");
        }
    }
}
