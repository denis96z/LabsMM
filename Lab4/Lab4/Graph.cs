using System;
using ZedGraph;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;

class Graph
{
    private ZedGraphControl zedGraph = null;

    public Graph(ZedGraphControl control)
    {
        zedGraph = control ??
            throw new ArgumentNullException("control");
    }

    public void DrawGraph(double[] x, List<double[]> t, double tenv)
    {
        GraphPane pane = zedGraph.GraphPane;
        pane.CurveList.Clear();

        PointPairList list = null;
        for (int i = 0; i < t.Count - 1; i++)
        {
            list = new PointPairList();
            for (int j = 0; j < x.Length; j++)
            {
                list.Add(x[j], t[i][j] /*> tenv ? t[i][j] : tenv*/);
            }
            pane.AddCurve("", list, Color.Blue, SymbolType.None);
        }

        list = new PointPairList();
        for (int i = 0; i < x.Length; i++)
        {
            list.Add(x[i], t.Last()[i] /*> tenv ? t[i][j] : tenv*/);
        }
        pane.AddCurve("", list, Color.Red, SymbolType.Star);

        zedGraph.AxisChange();
        zedGraph.Invalidate();
    }
}