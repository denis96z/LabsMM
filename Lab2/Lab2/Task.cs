using System;

struct TaskSolution
{
    public DiffEquationSolution I;
    public DiffEquationSolution Uc;
    public DiffEquationSolution Rp;
    public DiffEquationSolution Ucp;
}

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

    public TaskSolution Solve(double a, double b, int n)
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

        DiffEquationSolution[] sysSolution = deSys.FindSolution(a, b, new double[] { I0, Uc0 }, n);
        DiffEquationSolution rpSolution = new DiffEquationSolution(a, b, n);
        for (int i = 0; i <= n; i++)
        {
            rpSolution.Y[i] = Rp(sysSolution[0].Y[i]);
        }
        DiffEquationSolution ucpSolution = new DiffEquationSolution(a, b, n);
        for (int i = 0; i <= n; i++)
        {
            ucpSolution.Y[i] = rpSolution.Y[i] * sysSolution[0].Y[i];
        }

        TaskSolution taskSolution;
        taskSolution.I = sysSolution[0];
        taskSolution.Uc = sysSolution[1];
        taskSolution.Rp = rpSolution;
        taskSolution.Ucp = ucpSolution;

        return taskSolution;
    }

    private double Rp(double I)
    {
        //!!! Вроде силу тока по модулю брать надо, после тестирования будет понятно.
        I = Math.Abs(I);

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

            return (2 / Math.Pow(R, 2)) * itgN.FindValue(0, R, INTEGRAL_NODES) - (P0 * 7242 / Ts);
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