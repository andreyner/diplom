using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.Individuals;
using Diplom.Gens;

namespace Diplom.GenAlg.Mutation
{
    public class Bit_Mutation : Mutations
    {
        public Bit_Mutation(double Pm) : base(Pm)
        {

        }
        public override List<Individual> runMutation(List<Individual> individuals)
        {
            Random rnd = new Random();
            foreach (Individual individ in individuals)
            {
                foreach (Gen gen in individ.genes)
                {
                    
                    if (rnd.NextDouble() < Mutations.Pm)
                    {
                        gen.Bgenvalue.Not();
                        gen.Bgenvalue = gen.Bgenvalue;

                    }
                }
            }


            return individuals;
        }
    }
}
