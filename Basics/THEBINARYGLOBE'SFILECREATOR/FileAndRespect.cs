using System;
using System.Collections.Generic;
using System.IO;

namespace DIY_Create_AFileAndAsktheuserwhathewouldaddtoit
{
    public class FileAndRespect
    {
        public FileAndRespect(string filePath,string userName)
        {
            FilePath = filePath;
            UserName=userName;
        }

        string FilePath { get; set; }
        static public string UserName{get;set;}
        static public void GreetUser()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Welcome! To The File Manager App by The Binary Globe! Dear {UserName}");   
            Console.WriteLine("What do you want to add to your file?");
           
        }
        static public void WriteToFile(string FilePath, string Content)   
        {
             StreamWriter streamWriter = new StreamWriter(FilePath, true);
            using (streamWriter)
            {
                streamWriter.WriteLine(Content);
                streamWriter.Flush();
            }
        }
        public static IEnumerable<string> ReadFromFile(string FilePath)
        {
            StreamReader UserFile= new StreamReader(FilePath);
            while(!UserFile.EndOfStream)
            {
                yield return UserFile.ReadLine();    
            }
        }

        static public bool AskForAppToEnd(int option)
        {
            switch(option)
            {
                case 1:
                return true;
                case 2:
                return false;
                default:
                return false;
            }
        }
        static public void SaluteUser()
        {
             Console.WriteLine($"Thank you for using our application! BinBot Loves You Dear {UserName}");
        }
    }
}