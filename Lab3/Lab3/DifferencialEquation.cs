using System;
using System.Drawing;

namespace BMSTU.IU7.Zinovyev.Mathematics
{
    struct FunNode2
    {
        public double x;
        public double y;

        public FunNode2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static explicit operator PointF(FunNode2 node)
        {
            return new PointF((float)node.x, (float)node.y);
        }
    }

    /// <summary>
    /// Предназначен для решения дифференциальных уравнений вида:
    /// d(p(x)*du(x)/dx)/dx + q(x)*du(x)/dx + r(x)*u(x) = f(x), x∈[a, b],
    /// с краевыми условиями вида:
    /// α1*u(a) + α2*du(a)/dx = α
    /// β1*u(b) + β2*du(b)/dx = β,
    /// где p(x), q(x), r(x), f(x) - некоторые заданные функции,
    /// α1, α2, α, β1, β2, β - заданные коэффициенты.
    /// </summary>
    class SturmLiouvilleDiffEquation
    {
        public delegate double OneArgFun(double x);

        private OneArgFun p;
        private OneArgFun q;
        private OneArgFun r;
        private OneArgFun f;

        public SturmLiouvilleDiffEquation(OneArgFun p, OneArgFun q, OneArgFun r, OneArgFun f)
        {
            this.p = p;
            this.q = q;
            this.r = r;
            this.f = f;
        }

        public FunNode2[] Solve(double a, double b, int n,
            double alfa1, double alfa2, double alfa,
            double beta1, double beta2, double beta)
        {
            // Значения функций в узлах.
            double[] P = FindFunValues(p, a, b, n);
            double[] Q = FindFunValues(q, a, b, n);
            double[] R = FindFunValues(r, a, b, n);
            double[] F = FindFunValues(f, a, b, n);

            // Значения коэффициентов трехдиагональной системы уравнений.
            double[] A = new double[n + 1];
            double[] B = new double[n + 1];
            double[] C = new double[n + 1];
            double[] D = new double[n + 1];

            // Шаг сетки.
            double h = (b - a) / n;

            // Аппроксимация левого граничного условия.
            A[0] = 0;
            B[0] = alfa1 - (alfa2 / h);
            C[0] = alfa2 / h;
            D[0] = alfa;

            // Аппроксимация уравнения.
            for (int i = 1; i < n; i++)
            {
                A[i] = P[i] - (P[i + 1] - P[i - 1]) / 4 - (Q[i] * h) / 2;
                B[i] = R[i] * Math.Pow(h, 2) - 2 * P[i];
                C[i] = P[i] + (P[i + 1] - P[i - 1]) / 4 + (Q[i] * h) / 2;
                D[i] = F[i] * Math.Pow(h, 2);
            }

            // Аппроксимация правого граничного условия.
            A[n] = -beta2 / h;
            B[n] = beta1 + (beta2 / h);
            C[n] = 0;
            D[n] = beta;

            TridiagonalMatrixAlgorithm tAlgorithm = new TridiagonalMatrixAlgorithm();

            double[] x = FindFunValues(parameter => parameter, a, b, n);
            double[] y = tAlgorithm.ApplyTo(A, B, C, D);

            FunNode2[] solution = new FunNode2[n + 1];
            for (int i = 0; i <= n; i++)
            {
                solution[i] = new FunNode2(x[i], y[i]);
            }

            return solution;
        }

        private double[] FindFunValues(OneArgFun f, double a, double b, int n)
        {
            double[] values = new double[n + 1];

            double x = a;
            double h = (b - a) / n;
            for (int i = 0; i <= n; i++, x += h)
            {
                values[i] = f(x);
            }

            return values;
        }
    }

    /// <summary>
    /// Предназначен для решения трехдиагональных систем уравнений методом прогонки.
    /// </summary>
    class TridiagonalMatrixAlgorithm
    {
        public double[] ApplyTo(double[] a, double[] b, double[] c, double[] f)
        {
            if (a.Length != b.Length || a.Length != c.Length || a.Length != f.Length)
            {
                throw new ArgumentException("Arrays should be of the same length.");
            }

            // Индекс последнего элемента.
            int n = a.Length - 1;

            // Прогоночные коэффициенты.
            double[] s = new double[n + 1];
            double[] t = new double[n + 1];

            // Прямой ход.
            s[0] = -c[0] / b[0];
            t[0] = f[0] / b[0];
            for (int i = 1; i <= n; i++)
            {
                double d = (a[i] * s[i - 1]) + b[i];
                s[i] = -c[i] / d;
                t[i] = (f[i] - (a[i] * t[i - 1])) / d;
            }

            // Решения системы.
            double[] y = new double[n + 1];

            // Обратный ход.
            y[n] = t[n];
            for (int i = n - 1; i >= 0; i--)
            {
                y[i] = (s[i] * y[i + 1]) + t[i];
            }

            return y;
        }
    }
}
