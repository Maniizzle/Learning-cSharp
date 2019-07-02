using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactWriters
{
    public class ByteConversions
    {
        private const int V = 1024;

        public static void DisplayFilesinDirectory(string directoryPath)
        {
            DirectoryInfo dir = new DirectoryInfo(directoryPath);
            FileInfo[] files = dir.GetFiles();
            Console.WriteLine($"Total Files Found is :{files.Length}");

            var fileSizeInBytes = files.Sum(x => x.Length);
            Console.WriteLine($"All File Sizes{fileSizeInBytes}");
            var filesData = files.OrderByDescending(x => x.Name).
                                               ThenBy(x => x.Length);
            foreach(var file in filesData)
            {
                string fileLength= ByteConversions.ByteConversion(file.Length);
                Console.WriteLine($"FIle Name : {file.Name,-30}, File Size : {fileLength,15:N0}");
            }
        }
        public static string ByteConversion(double bytes)
        {
            if (bytes >=0 && bytes<= V)
                return $"{bytes} byte";
            if (bytes > 1023 && bytes < (Math.Pow(V, 2)))
                return $"{(bytes / V):N2} KB";
            if (bytes > ((V*V)-1) && bytes < (Math.Pow(V, 3)))
                return $"{(bytes / (V * V)):N2} MB";
            if (bytes > ((V*V*V)-1) && bytes < (Math.Pow(V,4)))
                return $"{(bytes / (Math.Pow(V, 3))):N2} GB";
            if (bytes > ((Math.Pow(V, 4)) - 1) && bytes < (Math.Pow(V, 5)))
                return $"{(bytes / (Math.Pow(V, 4))):N3} MB";
            return "Number out of Scope";
        }

        

    }
}
