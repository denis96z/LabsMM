using System;
using System.Drawing;

using BMSTU.IU7.Zinovyev.Mathematics;

namespace Lab3
{
    struct GraphLine
    {
        public PointF[] Nodes;
        public Color Color;
    }

    class Graph
    {
        public Bitmap Image { get; private set; }
        private Graphics graphics;

        public Color BackColor { get; set; } = Color.White;
        public Color CellsColor { get; set; } = Color.Gray;

        public int HorizontalCells { get; set; } = 10;
        public int VerticalCells { get; set; } = 10;

        private const int SPACE_LEFT = 50;
        private const int SPACE_BOTTOM = 30;

        private readonly int WIDTH, HEIGHT;

        public Graph(int width, int height)
        {
            Image = new Bitmap(width, height);
            graphics = Graphics.FromImage(Image);

            WIDTH = width - SPACE_LEFT;
            HEIGHT = height - SPACE_BOTTOM;

            Clear();
        }

        public void Clear()
        {
            graphics.Clear(BackColor);
        }

        public void Draw(GraphLine[] lines, float xMin, float xMax, float yMin, float yMax)
        {
            DrawCells(xMin, xMax, yMin, yMax);
            DrawData(xMin, xMax, yMin, yMax);
            DrawLine(lines[0], xMin, xMax, yMin, yMax);
        }

        public void DrawLine(GraphLine line, float xMin, float xMax, float yMin, float yMax)
        {
            PointF previousPoint = line.Nodes[0];
            Pen p = new Pen(line.Color);

            PointF ScaledPoint(PointF point)
            {
                float x = SPACE_LEFT + point.X * WIDTH / (xMax - xMin);
                float y = HEIGHT - point.Y * HEIGHT / (yMax - yMin);
                return new PointF(x, y);
            }

            for (int i = 1; i < line.Nodes.Length; i++)
            {
                graphics.DrawLine(p, ScaledPoint(line.Nodes[i - 1]), ScaledPoint(line.Nodes[i]));
            }
        }

        private void DrawCells(float xMin, float xMax, float yMin, float yMax)
        {
            Pen p = new Pen(CellsColor);

            int cellWidth = WIDTH / HorizontalCells;
            int cellHeight = HEIGHT / VerticalCells;

            for (int i = 0; i < HorizontalCells; i++)
            {
                for (int j = 0; j < VerticalCells; j++)
                {
                    graphics.DrawRectangle(p,
                        i * cellWidth + SPACE_LEFT, j * cellHeight, cellWidth, cellHeight);
                }
            }
        }

        private void DrawData(float xMin, float xMax, float yMin, float yMax)
        {
            Brush b = new SolidBrush(CellsColor);
            Font f = new Font("Times New Roman", 8);

            int cellWidth = WIDTH / HorizontalCells;
            int cellHeight = HEIGHT / VerticalCells;

            float yStep = (yMax - yMin) / VerticalCells;
            float xStep = (xMax - xMin) / HorizontalCells;

            float y = yMax;
            for (int i = 0; i <= VerticalCells; i++, y -= yStep)
            {
                graphics.DrawString(y.ToString(), f, b, 1, i * cellHeight);
            }

            float x = xMin;
            for (int i = 0; i <= HorizontalCells; i++, x += xStep)
            {
                graphics.DrawString(x.ToString(), f, b,
                    SPACE_LEFT + i * cellWidth, HEIGHT + SPACE_BOTTOM - f.Height - 1);
            }
        }
    }
}
