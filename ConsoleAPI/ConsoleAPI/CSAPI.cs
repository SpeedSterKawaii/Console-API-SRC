using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPI
{
    public class CSAPI
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool C();

        public void Create(string title) 
        {
            C();
            Console.Title = title;
        }

        public void Line(string line) 
        {
            Console.WriteLine(line);
        }

        public void BGColor(ConsoleColor b) 
        {
            Console.BackgroundColor = b;
        }

        public void FGColor(ConsoleColor e)
        {
            Console.ForegroundColor = e;
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void ReadK()
        {
            Console.ReadKey();
        }

        public void ReadL()
        {
            Console.ReadLine();
        }
    }
}
