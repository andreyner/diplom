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
      public  Individual(int countGen)
       {
           genes = new List<Gen<T>>(countGen);

       }
       public List<Gen<T>> genes { get; set; }

   }
}
