using System;

/// <summary>
/// Представляет решение ОДУ.
/// </summary>
struct DiffEquationSolution
{
    public double[] X;
    public double[] Y;
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

    public abstract DiffEquationSolution[] FindSolution(double a, double b, double[] y0, double h);

    protected SeveralArgFun[] f = null;
}

/// <summary>
/// Решает задачу Коши с помощью метода Рунге-Кутты 4-го порядка точности.
/// </summary>
class RungeKuttaDiffEquationSys : DiffEquationSys
{
    public RungeKuttaDiffEquationSys(SeveralArgFun[] f) : base(f) { }

    public override DiffEquationSolution[] FindSolution(double a, double b, double[] y0, double h)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// Решает задачу Коши с помощью неявного метода трапеций.
/// </summary>
class ImplTrapDiffEquationSys : DiffEquationSys
{
    public ImplTrapDiffEquationSys(SeveralArgFun[] f) : base(f) { }

    public override DiffEquationSolution[] FindSolution(double a, double b, double[] y0, double h)
    {
        throw new NotImplementedException();
    }
}