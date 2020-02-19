using Ordinamento;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ArrBS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensioni = { 1, 20, 50, 100, 500, 1000,50000,60000};
            using (StreamWriter sw = new StreamWriter("stat.csv", false, Encoding.UTF8))
            {
                sw.WriteLine("Algoritmo,Dimensione,Tipo");
                foreach(int dim in dimensioni)
                {
                    int[] numeri = new int[dim];
                    Random r = new Random(); 
                    for(int i = 0; i < dim; i++)
                        numeri[i] = r.Next();
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    BubbleSort.Sort(numeri);
                    s.Stop();
                    long elapsed = s.ElapsedMilliseconds;
                    sw.WriteLine($"BubbleSort;{dim};{elapsed}");
                    Console.WriteLine($"BubbleSort;{dim};{elapsed}");
                }
                sw.Flush();
                Console.ReadLine();
            }
        }
    }
}
