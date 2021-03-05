using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class Userintreface
    {
        public static string GetUserInputfor(string promt)
        {
            Console.WriteLine($"enter your {promt}");
            return Console.ReadLine();
             
        }
    }
}
