using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileEditor
{
    class TextFileOperations
    {
        public static string ReadTextFileContents(string fileName)
        {
            return File.ReadAllText(fileName);
        }
        public static void WriteTextFileContents(string fileName, string text)
        {
            File.WriteAllText(fileName, text);
        }
    }
}
