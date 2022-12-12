using System;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp
{
    internal class Program
    {

        static string chaine = string.Empty; // => "  " 
        static Stopwatch chrono = new Stopwatch();
        static StringBuilder stringBuilder = new StringBuilder(chaine);
        
        static void Main(string[] args)
        {
             
            chrono.Start();
            for (int i = 0; i < 20000; i++)
            {
                chaine = chaine + (i*10).ToString();
            }
            chrono.Stop();
            string durée_execution1 = chrono.Elapsed.TotalMilliseconds.ToString();
            
            chrono.Reset();

            chrono.Start();
            for (int i = 0; i < 20000; i++)
            {
                stringBuilder.Append((i * 10).ToString());
            }
            chrono.Stop();
            string durée_execution2 = chrono.Elapsed.TotalMilliseconds.ToString();

        }
    }
}
