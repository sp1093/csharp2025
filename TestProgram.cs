using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025
{
    internal class TestProgram
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("TestProgram output");

public static void Main(string[] args)
        {
            Console.WriteLine("");


            /// <summary> 
            /// For more information about writing UDOs, please refer to http://go.microsoft.com/fwlink/?LinkID=623598&clcid=0x409 
            /// </summary>
            [SqlUserDefinedCombiner]
            public class MyCombiner : ICombiner
        {
            public override IEnumerable<IRow> Combine(IRowset left, IRowset right, IUpdatableRow output)
            {
                int i = 0;
                if (right.Rows.GetEnumerator().MoveNext())
                {
                    foreach (IRow row in left.Rows)
                    {
                        output.Set(i++, row);
                        yield return output.AsReadOnly();
                    }
                }
            }
        }

        Console.ReadLine();
        }
                

        Console.ReadLine();
        }

    }
}
