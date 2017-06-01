/// <summary>
/// Метод прогонки.
/// </summary>
class TridiagonalMatrixAlgorithm
{
    public TridiagonalMatrixAlgorithm() { }

    /// <summary>
    /// Находит вектор решений системы уравнений с трехдиагональной матрицей коэффициентов. AXn-1 + BXn + CXn+1 = F
    /// </summary>
    /// <param name="a">Массив коэффициентов A. Имеет размер N + 1. Нулевой и N-й элементы = 0.</param>
    /// <param name="b">Массив коэффициентов B. Имеет размер N + 1. Нулевой и N-й элементы = 0.</param>
    /// <param name="c">Массив коэффициентов C. Имеет размер N + 1. Нулевой и N-й элементы = 0.</param>
    /// <param name="f">Массив коэффициентов F. Имеет размер N + 1. Нулевой и N-й элементы = 0.</param>
    /// <returns>Вектор решений системы.</returns>
    public double[] ApplyTo(double[] a, double[] b, double[] c, double[] f,
        double k0, double kn, double m0, double mn, double p0, double pn, int n)
    {
        // Прогоночные коэффициенты.
        double[] eps = new double[n + 1];
        double[] mu = new double[n + 1];

        // Начальные значения прогоночных коэффициентов из граничных условий.
        eps[1] = -m0 / k0;
        mu[1] = p0 / k0;

        // Прямой ход.
        for (int i = 1; i < n; i++)
        {
            eps[i + 1] = c[i] / (b[i] - a[i] * eps[i]);
            mu[i + 1] = (f[i] + a[i] * mu[i]) / (b[i] - a[i] * eps[i]);
        }

        // Решения системы.
        double[] y = new double[n + 1];

        // Обратный ход.
        y[n] = (pn - mn * mu[n]) / (kn + mn * eps[n]);
        for (int i = n; i > 0; i--)
        {
            y[i - 1] = eps[i] * y[i] + mu[i];
        }

        return y;
    }
}