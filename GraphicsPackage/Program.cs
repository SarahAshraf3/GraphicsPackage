// See https://aka.ms/new-console-template for more information

int x0 = 32, y0 = 8, xEnd = 48, yEnd = 3; //read from user 

//DDA Algorithm
DDA_Algorithm dd = new DDA_Algorithm { x0 = x0, y0 = y0, xEnd = xEnd, yEnd = yEnd };
double[,] pointsdd = dd.lineDDA();

//Bresenham Algorithm
Bresenham_Algorithm bres = new Bresenham_Algorithm { x0 = x0, y0 = y0, xEnd = xEnd, yEnd = yEnd };
int[,] pointsbres = bres.lineBres();

//Circal Algorithm
int xCenter = 0, yCenter = 0, radius = 10; //read from user 
Circal_Algorithm circal = new Circal_Algorithm { xCenter = xCenter, yCenter = yCenter, radius = radius };
int[,] pointscircal = circal.circleMidpoint();

//Ellipse Algorithm
double rx = 8;
double ry = 6;
double xc = 0;
double yc = 0;
Ellipse_Algorithm e = new Ellipse_Algorithm { rx = rx, ry = ry, xc = xc, yc = yc };
double[,] pointsellipse = e.ellipseMidpoint();




for (int k = 0; k < pointsbres.GetLength(0); k++)
{
    Console.WriteLine($"x={pointsbres[k, 0]} , y={pointsbres[k, 1]}");

}

