using System;
using System.Drawing;
using Mathematics = BMSTU.IU7.Zinovyev.Mathematics;

namespace Lab3
{
    class Task1
    {
        private double L;
        private double R;
        private double Tenv;
        private double F0;
        private double K0, Kn;
        private double A0, An;
        private int N;

        public Task1(double l, double r, double t, double f0,
            double k0, double kn, double a0, double an, int n)
        {
            L = l;
            R = r;
            Tenv = t;
            F0 = f0;
            K0 = k0;
            Kn = kn;
            A0 = a0;
            An = an;
            N = n;
        }

        public GraphLine FindSolution()
        {
            double[] a = new double[N + 1];
            double[] b = new double[N + 1];
            double[] c = new double[N + 1];
            double[] d = new double[N + 1];

            double h = L / N;
            double x = h;

            for (int i = 1; i <= N; i++, x += h)
            {
                a[i] = (k(x) + k(x - h)) / h;
                c[i] = (k(x) + k(x + h)) / h;
                b[i] = a[i] + c[i] + p(x) * h;
                d[i] = f(x) * h;
            }

            double x0 = 0, x1 = h;
            double xn = h * N, xn1 = xn - h;

            double px0 = p(x0), px1 = p(x1);
            double kx0 = k(x0), kx1 = k(x1);
            double fx0 = f(x0), fx1 = f(x1);

            double pxn = p(xn), kxn = k(xn), fxn = f(xn);
            double pxn1 = p(xn1), kxn1 = k(xn1), fxn1 = f(xn1);

            double al = p(L) * R / 2;

            double m0 = h * h / 16 * (px1 + px0) - (kx0 + kx1) / 2;
            double k0 = (kx0 + kx1) / 2 + h * h / 16 * (px1 + px0) + h * h * px0 / 4;
            double p0 = h * F0 + h * h * ((fx0 + fx1) / 2 + fx0) / 4;

            double mn = h * h / 16 * (pxn1 + pxn) - (kxn + kxn1) / 2;
            double kn = (kxn + kxn1) / 2 + h * h / 16 * (pxn1 + pxn) + h * h * pxn / 4 + h * al;
            double pn = h * Tenv * al + h * h * ((fxn + fxn1) / 2 + fxn) / 4;

            TridiagonalMatrixAlgorithm tma = new TridiagonalMatrixAlgorithm();
            double[] t = tma.ApplyTo(a, b, c, d, k0, kn, m0, mn, p0, pn, N);

            return FormLine(h, t);
        }

        private GraphLine FormLine(double h, double[] t)
        {
            PointF[] points = new PointF[t.Length];
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X = (float)(i * h);
                points[i].Y = (float)t[i];
            }

            GraphLine gl = new GraphLine();
            gl.Nodes = points;
            gl.Color = Color.Red;

            return gl;
        }

        private double p(double x)
        {
            double b = An * L / (An - A0);
            double a = -b * A0;
            return 2 / R * (a / (x - b));
        }

        private double f(double x)
        {
            return p(x) * Tenv;
        }

        private double k(double x)
        {
            double b = Kn * L / (Kn - K0);
            double a = -b * K0;
            return a / (x - b);
        }
    }

    class Task2
    {
        private double L;
        private double R;
        private double Tenv;
        private double F0;
        private double K0, Kn;
        private double A0, An;
        private int N;

        public Task2(double l, double r, double t, double f0,
            double k0, double kn, double a0, double an, int n)
        {
            L = l;
            R = r;
            Tenv = t;
            F0 = f0;
            K0 = k0;
            Kn = kn;
            A0 = a0;
            An = an;
            N = n;
        }

        public Mathematics.FunNode2[] FindSolution()
        {
            Mathematics.SturmLiouvilleDiffEquation e =
                new Mathematics.SturmLiouvilleDiffEquation(k,
                z => 0, z => -2 * alfa(z) / R, z => -2 * alfa(z) * Tenv / R);
            return e.Solve(0, L, N, 0, -k(0), F0, An, k(L), An * Tenv);
        }

        private double k(double x)
        {
            double b = (Kn * L) / (Kn - K0);
            double a = -K0 * b;
            return a / (x - b);
        }

        private double alfa(double x)
        {
            double b = (An * L) / (An - A0);
            double a = -A0 * b;
            return a / (x - b);
        }
    }
}
