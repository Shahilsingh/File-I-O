using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace File_Input_output_index
{
    class For
    {
        static void Main()
        {
            FileStream f = new FileStream("F:\\R.txt", FileMode.OpenOrCreate);
            for(int i = 67; i < 88 ; i++)
            {
                f.WriteByte((byte)i);
            }
            f.Close();
        }
    }
}
