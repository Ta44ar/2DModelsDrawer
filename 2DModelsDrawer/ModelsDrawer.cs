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
        private Point dragStartPoint;
        private List<Point> originalPolygonPoints = new List<Point>();

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
        }

        private void drawingPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isDrawing && polygonPoints.Count > 0)
            {
                isDragging = true;
                dragStartPoint = e.Location;
                originalPolygonPoints = new List<Point>(polygonPoints);
            }
        }

        private void drawingPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int dx = e.X - dragStartPoint.X;
                int dy = e.Y - dragStartPoint.Y;
                for (int i = 0; i < polygonPoints.Count; i++)
                {
                    polygonPoints[i] = new Point(originalPolygonPoints[i].X + dx, originalPolygonPoints[i].Y + dy);
                }
                drawingPictureBox.Invalidate(); // Redraw the PictureBox to show the moved polygon
            }
        }

        private void drawingPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                isDragging = false;
            }
        }

        private void drawingPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (polygonPoints.Count > 1)
            {
                e.Graphics.DrawPolygon(Pens.Black, polygonPoints.ToArray());
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
                MovePolygon(dx, dy);
            }
            else
            {
                MessageBox.Show("Please enter valid integer values for ΔX and ΔY.");
            }
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

        private void MovePolygon(int dx, int dy)
        {
            for (int i = 0; i < polygonPoints.Count; i++)
            {
                polygonPoints[i] = new Point(polygonPoints[i].X + dx, polygonPoints[i].Y + dy);
            }
            drawingPictureBox.Invalidate(); // Redraw the PictureBox to show the moved polygon
        }
    }
}