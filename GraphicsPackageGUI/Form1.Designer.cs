using System;

namespace GraphicsPackageGUI
{
    partial class GraphicsPackage_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.x0 = new System.Windows.Forms.Label();
            this.y0 = new System.Windows.Forms.Label();
            this.yEnd = new System.Windows.Forms.Label();
            this.xEnd = new System.Windows.Forms.Label();
            this.x0Box = new System.Windows.Forms.TextBox();
            this.yEndBox = new System.Windows.Forms.TextBox();
            this.xEndBox = new System.Windows.Forms.TextBox();
            this.y0Box = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ResultingPoints = new System.Windows.Forms.ListBox();
            this.ClearAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Circal_Draw = new System.Windows.Forms.Button();
            this.Ellipse_Draw = new System.Windows.Forms.Button();
            this.Bresenham_Line_Draw = new System.Windows.Forms.Button();
            this.DDA_Line_Draw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.yReflection = new System.Windows.Forms.Button();
            this.xReflection = new System.Windows.Forms.Button();
            this.Choice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.yT = new System.Windows.Forms.TextBox();
            this.xT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Translation = new System.Windows.Forms.Button();
            this.ScaleValue = new System.Windows.Forms.TextBox();
            this.Scale = new System.Windows.Forms.Button();
            this.Rotation = new System.Windows.Forms.Button();
            this.Angle = new System.Windows.Forms.TextBox();
            this.Draw_Square = new System.Windows.Forms.Button();
            this.Sheer_X = new System.Windows.Forms.Button();
            this.xValue = new System.Windows.Forms.TextBox();
            this.Sheer_Y = new System.Windows.Forms.Button();
            this.yValue = new System.Windows.Forms.TextBox();
            this.XY_Reflection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // x0
            // 
            this.x0.AutoSize = true;
            this.x0.Location = new System.Drawing.Point(84, 49);
            this.x0.Name = "x0";
            this.x0.Size = new System.Drawing.Size(20, 16);
            this.x0.TabIndex = 1;
            this.x0.Text = "x0";
            // 
            // y0
            // 
            this.y0.AutoSize = true;
            this.y0.Location = new System.Drawing.Point(84, 78);
            this.y0.Name = "y0";
            this.y0.Size = new System.Drawing.Size(21, 16);
            this.y0.TabIndex = 2;
            this.y0.Text = "y0";
            // 
            // yEnd
            // 
            this.yEnd.AutoSize = true;
            this.yEnd.Location = new System.Drawing.Point(199, 78);
            this.yEnd.Name = "yEnd";
            this.yEnd.Size = new System.Drawing.Size(53, 16);
            this.yEnd.TabIndex = 5;
            this.yEnd.Text = "yEnd/ry";
            // 
            // xEnd
            // 
            this.xEnd.AutoSize = true;
            this.xEnd.Location = new System.Drawing.Point(186, 49);
            this.xEnd.Name = "xEnd";
            this.xEnd.Size = new System.Drawing.Size(65, 16);
            this.xEnd.TabIndex = 6;
            this.xEnd.Text = "xEnd/R/rx";
            // 
            // x0Box
            // 
            this.x0Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.x0Box.Location = new System.Drawing.Point(110, 46);
            this.x0Box.Name = "x0Box";
            this.x0Box.Size = new System.Drawing.Size(59, 22);
            this.x0Box.TabIndex = 7;
            // 
            // yEndBox
            // 
            this.yEndBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.yEndBox.Location = new System.Drawing.Point(257, 78);
            this.yEndBox.Name = "yEndBox";
            this.yEndBox.Size = new System.Drawing.Size(59, 22);
            this.yEndBox.TabIndex = 8;
            // 
            // xEndBox
            // 
            this.xEndBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xEndBox.Location = new System.Drawing.Point(257, 49);
            this.xEndBox.Name = "xEndBox";
            this.xEndBox.Size = new System.Drawing.Size(59, 22);
            this.xEndBox.TabIndex = 9;
            // 
            // y0Box
            // 
            this.y0Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.y0Box.Location = new System.Drawing.Point(111, 78);
            this.y0Box.Name = "y0Box";
            this.y0Box.Size = new System.Drawing.Size(59, 22);
            this.y0Box.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(434, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 308);
            this.panel1.TabIndex = 11;
            // 
            // ResultingPoints
            // 
            this.ResultingPoints.FormattingEnabled = true;
            this.ResultingPoints.ItemHeight = 16;
            this.ResultingPoints.Location = new System.Drawing.Point(627, 326);
            this.ResultingPoints.Name = "ResultingPoints";
            this.ResultingPoints.Size = new System.Drawing.Size(339, 196);
            this.ResultingPoints.TabIndex = 12;
            // 
            // ClearAll
            // 
            this.ClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClearAll.Location = new System.Drawing.Point(156, 196);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(111, 36);
            this.ClearAll.TabIndex = 14;
            this.ClearAll.Text = "Clear";
            this.ClearAll.UseVisualStyleBackColor = false;
            this.ClearAll.Click += new System.EventHandler(this.ClearBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(69, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter Values";
            // 
            // Circal_Draw
            // 
            this.Circal_Draw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Circal_Draw.Location = new System.Drawing.Point(91, 154);
            this.Circal_Draw.Name = "Circal_Draw";
            this.Circal_Draw.Size = new System.Drawing.Size(111, 36);
            this.Circal_Draw.TabIndex = 25;
            this.Circal_Draw.Text = "Circal";
            this.Circal_Draw.UseVisualStyleBackColor = false;
            this.Circal_Draw.Click += new System.EventHandler(this.Circal_Draw_Click);
            // 
            // Ellipse_Draw
            // 
            this.Ellipse_Draw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Ellipse_Draw.Location = new System.Drawing.Point(228, 154);
            this.Ellipse_Draw.Name = "Ellipse_Draw";
            this.Ellipse_Draw.Size = new System.Drawing.Size(111, 36);
            this.Ellipse_Draw.TabIndex = 26;
            this.Ellipse_Draw.Text = "Ellipse";
            this.Ellipse_Draw.UseVisualStyleBackColor = false;
            this.Ellipse_Draw.Click += new System.EventHandler(this.Ellipse_Draw_Click);
            // 
            // Bresenham_Line_Draw
            // 
            this.Bresenham_Line_Draw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bresenham_Line_Draw.Location = new System.Drawing.Point(228, 112);
            this.Bresenham_Line_Draw.Name = "Bresenham_Line_Draw";
            this.Bresenham_Line_Draw.Size = new System.Drawing.Size(111, 36);
            this.Bresenham_Line_Draw.TabIndex = 27;
            this.Bresenham_Line_Draw.Text = " Bresenham";
            this.Bresenham_Line_Draw.UseVisualStyleBackColor = false;
            this.Bresenham_Line_Draw.Click += new System.EventHandler(this.Bresenham_Line_Draw_Click);
            // 
            // DDA_Line_Draw
            // 
            this.DDA_Line_Draw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DDA_Line_Draw.Location = new System.Drawing.Point(91, 112);
            this.DDA_Line_Draw.Name = "DDA_Line_Draw";
            this.DDA_Line_Draw.Size = new System.Drawing.Size(111, 36);
            this.DDA_Line_Draw.TabIndex = 28;
            this.DDA_Line_Draw.Text = "DDA ";
            this.DDA_Line_Draw.UseVisualStyleBackColor = false;
            this.DDA_Line_Draw.Click += new System.EventHandler(this.DDA_Line_Draw_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(69, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "2D Transformation";
            // 
            // yReflection
            // 
            this.yReflection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.yReflection.Location = new System.Drawing.Point(257, 368);
            this.yReflection.Name = "yReflection";
            this.yReflection.Size = new System.Drawing.Size(111, 36);
            this.yReflection.TabIndex = 30;
            this.yReflection.Text = "Y Reflection";
            this.yReflection.UseVisualStyleBackColor = false;
            this.yReflection.Click += new System.EventHandler(this.yReflection_Click);
            // 
            // xReflection
            // 
            this.xReflection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xReflection.Location = new System.Drawing.Point(257, 326);
            this.xReflection.Name = "xReflection";
            this.xReflection.Size = new System.Drawing.Size(111, 36);
            this.xReflection.TabIndex = 31;
            this.xReflection.Text = "X Reflection";
            this.xReflection.UseVisualStyleBackColor = false;
            this.xReflection.Click += new System.EventHandler(this.xReflection_Click);
            // 
            // Choice
            // 
            this.Choice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Choice.Location = new System.Drawing.Point(283, 279);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(59, 22);
            this.Choice.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Choose shape";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "1";
            // 
            // yT
            // 
            this.yT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.yT.Location = new System.Drawing.Point(143, 309);
            this.yT.Name = "yT";
            this.yT.Size = new System.Drawing.Size(59, 22);
            this.yT.TabIndex = 41;
            // 
            // xT
            // 
            this.xT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xT.Location = new System.Drawing.Point(61, 309);
            this.xT.Name = "xT";
            this.xT.Size = new System.Drawing.Size(59, 22);
            this.xT.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "x";
            // 
            // Translation
            // 
            this.Translation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Translation.Location = new System.Drawing.Point(75, 346);
            this.Translation.Name = "Translation";
            this.Translation.Size = new System.Drawing.Size(111, 36);
            this.Translation.TabIndex = 42;
            this.Translation.Text = "Translation";
            this.Translation.UseVisualStyleBackColor = false;
            this.Translation.Click += new System.EventHandler(this.Translation_Click);
            // 
            // ScaleValue
            // 
            this.ScaleValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ScaleValue.Location = new System.Drawing.Point(47, 404);
            this.ScaleValue.Name = "ScaleValue";
            this.ScaleValue.Size = new System.Drawing.Size(59, 22);
            this.ScaleValue.TabIndex = 43;
            // 
            // Scale
            // 
            this.Scale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Scale.Location = new System.Drawing.Point(126, 397);
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(111, 36);
            this.Scale.TabIndex = 44;
            this.Scale.Text = "Scale";
            this.Scale.UseVisualStyleBackColor = false;
            this.Scale.Click += new System.EventHandler(this.Scale_Click);
            // 
            // Rotation
            // 
            this.Rotation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rotation.Location = new System.Drawing.Point(126, 449);
            this.Rotation.Name = "Rotation";
            this.Rotation.Size = new System.Drawing.Size(111, 36);
            this.Rotation.TabIndex = 46;
            this.Rotation.Text = "Rotation";
            this.Rotation.UseVisualStyleBackColor = false;
            this.Rotation.Click += new System.EventHandler(this.Rotation_Click);
            // 
            // Angle
            // 
            this.Angle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Angle.Location = new System.Drawing.Point(47, 456);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(59, 22);
            this.Angle.TabIndex = 45;
            // 
            // Draw_Square
            // 
            this.Draw_Square.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Draw_Square.Location = new System.Drawing.Point(409, 410);
            this.Draw_Square.Name = "Draw_Square";
            this.Draw_Square.Size = new System.Drawing.Size(111, 36);
            this.Draw_Square.TabIndex = 47;
            this.Draw_Square.Text = "Draw Square";
            this.Draw_Square.UseVisualStyleBackColor = false;
            this.Draw_Square.Click += new System.EventHandler(this.Draw_Square_Click);
            // 
            // Sheer_X
            // 
            this.Sheer_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sheer_X.Location = new System.Drawing.Point(446, 452);
            this.Sheer_X.Name = "Sheer_X";
            this.Sheer_X.Size = new System.Drawing.Size(111, 36);
            this.Sheer_X.TabIndex = 49;
            this.Sheer_X.Text = "x Sheer";
            this.Sheer_X.UseVisualStyleBackColor = false;
            this.Sheer_X.Click += new System.EventHandler(this.Sheer_X_Click);
            // 
            // xValue
            // 
            this.xValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xValue.Location = new System.Drawing.Point(367, 459);
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(59, 22);
            this.xValue.TabIndex = 48;
            // 
            // Sheer_Y
            // 
            this.Sheer_Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sheer_Y.Location = new System.Drawing.Point(446, 494);
            this.Sheer_Y.Name = "Sheer_Y";
            this.Sheer_Y.Size = new System.Drawing.Size(111, 36);
            this.Sheer_Y.TabIndex = 51;
            this.Sheer_Y.Text = "y Sheer";
            this.Sheer_Y.UseVisualStyleBackColor = false;
            this.Sheer_Y.Click += new System.EventHandler(this.Sheer_Y_Click);
            // 
            // yValue
            // 
            this.yValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.yValue.Location = new System.Drawing.Point(367, 501);
            this.yValue.Name = "yValue";
            this.yValue.Size = new System.Drawing.Size(59, 22);
            this.yValue.TabIndex = 50;
            // 
            // XY_Reflection
            // 
            this.XY_Reflection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.XY_Reflection.Location = new System.Drawing.Point(257, 410);
            this.XY_Reflection.Name = "XY_Reflection";
            this.XY_Reflection.Size = new System.Drawing.Size(111, 36);
            this.XY_Reflection.TabIndex = 52;
            this.XY_Reflection.Text = "XY Reflection";
            this.XY_Reflection.UseVisualStyleBackColor = false;
            this.XY_Reflection.Click += new System.EventHandler(this.XY_Reflection_Click);
            // 
            // GraphicsPackage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 545);
            this.Controls.Add(this.XY_Reflection);
            this.Controls.Add(this.Sheer_Y);
            this.Controls.Add(this.yValue);
            this.Controls.Add(this.Sheer_X);
            this.Controls.Add(this.xValue);
            this.Controls.Add(this.Draw_Square);
            this.Controls.Add(this.Rotation);
            this.Controls.Add(this.Angle);
            this.Controls.Add(this.Scale);
            this.Controls.Add(this.ScaleValue);
            this.Controls.Add(this.Translation);
            this.Controls.Add(this.yT);
            this.Controls.Add(this.xT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Choice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xReflection);
            this.Controls.Add(this.yReflection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DDA_Line_Draw);
            this.Controls.Add(this.Bresenham_Line_Draw);
            this.Controls.Add(this.Ellipse_Draw);
            this.Controls.Add(this.Circal_Draw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.ResultingPoints);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.y0Box);
            this.Controls.Add(this.xEndBox);
            this.Controls.Add(this.yEndBox);
            this.Controls.Add(this.x0Box);
            this.Controls.Add(this.xEnd);
            this.Controls.Add(this.yEnd);
            this.Controls.Add(this.y0);
            this.Controls.Add(this.x0);
            this.Name = "GraphicsPackage_Form";
            this.Text = "Graphics Package";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label x0;
        private System.Windows.Forms.Label y0;
        private System.Windows.Forms.Label yEnd;
        private System.Windows.Forms.Label xEnd;
        private System.Windows.Forms.TextBox x0Box;
        private System.Windows.Forms.TextBox yEndBox;
        private System.Windows.Forms.TextBox xEndBox;
        private System.Windows.Forms.TextBox y0Box;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ResultingPoints;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Circal_Draw;
        private System.Windows.Forms.Button Ellipse_Draw;
        private System.Windows.Forms.Button Bresenham_Line_Draw;
        private System.Windows.Forms.Button DDA_Line_Draw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button yReflection;
        private System.Windows.Forms.Button xReflection;
        private System.Windows.Forms.TextBox Choice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox yT;
        private System.Windows.Forms.TextBox xT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Translation;
        private System.Windows.Forms.TextBox ScaleValue;
        private System.Windows.Forms.Button Scale;
        private System.Windows.Forms.Button Rotation;
        private System.Windows.Forms.TextBox Angle;
        private System.Windows.Forms.Button Draw_Square;
        private System.Windows.Forms.Button Sheer_X;
        private System.Windows.Forms.TextBox xValue;
        private System.Windows.Forms.Button Sheer_Y;
        private System.Windows.Forms.TextBox yValue;
        private System.Windows.Forms.Button XY_Reflection;
    }






}

