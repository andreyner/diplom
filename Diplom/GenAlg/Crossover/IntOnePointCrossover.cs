using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.Individuals;
using Diplom.Gens;
using System.Collections;
using Diplom.GenAlg.Mutation;

namespace Diplom.GenAlg.Crossover
{
    class IntOnePointCrossover : Crossovers
    {
        public IntOnePointCrossover(int break_pointCount, double Pc) :base(Pc)
        {

        }
      
       

        protected override void exchange(Individual parent1, Individual parent2)
        {
            Mutation = new Bit_Mutation(0.05);
            int lengthGenes = Individual.countGen * Gen.length;//сумма длинн всех генов
            Random rnd = new Random();
            int positionPoint = rnd.Next(0, lengthGenes);
            List<bool> linep1 = getBits(parent1,  positionPoint);
            List<bool> linep2 = getBits(parent2, positionPoint);

            int currentpos = 0;//текущая позиция в битах гена
            foreach (Gen gen in parent1.genes)
            {
                for (int i = 0; i < Gen.length; i++)
                {                  
                    if (currentpos >= positionPoint)
                    {
                        break;
                    }
                     gen.Bgenvalue.Set(i,linep2[currentpos]);
                     gen.Bgenvalue = gen.Bgenvalue;
                     currentpos++;
                }
                if (currentpos >= positionPoint)
                {
                    break;
                }
            }

            foreach (Gen gen in parent2.genes)
            {
                for (int i = 0; i < Gen.length; i++)
                {
                    if (currentpos >= positionPoint)
                    {
                        break;
                    }
                    gen.Bgenvalue.Set(i, linep1[currentpos]);
                    gen.Bgenvalue = gen.Bgenvalue;
                    currentpos++;
                }
                if (currentpos >= positionPoint)
                {
                    break;
                }
            }
            childs.Add(parent1);
            childs.Add(parent2);
            Mutation.runMutation(new List<Individual> { parent1,parent2});
            return ;
        }
        private List<bool> getBits(Individual parent ,int positionPoint)
        {
            
            List<bool> bits = new List<bool>();
            int currentpos = 0;//текущая позиция в битах гена
            foreach (Gen gen in parent.genes)
            {
                foreach (bool bit in gen.Bgenvalue)
                {
                    bits.Add(bit);
                    if (currentpos >= positionPoint)
                    {

                        break;
                    }
                    currentpos++;
                }
                if (currentpos >= positionPoint)
                {
                    break;
                }
            }
            return bits;
        }
    }
}
