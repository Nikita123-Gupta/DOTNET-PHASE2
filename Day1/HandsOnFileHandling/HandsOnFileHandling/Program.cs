using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileHandling
{
    class Program
    {
        public static void Read(string path)
        {
            using(StreamReader sr=new StreamReader(path))
            {
                string content = sr.ReadToEnd();//reads all lines of text in the file 
                Console.WriteLine(content);
            }
        }
        static void Main(string[] args)
        {
           try
            {
                Console.WriteLine("Enter Path");
                string path = Console.ReadLine();
                Read(path);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
