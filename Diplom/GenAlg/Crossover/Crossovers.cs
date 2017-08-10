using Diplom.GenAlg.Mutation;
using Diplom.Individuals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.GenAlg
{
    public abstract class Crossovers
    {  
        public  Crossovers( double Pc)
        {
            Crossovers.Pc = Pc;

        }
        protected Mutations Mutation;
        /// <summary>
        /// Вероятность скрещивания,от 0 до 1
        /// </summary>
        protected static double Pc;
        /// <summary>
        /// метод скрещивания
        /// </summary>
        /// <param name="individuals"></param>
        /// <returns></returns>
        /// <summary>
        /// поколение потомков
        /// </summary>
        protected List<Individual> childs;
        public  List<Individual> crossoverRun(List<Individual> individuals)
        {

            int k = 0;
            Random rnd = new Random();
            childs = new List<Individual>();
            int n = individuals.Count;
            while (k < n)
            {
                int i = rnd.Next(0, individuals.Count);
                int j = rnd.Next(0, individuals.Count);
                Individual p1 = individuals[i];
                Individual p2 = individuals[j];
                if (Crossovers.Pc > rnd.NextDouble())
                {

                    exchange(individuals[i], individuals[j]);


                }
                else
                {
                    childs.Add(individuals[i]);
                    childs.Add(individuals[j]);

                }
                k += 2;
            }

            return childs;
        }

        /// <summary>
        /// обмен генами между двумя особями
        /// </summary>
        /// <param name="parent1"></param>
        /// <param name="parent2"></param>
      protected  abstract void exchange(Individual parent1, Individual parent2);
    }

}
