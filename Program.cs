using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var path = @"c:\somefile.jpg";
            //File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            //File.Delete(path);
            //if (File.Exists(path))
            //{
            //    //
            //}
            //var content = File.ReadAllText(path);

            //var fileInfo = new FileInfo(path);

            //Directory.CreateDirectory(@"c:\temp\folder1");
            //var files = Directory.GetFiles(@"C:\Users\Aaron Singleterry\source\repos", "*.sln", SearchOption.AllDirectories);
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            //var directories = Directory.GetDirectories(@"C:\Users\Aaron Singleterry\source\repos", "*.*", SearchOption.AllDirectories);
            //foreach (var directory in directories)
            //{
            //    Console.WriteLine(directory);
            //}

            //Directory.Exists("..");

            //var directoryInfo = new DirectoryInfo("...");
            //directoryInfo.GetFiles();

            var path = @"C:\Users\Aaron Singleterry\source\repos\FileDirectory\FileDirectory.sln";

            // don't wanna do this
            var dotIndex = path.IndexOf('.');
            var extention = path.Substring(dotIndex);

            // do this instead

            Console.WriteLine("Ext.: " + Path.GetExtension(path));
            Console.WriteLine("Filename: " + Path.GetFileName(path));
            Console.WriteLine("Filename without ext: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory name: " + Path.GetDirectoryName(path));

        }
    }
}
