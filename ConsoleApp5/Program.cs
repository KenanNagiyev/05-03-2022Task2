using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string metn = Console.ReadLine();
            
                for (int i =0; i<metn.Length;i++)
            {
                if (metn[i] == 'a')
                {
                    Console.WriteLine("metnde 'a' simvolu var");
                    break;
                }
                if (metn[i] != 'a')
                {
                    Console.WriteLine("metnde 'a' simvolu yoxdur");
                    break;
                }
            }
            
        }
    }
}
