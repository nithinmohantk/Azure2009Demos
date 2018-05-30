using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo dInfo = new DirectoryInfo(@"F:\Temp");
            FileInfo[] fInfo = dInfo.GetFiles("*.htm",SearchOption.TopDirectoryOnly);

            foreach (var file in fInfo)
            {
                string newFile = dInfo.FullName + "\\" + Path.GetFileNameWithoutExtension(file.FullName);
                File.Move(file.FullName, newFile);

                string str = string.Empty;
            }
        }
    }
}
