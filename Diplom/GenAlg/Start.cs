using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.Individuals;
using Diplom.Gens;
using Diplom.GenAlg.Generation;
using Diplom.GenAlg.Cossover;

namespace Diplom.GenAlg
{
    class Start<T>
    {
        /// <summary>
        /// особи
        /// </summary>
        List<Individual<T>> individuals;
        /// <summary>
        /// количество особей
        /// </summary>
        public int sizeIndividual { get; set;}
        /// <summary>
        /// количество генов у одной особи
        /// </summary>
        public int countGen { get; set; }
        /// <summary>
        /// ссылка на генератор генов
        /// </summary>
        Generator <T> generator { get; set; }
        /// <summary>
        /// минимальное значение аргумента
        /// </summary>
        T xmin;
        /// <summary>
        /// максимальое значение аргумента
        /// </summary>
        T xmax;
        public Start()
        {
            generator = new Generator<T>(xmin,xmax);
        }
        /// <summary>
        /// Создание особей при запуске алгоритма
        /// </summary>
        public  void initialization()
        {
            individuals = new List<Individual<T>>(sizeIndividual);
            for (int i = 0; i < sizeIndividual; i++)//создание особей
            {
                Individual<T> individ = new Individual<T>(countGen);
                for (int j = 0; i < countGen; j++)//создание генов у особей особей
                {
                    individ.genes.Add(new Gen<T>());
                }
                    individuals.Add( individ);
            }
            if (typeof(T) == typeof(int))
            {
                generator.generation(ref  individuals);

            }



        }


    }
}
