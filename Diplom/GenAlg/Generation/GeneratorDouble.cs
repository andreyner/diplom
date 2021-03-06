﻿using Diplom.Gens;
using Diplom.Individuals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.GenAlg.Generation
{
    class GeneratorDouble:Generator
    {
       public  GeneratorDouble(double xmin,double xmax, int sizeIndivid, int sizeGen)
            : base(xmin, xmax, sizeIndivid, sizeGen)
        { 
        
        }

        protected override void generation(int sizeIndivid, int sizeGen)
        {
            Random rnd = new Random();

            foreach (Individual Individ in individuals)
            {
                foreach (Gen gen in Individ.genes)
                {
                    gen.value = rnd.NextDouble() + rnd.Next(Convert.ToInt32(min), Convert.ToInt32(max) - 1);
                }
            }

        }
    }
}
