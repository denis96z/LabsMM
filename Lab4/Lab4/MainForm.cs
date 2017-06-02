using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            zedGraph.GraphPane.Title.Text = "График";
            zedGraph.GraphPane.XAxis.Title.Text = "x";
            zedGraph.GraphPane.YAxis.Title.Text = "T";
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                double L = double.Parse(tbL.Text);
                double R = double.Parse(tbR.Text);
                double Tenv = double.Parse(tbTenv.Text);
                double F0 = double.Parse(tbF0.Text);
                double A0 = double.Parse(tbA0.Text);
                double An = double.Parse(tbAn.Text);
                int N = int.Parse(tbN.Text);

                Task task = new Task(L, R, Tenv, F0, A0, An, N, 1);
                var solution = task.Solve();

                int step = solution.T.Count / 10;
                List<double[]> graphs = new List<double[]>();
                for (int i = 0; i <= solution.T.Count - 10; i += step)
                {
                    graphs.Add(solution.Values[i]);
                }
                graphs.Add(solution.Values.Last());

                Graph graph = new Graph(zedGraph);
                graph.DrawGraph(solution.X, graphs, Tenv);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
