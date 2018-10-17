using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
 
namespace File_Input_output_index
{
    class AshuCLass
    {
        static void Main(string[] args)
        {
            //FileStream f = new FileStream("F:\\aa.txt", FileMode.OpenOrCreate);
            //f.WriteByte(66);
            //f.Close();
            //Console.ReadLine();
            Dictionary<int, string> names = new Dictionary<int, string>();
            names.Add(1, "Sonoo");
            names.Add(2, "Peter");
            names.Add(3, "James");
            names.Add(4, "Ratan");
            names.Add(5, "Irfan");
            names.Add(6, "Sonoo");

            foreach (KeyValuePair<int, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
                Console.ReadLine();
            }
            Console.ReadKey();


        }
    }
}
