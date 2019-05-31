using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Treinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo04

            string path = @"C:\Users\felipe.decker\temp\texto.txt";

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }

            #endregion

            #region Exemplo03

            //string path = @"C:\Users\felipe.decker\temp\texto.txt";

            //StreamReader sr = null;

            //try
            //{
            //    sr = File.OpenText(path);
            //    while (!sr.EndOfStream)
            //    {
            //        string line = sr.ReadLine();
            //        Console.WriteLine(line);
            //    }

            //    Console.ReadLine();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    throw;
            //}
            //finally
            //{
            //    if (sr != null)
            //    {
            //        sr.Close();
            //    }
            //}

            #endregion

            #region Exemplo02

            //string path = @"C:\Users\felipe.decker\temp\texto.txt";

            //FileStream fs = null;
            //StreamReader sr = null;

            //try
            //{
            //    fs = new FileStream(path, FileMode.Open);
            //    sr = new StreamReader(fs);

            //    string line = sr.ReadLine();
            //    Console.WriteLine(line);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    throw;
            //}
            //finally
            //{
            //    if (sr != null)
            //    {
            //        sr.Close();
            //    }

            //    if (fs != null)
            //    {
            //        fs.Close();
            //    }
            //}

            #endregion
        
            #region Exemplo01

            //string source = @"C:\Users\felipe.decker\temp\texto.txt";
            //string destiny = @"C:\Users\felipe.decker\temp\texto2.txt";
            //string[] linhas = File.ReadAllLines(source);

            //foreach (var line in linhas)
            //{
            //    Console.WriteLine(line);
            //}

            //try
            //{
            //    FileInfo fileInfo = new FileInfo(source);
            //    fileInfo.CopyTo(destiny);
            //}
            //catch (IOException e)
            //{

            //    Console.WriteLine("Ocorreu um puta erro!!! ta fudido");
            //    Console.WriteLine(e.Message);
            //}

            //Console.ReadLine();

            #endregion

        }
    }
}
