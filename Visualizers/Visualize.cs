using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleTables;

namespace SistemasNumericos.Visualizers
{
    public class Visualize
    {
        public void ConsoleSimpleView(List<int> numbers)
        {
            foreach(var number in numbers)
            {
                Console.Write(number);
            }
        }

        public void ViewElaboredTable(Dictionary<ulong, int> numbers)
        {
            var table = new ConsoleTable("QUOTIENT", "RESIDUE");

            foreach(var entry in numbers)
            {
                table.AddRow(entry.Key, entry.Value);
            }

            table.Write();
        }
    }
}
