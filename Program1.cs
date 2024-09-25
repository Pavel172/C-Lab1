using System;

namespace Task1
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine($"{typeof(bool)}: min:{bool.FalseString} max:{bool.TrueString}");
            Console.WriteLine($"{typeof(byte)}: min:{byte.MinValue} max:{byte.MaxValue}");
            Console.WriteLine($"{typeof(sbyte)}: min:{sbyte.MinValue} max:{sbyte.MaxValue}");
            Console.WriteLine($"{typeof(char)}: min:{char.MinValue} max:{char.MaxValue}");
            Console.WriteLine($"{typeof(short)}: min:{short.MinValue} max:{short.MaxValue}");
            Console.WriteLine($"{typeof(ushort)}: min:{ushort.MinValue} max:{ushort.MaxValue}");
            Console.WriteLine($"{typeof(int)}: min:{int.MinValue} max:{int.MaxValue}");
            Console.WriteLine($"{typeof(uint)}: min:{uint.MinValue} max:{uint.MaxValue}");
            Console.WriteLine($"{typeof(long)}: min:{long.MinValue} max:{long.MaxValue}");
            Console.WriteLine($"{typeof(ulong)}: min:{ulong.MinValue} max:{ulong.MaxValue}");
            Console.WriteLine($"{typeof(decimal)}: min:{decimal.MinValue} max:{decimal.MaxValue}");
            Console.WriteLine($"{typeof(float)}: min:{float.MinValue} max:{float.MaxValue}");
            Console.WriteLine($"{typeof(double)}: min:{double.MinValue} max:{double.MaxValue}");
        }
    }
}
