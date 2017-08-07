using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.GenAlg.Gens
{
  public  class GenBase
    {
        /// <summary>
        /// разрядность гена
        /// </summary>
        public static int length;
        /// <summary>
        /// минимальное значение параметра
        /// </summary>
        public double xmin;
        /// <summary>
        /// максимальное значение параметра
        /// </summary>
        public double xmax;
        /// <summary>
        /// фенотип genvalue,раскодированное значение
        /// </summary>
        protected double phenotype;
        /// <summary>
        /// закодированное значение фенотипа
        /// </summary>
        protected int genvalue;
        /// <summary>
        /// фенотип,раскодированное значение
        /// </summary>
        public virtual double Phenotype
        {
            get;set;
        }
        /// <summary>
        /// двоичное предствление genvalue
        /// </summary>
        protected BitArray bgenvalue;
        public virtual BitArray Bgenvalue
        {
            get; set;  
        }



    }
}
