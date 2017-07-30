using Diplom.Individuals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.GenAlg.Mutation
{
  public abstract class Mutations
    {
       protected static double Pm;
        public   Mutations(double Pm)
        {
            Mutations.Pm = Pm;
        }
        /// <summary>
        /// Запуск мутации
        /// </summary>
        /// <param name="individuals"> набор скрестившихся в кроссовере особей</param>
        /// <returns></returns>
       abstract public List<Individual> runMutation(List<Individual> individuals);
        
    }
}
