using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            zedGraph.GraphPane.Title.Text = "График";
            zedGraph.GraphPane.XAxis.Title.Text = "";
            zedGraph.GraphPane.YAxis.Title.Text = "";
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                double rk = double.Parse(tbRk.Text);
                double lk = double.Parse(tbLk.Text);
                double ck = double.Parse(tbCk.Text);
                double r = double.Parse(tbR.Text);
                double p0 = double.Parse(tbP0.Text);
                double ts = double.Parse(tbTs.Text);
                double tw = double.Parse(tbTw.Text);
                double le = double.Parse(tbLe.Text);
                double uc0 = double.Parse(tbUc0.Text);
                double i0 = double.Parse(tbI0.Text);
                int n = int.Parse(tbN.Text);

                Task task = new Task(rk, lk, ck, r, p0, ts, tw, le, uc0, i0);
                var solution = task.Solve(0, 0.0006, n);

                Graph graph = new Graph(zedGraph);
                graph.DrawGraph(solution.I, solution.Uc, solution.Rp, solution.Ucp);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
