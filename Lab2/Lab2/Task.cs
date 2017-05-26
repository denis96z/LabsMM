using System;

class Task
{
    public double Rk { get; set; }
    public double Lk { get; set; }
    public double Ck { get; set; }
    public double R { get; set; }
    public double P0 { get; set; }
    public double Ts { get; set; }
    public double Tw { get; set; }
    public double Le { get; set; }
    public double Uc0 { get; set; }
    public double I0 { get; set; }

    private const int INTEGRAL_NODES = 41;

    TablesManager manager = null;
    T0Table t0Table;
    MTable mTable;
    NTable nTable;
    SigmaTable sigmaTable;

    public Task(double rk, double lk, double ck,
    double r, double p0, double ts, double tw,
    double le, double uc0, double i0)
    {
        Rk = rk;
        Lk = lk;
        Ck = ck;
        R = r;
        P0 = p0;
        Ts = ts;
        Tw = tw;
        Le = le;
        Uc0 = uc0;
        I0 = I0;
    }

    public void Solve()
    {
        TablesManager manager = new TablesManager();
        t0Table = manager.T0Table;
        mTable = manager.MTable;
        nTable = manager.NTable;
        sigmaTable = manager.SigmaTable;

        //!!! Вроде силу тока по модулю брать надо (сила тока здесь y[0]), после тестирования будет понятно.
        DiffEquationSys deSys = new RungeKuttaDiffEquationSys(new DiffEquationSys.SeveralArgFun[]
        {
                (x, y) => ((y[1] - (Rk + Rp(y[0]))*y[0]) / Lk),
                (x, y) => (-y[0] / Ck)
        });
        var solution = deSys.FindSolution(0, 100, new double[] { I0, Uc0 }, 50);
    }

    private double Rp(double I)
    {
        double T(double r)
        {
            Interpolation itp = new LinearInterpolation(t0Table.I, t0Table.T0);
            double t0 = itp.FindValue(I);

            itp = new LinearInterpolation(mTable.I, mTable.M);
            double m = itp.FindValue(I);

            return (Tw - t0) * Math.Pow((r / R), m) + t0;
        }

        double f(double p)
        {
            Integral itgN = new SimpsonIntegral(r =>
            {
                Interpolation2 ditp = new LinearLogInterpolation2(nTable.T, nTable.P, nTable.N);
                double n = ditp.FindValue(T(r), p);
                return n * r;
            });

            return (2 / R * R) * itgN.FindValue(0, R, INTEGRAL_NODES) - (P0 * 7242 / Ts);
        }

        Dichotomy dch = new Dichotomy(f);
        double pValue = 1;
        double h = 1;
        while (f(pValue) * f(pValue + h) > 0)
        {
            pValue += h;
        }
        pValue = dch.FindSolution(pValue, pValue + h);

        Integral itgSigma = new SimpsonIntegral(r =>
        {
            Interpolation2 ditp = new LinearLogInterpolation2(sigmaTable.T, sigmaTable.P, sigmaTable.Sigma);
            double n = ditp.FindValue(T(r), pValue);
            return n * r;
        });

        return Le / (2 * Math.PI * itgSigma.FindValue(0, R, INTEGRAL_NODES));
    }
}