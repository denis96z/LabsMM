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
            throw new NotImplementedException();
        }
    }

    public MTable MTable
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public NTable NTable
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public SigmaTable SigmaTable
    {
        get
        {
            throw new NotImplementedException();
        }
    }
}