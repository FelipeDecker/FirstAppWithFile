using System;
using System.Collections;
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
            #region

            #endregion

            #region Exemplo08

            //string path = @"C:\Users\felipe.decker\temp\texto.txt";

            //Console.WriteLine("Directory Separator Char: " + Path.DirectorySeparatorChar);

            //Console.WriteLine("Path Separator: " + Path.PathSeparator);

            //Console.WriteLine("Get directory name: " + Path.GetDirectoryName(path));

            //Console.WriteLine("Get File Name: " + Path.GetFileName(path));

            //Console.WriteLine("Get Extension: " + Path.GetExtension(path));

            //Console.WriteLine("Get File Name Without Extension: " + Path.GetFileNameWithoutExtension(path));

            //Console.WriteLine("Get Full Path" + Path.GetFullPath(path));

            //Console.WriteLine("Get Temp Path: " + Path.GetTempPath());


            #endregion

            #region Exemplo07

            //string path = @"C:\Users\felipe.decker\temp";

            //try
            //{
            //    IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            //    //var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

            //    Console.WriteLine("Pastas");
            //    foreach (var s in folders)
            //    {
            //        Console.WriteLine(s);
            //    }

            //    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

            //    Console.WriteLine("Filés");

            //    foreach (var file in files)
            //    {
            //        Console.WriteLine(file);
            //    }

            //    Directory.CreateDirectory(path + @"\NewPasta");
            //    //Directory.CreateDirectory(path + "\\NewPasta");

            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            #endregion

            #region Exemplo06

            //string source = @"C:\Users\felipe.decker\temp\texto.txt";
            //string destiny = @"C:\Users\felipe.decker\temp\texto2.txt";

            //try
            //{
            //    string[] lines = File.ReadAllLines(source);

            //    using (StreamWriter sw = File.AppendText(destiny))
            //    {
            //        foreach (var line in  lines)
            //        {
            //            sw.WriteLine(line.ToUpper());
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}

            #endregion

            #region Exemplo05

            //string path = @"C:\Users\felipe.decker\temp\texto.txt";

            //try
            //{
            //    using (StreamReader sr = File.OpenText(path))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            #endregion

            #region Exemplo04

            //string path = @"C:\Users\felipe.decker\temp\texto.txt";

            //try
            //{
            //    using (FileStream fs = new FileStream(path, FileMode.Open))
            //    {
            //        using (StreamReader sr = new StreamReader(fs))
            //        {
            //            while (!sr.EndOfStream)
            //            {
            //                string line = sr.ReadLine();
            //                Console.WriteLine(line);
            //            }
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}


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

            #region Breve Explicação

            // O caminho contido na string path é referente ao caminho que esta meu arquivo texto
            // esse arquivo texto é um arquivo txt (sério?)
            // dentro dele eu escrevi 3 coisas em 3 linhas
            // isso pq o programa vai ler linha por linha

            #endregion

        }
    }
}
