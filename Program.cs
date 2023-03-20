using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] masses = { 68.4, 23.5, 71.8, 29.1, 212.3 };
            //double totalMass = 0;
            //foreach (double mass in masses) 
            //{
            //    totalMass += mass;
            //}
            //Console.WriteLine($"Общая масса груза: {totalMass} кг");
            double[] heights = { 170, 173, 160, 180, 193 };
            double sum = 0;
            for (int i=0; i<heights.Length;i++)
            {
                sum += heights[i];
            }
            double averageHeight = sum / heights.Length;
            Console.WriteLine("Средний рост:" + averageHeight);
        }
    }
}
