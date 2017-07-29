﻿using System;
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
       public  double xmax;
        /// <summary>
        /// фенотип genvalue,раскодированное значение
        /// </summary>
        private double phenotype { get; set; }
        /// <summary>
        /// закодированное значение фенотипа
        /// </summary>
        private int genvalue;
        /// <summary>
        /// фенотип,раскодированное значение
        /// </summary>
        public double Phenotype
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
       public BitArray bgenvalue;
    }
}
