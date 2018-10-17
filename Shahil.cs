using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace File_Input_output_index
{
    class Shahil
    {
        static void Main()
        {
           FileStream F = new FileStream("F:\\Shahil.txt", FileMode.OpenOrCreate);
            F.WriteByte(69);
            F.Close();
        }
    }
}
