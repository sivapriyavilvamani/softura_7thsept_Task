using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    internal class RestrauntFile
    {
       
        public static void Main()
        {

            ArrayList desserts = new ArrayList();
            desserts.Add("Gulab Jamun");
            desserts.Add("Rasamalai");
            desserts.Add("Choco Truffle");
            desserts.Add("Badham halwa");
            foreach (string des in desserts)
                Console.WriteLine(des);

            FileStream fs = new FileStream("C:\\Users\\admin\\Documents\\softura training\\Restaurent.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Desserts in the restaurent");
            foreach (string des in desserts)
            {
                sw.WriteLine(des);
            }
            sw.Flush();
            sw.Close();
            fs.Close();
            FileStream fs1 = new FileStream("C:\\Users\\admin\\Documents\\softura training\\Restaurent.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            fs1.Close();
            FileInfo fi = new FileInfo("C:\\Users\\admin\\Documents\\softura training\\Restaurent.txt");
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastAccessTime);
            //File.WriteAllLines("C: \\Users\\admin\\Documents\\softura training\\softura_7thsept_Task\\RestraurentFile", desserts.Cast<string>());

            //    DirectoryInfo dessert = new DirectoryInfo("C: \\Users\\admin\\Documents\\softura training\\softura_7thsept_Task\\RestraurentFile");
            //    Console.WriteLine(dessert.FullName);
            //    Console.WriteLine(dessert.Parent);
            //    Console.WriteLine(dessert.CreationTime);
            //    foreach (object dic in dessert.GetDirectories())
            //        Console.WriteLine(dic.ToString());
            //    foreach (object fs in dessert.GetFiles())
            //        Console.WriteLine(fs);
        }
        }
}
