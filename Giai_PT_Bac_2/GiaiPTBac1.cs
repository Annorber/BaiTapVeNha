using System;

class GiaiPTBac1
{
    protected double a;
    protected double b;

    public GiaiPTBac1(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public virtual string Giai()
    {
        const double eps = 1e-12;
        if (Math.Abs(a) < eps)
        {
            if (Math.Abs(b) < eps) return "Vo so nghiem";
            return "Vo nghiem";
        }

        double x = -b / a;
        return "Nghiem: x = " + x;
    }

    public static string Giai(double a, double b)
    {
        return new GiaiPTBac1(a, b).Giai();
    }
}
