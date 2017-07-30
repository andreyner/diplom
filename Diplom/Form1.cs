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
using Diplom.Gens;
using Diplom.GenAlg.Selection;
using Diplom.GenAlg.Crossover;
using Diplom.GenAlg.Mutation;

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
       
        List<Individual> individuals;
        private void button1_Click(object sender, EventArgs e)
        {
            
            Gen.length = Convert.ToInt32(RangGen.Value);
            double[] Xmin = new double[Convert.ToInt32(NGen.Value)];
            double[] Xmax = new double[Convert.ToInt32(NGen.Value)];
            for (int i = 0; i < Convert.ToInt32(NGen.Value); i++)
            {
                Xmin[i] = Convert.ToDouble(xmin.Text);
                Xmax[i] = Convert.ToDouble(xmax.Text);
            }
            Generator generator = new Generator(Xmin, Xmax,Convert.ToInt32(Individ.Value), Convert.ToInt32(NGen.Value));//генерируем исходные данные
            individuals = generator.generation();//сгенерировали особей
            for (int i = 0; i < Convert.ToInt32(generation.Value); i++)
            {


                Selection selection = new TournamentSelection(Convert.ToInt32(sizeTurnir.Value), 1);//турнирный отбор в селекции
                individuals = selection.selectionRun(individuals);//оценили приспособленность и отобрали для скрещивания (кроссовера)
                Crossovers Crosover = new IntegerCrossover(1, Convert.ToDouble(Pc.Value));
                individuals = Crosover.crossoverRun(individuals);//Запуск кроссовера(скрещиваниe)
                Mutations Mutation = new Bit_Mutation(Convert.ToDouble(Pm.Value));
                individuals = Mutation.runMutation(individuals);//Запуск мутации
                individuals.Sort();
            }

        }
    }
}
