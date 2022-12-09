using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortingDemos
{
    internal class FileReader
    {
        List<string> stringdata= new List<string>();
        int[] data;
        public FileReader(out int[] data)
        {
            data = run("scores.txt");
        }

        public int[] getData()
        {
            return run("scores.txt");
        }
        private int[] run(string filename)
        {
            stringdata = File.ReadAllLines(filename).ToList();
            data = new int[stringdata.Count];
            for(int i =0; i < stringdata.Count; i++)
            {
                data[i] = Int32.Parse(stringdata[i]);
            }
            return data;
        }
    }
}
