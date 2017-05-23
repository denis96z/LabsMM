using System;

abstract class Interpolation2D
{
    public Interpolation2D(double[] x, double[] y)
    {
        this.xValues = x;
        this.yValues = y;
        NODES_COUNT = x.Length;
    }

    public abstract double FindValue(double x);

    protected double[] xValues = null, yValues = null;
    protected readonly int NODES_COUNT = 0;
}

class LinearInterpolation2D : Interpolation2D
{
    public LinearInterpolation2D(double[] x, double[] y) : base(x, y) { }

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

abstract class Interpolation3D
{
    public Interpolation3D(double[] x, double[] y, double[,] z)
    {
        this.xValues = x;
        this.yValues = y;
        this.zValues = z;
    }

    public abstract double FindValue(double x, double y);

    protected double[] xValues = null, yValues = null;
    protected double[,] zValues = null;
}

class LinearInterpolation3D : Interpolation3D
{
    public LinearInterpolation3D(double[] x,
        double[] y, double[,] z) : base(x, y, z) { }

    public override double FindValue(double x, double y)
    {
        throw new NotImplementedException();
    }
}

class LinearLogInterpolation3D : Interpolation3D
{
    public LinearLogInterpolation3D(double[] x,
        double[] y, double[,] z) : base(x, y, z) { }

    public override double FindValue(double x, double y)
    {
        throw new NotImplementedException();
    }
}