using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _5.DirectoryTraversal
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            string directoryPath = Directory.GetCurrentDirectory();
            string[] fileNames = Directory.GetFiles(directoryPath);
            Dictionary<string, Dictionary<string, double>> filesData = new Dictionary<string, Dictionary<string, double>>();

            foreach (string file in fileNames)
            {
                FileInfo fileInfo = new FileInfo(file);
                string extention = fileInfo.Extension;
                long size= fileInfo.Length;
                double kbSize = Math.Round(size / 1024.0, 3);

                if (!filesData.ContainsKey(extention))
                {
                    filesData.Add(extention, new Dictionary<string, double>());
                }
                filesData[extention].Add(fileInfo.Name,kbSize);
            }

            filesData = filesData.OrderByDescending(k => k.Value.Count).ThenBy(k => k.Key).ToDictionary(k => k.Key, k => k.Value);
            List<string> res = new List<string>();
            foreach (var item in filesData)
            {
                res.Add(item.Key);

                foreach (var element in item.Value.OrderBy(x=>x.Key))
                {
                    res.Add($"--{ element.Key} - { element.Value}kb");
                }
            }
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "../../../path.txt");
            File.WriteAllLines(filePath, res);
        }
    }
}
