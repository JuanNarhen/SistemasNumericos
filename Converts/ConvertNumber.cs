using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemasNumericos.Converts
{
    public class ConvertNumber
    {
        public List<int> FromDecimalToBase(ulong decimalNum, int baseNum)
        {
            var residue = 0;
            var quotient = decimalNum;

            List<int> convertedNum = new List<int>();

            try
            {
                while (quotient != 1)
                {
                    convertedNum.Add((int)quotient % baseNum);
                    quotient = quotient / (ulong)baseNum;
                }

                convertedNum.Add((int)quotient);
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine($"Something wrong bad in convertion :: data: {JsonConvert.SerializeObject(ex)}");
            }

            return ConvertResultToBase(convertedNum);
        }

        private List<int> ConvertResultToBase(List<int> numberList)
        {
            var result = new List<int>();

            for (int i = numberList.Count-1; i >= 0; i--)
            {
                result.Add(numberList[i]);
            }

            return result;
        }

        public Dictionary<ulong, int> ConvertFromDecimalToBase_Complex(ulong decimalNum, int baseNum)
        {
            var quotient = decimalNum;
            var residue = (ulong)0;
            var result = new Dictionary<ulong, int>();

            while (quotient != 0)
            {
                residue = quotient % (ulong)baseNum;
                quotient = quotient / (ulong)baseNum;
                result.Add(quotient, (int)residue);
            }

            return result;
        }

    }
}
