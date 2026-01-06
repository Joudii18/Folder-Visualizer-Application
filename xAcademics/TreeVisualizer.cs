using System.Drawing;

namespace xAcademics
{
    internal class TreeVisualizer : Visualizer
    {
        private const int NodeWidth = 130;
        private const int NodeHeight = 26;
        private const int HSpacing = 80;
        private const int VSpacing = 25;

        public void visualize(FileSystemComponent root, Graphics g, int x, int y)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            int currentY = 20;
            DrawNode(g, root, depth: 0, currentY: ref currentY, parentRect: null);
        }

        private void DrawNode(Graphics g,
                              FileSystemComponent node,
                              int depth,
                              ref int currentY,
                              Rectangle? parentRect)
        {
            // Logical position of this node
            int logicalX = 20 + depth * HSpacing;
            int logicalY = currentY;

            Rectangle rect = new Rectangle(logicalX, logicalY, NodeWidth, NodeHeight);

            // Draw connector line from parent to this node (if any)
            if (parentRect.HasValue)
            {
                Point parentCenter = new Point(
                    parentRect.Value.Right,
                    parentRect.Value.Top + NodeHeight / 2
                );

                Point childCenter = new Point(
                    rect.Left,
                    rect.Top + NodeHeight / 2
                );

                g.DrawLine(Pens.Gray, parentCenter, childCenter);
            }

            // Draw node box (different color for folder vs file)
            Brush fill = (node is Folder) ? Brushes.Gainsboro : Brushes.LightBlue;
            g.FillRectangle(fill, rect);
            g.DrawRectangle(Pens.Black, rect);

            // Draw node name
            g.DrawString(node.getName(), SystemFonts.DefaultFont, Brushes.Black,
                         rect.X + 4, rect.Y + 4);

            
            currentY += NodeHeight + VSpacing; // Move the Y down for the next 

            // Recurse on children if this is a folder
            if (node is Folder folder)
            {
                foreach (var child in folder.children)   // uses your `children` list
                {
                    DrawNode(g, child, depth + 1, ref currentY, rect);
                }
            }
        }
    }
}

