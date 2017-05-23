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

    public void Solve()
    {
        TablesManager manager = new TablesManager();
        t0Table = manager.T0Table;
        mTable = manager.MTable;
        nTable = manager.NTable;
        sigmaTable = manager.SigmaTable;

        DiffEquationSys deSys = new RungeKuttaDiffEquationSys(new DiffEquationSys.SeveralArgFun[]
        {
                (x, y) => ((y[1] - (Rk + Rp(y[0]))*y[0]) / Lk),
                (x, y) => (-y[0] / Ck)
        });

    }

    private double Rp(double I)
    {
        double T(double r)
        {
            Interpolation2D itp = new LinearInterpolation2D(t0Table.I, t0Table.T0);
            double t0 = itp.FindValue(I);

            itp = new LinearInterpolation2D(mTable.I, mTable.M);
            double m = itp.FindValue(I);

            return (Tw - t0) * Math.Pow((r / R), m) + t0;
        }

        double f(double p)
        {
            Integral itgN = new SimpsonIntegral(r =>
            {
                Interpolation3D ditp = new LinearInterpolation3D(nTable.T, nTable.P, nTable.N);
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
            Interpolation3D ditp = new LinearInterpolation3D(sigmaTable.T, sigmaTable.P, sigmaTable.Sigma);
            double n = ditp.FindValue(T(r), pValue);
            return n * r;
        });

        return Le / (2 * Math.PI * itgSigma.FindValue(0, R, INTEGRAL_NODES));
    }
}