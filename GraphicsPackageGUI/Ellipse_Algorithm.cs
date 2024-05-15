using System.Collections.Generic;

namespace GraphicsPackageGUI
{
    public class Ellipse_Algorithm
    {
        public double rx { get; set; }
        public double ry { get; set; }
        public double xc { get; set; }
        public double yc { get; set; }


        public double[,] ellipseMidpoint()
        {

            double dx, dy, d1, d2, x, y;
            x = 0;
            y = ry;

            // Initial decision parameter of region 1
            d1 = (ry * ry) - (rx * rx * ry) + (0.25f * rx * rx);
            dx = 2 * ry * ry * x;
            dy = 2 * rx * rx * y;

            List<double> Xpoints = new List<double>();
            List<double> Ypoints = new List<double>();

            // For region 1
            while (dx < dy)
            {
                Xpoints.Add(x); Ypoints.Add(y);
                // Checking and updating value of
                // decision parameter based on algorithm
                if (d1 < 0)
                {
                    x++;
                    dx = dx + (2 * ry * ry);
                    d1 = d1 + dx + (ry * ry);
                }
                else
                {
                    x++;
                    y--;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d1 = d1 + dx - dy + (ry * ry);
                }
            }
            // Decision parameter of region 2
            d2 = ((ry * ry) * ((x + 0.5f) * (x + 0.5f)))
                + ((rx * rx) * ((y - 1) * (y - 1)))
                - (rx * rx * ry * ry);

            // Plotting points of region 2
            while (y >= 0)
            {
                Xpoints.Add(x); Ypoints.Add(y);
                // Checking and updating parameter
                // value based on algorithm
                if (d2 > 0)
                {
                    y--;
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + (rx * rx) - dy;
                }
                else
                {
                    y--;
                    x++;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + dx - dy + (rx * rx);
                }
            }

            int length = Xpoints.Count;
            double[,] points = new double[length, 2];
            for (int i = 0; i < length; i++)
            {
                points[i, 0] = Xpoints[i];
                points[i, 1] = Ypoints[i];

            }
            return points;

        }

    }

}


