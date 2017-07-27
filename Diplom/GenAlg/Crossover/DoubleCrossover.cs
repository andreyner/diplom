using Diplom.Individuals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.GenAlg.Cossover
{
    public class DoubleCrossover : Crossover<double>
    {
        public DoubleCrossover(ref List<Individual<double>> individual) : base(ref individual)
        {

        }
        public override List<Individual<double>> CrossoverStart()
        {
            return individual;
        }
    }
}
