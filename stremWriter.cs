using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Input_output_index
{
    class stremWriter
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("f:\\output.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);

            s.WriteLine("hello c#");
            s.Close();
            f.Close();
            Console.WriteLine("File created successfully...");
            Console.ReadLine();
        }
              
    }
}