using Diplom.Individuals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.GenAlg
{
     abstract class Crossover<T>
    {

        public List<Individual<T>> individual { private set; get; }
        public Crossover(ref List<Individual<T>> individual)
        {
            this.individual = individual;
        }
        public  abstract void CrossoverStart();
    }
}
