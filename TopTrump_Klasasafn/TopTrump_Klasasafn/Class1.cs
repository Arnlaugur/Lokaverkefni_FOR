﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTrump_Klasasafn
{
    public class Class1
    {
        public string Reglur()
        {
            return "Í toptrumps er kortum skipt jafnt á milli leikmana og meiga þeir bara skoða efsta spilið sitt leikurinn byrjar á því að einn leikmaður velur grein til að keppa í og vinnur ef hann hefur hærri tölu í þeirri grein og tekur kortin sem voru notuð í þeirri umferð og draga spilarar efsta kort aftur og næsti leikmaður velur grein.";
        }

        public int[] SkyptaKortum()
        {
            Random Rand = new Random();
            int[] kort = new int[52];
            for (int i = 0; i < 51; i++)
            {
                kort[i] = Rand.Next(0, 51);
            }
            return kort;
        }
    }
}
