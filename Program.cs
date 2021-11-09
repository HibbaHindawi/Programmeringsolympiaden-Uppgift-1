using System;

namespace Programmeringsolympiaden_Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //exempel 1
            double kuvertA1 = (0.074196);
            double affischA1 = (0.12474);
            double bladA1 = (0.06237);
            
            Console.Write("Vad är ytvikten för kuverten?:");
            int kuvert1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vad är ytvikten för affischen?:");
            int affisch1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vad är ytvikten för bladet?:");
            int blad1 = Convert.ToInt32(Console.ReadLine());

            double svar1 = (kuvert1* kuvertA1);
            double svar11= Math. Round(svar1, 4);
            double svar2 = (affisch1* affischA1);
            double svar22= Math. Round(svar2, 4);
            double svar3 = (blad1* bladA1);
            double svar33= Math. Round(svar3, 4);

            Console.WriteLine("Vikten för kuvertet = " + (svar11));
            Console.WriteLine("Vikten för affischen = " + (svar22));
            Console.WriteLine("Vikten för bladet = " + (svar33));

            double slutsvar = ((svar11 * 2) + (svar22 * 2) + svar33);
            double slutsvar1 = Math.Round(slutsvar, 3);
            
            Console.Write("Vikten för ett helt paket är: " + slutsvar1);
            Console.ReadKey();
        }
    }
}
