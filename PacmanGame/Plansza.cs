using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PacmanGame
{
    class Plansza
    {
        public Plansza()
        {
            wczytajPlanszeZPliku();
        }
       
        public char[,] planszaTab = new char[14, 17];
   
        public void generowanieTablicy(ref PacMan pkt)
        {
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    if (pkt.y == i && pkt.x == j)
                        planszaTab[i, j] = '@';
                }
            }
            wyswietlPlanszeZPliku();
        }
        public void wczytajPlanszeZPliku()
        {

            string path = @"C:\Repository\PacmanGame\mapa.txt";
            StreamReader sr = new StreamReader(path);


            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    planszaTab[i, j] = (char)sr.Read();
                }
            }
                                
        }
        public void wyswietlPlanszeZPliku()
        {
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    Console.Write(planszaTab[i, j]);
                }
               
            };
        }
    }
}
/*
┌――――――――――――┐┌――――――――――――┐
│∙∙∙∙∙∙∙∙∙∙∙∙││∙∙∙∙∙∙∙∙∙∙∙∙│
│∙┌――┐∙┌―――┐∙││∙┌―――┐∙┌――┐∙│
│+│  │∙│   │∙││∙│   │∙│  │+│
│∙└――┘∙└―――┘∙└┘∙└―――┘∙└――┘∙│
│∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙│
│∙┌――┐∙┌┐∙┌――――――┐∙┌┐∙┌――┐∙│
│∙└――┘∙││∙└――┐┌――┘∙││∙└――┘∙│
│∙∙∙∙∙∙││∙∙∙∙││∙∙∙∙││∙∙∙∙∙∙│
└――――┐∙│└――┐ └┘ ┌――┘│∙┌――――┘
     │∙│┌――┘    └――┐│∙│
	 │∙││          ││∙│
	 │∙││          ││∙│
―――――┘∙└┘          └┘∙└―――――
      ∙              ∙
―――――┐∙┌┐          ┌┐∙┌―――――
	 │∙││          ││∙│
	 │∙││          ││∙│
     │∙│└――┐    ┌――┘│∙│
┌――――┘∙│┌――┘ ┌┐ └――┐│∙└――――┐
│∙∙∙∙∙∙││∙∙∙∙││∙∙∙∙││∙∙∙∙∙∙│
│∙┌――┐∙││∙┌――┘└――┐∙││∙┌――┐∙│
│∙└――┘∙└┘∙└――――――┘∙└┘∙└――┘∙│
│∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙∙│
│∙┌――┐∙┌―――┐∙┌┐∙┌―――┐∙┌――┐∙│
│+│  │∙│   │∙││∙│   │∙│  │+│
│∙└――┘∙└―――┘∙││∙└―――┘∙└――┘∙│
│∙∙∙∙∙∙∙∙∙∙∙∙││∙∙∙∙∙∙∙∙∙∙∙∙│
└――――――――――――┘└――――――――――――┘
*/