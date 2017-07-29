using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.Gens;
namespace Diplom.Individuals
{
   public  class Individual:IComparable<Individual>
   {
        /// <summary>
        /// оценка приспособленности особи (значение функции)
        /// </summary>
        public double fitness;
        public static int countGen;
        public Individual(int countGen)
        {
            Individual.countGen = countGen;
            genes = new List<Gen>(countGen);

        }
        public List<Gen> genes { get; set; }

        public int CompareTo(Individual other)
        {
            if (this.fitness > other.fitness)
            {
                return 1;
            }
            if (this.fitness < other.fitness)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
