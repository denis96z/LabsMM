using System;

struct T0Table
{
    public double[] I;
    public double[] T0;
}

struct MTable
{
    public double[] I;
    public double[] M;
}

struct NTable
{
    public double[] T;
    public double[] P;
    public double[,] N;
}

struct SigmaTable
{
    public double[] T;
    public double[] P;
    public double[,] Sigma;
}

class TablesManager
{
    public T0Table T0Table
    {
        get
        {
            T0Table table;
            table.I = new double[] { 0.5, 1, 5, 10, 50, 200, 400, 800, 1200 };
            table.T0 = new double[] { 6400, 6790, 7150, 7270, 8010, 9185, 10010, 11140, 12010 };
            return table;
        }
    }

    public MTable MTable
    {
        get
        {
            MTable table;
            table.I = new double[] { 0.5, 1, 5, 10, 50, 200, 400, 800, 1200 };
            table.M = new double[] { 0.40, 0.55, 1.70, 3.0, 11.0, 32.0, 40.0, 41.0, 39.0 };
            return table;
        }
    }

    public NTable NTable
    {
        get
        {
            NTable table;
            table.T = new double[]
            {
                1000, 1500, 2000, 2500, 3000, 3500, 4000, 4500,
                5000, 6000, 7000, 8000, 9000, 10000, 11000, 12000,
                13000, 14000, 15000
            };
            table.P = new double[] { 5, 15, 25 };
            table.N = new double[,]
            {
                { 3.62e+01,    1.086e+02,  1.81e+02 },
                { 2.41e+01,    7.242e+01,  1.21e+02 },
                { 1.81e+01,    5.431e+01,  9.05e+01 },
                { 1.45e+01,    4.345e+01,  7.24e+01 },
                { 1.21e+01,    3.621e+01,  6.04e+01 },
                { 1.03e+01,    3.104e+01,  5.17e+01 },
                { 9.05e+00,    2.716e+01,  4.53e+01 },
                { 8.05e+00,    2.414e+01,  4.02e+01 },
                { 7.24e+00,    2.173e+01,  3.62e+01 },
                { 6.03e+00,    1.810e+01,  3.02e+01 },
                { 5.16e+00,    1.550e+01,  2.58e+01 },
                { 4.49e+00,    1.350e+01,  2.25e+01 },
                { 3.92e+00,    1.188e+01,  1.99e+01 },
                { 3.39e+00,    1.044e+01,  1.76e+01 },
                { 2.87e+00,    9.089e+00,  1.54e+01 },
                { 2.37e+00,    7.784e+00,  1.34e+01 },
                { 1.94e+00,    6.564e+00,  1.14e+01 },
                { 1.62e+00,    5.516e+00,  9.72e+00 },
                { 1.40e+00,    4.695e+00,  8.30e+00 }
            };
            return table;
        }
    }

    public SigmaTable SigmaTable
    {
        get
        {
            SigmaTable table;
            table.T = new double[]
            {
                2000, 3000, 4000, 5000, 6000, 7000, 8000,
                9000, 10000, 11000, 12000, 13000, 14000, 15000,
                16000, 17000, 18000, 19000, 20000
            };
            table.P = new double[] { 5, 15, 25 };
            table.Sigma = new double[,]
            {
                { 0.525e-3,    0.309e-3,    0.239e-3 },
                { 0.525e-2,    0.309e-2,    0.239e-2 },
                { 0.525e-1,    0.309e-1,    0.239e-1 },
                { 0.442e+0,    0.270e+0,    0.214e+0 },
                { 0.283e1,     0.205e1,     0.175e1 },
                { 0.741e1,     0.606e1,     0.545e1 },
                { 0.138e2,     0.120e2,     0.111e2 },
                { 0.220e2,     0.199e2,     0.188e2 },
                { 0.317e2,     0.296e2,     0.284e2 },
                { 0.428e2,     0.411e2,     0.399e2 },
                { 0.547e2,     0.541e2,     0.533e2 },
                { 0.664e2,     0.677e2,     0.677e2 },
                { 0.769e2,     0.815e2,     0.825e2 },
                { 0.861e2,     0.938e2,     0.965e2 },
                { 0.941e2,     0.105e3,     0.109e3 },
                { 0.102e3,     0.115e3,     0.120e3 },
                { 0.112e3,     0.124e3,     0.131e3 },
                { 0.126e3,     0.135e3,     0.124e3 },
                { 0.149e3,     0.150e3,     0.154e3 }
            };
            return table;
        }
    }
}