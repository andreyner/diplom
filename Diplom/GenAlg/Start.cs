using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.Individuals;
using Diplom.Gens;
namespace Diplom.GenAlg
{
    class Start<T>
    {

        List <Individual<T>> individuals;
        public Start(int size )
        {

         individuals = new List <Individual<T>>(size);
         initialization();
 
        }
        private void initialization()
        {

            foreach (Individual<T> individ in individuals)
            {
                foreach ( Gen<T> gen in individ.genes)
                {
                    
                }
            }
        
        }


    }
}
