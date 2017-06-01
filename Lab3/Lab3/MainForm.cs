using System;
using System.Drawing;
using System.Windows.Forms;

using Mathematics = BMSTU.IU7.Zinovyev.Mathematics;

namespace Lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Mathematics.SturmLiouvilleDiffEquation e =
                new Mathematics.SturmLiouvilleDiffEquation(x => 0, x => 1, x => 0, x => x);
            Mathematics.FunNode2[] nodes = e.Solve(0, 1, 10, 1, 0, 0, 1, 0, 0.5);
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                double L = double.Parse(tbL.Text);
                double R = double.Parse(tbR.Text);
                double Tenv = double.Parse(tbTenv.Text);
                double F0 = double.Parse(tbF0.Text);
                double K0 = double.Parse(tbK0.Text);
                double Kn = double.Parse(tbKn.Text);
                double A0 = double.Parse(tbA0.Text);
                double An = double.Parse(tbAn.Text);
                int N = int.Parse(tbN.Text);

                Task1 task = new Task1(L, R, Tenv, F0, K0, Kn, A0, An, N);
                GraphLine gl = task.FindSolution();

                /*Task2 task = new Task2(L, R, Tenv, F0, K0, Kn, A0, An, N);
                GraphLine gl;
                Mathematics.FunNode2[] t = task.FindSolution();
                gl.Color = Color.Red;
                gl.Nodes = new PointF[N + 1];

                for (int i = 0; i <= N; i++)
                {
                    gl.Nodes[i] = (PointF)t[i];
                }*/

                Graph graph = new Graph(pbGraph.Width, pbGraph.Height);
                graph.Draw(new GraphLine[] { gl }, 0, (float)L, 0,
                    Math.Max(gl.Nodes[0].Y, gl.Nodes[N].Y));

                pbGraph.CreateGraphics().DrawImage(graph.Image, 0, 0);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
