using System.Xml.Linq;

namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = Console.ReadLine();

            var lastSlashIndex = path.LastIndexOf('\\');
            var fullFileName = path[(lastSlashIndex + 1)..];

            var lastDotIndex = fullFileName.LastIndexOf('.');
            string fileName;
            var fileExtension = String.Empty;

            if (lastDotIndex == -1)
            {
                fileName = fullFileName;
            }
            else
            {
                fileName = fullFileName[..lastDotIndex];
                fileExtension = fullFileName[(lastDotIndex + 1)..];
            }

            Console.WriteLine($"File name: {fileName}"); 
            Console.WriteLine($"File extension: {fileExtension}");

            //var name = failName.Split(".").ToArray();
            //Console.WriteLine($"File name: {name[name.Length-2]}");
            //Console.WriteLine($"File extension: {name[name.Length-1]}");
        }
    }
}
