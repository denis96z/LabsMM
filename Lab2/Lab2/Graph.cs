using System;
using ZedGraph;
using System.Drawing;

class Graph
{
    private ZedGraphControl zedGraph = null;

    public Graph(ZedGraphControl control)
    {
        zedGraph = control ??
            throw new ArgumentNullException("control");
    }

    public void DrawGraph(DiffEquationSolution I, DiffEquationSolution Uc)
    {
        GraphPane pane = zedGraph.GraphPane;
        pane.CurveList.Clear();

        PointPairList list = new PointPairList();
        for (int i = 0; i <= I.N; i++)
        {
            list.Add(I.X[i], I.Y[i]);
        }
        pane.AddCurve("I", list, Color.Blue, SymbolType.None);

        list = new PointPairList();
        for (int i = 0; i <= I.N; i++)
        {
            list.Add(Uc.X[i], Uc.Y[i]);
        }
        pane.AddCurve("Uc", list, Color.Red, SymbolType.None);

        zedGraph.AxisChange();
        zedGraph.Invalidate();
    }
}