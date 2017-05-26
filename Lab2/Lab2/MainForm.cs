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
    }
}
