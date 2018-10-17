using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                FileStream f = new FileStream("G:\\Ashu.txt", FileMode.Create);
                StreamWriter s = new StreamWriter(f);

                s.WriteLine("hello c#");
                s.Close();
                f.Close();
                Console.WriteLine("File created successfully...");
                Console.ReadLine();
            }
        }
    }
}
