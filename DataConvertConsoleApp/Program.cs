using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConvertConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataConvert.ToNullableDateTime("12.5.2015"));
            Console.WriteLine(DataConvert.ToNullableDouble("12.6958"));
            Console.WriteLine(DataConvert.ToNullableDouble("00012,6958"));
        }
    }
}
