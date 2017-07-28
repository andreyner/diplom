using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.Gens;
namespace Diplom.Individuals
{
   public  class Individual
   {
      public  Individual(int countGen)
       {
           genes = new ArrayList(countGen);

       }
      public ArrayList genes { get; set; }

   }
}
