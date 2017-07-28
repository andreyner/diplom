using Diplom.Gens;
using Diplom.Individuals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.GenAlg.Generation
{
    class GeneratorInt:Generator
    {

       public   GeneratorInt(int xmin,int xmax)
            : base(xmin, xmax)
        { 
        
        }
        public override void generation()
        {
            Random rnd = new Random();

            foreach (Individual Individ in individuals)
            {
                foreach (Gen gen in Individ.genes)
                {
                    gen.value = rnd.Next(Convert.ToInt32(min), Convert.ToInt32(max));
                }
            }
            
        }
    }
}
