abstract class Integral
{
    public delegate double OneArgFun(double x);

    public Integral(OneArgFun f)
    {
        this.f = f;
    }

    public abstract double FindValue(double a, double b, int n);

    protected OneArgFun f;
}

class SimpsonIntegral : Integral
{
    public SimpsonIntegral(OneArgFun f) : base(f) { }

    public override double FindValue(double a, double b, int n)
    {
        double h;
        h = (b - a) / n;

        double I, I2 = 0, I4 = 0;
        I4 = f(a + h);
        for (int k = 2; k < n; k += 2)
        {
            I4 += f(a + (k + 1) * h);
            I2 += f(a + k * h);
        }
        I = f(a) + f(b) + 4 * I4 + 2 * I2;
        I *= h / 3;

        return I;
    }
}