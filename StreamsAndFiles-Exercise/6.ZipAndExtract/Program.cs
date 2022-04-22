using System;
using System.IO.Compression;

namespace _6.ZipAndExtract
{
    public class Program
    {
        static void Main(string[] args)
        {
            ZipArchive zipArchive = ZipFile.Open("zipfile.zip",ZipArchiveMode.Create);
            ZipArchiveEntry zipArchiveEntry = zipArchive.CreateEntryFromFile("output.txt", "entry.txt");
        }
    }
}
