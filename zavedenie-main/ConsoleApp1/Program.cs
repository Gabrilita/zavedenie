﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Колко хора?: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Избери маса: пушачи или непушачи? ");
            string vidMasa = Console.ReadLine();
            //Console.WriteLine("Начин на плащане: кеш или карта? ");
            //string nachinNaPlashtane = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Избери храна: ");

             Console.Write("Колко салати? ");
            int salati = int.Parse( Console.ReadLine());
            Console.Write("Колко шопски? ");
            int shopska = int.Parse( Console.ReadLine());
            Console.Write("Колко млечни? ");
            int mlechni = int.Parse( Console.ReadLine());
            Console.Write("Колко труший? ");
            int trushiq = int.Parse( Console.ReadLine());
            Console.WriteLine();
            Console.Write("Колко основни? ");
            int osnovno = int.Parse(Console.ReadLine());
            Console.Write("Колко кебапчета? ");
            int kebapche = int.Parse(Console.ReadLine());
            Console.Write("Колко първени картофи? ");
            int kartofi = int.Parse( Console.ReadLine());   
            Console.Write("Колко агнешки чорби? ");
            int agneshki = int.Parse( Console.ReadLine());  
            Console.WriteLine();
            Console.Write("Колко десерти? ");
            int desert = int.Parse(Console.ReadLine());
            Console.Write("Колко торти? ");
            int torti = int.Parse(Console.ReadLine());
            Console.Write("Колко сладоледа? ");
            int sladoled = int.Parse( Console.ReadLine());  
            Console.Write("Колко крем карамела? ");
            int krem = int.Parse( Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Избери Напитки: ");

            Console.Write("Колко алкохол? ");
            int alkohol = int.Parse(Console.ReadLine());
            Console.Write("Колко ракия? ");
            int rakiq = int.Parse(Console.ReadLine());
            Console.Write("Колко уиски? ");
            int uiski = int.Parse(Console.ReadLine());
            Console.Write("Колко водка? ");
            int vodka = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Колко безалкохолно? ");
            int bezalkoholno = int.Parse(Console.ReadLine());
            Console.Write("Колко фреш? ");
            int fresh = int.Parse(Console.ReadLine());
            Console.Write("Колко газирано? ");
            int gazirano = int.Parse(Console.ReadLine());   
            Console.Write("Колко вода? ");
            int voda = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Колко топли напитки? ");
            int topliNapitki = int.Parse(Console.ReadLine());
            Console.Write("Колко кафе? ");
            int kafe = int.Parse(Console.ReadLine());   
            Console.Write("Колко чай? ");
            int chai = int.Parse(Console.ReadLine());   
            Console.Write("Колко гряна ракия? ");
            int grqnaRakiq = int.Parse(Console.ReadLine());    
            Console.WriteLine();

            Console.WriteLine("Сума: ");
           
            double shopskaS = shopska* 5.50;
            double mlechnaS = mlechni * 3.70;
            double trushiqS = trushiq* 4.85;
            Console.WriteLine("За салати:" + shopskaS + mlechnaS + trushiqS);
            double kebapcheO = kebapche * 3.00;
            double kartofO = kartofi * 10.00;
            double agneshko = agneshki * 25.00;
            Console.WriteLine("За основно: " +kebapcheO+kartofO+agneshki);
            double tortaD = torti * 3.00;
            double sladoledD = sladoled * 2.50;
            double kremD = krem * 3.00;
            Console.WriteLine("За десерт: " + tortaD+sladoledD+kremD);
            double freshB = fresh * 4.00;
            double gaziranoB = gazirano * 1.00;
            double vodaB = voda * 0.80;

            double chaiT = chai * 0.70;
            double kafeT = kafe * 2.00;
            double grT =grqnaRakiq* 7.00;

            double rakiqA = rakiq * 7.00;
            double uiskiA = uiski * 5.50;
            double vodkaA = vodka * 15;

           
           
           


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Какви салати?: ");
                

            }


            

            
        }
    }
}