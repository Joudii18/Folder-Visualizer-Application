using System.Drawing;

namespace xAcademics
{
    internal class BarChartVisualizer : Visualizer
    {
        public void visualize(FileSystemComponent comp, Graphics g, int x, int y)
        {
            if (comp is Folder rootFolder)
            {
                DrawBars(rootFolder.children, g, x, y);
            }
        }

        private void DrawBars(List<FileSystemComponent> items, Graphics g, int x, int startY)
        {
            int maxSize = items.Max(item => item.calculateSize());
            float scale = 300f / maxSize;  

            int y = startY;

            foreach (var item in items)
            {
                int size = item.calculateSize();
                int width = (int)(size * scale);
                if (width < 40) width = 40;

                Brush color = (item is Folder)
                    ? new SolidBrush(Color.FromArgb(150, 120, 170, 255))  
                    : new SolidBrush(Color.FromArgb(150, 255, 150, 120));   

                g.FillRectangle(color, x, y, width, 25);
                g.DrawRectangle(Pens.Black, x, y, width, 25);

                string label = $"({size} KB) {item.getName()}";
                g.DrawString(label, SystemFonts.DefaultFont, Brushes.Black, x + 5, y + 5);

                y += 40; 
            }
        }
    }
}
