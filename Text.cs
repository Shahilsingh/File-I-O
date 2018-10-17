using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
    class Text
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("G:\\f.txt"))
            {
                writer.WriteLine("Hello C#");
                writer.WriteLine("C# File Handling by JavaTpoint");
            }
            Console.WriteLine("Data written successfully...");
            Console.ReadLine();
        }
    }
}
