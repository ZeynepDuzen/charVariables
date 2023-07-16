using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char letter;
            //letter = 'a';
            //Console.WriteLine(letter);

            //char number;
            //number = '5';
            //Console.WriteLine(number);

            //char s;
            //s = '*';
            //Console.WriteLine(s);

            char choose;
            Console.WriteLine("Lütfen seciminizi tek bir karakter ile yapın : ");
            Console.WriteLine();
            choose = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Seciminiz : " + choose);

            Console.Read();
        }
    }
}
