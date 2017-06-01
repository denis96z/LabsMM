using System;

class Task
{
    public struct Solution
    {
        /// <summary>
        /// Координата.
        /// </summary>
        double[] X;
        /// <summary>
        /// Время.
        /// </summary>
        double[] Time;
        /// <summary>
        /// Температура.
        /// </summary>
        double[,] Temperature;
    }

    public double L { get; set; }
    public double R { get; set; }
    public double Tenv { get; set; }
    public double F0 { get; set; }
    public double Alfa0 { get; set; }
    public double AlfaN { get; set; }
    
    public double N { get; set; }
    public double M { get; set; }

    public Table table;

    public Task(double l, double r, double tenv, double f0,
        double alfa0, double alfan)
    {
        L = l;
        R = r;
        Tenv = tenv;
        F0 = f0;
        Alfa0 = alfa0;
        AlfaN = alfan;

        table = new TableManager().LoadTable();
    }

    public Solution Solve()
    {
        throw new NotImplementedException();
    }

    public double k(double T)
    {
        return new LinearInterpolation(table.T, table.C).FindValue(T);
    }
}