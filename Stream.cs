using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace Index
{
    public class StreamReaderExample
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("G:\\output.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            string line = s.ReadLine();
            Console.WriteLine(line);

            s.Close();
            f.Close();
        }
    }
}