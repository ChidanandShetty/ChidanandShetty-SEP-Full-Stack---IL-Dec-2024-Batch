using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    internal class PrintSize
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Data Type Information in C#:");
            Console.WriteLine("-----------------------------------------");

            PrintTypeInfo("sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            PrintTypeInfo("byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            PrintTypeInfo("short", sizeof(short), short.MinValue, short.MaxValue);
            PrintTypeInfo("ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            PrintTypeInfo("int", sizeof(int), int.MinValue, int.MaxValue);
            PrintTypeInfo("uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            PrintTypeInfo("long", sizeof(long), long.MinValue, long.MaxValue);
            PrintTypeInfo("ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            PrintTypeInfo("float", sizeof(float), float.MinValue, float.MaxValue);
            PrintTypeInfo("double", sizeof(double), double.MinValue, double.MaxValue);
            PrintTypeInfo("decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void PrintTypeInfo(string typeName, int size, object min, object max)
        {
            Console.WriteLine(typeName.PadRight(10) + " | Size: " + size + " bytes | Min: " + min + " | Max: " + max);

        }
    }
}
