using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    internal class WorkingWithFiles
    {
        public static void FilesDemo()
        {
            var path = @"c:\somefile.jpg";

            // static methods
            // copy a file
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true); // verbatim string
            // delete a file
            File.Delete(path);
            // check if a file exists
            if (File.Exists(path))
            {
                // ...
            }
            // read a file
            var content = File.ReadAllText(path);

            // instance methods
            var fileInfo = new FileInfo(path);
            // copy
            fileInfo.CopyTo("...");
            // delete
            fileInfo.Delete();
            // exists
            if (fileInfo.Exists)
            {
                // ...
            }
            // doesn't have a read method
        }

        public static void DirectoryandDirectoryInfoDemo()
        {
            // Directory - static
            Directory.CreateDirectory(@"c:\temp\folder1");

            // Get all files from a directory and its subdirectories
            var files = Directory.GetFiles(@"C:\Users\lion_\Desktop\workspace\masterc#", "*.sln", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            // Get all directories
            var directories = Directory.GetDirectories(@"C:\Users\lion_\Desktop\workspace\masterc#", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            // Directory exists?
            Console.WriteLine(Directory.Exists(@"C:\Users\lion_\Desktop\workspace\masterc#"));

            // DirectoryInfo - instance
            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }


        public static void PathDemo()
        {
            var path = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            // Poor way
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            // Path Class
            Console.WriteLine("Extension: " + Path.GetExtension(path)); // file extension: .sln
            Console.WriteLine("File Name: " + Path.GetFileName(path)); // file name: HelloWorld.sln
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path)); // without ext: HelloWorld
            Console.WriteLine("Directory name: " + Path.GetDirectoryName(path)); // directory name: C:\Projects\CSharpFundamentals\HelloWorld
        }


        public static void ExerciseOne()
        {
            // Write a program that reads a text file
            // and displays the number of words.
            var path = @"C:\Users\lion_\Desktop\workspace\masterc#\CSharpFundamentals\CSharpFundamentals\testFile1.txt";
            var text = File.ReadAllText(path);
            var words = text.Split(' ');
            var counter = 0;

            foreach (var word in words)
            {
                counter++;
            }

            Console.WriteLine("Number of words: " + counter);
        }

        public static void ExerciseTwo()
        {
            // Write a program that reads a text file
            // and displays the longest word in the file. 
            var path = @"C:\Users\lion_\Desktop\workspace\masterc#\CSharpFundamentals\CSharpFundamentals\testFile1.txt";
            var text = File.ReadAllText(path);
            var words = text.Split(' ');
            // longest word is the first one
            var longestWord = words[0];
            var amountOfWords = longestWord.Length;

            // Check the longest word
            for(var i = 1; i < words.Length;i++)
            {
                amountOfWords = words[i].Length;

                if(amountOfWords > longestWord.Length)
                {
                    longestWord = words[i];
                }
            }

            Console.WriteLine("Longest word: " + longestWord);
        }
    }
}
