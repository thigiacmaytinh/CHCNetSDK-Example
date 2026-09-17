using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace TGMTcs
{
    public class TGMTdraw
    {
        private static Random random = new Random();
        static SolidBrush whiteBrush = new SolidBrush(Color.White);

        public static void DrawRectangle(Bitmap bmp, Rectangle rect, Color c, bool fill = false, int thickness = 1)
        {
            if(bmp == null)
                return;

            using (Graphics g = Graphics.FromImage(bmp))
            {
                SolidBrush shadowBrush = new SolidBrush(c);
                if(fill)
                {
                    g.FillRectangles(shadowBrush, new RectangleF[] { rect });
                }
                else
                {
                    Pen p = new Pen(c, thickness);
                    g.DrawRectangle(p, rect);
                }                
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap DrawRectangles(Bitmap bmp, Rectangle[] rects, Color c, bool fill = false, int thickness = 1)
        {
            if(rects.Length == 0)
                return bmp;

            Image image = (Image)bmp;
            Pen p = new Pen(c, thickness);

            using (Graphics g = Graphics.FromImage(image))
            {
                SolidBrush shadowBrush = new SolidBrush(c);

                for(int i=0; i<rects.Length; i++)
                {
                    Rectangle rect = rects[i];
                    if (fill)
                    {
                        g.FillRectangles(shadowBrush, new RectangleF[] { rect });
                    }
                    else
                    {

                        g.DrawRectangle(p, rect);
                    }
                }
                
            }

            return (Bitmap)image;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void DrawFancyRectangle(Bitmap bmp, Rectangle rect, Color color, int thickness)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                int r = rect.Width / 20;
                int d = rect.Width / 6;

                int x1 = rect.Left;
                int y1 = rect.Top;
                int x2 = rect.Right;
                int y2 = rect.Bottom;

                if (rect.Width > 200)
                    thickness = 5;
                else if (rect.Width < 50)
                    thickness = 3;

                // Define a pen for drawing with the specified color and thickness
                Pen pen = new Pen(color, thickness)
                {
                    LineJoin = LineJoin.Round
                };

                // Set the smoothing mode for better quality
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Top left
                g.DrawLine(pen, x1 + r, y1, x1 + r + d, y1);
                g.DrawLine(pen, x1, y1 + r, x1, y1 + r + d);
                g.DrawArc(pen, x1, y1, 2 * r, 2 * r, 180, 90);

                // Top right
                g.DrawLine(pen, x2 - r, y1, x2 - r - d, y1);
                g.DrawLine(pen, x2, y1 + r, x2, y1 + r + d);
                g.DrawArc(pen, x2 - 2 * r, y1, 2 * r, 2 * r, 270, 90);

                // Bottom left
                g.DrawLine(pen, x1 + r, y2, x1 + r + d, y2);
                g.DrawLine(pen, x1, y2 - r, x1, y2 - r - d);
                g.DrawArc(pen, x1, y2 - 2 * r, 2 * r, 2 * r, 90, 90);

                // Bottom right
                g.DrawLine(pen, x2 - r, y2, x2 - r - d, y2);
                g.DrawLine(pen, x2, y2 - r, x2, y2 - r - d);
                g.DrawArc(pen, x2 - 2 * r, y2 - 2 * r, 2 * r, 2 * r, 0, 90);

                // Dispose of the pen
                pen.Dispose();
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap DrawFancyRectangles(Bitmap bmp, Rectangle[] rects, Color color, int thickness)
        {
            if (rects == null)
                return bmp;

            // Define a pen for drawing with the specified color and thickness
            Pen pen = new Pen(color, thickness)
            {
                LineJoin = LineJoin.Round
            };

            using (Graphics g = Graphics.FromImage(bmp))
            {
                for (int i = 0; i < rects.Length; i++)
                {
                    Rectangle rect = rects[i];
                    int r = rect.Width / 20;
                    int d = rect.Width / 6;

                    int x1 = rect.Left;
                    int y1 = rect.Top;
                    int x2 = rect.Right;
                    int y2 = rect.Bottom;

                    if (rect.Width > 200)
                        thickness = 5;
                    else if (rect.Width < 50)
                        thickness = 3;

                    

                    // Set the smoothing mode for better quality
                    g.SmoothingMode = SmoothingMode.AntiAlias;

                    // Top left
                    g.DrawLine(pen, x1 + r, y1, x1 + r + d, y1);
                    g.DrawLine(pen, x1, y1 + r, x1, y1 + r + d);
                    g.DrawArc(pen, x1, y1, 2 * r, 2 * r, 180, 90);

                    // Top right
                    g.DrawLine(pen, x2 - r, y1, x2 - r - d, y1);
                    g.DrawLine(pen, x2, y1 + r, x2, y1 + r + d);
                    g.DrawArc(pen, x2 - 2 * r, y1, 2 * r, 2 * r, 270, 90);

                    // Bottom left
                    g.DrawLine(pen, x1 + r, y2, x1 + r + d, y2);
                    g.DrawLine(pen, x1, y2 - r, x1, y2 - r - d);
                    g.DrawArc(pen, x1, y2 - 2 * r, 2 * r, 2 * r, 90, 90);

                    // Bottom right
                    g.DrawLine(pen, x2 - r, y2, x2 - r - d, y2);
                    g.DrawLine(pen, x2, y2 - r, x2, y2 - r - d);
                    g.DrawArc(pen, x2 - 2 * r, y2 - 2 * r, 2 * r, 2 * r, 0, 90);                    
                }

                // Dispose of the pen
                pen.Dispose();
            }

            return bmp;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void DrawText(Bitmap bmp, string text, Point position, Color color, float fontSize)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Set the smoothing mode for better quality
                g.SmoothingMode = SmoothingMode.AntiAlias;
                // Define the font and brush for drawing text
                using (Font font = new Font("Arial", fontSize, FontStyle.Bold, GraphicsUnit.Pixel))
                {
                    SizeF textSize = g.MeasureString(text, font);
                    using (SolidBrush brush = new SolidBrush(color))
                    {
                        g.FillRectangle(brush, position.X - 4, position.Y, textSize.Width + 8, textSize.Height);

                        // Draw the text at the specified position
                        g.DrawString(text, font, whiteBrush, position);
                    }
                }
            }
        }
        
        public static Color GenerateRandomColor()
        {
            int r = random.Next(200); // Generates a value between 0 and 255
            int g = random.Next(200);
            int b = random.Next(200);

            return Color.FromArgb(r, g, b);
        }
    }
    
}
