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

            Interpolation itp = new LinearInterpolation(new double[] { 0, 2, 3, 4, 5 },
                new double[] { 1, 1, 0, 1, 0 });
            double y = itp.FindValue(-1);
            y = itp.FindValue(1);
            y = itp.FindValue(2);
            y = itp.FindValue(2.5);
            y = itp.FindValue(4.5);
            y = itp.FindValue(10);
        }
    }
}
