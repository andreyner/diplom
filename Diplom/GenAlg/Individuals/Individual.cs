using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.Gens;
namespace Diplom.Individuals
{
   public  class Individual<T>
   {
      public  Individual(int size)
       {
           genes = new List<Gen<T>>(size);

       }
       public List<Gen<T>> genes { get; set; }

   }
}
