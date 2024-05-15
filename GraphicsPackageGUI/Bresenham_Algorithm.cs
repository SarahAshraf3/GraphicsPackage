using System;

namespace GraphicsPackageGUI
{
    // See https://aka.ms/new-console-template for more information

    public class Bresenham_Algorithm
    {
        public int x0 { get; set; }
        public int y0 { get; set; }
        public int xEnd { get; set; }
        public int yEnd { get; set; }


        public int[,] lineBres()
        {


            int x, y;
            x = x0;
            y = y0;
            float m = (float)(yEnd - y0) / (float)(xEnd - x0);
            if (m > 1 || m < -1)
            {
                x = y0;
                y = x0;

                int tmp = xEnd;
                xEnd = yEnd;
                yEnd = tmp;
            }


            int dx = Math.Abs(xEnd - x), dy = Math.Abs(yEnd - y);
  
            int p = (2 * dy) - dx;
            int twoDy = 2 * dy, twoDyMinusDx = 2 * (dy - dx);



            int steps = Math.Abs(xEnd - x) + 1;

            int[,] points = new int[steps, 2];


            if (m > 1 || m < -1)
            {
                points[0, 0] = y;
                points[0, 1] = x;

            }
            else
            {
                points[0, 0] = x;
                points[0, 1] = y;
            }

            int max = 0, min = 0;
            if (x > xEnd)
            {
                max = x;
                min = xEnd;

            }
            else
            {
                max = xEnd;
                min = x;
            }


            int i = 1;
            while (min < max)
            {

                if (x > xEnd)
                {
                    x--;
                }
                else
                {
                    x++;
                }

                if (p < 0)
                    p += twoDy;
                else
                {

                    if (y > yEnd)
                    {
                        y--;
                    }
                    else
                    {
                        y++;
                    }
                    p += twoDyMinusDx;


                }

                if (m > 1 || m < -1)
                {
                    points[i, 0] = y;
                    points[i, 1] = x;

                }
                else
                {
                    points[i, 0] = x;
                    points[i, 1] = y;
                }
                i++;
                min++;
            }



            return points;

        }

    }


}


