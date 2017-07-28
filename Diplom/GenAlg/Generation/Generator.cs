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
       protected List<Individual> individuals {get; set;}
       public  Generator(double []min,double [] max, int sizeIndivid, int sizeGen)
        {
            
            this.sizeGen = sizeGen;
            this.sizeIndivid = sizeIndivid;
             allocationMemory(ref min,ref max);
             generation( sizeIndivid, sizeGen);
        }
       int sizeIndivid;
       int sizeGen;
        /// <summary>
        ///Созданиие и генерация особей
        /// </summary>
        /// <param name="sizeIndivid"> количество особей</param>
        /// <param name="sizeGen">количество генов у одной особи</param>
         protected void generation(int sizeIndivid, int sizeGen)
        {
            Random rnd = new Random();

            foreach (Individual Individ in individuals)
            {
                foreach (Gen gen in Individ.genes)
                {
                    gen.Genvalue =  rnd.Next(Convert.ToInt32(gen.xmin), Convert.ToInt32(gen.xmax));
                }
            }
        }
        /// <summary>
        /// Выделение памяти под особей и гены,заполнение полей генов и особей начальыми значениями
        /// </summary>
        void allocationMemory(ref double[] min, ref double[] max)
        {
            individuals = new List<Individual>(sizeIndivid);
            for (int i = 0; i < sizeIndivid; i++)
            {
                Individual Individ = new Individual(sizeGen);
                for (int j = 0; j < sizeGen; j++)
                {
                    Gen gen = new Gen();
                    gen.xmin = min[j];
                    gen.xmax = max[j];
                    Individ.genes.Add(gen);
                }
                individuals.Add(Individ);
            }
        }

      
    }
}
