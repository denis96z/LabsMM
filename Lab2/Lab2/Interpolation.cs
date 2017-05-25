using System;

/// <summary>
/// Одномерная интерполяция.
/// </summary>
abstract class Interpolation
{
    public Interpolation(double[] x, double[] y)
    {
        this.xValues = x;
        this.yValues = y;
        NODES_COUNT = x.Length;
    }

    public abstract double FindValue(double x);

    protected double[] xValues = null, yValues = null;
    protected readonly int NODES_COUNT = 0;
}

/// <summary>
/// Одномерная линейная интерполяция.
/// </summary>
class LinearInterpolation : Interpolation
{
    public LinearInterpolation(double[] x, double[] y) : base(x, y) { }

    public override double FindValue(double x)
    {
        int index1 = FirstIndex(x);
        int index2 = index1 + 1;

        double result = yValues[index1] + (yValues[index2] - yValues[index1]) *
            ((x - xValues[index1]) / (xValues[index2] - xValues[index1]));
        return result;
    }

    private int FirstIndex(double x)
    {
        for (int i = 1; i < NODES_COUNT - 1; i++)
        {
            if (x <= xValues[i])
            {
                return i - 1;
            }
        }
        return NODES_COUNT - 2;
    }
}

/// <summary>
/// Двумерная интерполяция.
/// </summary>
abstract class Interpolation2
{
    public Interpolation2(double[] x, double[] y, double[,] z)
    {
        this.xValues = x;
        this.yValues = y;
        this.zValues = z;
    }

    public abstract double FindValue(double x, double y);

    protected double[] xValues = null, yValues = null;
    protected double[,] zValues = null;
}

/// <summary>
/// Двумерная линейная интерполяция.
/// </summary>
class LinearInterpolation2 : Interpolation2
{
    public LinearInterpolation2(double[] x,
        double[] y, double[,] z) : base(x, y, z) { }

    public override double FindValue(double x, double y)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// Двумерная линейно-логарифмическая интерполяция.
/// </summary>
class LinearLogInterpolation2 : Interpolation2
{
    public LinearLogInterpolation2(double[] x,
        double[] y, double[,] z) : base(x, y, z) { }

    public override double FindValue(double x, double y)
    {
        throw new NotImplementedException();
    }
}