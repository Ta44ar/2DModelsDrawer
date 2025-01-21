using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _2DModelsDrawer
{
    public partial class ModelsDrawer : Form
    {
        private List<Point> polygonPoints = new List<Point>();
        private bool isDrawing = false;
        private bool isDragging = false;
        private bool isRotating = false;
        private Point dragStartPoint;
        private Point rotationPoint;
        private List<Point> originalPolygonPoints = new List<Point>();
        private double initialAngle;
        private const int MoveSensitivity = 2; // Sensitivity threshold for moving

        public ModelsDrawer()
        {
            InitializeComponent();
        }

        private void drawingPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                polygonPoints.Add(e.Location);
                drawingPictureBox.Invalidate(); // Redraw the PictureBox to show the new point
            }
            else if (isRotating)
            {
                rotationPoint = e.Location;
                isRotating = false;
                drawingPictureBox.Invalidate(); // Redraw the PictureBox to show the rotation point
            }
        }

        private void drawingPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isDrawing && polygonPoints.Count > 0)
            {
                if (Control.ModifierKeys == Keys.Shift)
                {
                    isRotating = true;
                    rotationPoint = GetPolygonCenter();
                    initialAngle = GetAngle(rotationPoint, e.Location);
                    originalPolygonPoints = new List<Point>(polygonPoints);
                }
                else
                {
                    isDragging = true;
                    dragStartPoint = e.Location;
                    originalPolygonPoints = new List<Point>(polygonPoints);
                }
            }
        }

        private void drawingPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int dx = e.X - dragStartPoint.X;
                int dy = e.Y - dragStartPoint.Y;

                // Apply sensitivity threshold
                if (Math.Abs(dx) > MoveSensitivity || Math.Abs(dy) > MoveSensitivity)
                {
                    ApplyTransformation(CreateTranslationMatrix(dx, dy));
                    dragStartPoint = e.Location; // Update drag start point
                    drawingPictureBox.Invalidate(); // Redraw the PictureBox to show the moved polygon
                }
            }
            else if (isRotating)
            {
                double currentAngle = GetAngle(rotationPoint, e.Location);
                double angleDifference = currentAngle - initialAngle;

                // Apply direction check
                if (!directionCheckBox.Checked)
                {
                    angleDifference = -angleDifference; // Counter-clockwise rotation
                }

                ApplyTransformation(CreateRotationMatrix(angleDifference, rotationPoint));
                initialAngle = currentAngle;
            }
        }

        private void drawingPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                isDragging = false;
            }
            else if (isRotating)
            {
                isRotating = false;
            }
        }

        private void drawingPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (polygonPoints.Count > 1)
            {
                e.Graphics.DrawPolygon(Pens.Black, polygonPoints.ToArray());
            }
            if (rotationPoint != Point.Empty)
            {
                e.Graphics.FillEllipse(Brushes.Red, rotationPoint.X - 5, rotationPoint.Y - 5, 10, 10);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartDrawing();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            StopDrawing();
        }

        private void addPointButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(xTextBox.Text, out int x) && int.TryParse(yTextBox.Text, out int y))
            {
                AddPointFromTextBox(x, y);
            }
            else
            {
                MessageBox.Show("Please enter valid integer values for X and Y.");
            }
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(xTextBox.Text, out int dx) && int.TryParse(yTextBox.Text, out int dy))
            {
                ApplyTransformation(CreateTranslationMatrix(dx, dy));
                drawingPictureBox.Invalidate(); // Redraw the PictureBox to show the moved polygon
            }
            else
            {
                MessageBox.Show("Please enter valid integer values for ΔX and ΔY.");
            }
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(angleTextBox.Text, out int angle))
            {
                ApplyTransformation(CreateRotationMatrix(angle, GetPolygonCenter()));
                drawingPictureBox.Invalidate(); // Redraw the PictureBox to show the rotated polygon
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value for the angle.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearDrawing();
        }

        private void StartDrawing()
        {
            isDrawing = true;
            polygonPoints.Clear();
            drawingPictureBox.Invalidate(); // Clear the PictureBox
        }

        private void StopDrawing()
        {
            isDrawing = false;
            drawingPictureBox.Invalidate(); // Redraw the PictureBox to show the final polygon
        }

        private void AddPointFromTextBox(int x, int y)
        {
            polygonPoints.Add(new Point(x, y));
            drawingPictureBox.Invalidate(); // Redraw the PictureBox to show the new point
        }

        private void ApplyTransformation(double[,] matrix)
        {
            for (int i = 0; i < polygonPoints.Count; i++)
            {
                polygonPoints[i] = TransformPoint(polygonPoints[i], matrix);
            }
        }

        private Point TransformPoint(Point point, double[,] matrix)
        {
            double x = point.X * matrix[0, 0] + point.Y * matrix[0, 1] + matrix[0, 2];
            double y = point.X * matrix[1, 0] + point.Y * matrix[1, 1] + matrix[1, 2];
            return new Point((int)x, (int)y);
        }

        private double[,] CreateTranslationMatrix(int dx, int dy)
        {
            return new double[,]
            {
                { 1, 0, dx },
                { 0, 1, dy },
                { 0, 0, 1 }
            };
        }

        private double[,] CreateRotationMatrix(double angle, Point center)
        {
            double radians = angle * Math.PI / 180.0;
            if (!directionCheckBox.Checked)
            {
                radians = -radians; // Counter-clockwise rotation
            }
            double cos = Math.Cos(radians);
            double sin = Math.Sin(radians);
            double tx = center.X * (1 - cos) + center.Y * sin;
            double ty = center.Y * (1 - cos) - center.X * sin;

            return new double[,]
            {
                { cos, -sin, tx },
                { sin, cos, ty },
                { 0, 0, 1 }
            };
        }

        private Point GetPolygonCenter()
        {
            int sumX = 0;
            int sumY = 0;
            foreach (Point point in polygonPoints)
            {
                sumX += point.X;
                sumY += point.Y;
            }
            return new Point(sumX / polygonPoints.Count, sumY / polygonPoints.Count);
        }

        private double GetAngle(Point center, Point target)
        {
            return Math.Atan2(target.Y - center.Y, target.X - center.X) * 180.0 / Math.PI;
        }

        private void ClearDrawing()
        {
            polygonPoints.Clear();
            rotationPoint = Point.Empty;
            drawingPictureBox.Invalidate(); // Clear the PictureBox
        }
    }
}