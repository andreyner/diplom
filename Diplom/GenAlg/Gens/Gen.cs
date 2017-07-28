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
    public class Gen 
    {
        /// <summary>
        /// минимальное значение параметра
        /// </summary>
        public double xmin;
        /// <summary>
        /// максимальное значение параметра
        /// </summary>
       public  double xmax;
        /// <summary>
        /// фенотип genvalu
        /// </summary>
        public double phenotype { get; set; }
        private int genvalue;
        /// <summary>
        /// исходное значение гена
        /// </summary>
        public int Genvalue
        {   get
            {
                return genvalue;
            }
            set
            {
                genvalue = value;
                bgenvalue = new BitArray(new int[] {genvalue});

            }

        }
        /// <summary>
        /// двоичное предствление genvalue
        /// </summary>
        BitArray bgenvalue;
    }
}
