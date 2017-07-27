using Diplom.Gens;
using Diplom.Individuals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.GenAlg.Generation
{
    public  class Generator<T>
    {
       public  Generator(T min,T max)
        {
            this.min = min;
            this.max = max;
        } 
       protected T min;
       protected T max;

        public List<Individual<double>> generation(ref List<Individual<double>> individual)
        {
            Random rnd = new Random();

            foreach (Individual<double> Individ in individual)
            {
                foreach (Gen<double> gen in Individ.genes)
                {
                    gen.value = rnd.NextDouble() + rnd.Next(Convert.ToInt32(min), Convert.ToInt32(max)-1);
                }
            }
            return individual;
        }
        //public List<Individual<T>> generation(ref List<Individual<T>> individual)
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
