using System;


class GiaiPTBac2 : GiaiPTBac1
{
    private double c;

    public GiaiPTBac2(double a, double b, double c) : base(a, b)
    {
        this.c = c;
    }

    public override string Giai()
    {
        if (Math.Abs(a) == 0)
        {
            return GiaiPTBac1.Giai(a, b);
        }

        double delta = b * b - 4 * a * c;
        if (delta > 0)
        {
            double s = Math.Sqrt(delta);
            double x1 = (-b + s) / (2 * a);
            double x2 = (-b - s) / (2 * a);
            return "2 nghiem: x1=" + x1 + ", x2=" + x2;
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            return "Nghiem kep: x=" + x;
        }
        else
        {
            double phanThuc = -b / (2 * a);
            double phanAo = Math.Sqrt(-delta) / (2 * a);
            return "2 nghiem phuc: " + phanThuc + "+" + phanAo + "i, " + phanThuc + "-" + phanAo + "i";
        }
    }
}
