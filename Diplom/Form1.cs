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
            switch (typecoding.SelectedIndex)
            {
                case 0: run.generator = new GeneratorInt(Convert.ToInt32(xmin.Text), Convert.ToInt32(xmax.Text)); break;
                case 1: run.generator = new GeneratorDouble(Convert.ToDouble(xmin.Text), Convert.ToDouble(xmax.Text)); break;
            }
            
        }
    }
}
