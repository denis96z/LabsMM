using System;
using System.Linq;
using System.Collections.Generic;

class Task
{
    public struct Solution
    {
        /// <summary>
        /// Координата.
        /// </summary>
        public double[] X;
        /// <summary>
        /// Время.
        /// </summary>
        public List<double> T;
        /// <summary>
        /// Температура.
        /// </summary>
        public List<double[]> Values;
    }

    public double L { get; set; }
    public double R { get; set; }
    public double Tenv { get; set; }
    public double F0 { get; set; }
    public double Alfa0 { get; set; }
    public double AlfaN { get; set; }
    
    public int N { get; set; }
    public double Tau { get; set; }

    public Table table;

    public Task(double l, double r, double tenv, double f0,
        double alfa0, double alfan, int n, double tau)
    {
        L = l;
        R = r;
        Tenv = tenv;
        F0 = f0;
        Alfa0 = alfa0;
        AlfaN = alfan;

        N = n;
        Tau = tau;

        table = new TableManager().LoadTable();
    }

    public Solution Solve()
    {
        Solution solution;
        solution.X = new double[N + 1];
        solution.T = new List<double>();
        solution.Values = new List<double[]>();

        double x = 0;
        double h = L / N;
        for (int i = 0; i <= N; i++, x += h)
        {
            solution.X[i] = x;
        }

        solution.T.Add(Tenv);
        solution.Values.Add(new double[N + 1]);
        for (int i = 0; i <= N; i++)
        {
            solution.Values[0][i] = Tenv;
        }

        while (true)
        {
            double[] curTemp = null;
            double[] prevTemp = solution.Values.Last();

            solution.T.Add(solution.T.Last() + Tau);
            while (true)
            {
                double cx0 = C(prevTemp[0]), kx0 = k(prevTemp[0]);
                double cx1 = C(prevTemp[1]), kx1 = k(prevTemp[1]);
                double x0 = solution.X[0], x1 = solution.X[1];
                double px0 = p(x0), px1 = p(x1);
                double fx0 = f(x0), fx1 = f(x1);

                double k01 = (kx0 + kx1) / 2;
                double p01 = (px0 + px1) / 2;

                double m0 = Tau * (p01 * h / 8 - k01 / h);
                double k0 = Tau * (k01 / h + p01 * h / 8 + px0 * h / 4);
                double p0 = Tau * (F0 + (3 * fx0 + fx1) * h / 8);

                m0 += (cx0 + cx1) * h / 16;
                k0 += cx0 * h / 4 + (cx0 + cx1) * h / 16;
                p0 += cx0 * h * prevTemp[0] / 4 + (prevTemp[0] + prevTemp[1]) * (cx0 + cx1) * h / 16;

                double cxn = C(prevTemp[N]), kxn = k(prevTemp[N]);
                double cxn1 = C(prevTemp[N - 1]), kxn1 = k(prevTemp[N - 1]);
                double xn = solution.X[N], xn1 = solution.X[N - 1];
                double pxn = p(xn), pxn1 = p(xn1);
                double fxn = f(xn), fxn1 = f(xn1);
                double alpha_l = p(L) * R / 2;

                double pn12 = (pxn + pxn1) / 2;
                double kn12 = (kxn + kxn1) / 2;
                double mn = Tau * (kn12 / h - pn12 * h / 8);
                double kn = -Tau * (kn12 / h + pn12 * h / 8 + pxn * h / 4 + alpha_l);
                double pn = -Tau * (alpha_l * Tenv + (3 * fxn + fxn1) * h / 8);

                mn += (cxn + cxn1) * h / 16;
                kn += cxn * h / 4 + (cxn + cxn1) * h / 16;
                pn += prevTemp[N] * cxn * h / 4 + (prevTemp[N] + prevTemp[N - 1]) * (cxn + cxn1) * h / 16;

                double[] a = new double[N + 1];
                double[] b = new double[N + 1];
                double[] c = new double[N + 1];
                double[] d = new double[N + 1];

                for (int i = 1; i < N; i++)
                {
                    double t1 = prevTemp[i - 1];
                    double t2 = prevTemp[i];  
                    double t3 = prevTemp[i + 1];
                    double c1 = C(t1), k1 = k(t1);
                    double c2 = C(t2), k2 = k(t2);
                    double c3 = C(t3), k3 = k(t3);

                    a[i] = Tau * (k1 + k2) / h / 2;
                    c[i] = Tau * (k2 + k3) / h / 2;
                    b[i] = (a[i] + c[i] + h * Tau * p(solution.X[i]) + c2 * h);
                    d[i] = (f(solution.X[i]) * h * Tau + c2 * h * solution.Values.Last()[i]);
                }

                curTemp = new TridiagonalMatrixAlgorithm().ApplyTo(a, b, c, d, k0, kn, m0, mn, p0, pn, N);

                if (Math.Abs(curTemp[0] - prevTemp[0]) / Math.Abs(curTemp[0]) < 1e-4)
                {
                    break;
                }
                else
                {
                    prevTemp = curTemp;
                }
            }

            prevTemp = solution.Values.Last();
            solution.Values.Add(curTemp);

            if (Math.Abs(curTemp[0] - prevTemp[0]) / Math.Abs(curTemp[0]) < 1e-4)
            {
                break;
            }
        }

        return solution;
    }

    private double C(double T)
    {
        return new LinearInterpolation(table.T, table.C).FindValue(T);
    }

    private double k(double T)
    {
        return new LinearInterpolation(table.T, table.K).FindValue(T);
    }

    private double alfa(double x)
    {
        double b = (AlfaN * L) / (AlfaN - Alfa0);
        double a = -Alfa0 * b;
        return a / (x - b);
    }

    private double p(double x)
    {
        double b = AlfaN * L / (AlfaN - Alfa0);
        double a = -b * Alfa0;
        return 2 / R * (a / (x - b));
    }

    private double f(double x)
    {
        double b = AlfaN * L / (AlfaN - Alfa0);
        double a = -b * Alfa0;
        return 2 / R * (a / (x - b)) * Tenv;
    }
}