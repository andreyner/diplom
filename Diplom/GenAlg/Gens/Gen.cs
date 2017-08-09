using Diplom.GenAlg.Gens;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Gens
{
    /// <summary>
    /// Ген-параметр решения
    /// </summary>
    public class Gen:GenBase
    {
      
        public override double Phenotype
        {
            get
            {
                return phenotype;
            }
            set
            {
                phenotype = value;
                
                double notrounding = (Math.Round((phenotype - xmin) * (Math.Pow(2, Convert.ToDouble(length)) - 1)) / (xmax - xmin));
                if (notrounding > 0)//округляем положительне числа в меньшую сторону,отицительные в большую
                {

                    notrounding = Math.Floor(notrounding);
                }
                else {
                    if (notrounding < 0)
                    {
                        notrounding = Math.Ceiling(notrounding);
                    }
                }
                genvalue = Convert.ToInt32(notrounding);
                bgenvalue = new BitArray(new int[] { genvalue });        
                bgenvalue.Length = length;


            }
        }
        /// <summary>
        /// двоичное предствление genvalue
        /// </summary>
       //private BitArray bgenvalue;
       public override BitArray Bgenvalue
       {
            get
            {
                return bgenvalue;
            }
            set
            {   
                bgenvalue = value;
           //     bgenvalue = new BitArray(10);
                //for (int i = 0; i < bgenvalue.Count; i++)
                //{    if (i != 8)
                //        Bgenvalue.Set(i, true);
                //    else { Bgenvalue.Set(i, false); }
                //}
                int[] array = new int[1];
                bgenvalue.CopyTo(array, 0);
                genvalue=array[0];
                phenotype = ((genvalue * (xmax - xmin)) / (Math.Pow(2, length) - 1)) + xmin;

            }
        }

    }
}
