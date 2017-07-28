using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diplom.Individuals;
using Diplom.GenAlg;
using Diplom.GenAlg.Generation;
namespace Diplom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        Start run;
        private void button1_Click(object sender, EventArgs e)
        {
            run = new Start();
            double[] Xmin = new double[Convert.ToInt32(Gen.Value)];
            double[] Xmax = new double[Convert.ToInt32(Gen.Value)];
            for (int i = 0; i < Convert.ToInt32(Gen.Value); i++)
            {
                Xmin[i] = Convert.ToDouble(xmin.Text);
                Xmax[i] = Convert.ToDouble(xmax.Text);
            }
            run.generator = new Generator(Xmin, Xmax,Convert.ToInt32(Individ.Value), Convert.ToInt32(Gen.Value));
            //switch (typecoding.SelectedIndex)
            //{
            //    case 0: run.generator = new GeneratorInt(Convert.ToInt32(xmin.Text), Convert.ToInt32(xmax.Text)); break;
            //    case 1: run.generator = new GeneratorDouble(Convert.ToDouble(xmin.Text), Convert.ToDouble(xmax.Text)); break;
            //}
            
        }
    }
}
