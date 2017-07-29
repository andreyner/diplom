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

        /// <summary>
        /// Вероятность скрещивания,от 0 до 1
        /// </summary>
        protected static double Pc;
        /// <summary>
        /// метод скрещивания
        /// </summary>
        /// <param name="individuals"></param>
        /// <returns></returns>
        public abstract List<Individual> crossoverRun(List<Individual> individuals);
    }

}
