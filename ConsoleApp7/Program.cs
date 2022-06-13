using System;

namespace delta
{
    public class licz
    {
        public static void liczdelta(double a, double b, double c, double x1, double x2)
        {
            double delta = (b * b) - (4 * a * c);
            if (delta < 0)
            {
                Console.WriteLine("DELTA WYNOSI " + delta + " DELTA<0 ROWNANIE NIE MA PIERWIASTKOW");
            }
            if (delta == 0)
            {
                x1 = -b / 2 * a;
                Console.WriteLine("DELTA WYNOSI " + delta + " DELTA=0 ROWNANIE MA JEDEN PIERWIASTEK X1=" + x1);
            }
            if (delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("DELTA WYNOSI " + delta + " DELTA>0 ROWNANIE MA DWA PIERWIASTKI X1=" + x1 + " X2=" + x2);
            }
        }

        static void Main(string[] args)
        {

        }
    }
}