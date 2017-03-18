using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PacmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Plansza plansza = new Plansza();
            PacMan pacman = new PacMan(plansza);
            ConsoleKeyInfo cki = new ConsoleKeyInfo();

            while (true)
            {
                while (Console.KeyAvailable == false)
                {
                    Console.Clear();
                    //punkt.ruch(cki);
                    
                    pacman.ruch(cki, ref plansza);
                    plansza.generowanieTablicy(ref pacman);
                    
                    Console.WriteLine("\nPunkt x {0} punkt y {1}",pacman.x, pacman.y);
                    Console.WriteLine("Punkty: {0}", pacman.score);
                       
                    Thread.Sleep(300);
                }
                cki = Console.ReadKey();
            }
            Console.ReadLine();
        } 
    }
}
