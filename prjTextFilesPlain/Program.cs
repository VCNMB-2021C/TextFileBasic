using System;
using System.IO;
using System.Linq;
namespace prjTextFilesPlain
{
    class Program
    {
        private static  string path = System.IO.Path.GetFullPath(@"..\..\..\")+"flex.txt";
        static void Main(string[] args)
        {

            //using (StreamWriter sw = new StreamWriter(path,true))
            //{
            //    sw.WriteLine("Hello WOrld from 20290229309");
            //    sw.Close();
            //}

            //StreamReader sr = new StreamReader(path, true);
            //for(int i = 0; i< File.ReadLines(path).Count();i++)
            //{
            //    String strLine1 = sr.ReadLine();
              
            //    Console.WriteLine(strLine1);
            //}

            if ( !File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Brad deleted me oh no , oh no , oh no");
                    sw.Close();
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine("Never mind brad didnt do anything");
                    sw.Close();
                }
            }


        }
    }
}
