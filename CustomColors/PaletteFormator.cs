using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace CustomColors
{
    static class ColorPalette
    {
        public static Bitmap RainbowBitmap(Size size)
        {
            var bmp = new Bitmap(size.Width, size.Height);
            using (var g = Graphics.FromImage(bmp))
            using (var brush = RainbowBrush(new Point(0, 0), new Point(size.Width, size.Height)))
            {
                g.FillRectangle(brush, 0, 0, size.Width, size.Height);
            }
            return bmp;
        }

        public static Bitmap AltRainbowBitmap(Size size)
        {
            var bmp = new Bitmap(size.Width, size.Height);
            using (var g = Graphics.FromImage(bmp))
            using (var brush = AltRainbowBrush(new Point(0, 0), new Point(size.Width, size.Height)))
            {
                g.FillRectangle(brush, 0, 0, size.Width, size.Height);
            }
            return bmp;
        }

        public static Bitmap GrayBitmap(Size size)
        {
            var bmp = new Bitmap(size.Width, size.Height);
            using (var g = Graphics.FromImage(bmp))
            using (var brush = GrayBrush(new Point(0, 0), new Point(size.Width, size.Height)))
            {
                g.FillRectangle(brush, 0, 0, size.Width, size.Height);
            }
            return bmp;
        }

        public static LinearGradientBrush RainbowBrush(Point sPoint, Point ePoint)
        {
            var brush = new LinearGradientBrush(sPoint, ePoint, Color.Red, Color.Fuchsia)
            {
                InterpolationColors = new ColorBlend()
                {
                    Colors = new Color[] { Color.Red, Color.Yellow, Color.Lime, Color.Aqua, Color.Blue, Color.Fuchsia },
                    Positions = new float[] { 0, 0.2f, 0.4f, 0.6f, 0.8f, 1 }
                }
            };
            return brush;
        }

        public static LinearGradientBrush AltRainbowBrush(Point sPoint, Point ePoint)
        {
            var brush = new LinearGradientBrush(sPoint, ePoint, Color.Red, Color.Fuchsia)
            {
                InterpolationColors = new ColorBlend()
                {
                    Colors = new Color[] { Color.Fuchsia, Color.Blue, Color.Aqua, Color.Lime, Color.Yellow, Color.Red },
                    Positions = new float[] { 0, 0.2f, 0.4f, 0.6f, 0.8f, 1 }
                }
            };
            return brush;
        }

        public static LinearGradientBrush GrayBrush(Point sPoint, Point ePoint)
        {
            var brush = new LinearGradientBrush(sPoint, ePoint, Color.White, Color.Black)
            {
                InterpolationColors = new ColorBlend()
                {
                    Colors = new Color[] { Color.White, Color.Black },
                    Positions = new float[] { 0, 1 }
                }
            };
            return brush;
        }

        public static Color GetRainbowColor(float n)
        {
            int r = 0, g = 0, b = 0;
            int c = Convert.ToInt32(1275 * n);
            switch (c / 255)
            {
                case 0: // Red with less green
                    r = 255;
                    g = c;
                    break;
                case 1: // Green with less red
                    g = 255;
                    r = 510 - c;
                    break;
                case 2: // Green with less blue
                    g = 255;
                    b = c - 510;
                    break;
                case 3: // Blue with less green
                    b = 255;
                    g = 1020 - c;
                    break;
                default: // Blue with less red
                    b = 255;
                    r = c - 1020;
                    break;
            }
            return Color.FromArgb(r, g, b);
        }

        public static Color GetAltRainbowColor(float n)
        {
            int r = 0, g = 0, b = 0;
            int c = Convert.ToInt32(1275 * n);
            switch (c / 255)
            {
                case 0: // Blue with less red
                    b = 255;
                    r = 255 - c;
                    break;
                case 1: // Blue with less green
                    b = 255;
                    g = c - 255;
                    break;
                case 2: // Green with less blue
                    g = 255;
                    b = 765 - c;
                    break;
                case 3: // Green with less red
                    g = 255;
                    r = c - 765;
                    break;
                default: // Red with less green
                    r = 255;
                    g = 1275 - c;
                    break;
            }
            return Color.FromArgb(r, g, b);
        }

        public static Color GetGrayColor(float n)
        {
            int c = 255 - Convert.ToInt32(255 * n);
            return Color.FromArgb(c, c, c);
        }

        public static Bitmap RainbowLegend(float min, float max, int count)
        {
            var bmp = new Bitmap(100, 200);
            using (var g = Graphics.FromImage(bmp))
            {
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                for (int i = 0; i < count; i++)
                {
                    g.FillRectangle(new SolidBrush(GetRainbowColor(i / (count - 1.0f))), 0, i * 20, 15, 15);
                    g.DrawRectangle(Pens.Black, 0, i * 20, 15, 15);
                    g.DrawString($"{i * (max - min) / (count - 1.0f) + min}", new Font("Arial", 11), Brushes.Black, 20, i * 20 - 1);
                }
            }
            return bmp;
        }

        public static Bitmap AltRainbowLegend(float min, float max, int count)
        {
            var bmp = new Bitmap(100, 200);
            using (var g = Graphics.FromImage(bmp))
            {
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                for (int i = 0; i < count; i++)
                {
                    g.FillRectangle(new SolidBrush(GetAltRainbowColor(i / (count - 1.0f))), 0, i * 20, 15, 15);
                    g.DrawRectangle(Pens.Black, 0, i * 20, 15, 15);
                    g.DrawString($"{i * (max - min) / (count - 1.0f) + min}", new Font("Arial", 11), Brushes.Black, 20, i * 20 - 1);
                }
            }
            return bmp;
        }

        public static Bitmap GrayLegend(float min, float max, int count)
        {
            var bmp = new Bitmap(100, 200);
            using (var g = Graphics.FromImage(bmp))
            {
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                for (int i = 0; i < count; i++)
                {
                    g.FillRectangle(new SolidBrush(GetGrayColor(i / (count - 1.0f))), 0, i * 20, 15, 15);
                    g.DrawRectangle(Pens.Black, 0, i * 20, 15, 15);
                    g.DrawString($"{i * (max - min) / (count - 1.0f) + min}", new Font("Arial", 11), Brushes.Black, 20, i * 20 - 1);
                }
            }
            return bmp;
        }
    }
}