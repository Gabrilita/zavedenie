using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zawedenieS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Колко хора?: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Избери маса: пушачи или непушачи? ");
            string vidMasa = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Избери храна: ");

            Console.WriteLine();

            Console.WriteLine("Салати: ");
            Console.Write("Колко шопски? ");
            int shopska = int.Parse(Console.ReadLine());
            Console.Write("Колко млечни? ");
            int mlechni = int.Parse(Console.ReadLine());
            Console.Write("Колко труший? ");
            int trushiq = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Основни: ");
            Console.Write("Колко кебапчета? ");
            int kebapche = int.Parse(Console.ReadLine());
            Console.Write("Колко първени картофи? ");
            int kartofi = int.Parse(Console.ReadLine());
            Console.Write("Колко агнешки чорби? ");
            int agneshki = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Десерти: ");    
            Console.Write("Колко торти? ");
            int torti = int.Parse(Console.ReadLine());
            Console.Write("Колко сладоледа? ");
            int sladoled = int.Parse(Console.ReadLine());
            Console.Write("Колко крем карамела? ");
            int krem = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Избери Напитки: ");

            Console.WriteLine();

            Console.WriteLine("Алкохол: ");   
            Console.Write("Колко ракия? ");
            int rakiq = int.Parse(Console.ReadLine());
            Console.Write("Колко уиски? ");
            int uiski = int.Parse(Console.ReadLine());
            Console.Write("Колко водка? ");
            int vodka = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Безалкохолно: ");
            Console.Write("Колко фреш? ");
            int fresh = int.Parse(Console.ReadLine());
            Console.Write("Колко газирано? ");
            int gazirano = int.Parse(Console.ReadLine());
            Console.Write("Колко вода? ");
            int voda = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Топли напитки: ");
            Console.Write("Колко кафе? ");
            int kafe = int.Parse(Console.ReadLine());
            Console.Write("Колко чай? ");
            int chai = int.Parse(Console.ReadLine());
            Console.Write("Колко гряна ракия? ");
            int grqnaRakiq = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Сума: ");

            double shopskaS = shopska * 5.50;
            double mlechnaS = mlechni * 3.70;
            double trushiqS = trushiq * 4.85;
            Console.WriteLine("За салати: " + (shopskaS + mlechnaS + trushiqS));
            double kebapcheO = kebapche * 3.00;
            double kartofO = kartofi * 10.00;
            double agneshko = agneshki * 25.00;
            Console.WriteLine("За основно: " + (kebapcheO + kartofO + agneshki));
            double tortaD = torti * 3.00;
            double sladoledD = sladoled * 2.50;
            double kremD = krem * 3.00;
            Console.WriteLine("За десерт: " + (tortaD + sladoledD + kremD));
            double freshB = fresh * 4.00;
            double gaziranoB = gazirano * 1.00;
            double vodaB = voda * 0.80;
            Console.WriteLine("За безалкохолни: " + (freshB + gaziranoB + vodaB));
            double chaiT = chai * 0.70;
            double kafeT = kafe * 2.00;
            double grT = grqnaRakiq * 7.00;
            Console.WriteLine("За топли напитки: " + (chaiT + kafeT + grT));
            double rakiqA = rakiq * 7.00;
            double uiskiA = uiski * 5.50;
            double vodkaA = vodka * 15;
            Console.WriteLine("За алкохол: " + (rakiqA + uiskiA + vodkaA));
            Console.WriteLine("Общо до тук: " + (shopskaS + mlechnaS + trushiqS + kebapcheO + kartofO + agneshki + tortaD + sladoledD + kremD + freshB + gaziranoB + vodaB + chaiT + kafeT + grT));
            Console.WriteLine();
            Console.Write("Начин на плащане: кеш или карта?: ");
            string nachinNaPlashtane = Console.ReadLine();
            if (nachinNaPlashtane == "кеш")
            {
                Console.Write("Ще даваш ли бакшиш?: ");
                string bakshish = Console.ReadLine();
                if (bakshish == "да")
                {
                    Console.Write("Колко бакшиш ще оставиш?: ");
                    double bak = double.Parse(Console.ReadLine());
                    Console.WriteLine((bak + shopskaS + mlechnaS + trushiqS + kebapcheO + kartofO + agneshki + tortaD + sladoledD + kremD + freshB + gaziranoB + vodaB + chaiT + kafeT + grT));
                }
                if (bakshish == "не")
                {
                    Console.WriteLine((shopskaS + mlechnaS + trushiqS + kebapcheO + kartofO + agneshki + tortaD + sladoledD + kremD + freshB + gaziranoB + vodaB + chaiT + kafeT + grT));
                }


            }
            else
            {

                Console.WriteLine((shopskaS + mlechnaS + trushiqS + kebapcheO + kartofO + agneshki + tortaD + sladoledD + kremD + freshB + gaziranoB + vodaB + chaiT + kafeT + grT) * 0.5);
            }
            Console.ReadKey();





        }
    }
}
