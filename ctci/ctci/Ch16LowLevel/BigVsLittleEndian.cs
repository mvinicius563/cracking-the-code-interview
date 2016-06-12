using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctci.Ch16LowLevel
{
    /// <summary>
    /// In big endian, the most significant byte is stored at the memory address location with the lowest address
    /// This is akin to left-to-right reading order
    /// Little endian is the reverse: the most significant byte is stored at the address with the highest address
    /// </summary>
    internal class BigVsLittleEndian
    {
        internal static void Run()
        {
            //var x = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(x, 2));
            var t = 0x0001;
            var b = BitConverter.GetBytes(t);
            if (b[0] == 1)
            {
                Console.WriteLine($"LittleEndian; BitConverter.IsLittleEndian={BitConverter.IsLittleEndian}");
            }
            else
            {
                Console.WriteLine($"BigEndian; BitConverter.IsLittleEndian={BitConverter.IsLittleEndian}");
            }
        }


    }
}
