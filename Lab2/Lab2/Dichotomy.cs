using System;

class Dichotomy
{
    public delegate double OneArgFun(double x);

    public Dichotomy(OneArgFun f)
    {
        this.f = f;
    }

    public double FindSolution(double a, double b)
    {
        const double EPS = 1e-5;

        double x;
        double y1 = f(a), y2;
        do
        {
            x = (a + b) / 2;
            y2 = f(x);

            if (y1 * y2 > 0)
            {
                a = x;
            }
            else
            {
                b = x;
            }
        }
        while (Math.Abs(b - a) >= EPS);

        return x;
    }

    private OneArgFun f;
}