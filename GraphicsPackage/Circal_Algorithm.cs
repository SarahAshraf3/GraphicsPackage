// See https://aka.ms/new-console-template for more information

public class Circal_Algorithm
{
    public int xCenter { get; set; }
    public int yCenter { get; set; }
    public int radius { get; set; }



    public int[,] circleMidpoint()
    {

        int x = 0;
        int y = radius;
        int p = 1 - radius;

        List<int> Xpoints = new List<int>();
        List<int> Ypoints = new List<int>();
        Xpoints.Add(x);
        Ypoints.Add(y);
        while (x < y)
        {
            x++;
            if (p < 0)
            {
                p += 2 * x + 1;
            }
            else
            {
                y--;
                p += 2 * (x - y) + 1;
            }
            Xpoints.Add(x);
            Ypoints.Add(y);
        }

        int length = Xpoints.Count;
        int[,] points = new int[length, 2];
        for (int i = 0; i < length; i++)
        {
            points[i, 0] = Xpoints[i];
            points[i, 1] = Ypoints[i];

        }

        return points;


    }


}

