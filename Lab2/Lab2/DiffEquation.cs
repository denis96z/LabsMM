using System;

/// <summary>
/// Представляет решение ОДУ.
/// </summary>
struct DiffEquationSolution
{
    public double[] X;
    public double[] Y;
    public int N;

    public DiffEquationSolution(int n)
    {
        if (n > 0)
        {
            X = new double[n + 1];
            Y = new double[n + 1];
            N = n;
        }
        else
        {
            throw new ArgumentException("n");
        }
    }

    public DiffEquationSolution(double a,
        double b, int n) : this(n)
    {
        X[0] = a;
        double h = (b - a) / n;
        for (int i = 1; i <= n; i++)
        {
            X[i] = X[i - 1] + h;
        }
    }
}

/// <summary>
/// Решает задачу Коши.
/// </summary>
abstract class DiffEquationSys
{
    public delegate double SeveralArgFun(double x, double[] y);

    public DiffEquationSys(SeveralArgFun[] f)
    {
        this.f = f;
    }

    public abstract DiffEquationSolution[] FindSolution(double a, double b, double[] y0, int n);

    protected SeveralArgFun[] f = null;
}

/// <summary>
/// Решает задачу Коши с помощью метода Рунге-Кутты 4-го порядка точности.
/// </summary>
class RungeKuttaDiffEquationSys : DiffEquationSys
{
    public RungeKuttaDiffEquationSys(SeveralArgFun[] f) : base(f) { }

    public override DiffEquationSolution[] FindSolution(double a, double b, double[] y0, int n)
    {
        DiffEquationSolution[] solutions = new DiffEquationSolution[f.Length];

        for (int i = 0; i < f.Length; i++)
        {
            solutions[i] = new DiffEquationSolution(a, b, n);
            solutions[i].Y[0] = y0[i];
        }

        double x = a;
        double h = (b - a) / n;
        for (int i = 1; i <= n; i++, x += h)
        {
            double[,] k = new double[4, f.Length];

            // Вычисление K0.
            double[] y = new double[f.Length];
            for (int j = 0; j < f.Length; j++)
            {
                y[j] = solutions[j].Y[i - 1];
            }
            for (int j = 0; j < f.Length; j++)
            {
                k[0, j] = h * f[j](x, y);
            }

            // Вычисление Kindex, index = 1,...,3
            for (int index = 1; index <= 3; index++)
            {
                for (int j = 0; j < f.Length; j++)
                {
                    y[j] = solutions[j].Y[i - 1] + 0.5*k[index-1, j];
                }
                for (int j = 0; j < f.Length; j++)
                {
                    k[index, j] = h * f[j](x + 0.5*h, y);
                }
            }

            // Приращение функции.
            for (int j = 0; j < f.Length; j++)
            {
                y[j] = 0.1667 * (k[0, j] + 2*k[1, j] + 2*k[2, j] + k[3, j]);
                solutions[j].Y[i] = solutions[j].Y[i - 1] + y[j];
            }
        }

        return solutions;
    }
}

/// <summary>
/// Решает задачу Коши с помощью неявного метода трапеций.
/// </summary>
class ImplTrapDiffEquationSys : DiffEquationSys
{
    public ImplTrapDiffEquationSys(SeveralArgFun[] f) : base(f) { }

    public override DiffEquationSolution[] FindSolution(double a, double b, double[] y0, int n)
    {
        DiffEquationSolution[] solutions = new DiffEquationSolution[f.Length];

        for (int i = 0; i < f.Length; i++)
        {
            solutions[i] = new DiffEquationSolution(a, b, n);
            solutions[i].Y[0] = y0[i];
        }

        double x = a;
        double h = (b - a) / n;
        for (int i = 1; i <= n; i++, x += h)
        {
            double[] yk = new double[f.Length];
            for (int j = 0; j < f.Length; j++)
            {
                yk[j] = solutions[j].Y[i - 1];
            }

            double[] yk1 = new double[f.Length];
            for (int j = 0; j < f.Length; j++)
            {
                yk[j] = solutions[j].Y[i - 1];
            }

            for (int j = 0; j < f.Length; j++)
            {
                yk1[j] = yk[j] + 0.5 * h * (f[j](x, yk) + f[j](x + h, yk1));
            }
            for (int j = 0; j < f.Length; j++)
            {
                yk1[j] = yk[j] + 0.5 * h * (f[j](x, yk) + f[j](x + h, yk1));
            }

            for (int j = 0; j < f.Length; j++)
            {
                solutions[j].Y[i] = yk1[j];
            }
        }

        return solutions;
    }
}