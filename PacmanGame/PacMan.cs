using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PacmanGame
{
    class PacMan : Postac
    {
        public int score = 0;
        public PacMan(Plansza plansza)
        {
            for(int i=0; i<14; i++)
            {
                for(int j=0; j<17; j++)
                {
                    if (plansza.planszaTab[i, j] == '@')
                    {
                        this.x = j;
                        this.y = i;
                    }
                }
            }
        }

        public void ruch(ConsoleKeyInfo cki, ref Plansza plansza)
        {
            switch (cki.Key)
            {
                case ConsoleKey.LeftArrow:
                    {
                        if (plansza.planszaTab[this.y, (this.x - 1)] == '#')
                        { }
                        else if (plansza.planszaTab[this.y, (this.x - 1)] == '!')
                        { }
                        else
                        {
                            if (plansza.planszaTab[this.y, (this.x - 1)] == '.')
                            {
                                plansza.planszaTab[this.y, this.x] = ' ';
                                this.score += 1;
                            }
                            else if (plansza.planszaTab[this.y, (this.x - 1)] == ' ')
                            {
                                plansza.planszaTab[this.y, this.x] = ' ';
                            }
                            this.x--;
                        }
                    }
                    break;
                case ConsoleKey.DownArrow:
                    {
                        if (plansza.planszaTab[(this.y + 1), this.x] == '#')
                        { }
                        else if (plansza.planszaTab[(this.y + 1), this.x] == '!')
                        { }
                        else
                        {
                            if (plansza.planszaTab[(this.y + 1), this.x] == '.')
                            {
                                plansza.planszaTab[this.y, this.x] = ' ';
                                this.score += 1;
                            }
                            else if (plansza.planszaTab[(this.y + 1), this.x] == ' ')
                            {
                                plansza.planszaTab[this.y, this.x] = ' ';
                            }
                            this.y++;
                        }
                    }
                    break;
                case ConsoleKey.RightArrow:
                    {
                        if (plansza.planszaTab[this.y, (this.x + 1)] == '#')
                        { }
                        else if (plansza.planszaTab[this.y, (this.x + 1)] == '!')
                        { }
                        else
                        {
                            if (plansza.planszaTab[this.y, (this.x + 1)] == '.')
                            {
                                plansza.planszaTab[this.y, this.x] = ' ';
                                this.score += 1;
                            }
                            else if (plansza.planszaTab[this.y, (this.x + 1)] == ' ')
                            {
                                plansza.planszaTab[this.y, this.x] = ' ';
                            }
                            this.x++;
                        }
                    }
                    break;
                case ConsoleKey.UpArrow:
                    {
                        if (plansza.planszaTab[(this.y - 1), this.x] == '#')
                        { }
                        else if (plansza.planszaTab[(this.y - 1), this.x] == '!')
                        { }
                        else
                        {
                            if (plansza.planszaTab[(this.y - 1), this.x] == '.')
                            {
                                plansza.planszaTab[this.y, this.x] = ' ';
                                this.score += 1;
                            }
                            else if (plansza.planszaTab[(this.y - 1), this.x] == ' ')
                            {
                                plansza.planszaTab[this.y, this.x] = ' ';
                            }
                            this.y--;
                        }
                    }
                    break;
            }
        }
    }
}
