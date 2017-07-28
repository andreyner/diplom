using Diplom.Gens;
using Diplom.Individuals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.GenAlg.Generation
{
  abstract  public  class Generator
    {
       protected List<Individual> individuals {get; set;}
       public  Generator(double min,double max)
        {
            this.min = min;
            this.max = max;
            generation();
        }
       public Generator(int min, int max)
       {
           this.min = min;
           this.max = max;
           generation();
       } 
       protected double min;
       protected double max;
       abstract public void generation();
    }
}
