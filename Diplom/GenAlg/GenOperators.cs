using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.Individuals;
namespace Diplom.GenAlg
{
    class GenOperators<T>
    { 
  
       private double  Pc {get; set;}//вероятность срещивания
       public  GenOperators(double Pc, ref List <Individual<T>> individual)
       {
           this.Pc = Pc;
           this.individual = individual;
       }
        List <Individual<T>> individual;
       

    }
}
