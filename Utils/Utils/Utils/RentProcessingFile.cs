using System;
using System.IO;

namespace Utils
{
    public class RentProcessingFile
    {
        string path = @"C:\Users\liviu.sosu\Work\Projects\Tutorial\Machine  Learning\Machine-Learning\Utils\Utils\Utils\";
        public void Lines()
        {
            foreach (string line in File.ReadLines(path + "rent.txt"))
            {
                string[] info = line.Split(';');
                using (StreamWriter sw = File.AppendText(path+"income.txt"))
                {
                    sw.WriteLine(info[0]);
                }

                using (StreamWriter sw = File.AppendText(path + "profit.txt"))
                {
                    sw.WriteLine(info[1]);
                }
            }
        }
    }

}
