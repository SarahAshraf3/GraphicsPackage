using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsPackageGUI
{
    public partial class GraphicsPackage_Form : Form
    {
        public GraphicsPackage_Form(){InitializeComponent();}

        private void Form1_Load(object sender, EventArgs e){}


        //Functions
        private void drawDDA(int xr, int yr, int x_T, int y_T, int Scale, double Angle)
        {
            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();

            if (int.TryParse(x0Box.Text, out int x0) &&
                int.TryParse(y0Box.Text, out int y0) &&
                int.TryParse(xEndBox.Text, out int xEnd) &&
                int.TryParse(yEndBox.Text, out int yEnd))
            {

                x0 = x_T + x0 * xr;
                y0 = y_T + y0 * yr;
                xEnd = x_T + (((xEnd - x0) * Scale) + x0) * xr;
                yEnd = y_T + (((yEnd - y0) * Scale) + y0) * yr;

                if (Angle != 0)
                {
                    double pointx = (((xEnd - x0) * Math.Cos(Angle)) - ((yEnd - y0) * Math.Sin(Angle))) + x0;
                    double pointy = (((yEnd - y0) * Math.Cos(Angle)) + ((xEnd - x0) * Math.Sin(Angle))) + y0;
                    xEnd = (int)Math.Round(pointx);
                    yEnd = (int)Math.Round(pointy);

                }

                //points BEFORE normalization
                DDA_Algorithm dd = new DDA_Algorithm { x0 = x0, y0 = y0, xEnd = xEnd, yEnd = yEnd };
                double[,] pointsdd = dd.lineDDA();

                // Calculate the center of the panel
                float centerX = panel1.Width / 2f;
                float centerY = panel1.Height / 2f;

                // Translate the coordinates to the center of the panel
                x0 = (int)(centerX + (x0));
                y0 = (int)(centerY - (y0)); // Invert the Y-axis
                int x1 = (int)(centerX + (xEnd));
                int y1 = (int)(centerY - (yEnd)); // Invert the Y-axis

                //points AFTER normalization
                dd.x0 = x0; dd.y0 = y0; dd.xEnd = x1; dd.yEnd = y1;
                double[,] pointsdd_center = dd.lineDDA();

                ResultingPoints.Items.Add("DDA Points");
                for (int k = 0; k < pointsdd_center.GetLength(0); k++)
                {
                    g.FillRectangle(aBrush, (float)pointsdd_center[k, 0], (float)pointsdd_center[k, 1], 1, 1);
                    ResultingPoints.Items.Add($"x = {pointsdd[k, 0]} , y = {pointsdd[k, 1]}");
                }
                ResultingPoints.EndUpdate();
            }

        }

        private void drawBresenham(int xr, int yr, int x_T, int y_T, int Scale, double Angle)
        {
            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();
            if (int.TryParse(x0Box.Text, out int x0) &&
                int.TryParse(y0Box.Text, out int y0) &&
                int.TryParse(xEndBox.Text, out int xEnd) &&
                int.TryParse(yEndBox.Text, out int yEnd))
            {
                x0 = x_T + x0 * xr;
                y0 = y_T + y0 * yr;
                xEnd = x_T + (((xEnd - x0) * Scale) + x0) * xr;
                yEnd = y_T + (((yEnd - y0) * Scale) + y0) * yr;

                if (Angle != 0)
                {
                    double pointx = (((xEnd - x0) * Math.Cos(Angle)) - ((yEnd - y0) * Math.Sin(Angle))) + x0;
                    double pointy = (((yEnd - y0) * Math.Cos(Angle)) + ((xEnd - x0) * Math.Sin(Angle))) + y0;
                    xEnd = (int)Math.Round(pointx);
                    yEnd = (int)Math.Round(pointy);

                }
                //points BEFORE normalization
                Bresenham_Algorithm bres = new Bresenham_Algorithm { x0 = x0, y0 = y0, xEnd = xEnd, yEnd = yEnd };
                int[,] pointsbres = bres.lineBres();

                // Calculate the center of the panel
                float centerX = panel1.Width / 2f;
                float centerY = panel1.Height / 2f;

                // Translate the coordinates to the center of the panel
                x0 = (int)(centerX + x0);
                y0 = (int)(centerY - y0); // Invert the Y-axis
                int x1 = (int)(centerX + xEnd);
                int y1 = (int)(centerY - yEnd); // Invert the Y-axis

                //points AFTER normalization
                bres.x0 = x0; bres.y0 = y0; bres.xEnd = x1; bres.yEnd = y1;
                int[,] pointsbresCenter = bres.lineBres();

                ResultingPoints.Items.Add("Bresenham Points");
                for (int k = 0; k < pointsbresCenter.GetLength(0); k++)
                {
                    g.FillRectangle(aBrush, (float)pointsbresCenter[k, 0], (float)pointsbresCenter[k, 1], 1, 1);
                    ResultingPoints.Items.Add($"x = {pointsbres[k, 0]} , y = {pointsbres[k, 1]}");

                }
                ResultingPoints.EndUpdate();
            }
        }

        private void drawCircal(int xr, int yr, int x_T, int y_T, int Scale)
        {
            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();

            if (int.TryParse(x0Box.Text, out int x0) &&
                int.TryParse(y0Box.Text, out int y0) &&
                int.TryParse(xEndBox.Text, out int r))
            {
                x0 = x_T + x0 * xr;
                y0 = y_T + y0 * yr;

                Circal_Algorithm circal = new Circal_Algorithm { xCenter = x0, yCenter = y0, radius = r * Scale };
                int[,] points = circal.circleMidpoint();
                // Calculate the center of the panel
                float centerX = panel1.Width / 2f;
                float centerY = panel1.Height / 2f;

                // Translate the coordinates to the center of the panel
                int xc = (int)(centerX + x0); ;
                int yc = (int)(centerY - y0); // Invert the Y-axis

                ResultingPoints.Items.Add("Circal Points");
                for (int k = 0; k < points.GetLength(0); k++)
                {
                    int pointx = points[k, 0];
                    int pointy = points[k, 1];
                    //x,y
                    g.FillRectangle(aBrush, (float)(pointx + xc), (float)(pointy + yc), 1, 1);
                    //y,x
                    g.FillRectangle(aBrush, (float)(pointy + xc), (float)(pointx + yc), 1, 1);
                    //y,-x
                    g.FillRectangle(aBrush, (float)(pointy + xc), (float)((-1 * pointx) + yc), 1, 1);
                    //x,-y
                    g.FillRectangle(aBrush, (float)(pointx + xc), (float)((-1 * pointy) + yc), 1, 1);
                    //-x,-y
                    g.FillRectangle(aBrush, (float)((-1 * pointx) + xc), (float)((-1 * pointy) + yc), 1, 1);
                    //-y,-x
                    g.FillRectangle(aBrush, (float)((-1 * pointy) + xc), (float)(-1 * pointx + yc), 1, 1);
                    //-y,x
                    g.FillRectangle(aBrush, (float)((-1 * pointy) + xc), (float)(pointx + yc), 1, 1);
                    //-x,y
                    g.FillRectangle(aBrush, (float)(-1 * pointx + xc), (float)(pointy + yc), 1, 1);



                    ResultingPoints.Items.Add($"(x,y) x = {pointx + x0} , y = {points[k, 1] + y0}");
                    ResultingPoints.Items.Add($"(y,x) x = {pointy + x0} , y = {pointx + y0}");
                    ResultingPoints.Items.Add($"(y,-x) x = {pointy + x0} , y = {(-1 * pointx) + y0}");
                    ResultingPoints.Items.Add($"(x,-y) x = {pointx + x0} , y = {(-1 * pointy) + y0}");
                    ResultingPoints.Items.Add($"(-x,-y) x = {(-1 * pointx) + x0} , y = {(-1 * pointy) + y0}");
                    ResultingPoints.Items.Add($"(-y,-x) x = {(-1 * pointy) + x0} , y = {(-1 * pointx) + y0}");
                    ResultingPoints.Items.Add($"(-y,x) x = {(-1 * pointy) + x0} , y = {pointx + y0}");
                    ResultingPoints.Items.Add($"(-x,y) x = {(-1 * pointx) + x0} , y = {pointy + y0}");

                }
                ResultingPoints.EndUpdate();

            }
        }

        private void drawEllipse(int xr, int yr, int x_T, int y_T, int Scale)
        {
            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();

            if (int.TryParse(x0Box.Text, out int x0) &&
                int.TryParse(y0Box.Text, out int y0) &&
                int.TryParse(xEndBox.Text, out int rx) &&
                int.TryParse(yEndBox.Text, out int ry))
            {
                x0 = x_T + x0 * xr;
                y0 = y_T + y0 * yr;



                Ellipse_Algorithm ellipse = new Ellipse_Algorithm { xc = x0, yc = y0, rx = rx * Scale, ry = ry * Scale };

                double[,] points = ellipse.ellipseMidpoint();
                // Calculate the center of the panel
                float centerX = panel1.Width / 2f;
                float centerY = panel1.Height / 2f;

                // Translate the coordinates to the center of the panel
                int xc = (int)(centerX + x0); ;
                int yc = (int)(centerY - y0); // Invert the Y-axis

                ResultingPoints.Items.Add("Ellipse Points");
                for (int k = 0; k < points.GetLength(0); k++)
                {
                    double pointx = points[k, 0];
                    double pointy = points[k, 1];
                    //x,y
                    g.FillRectangle(aBrush, (float)(pointx + xc), (float)(pointy + yc), 1, 1);
                    //x,-y
                    g.FillRectangle(aBrush, (float)(pointx + xc), (float)((-1 * pointy) + yc), 1, 1);
                    //-x,-y
                    g.FillRectangle(aBrush, (float)((-1 * pointx) + xc), (float)((-1 * pointy) + yc), 1, 1);
                    //-x,y
                    g.FillRectangle(aBrush, (float)(-1 * pointx + xc), (float)(pointy + yc), 1, 1);



                    ResultingPoints.Items.Add($"(x,y) x = {pointx + x0} , y = {points[k, 1] + y0}");
                    ResultingPoints.Items.Add($"(x,-y) x = {pointx + x0} , y = {(-1 * pointy) + y0}");
                    ResultingPoints.Items.Add($"(-x,-y) x = {(-1 * pointx) + x0} , y = {(-1 * pointy) + y0}");
                    ResultingPoints.Items.Add($"(-x,y) x = {(-1 * pointx) + x0} , y = {pointy + y0}");

                }
                ResultingPoints.EndUpdate();

            }

        }

        private void EllipseRotation(double angle)
        {
            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();

            if (int.TryParse(x0Box.Text, out int x0) &&
                int.TryParse(y0Box.Text, out int y0) &&
                int.TryParse(xEndBox.Text, out int rx) &&
                int.TryParse(yEndBox.Text, out int ry))
            {

                List<Point> points = new List<Point>();
                List<Point> pointswithoutCenter= new List<Point>();
                // Calculate the center of the panel
                float centerX = panel1.Width / 2f;
                float centerY = panel1.Height / 2f;

                // Translate the coordinates to the center of the panel
                int xc = (int)(centerX + x0); ;
                int yc = (int)(centerY - y0); // Invert the Y-axis
                double cos = Math.Cos(angle);
                double sin = Math.Sin(angle);
                for (double i = 0; i < 2 * Math.PI; i += 0.01)
                {
                    double x = rx * Math.Cos(i);
                    double y = ry * Math.Sin(i);

                    double xRotation = x * cos - y * sin;
                    double yRotation = y * cos + x * sin;
                    pointswithoutCenter.Add(new Point((int)Math.Round(xRotation)+x0, (int)Math.Round(yRotation)+y0));

                    int PointX = (int)Math.Round(xRotation + xc);
                    int PointY = (int)Math.Round(yRotation + yc);

                    points.Add(new Point(PointX, PointY));



                }
                Point[] newpointswithoutCenter = pointswithoutCenter.ToArray();
                Point[] newPoints = points.ToArray();
                ResultingPoints.Items.Add("Ellipse Rotation Points");
                for (int i = 0; i < newPoints.Length; i++)
                {

                    //x,y
                    g.FillRectangle(aBrush, (float)(newPoints[i].X), (float)(newPoints[i].Y), 1, 1);
                    //x,-y
                    g.FillRectangle(aBrush, (float)(newPoints[i].X), (float)((-1 * newPoints[i].Y)), 1, 1);
                    //-x,-y
                    g.FillRectangle(aBrush, (float)((-1 * newPoints[i].X)), (float)((-1 * newPoints[i].Y)), 1, 1);
                    //-x,y
                    g.FillRectangle(aBrush, (float)(-1 * newPoints[i].X), (float)(newPoints[i].Y), 1, 1);

                    ResultingPoints.Items.Add($"(x,y) x = {newpointswithoutCenter[i].X} , y = {newpointswithoutCenter[i].Y}");
                    ResultingPoints.Items.Add($"(x,-y) x = {newpointswithoutCenter[i].X} , y = {-1 * newpointswithoutCenter[i].Y}");
                    ResultingPoints.Items.Add($"(-x,-y) x = {-1 * newpointswithoutCenter[i].X} , y = {-1 * newpointswithoutCenter[i].Y}");
                    ResultingPoints.Items.Add($"(-x,y) x = {-1 * newpointswithoutCenter[i].X} , y = {newpointswithoutCenter[i].Y}");

                }
                ResultingPoints.EndUpdate();

            }


        }

        private void Square(float xS, float yS)
        {
            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();


            float centerX = panel1.Width / 2f;
            float centerY = panel1.Height / 2f;

            int originx = (int)Math.Round(centerX);
            int originy = (int)Math.Round(centerY);
            int size = 50;


            DDA_Algorithm bottomLine = new DDA_Algorithm { x0 = 0, y0 = 0, xEnd = size, yEnd = 0 };
            double[,] bottomLinePoints = bottomLine.lineDDA();

            DDA_Algorithm leftLine = new DDA_Algorithm { x0 = 0, y0 = 0, xEnd = 0, yEnd = size };
            double[,] leftLinePoints = leftLine.lineDDA();



            DDA_Algorithm rightLine = new DDA_Algorithm { x0 = size, y0 = 0, xEnd = size, yEnd = size };
            double[,] rightLinePoints= rightLine.lineDDA();

            DDA_Algorithm topLine = new DDA_Algorithm { x0 = 0, y0 = size, xEnd = size, yEnd = size};
            double[,] topLinePoints= topLine.lineDDA();

            if (xS == 0 && yS==0)
            {
                for (int k = 0; k < bottomLinePoints.GetLength(0); k++)
                {
                    g.FillRectangle(aBrush, originx + ((float)bottomLinePoints[k, 0]), originy - (float)bottomLinePoints[k, 1], 1, 1);
                    g.FillRectangle(aBrush, originx + (float)leftLinePoints[k, 0], originy - (float)leftLinePoints[k, 1], 1, 1);
                    g.FillRectangle(aBrush, originx + (float)topLinePoints[k, 0], originy - (float)topLinePoints[k, 1], 1, 1);
                    g.FillRectangle(aBrush, originx + (float)rightLinePoints[k, 0], originy - (float)rightLinePoints[k, 1], 1, 1);

                    //ResultingPoints.Items.Add($"Bottom Line x = {bottomLinePoints[k, 0]} , y = {bottomLinePoints[k, 1]}");
                    //ResultingPoints.Items.Add($"Left Line x = {leftLinePoints[k, 0]} , y = {leftLinePoints[k, 1]}");
                    //ResultingPoints.Items.Add($"Top Line x = {topLinePoints[k, 0]} , y = {topLinePoints[k, 1]}");
                    //ResultingPoints.Items.Add($"Right Line x = {rightLinePoints[k, 0]} , y = {rightLinePoints[k, 1]}");
                }
                //ResultingPoints.EndUpdate();

            }

            if (xS != 0)
            {
                ResultingPoints.Items.Add("Sheering the Square in X axis");
                for (int k = 0; k < bottomLinePoints.GetLength(0); k++)
                {
                    g.FillRectangle(aBrush, originx + (float)bottomLinePoints[k, 0], originy - (float)bottomLinePoints[k, 1], 1, 1);
                    g.FillRectangle(aBrush, originx + ((float)leftLinePoints[k, 0]+(xS* (float)leftLinePoints[k, 1])), originy - (float)leftLinePoints[k, 1], 1, 1);
                    g.FillRectangle(aBrush, originx + ((float)topLinePoints[k, 0] + (xS * (float)topLinePoints[k, 1])), originy - (float)topLinePoints[k, 1], 1, 1);
                    g.FillRectangle(aBrush, originx + ((float)rightLinePoints[k, 0] + (xS * (float)rightLinePoints[k, 1])), originy - (float)rightLinePoints[k, 1], 1, 1);

                    ResultingPoints.Items.Add($"Bottom Line x = {bottomLinePoints[k, 0]} , y = {bottomLinePoints[k, 1]}");
                    ResultingPoints.Items.Add($"Left Line x = {(float)leftLinePoints[k, 0] + (xS * (float)leftLinePoints[k, 1])} , y = {leftLinePoints[k, 1]}");
                    ResultingPoints.Items.Add($"Top Line x = {(float)topLinePoints[k, 0] + (xS * (float)topLinePoints[k, 1])} , y = {topLinePoints[k, 1]}");
                    ResultingPoints.Items.Add($"Right Line x = {(float)rightLinePoints[k, 0] + (xS * (float)rightLinePoints[k, 1])} , y = {rightLinePoints[k, 1]}");
                }
                ResultingPoints.EndUpdate();
            }
            else if (yS != 0)
            {
                ResultingPoints.Items.Add("Sheering the Square in Y axis");
                for (int k = 0; k < bottomLinePoints.GetLength(0); k++)
                {
                    g.FillRectangle(aBrush, originx + ((float)bottomLinePoints[k, 0]), originy - ((float)bottomLinePoints[k, 1] + (yS * (float)bottomLinePoints[k, 0])), 1, 1);
                    g.FillRectangle(aBrush, originx + (float)leftLinePoints[k, 0], originy - ((float)leftLinePoints[k, 1]), 1, 1);
                    g.FillRectangle(aBrush, originx + (float)topLinePoints[k, 0], originy - ((float)topLinePoints[k, 1] + (yS * (float)topLinePoints[k, 0])), 1, 1);
                    g.FillRectangle(aBrush, originx + (float)rightLinePoints[k, 0], originy - ((float)rightLinePoints[k, 1] + (yS * (float)rightLinePoints[k, 0])), 1, 1);


                    ResultingPoints.Items.Add($"Bottom Line x = {bottomLinePoints[k, 0]} , y = {(float)bottomLinePoints[k, 1] + (yS * (float)bottomLinePoints[k, 0])}");
                    ResultingPoints.Items.Add($"Left Line x = {leftLinePoints[k, 0]} , y = {leftLinePoints[k, 1]}");
                    ResultingPoints.Items.Add($"Top Line x = {topLinePoints[k, 0]} , y = {(float)topLinePoints[k, 1] + (yS * (float)topLinePoints[k, 0])}");
                    ResultingPoints.Items.Add($"Right Line x = {rightLinePoints[k, 0]} , y = {(float)rightLinePoints[k, 1] + (yS * (float)rightLinePoints[k, 0])}");
                }
                ResultingPoints.EndUpdate();
            }







        }





        //Buttons
        private void ClearBox_Click(object sender, EventArgs e)
        {
            if (ResultingPoints.Items.Count != 0)
            {
                ResultingPoints.Items.Clear();

            }
            panel1.Refresh();
        }

        private void DDA_Line_Draw_Click(object sender, EventArgs e)
        {
            drawDDA(1, 1, 0, 0, 1, 0);
        }

        private void Bresenham_Line_Draw_Click(object sender, EventArgs e)
        {
            drawBresenham(1, 1, 0, 0, 1, 0);
        }

        private void Circal_Draw_Click(object sender, EventArgs e)
        {
            drawCircal(1, 1, 0, 0, 1);
        }

        private void Ellipse_Draw_Click(object sender, EventArgs e)
        {
            drawEllipse(1, 1, 0, 0, 1);
        }

        private void Draw_Square_Click(object sender, EventArgs e)
        {
            Square(0, 0);
        }

        private void xReflection_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Choice.Text, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        drawDDA(-1, 1, 0, 0, 1, 0); break;
                    case 2:
                        drawBresenham(-1, 1, 0, 0, 1, 0); break;
                    case 3:
                        drawCircal(-1, 1, 0, 0, 1); break;
                    case 4:
                        drawEllipse(-1, 1, 0, 0, 1); break;

                }
            }
        }

        private void yReflection_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Choice.Text, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        drawDDA(1, -1, 0, 0, 1, 0);
                        break;
                    case 2:
                        drawBresenham(1, -1, 0, 0, 1, 0); break;
                    case 3:
                        drawCircal(1, -1, 0, 0, 1); break;
                    case 4:
                        drawEllipse(1, -1, 0, 0, 1); break;
                }
            }

        }

        private void XY_Reflection_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Choice.Text, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        drawDDA(-1, -1, 0, 0, 1, 0);
                        break;
                    case 2:
                        drawBresenham(-1, -1, 0, 0, 1, 0); break;
                    case 3:
                        drawCircal(-1, -1, 0, 0, 1); break;
                    case 4:
                        drawEllipse(-1, -1, 0, 0, 1); break;
                }
            }

        }

        private void Translation_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Choice.Text, out int choice) &&
                int.TryParse(xT.Text, out int x_T) &&
                int.TryParse(yT.Text, out int y_T))
            {
                switch (choice)
                {
                    case 1:
                        drawDDA(1, 1, x_T, y_T, 1, 0);
                        break;
                    case 2:
                        drawBresenham(1, 1, x_T, y_T, 1, 0); break;
                    case 3:
                        drawCircal(1, 1, x_T, y_T, 1); break;
                    case 4:
                        drawEllipse(1, 1, x_T, y_T, 1); break;
                }

            }
        }

        private void Scale_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Choice.Text, out int choice) &&
                int.TryParse(ScaleValue.Text, out int Scale))
            {
                switch (choice)
                {
                    case 1:
                        drawDDA(1, 1, 0, 0, Scale, 0);
                        break;
                    case 2:
                        drawBresenham(1, 1, 0, 0, Scale, 0); break;
                    case 3:
                        drawCircal(1, 1, 0, 0, Scale); break;
                    case 4:
                        drawEllipse(1, 1, 0, 0, Scale); break;
                }

            }

        }

        private void Rotation_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Choice.Text, out int choice) &&
                double.TryParse(Angle.Text, out double RadAngle))
            {
                switch (choice)
                {
                    case 1:
                        drawDDA(1, 1, 0, 0, 1, RadAngle); break;
                    case 2:
                        drawBresenham(1, 1, 0, 0, 1, RadAngle); break;
                    case 3:
                        drawCircal(1, 1, 0, 0, 1); break;
                    case 4:
                        EllipseRotation(RadAngle); break;
                }

            }

        }

        private void Sheer_X_Click(object sender, EventArgs e)
        {
            if (float.TryParse(xValue.Text, out float value))
            {
                Square(value, 0);
            }
        }

        private void Sheer_Y_Click(object sender, EventArgs e)
        {
            if (float.TryParse(yValue.Text, out float value))
            {
                Square(0, value);
            }
        }


    }
}
