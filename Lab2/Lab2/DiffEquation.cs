using System;

abstract class DiffEquationSys
{
    public delegate double SeveralArgFun(double x, double[] y);

    public DiffEquationSys(SeveralArgFun[] f)
    {
        this.f = f;
    }

    public abstract double[,] FindSolution(double a, double b, double[] y0, double h);

    protected SeveralArgFun[] f = null;
}

class RungeKuttaDiffEquationSys : DiffEquationSys
{
    public RungeKuttaDiffEquationSys(SeveralArgFun[] f) : base(f) { }

    public override double[,] FindSolution(double a, double b, double[] y0, double h)
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

    public override double[,] FindSolution(double a, double b, double[] y0, double h)
    {
        throw new NotImplementedException();
    }
}