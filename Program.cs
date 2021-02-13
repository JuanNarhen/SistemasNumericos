using SistemasNumericos.Constants;
using SistemasNumericos.Converts;
using SistemasNumericos.Visualizers;
using System;
using System.Collections.Generic;

namespace SistemasNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseNum = BaseConstants.Octal;
            var decimalNumber = 1002652783;

            var converter = new ConvertNumber();
            var visualizer = new Visualize();

            var convertedNumber = converter.ConvertFromDecimalToBase_Complex((ulong)decimalNumber, baseNum);
            visualizer.ViewElaboredTable(convertedNumber);

            Console.ReadKey();
        }
    }
}
