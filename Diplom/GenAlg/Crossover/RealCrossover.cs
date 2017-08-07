using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.Individuals;

namespace Diplom.GenAlg.Crossover
{
    public class RealCrossover : Crossovers
    {
        public RealCrossover(double Pc) : base(Pc)
        {

        }

        public override List<Individual> crossoverRun(List<Individual> individuals)
        {
            throw new NotImplementedException();
        }
    }
}
