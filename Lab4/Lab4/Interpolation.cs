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
        X_NODES_COUNT = x.Length;
        Y_NODES_COUNT = y.Length;
    }

    public abstract double FindValue(double x, double y);

    protected double[] xValues = null, yValues = null;
    protected double[,] zValues = null;
    protected readonly int X_NODES_COUNT = 0;
    protected readonly int Y_NODES_COUNT = 0;
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
        int index1_X = FirstIndex(x, xValues, X_NODES_COUNT);
        int index2_X = index1_X + 1;

        int index1_Y = FirstIndex(y, yValues, Y_NODES_COUNT);
        int index2_Y = index1_Y + 1;


        double r1 = (xValues[index2_X] - x) / (xValues[index2_X] - xValues[index1_X]) * zValues[index1_X, index1_Y] +
        	(x - xValues[index1_X]) / (xValues[index2_X] - xValues[index1_X]) * zValues[index2_X, index1_Y];


		double r2 = (xValues[index2_X] - x) / (xValues[index2_X] - xValues[index1_X]) * zValues[index1_X, index2_Y] +
        	(x - xValues[index1_X]) / (xValues[index2_X] - xValues[index1_X]) * zValues[index2_X, index2_Y];
        	

        double result = (yValues[index2_Y] - y) / (yValues[index2_Y] - yValues[index1_Y]) * r1 +
        	(y - yValues[index1_Y]) / (yValues[index2_Y] - yValues[index1_Y]) * r2;

        return result;
    }

    private int FirstIndex(double value, double[] conteiner, int nodesCount)
    {
        for (int i = 1; i < nodesCount - 1; i++)
        {
            if (value <= conteiner[i])
            {
                return i - 1;
            }
        }
        return nodesCount - 2;
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
        int index1_X = FirstIndex(x, xValues, X_NODES_COUNT);
        int index2_X = index1_X + 1;

        int index1_Y = FirstIndex(y, yValues, Y_NODES_COUNT);
        int index2_Y = index1_Y + 1;

        double r1 = zValues[index1_X, index1_Y] + (zValues[index1_X, index2_Y] - zValues[index1_X, index1_Y]) *
            ((y - yValues[index1_Y]) / (yValues[index2_Y] - yValues[index1_Y]));
        double r2 = zValues[index2_X, index1_Y] + (zValues[index2_X, index2_Y] - zValues[index2_X, index1_Y]) *
            ((y - yValues[index1_Y]) / (yValues[index2_Y] - yValues[index1_Y]));

        double r = Math.Log(r1) + (Math.Log(r2) - Math.Log(r1)) *
            ((x - xValues[index1_X]) / (xValues[index2_X] - xValues[index1_X]));

        return Math.Exp(r);
    }

    private int FirstIndex(double value, double[] conteiner, int nodesCount)
    {
        for (int i = 1; i < nodesCount - 1; i++)
        {
            if (value <= conteiner[i])
            {
                return i - 1;
            }
        }
        return nodesCount - 2;
    }
}