using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework
{
    class Lotka
    {
        public double a { get; set; }
        public double b { get; set; }
        public double g { get; set; }
        public double d { get; set; }
        public double x_init { get; set; }
        public double y_init { get; set; }
        public double t_end { get; set; }
        public GraphSelect graph { get; set; }

        private const double step = 0.1;

        public Lotka()
        {
            a = 4.0;
            b = 2.5;
            g = 2;
            d = 1;
            x_init = 3;
            y_init = 1;

        }

        private static Lotka _inst;

        public static Lotka Inst
        {
            get
            {
                if (_inst == null)
                {
                    _inst = new Lotka();
                }
                return _inst;
            }
        }

        private double fx(double x, double y)
        {
            return a * x - b * x * y;
        }

        private double fy(double x, double y)
        {
            return -g * y + d * x * y;
        }

        private void rungeKutta(ref double x, ref double y)
        {
            double dx1, dx2, dx3, dx4, dy1, dy2, dy3, dy4;
            double h = step;
            dx1 = fx(x, y);
            dy1 = fy(x, y);
            dx2 = fx(x + (h / 2.0) * dx1, y + (h / 2.0) * dy1);
            dy2 = fy(x + (h / 2.0) * dx1, y + (h / 2.0) * dy1);
            dx3 = fx(x + (h / 2.0) * dx2, y + (h / 2.0) * dy2);
            dy3 = fy(x + (h / 2.0) * dx2, y + (h / 2.0) * dy2);
            dx4 = fx(x + h * dx3, y + h * dy3);
            dy4 = fy(x + h * dx3, y + h * dy3);

            x += h * (dx1 + 2.0 * dx2 + 2.0 * dx3 + dx4) / 6.0;
            y += h * (dy1 + 2.0 * dy2 + 2.0 * dy3 + dy4) / 6.0;
        }

        public List<TheData> getData(double x_init = -1.0, double y_init = -1.0)
        {
            double x = x_init < 0 ? this.x_init : x_init;
            double y = y_init < 0 ? this.y_init : y_init;
            double i = 0;
            var res = new List<TheData>();
            do
            {
                res.Add(new TheData { t = i, x = x, y = y });
                rungeKutta(ref x, ref y);
                i += step;
            }
            while (i <= t_end);
            return res;
        }

        public List<List<TheData>> getCircleData()
        {
            var res = new List<List<TheData>>();
            double centerX = Lotka.Inst.getCenterX();
            double centerY = Lotka.Inst.getCenterY();
            for (double x_init = centerX; x_init < centerX + 10.0; x_init += 1.0)
            {
                var dataCircles = Lotka.Inst.getData(x_init, centerY);
                res.Add(dataCircles);
            }
            return res;
        }

        public double getCenterX()
        {
            return g/d;
        }

        public double getCenterY()
        {
            return a/b;
        }
    }

    public class TheData
    {
        public double t { get; set; }
        public double x { get; set; }
        public double y { get; set; }
    }
}

