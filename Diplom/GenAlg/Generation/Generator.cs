using Diplom.Gens;
using Diplom.Individuals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.GenAlg.Generation
{
    public  class Generator
    {
       public  Generator(double min,double max)
        {
            this.min = min;
            this.max = max;
        }
       public Generator(int min, int max)
       {
           this.min = min;
           this.max = max;
       } 
       protected double min;
       protected double max;
       
       //public List<Individual<double>> generation(ref List<Individual<double>> individual)
       //{
       //    Random rnd = new Random();

       //    foreach (Individual<double> Individ in individual)
       //    {
       //        foreach (Gen<double> gen in Individ.genes)
       //        {
       //            gen.value = rnd.NextDouble() + rnd.Next(Convert.ToInt32(min), Convert.ToInt32(max) - 1);
       //        }
       //    }
       //    return individual;
       //}
       //public List<Individual<int>> generation(ref List<Individual<int>> individual)
       //{
       //    Random rnd = new Random();

       //    foreach (Individual<int> Individ in individual)
       //    {
       //        foreach (Gen<int> gen in Individ.genes)
       //        {
       //            gen.value = rnd.Next(Convert.ToInt32(min), Convert.ToInt32(max));
       //        }
       //    }
       //    return individual;
       //}


    }
}
