using System;

namespace GraphicsPackageGUI
{
    public class DDA_Algorithm
    {
        public int x0 { get; set; }
        public int y0 { get; set; }
        public int xEnd { get; set; }
        public int yEnd { get; set; }


        public double[,] lineDDA()
        {
            int dx = xEnd - x0, dy = yEnd - y0, steps, k;
            double xIncrement, yIncrement, x = x0, y = y0;
            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;
            double[,] points = new double[steps, 2];
            points[0, 0] = Math.Round(x);
            points[0, 1] = Math.Round(y);


            for (k = 1; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                points[k, 0] = Math.Round(x);
                points[k, 1] = Math.Round(y);

            }

            return points;

        }

    }
}


