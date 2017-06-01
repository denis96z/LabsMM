struct Table
{
    public double[] T;
    public double[] C;
    public double[] K;
}

class TableManager
{
    
    public Table LoadTable()
    {
        Table table;
        table.T = new double[]
        {
            300,  400,  500,  600,  700,  800,
            900, 1000, 1200, 1400, 1600, 1800
        };
        table.C = new double[]
        {
            2.3886, 2.4942, 2.5756, 2.6970, 2.7893, 2.8220,
            2.8633, 2.8464, 2.7701, 2.8871, 3.1497, 3.4311
        };
        table.K = new double[]
        {
            0.223, 0.207, 0.197, 0.197, 0.198, 0.198,
            0.198, 0.196, 0.219, 0.239, 0.277, 0.309
        };
        return table;
    }
}