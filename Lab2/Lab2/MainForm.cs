using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            DiffEquationSys sys = new RungeKuttaDiffEquationSys(new DiffEquationSys.SeveralArgFun[]
            {
                (x, y) => x,
                (x, y) => y[1]
            });
            DiffEquationSolution[] solutions = sys.FindSolution(0, 1, new double[] { 1, 1 }, 100);
        }
    }
}
