using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace dekodolo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("szoveg.txt", FileMode.Open);
            StreamReader fileBe = new StreamReader(file);
            int kod = 0;
            int vmi = 0;
            string sor = string.Empty;

            Console.Write("Mi legyen a kod: ");
            kod = Convert.ToInt32(Console.ReadLine());
            
            while (!fileBe.EndOfStream) {
                sor = fileBe.ReadLine();
                for (int i = 0; i < sor.Length; i++)
                {
                    vmi = sor[i] ^ kod;
                    Console.Write((char)vmi);
                }
            }

            fileBe.Close();
            file.Close();
            Console.WriteLine("Vége");
            Console.ReadLine();
        }
    }
}
