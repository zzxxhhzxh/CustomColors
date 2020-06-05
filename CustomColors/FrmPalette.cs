using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace CustomColors
{
    public partial class FrmPalette : Form
    {
        private Color rainbowColor;
        private Color grayColor;
        private Color altRainbowColor;
        private float value;

        public FrmPalette()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rainbowColor = ColorPalette.GetRainbowColor(0);
            grayColor = ColorPalette.GetGrayColor(0);
            altRainbowColor = ColorPalette.GetAltRainbowColor(0);
            lblColor.Text = $"Value: 0\nRainbow Color: {rainbowColor.R}, {rainbowColor.G}, {rainbowColor.B}\nGray Color: {grayColor.R}, {grayColor.G}, {grayColor.B}\nAlt Rainbow Color: {altRainbowColor.R}, {altRainbowColor.G}, {altRainbowColor.B}";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (tmrMove.Enabled)
                tmrMove.Enabled = false;
            else
                tmrMove.Enabled = true;
        }

        private void picRainbow_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = ColorPalette.RainbowBrush(new Point(0, 0), new Point(picRainbow.Width, picRainbow.Height)))
            {
                e.Graphics.FillRectangle(brush, picRainbow.ClientRectangle);
            }
            int x = Convert.ToInt32(value * picRainbow.Width);
            e.Graphics.FillPolygon(Brushes.Black, new Point[] { new Point(x - 5, 0), new Point(x, 5), new Point(x + 5, 0) });
            e.Graphics.FillPolygon(Brushes.Black, new Point[] { new Point(x - 5, 50), new Point(x, 45), new Point(x + 5, 50) });
        }

        private void picGray_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = ColorPalette.GrayBrush(new Point(0, 0), new Point(picGray.Width, picGray.Height)))
            {
                e.Graphics.FillRectangle(brush, picGray.ClientRectangle);
            }
            int x = Convert.ToInt32(value * picGray.Width);
            e.Graphics.FillPolygon(Brushes.Tomato, new Point[] { new Point(x - 5, 0), new Point(x, 5), new Point(x + 5, 0) });
            e.Graphics.FillPolygon(Brushes.Tomato, new Point[] { new Point(x - 5, 50), new Point(x, 45), new Point(x + 5, 50) });
        }

        private void picAltRainbow_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = ColorPalette.AltRainbowBrush(new Point(0, 0), new Point(picAltRainbow.Width, picAltRainbow.Height)))
            {
                e.Graphics.FillRectangle(brush, picAltRainbow.ClientRectangle);
            }
            int x = Convert.ToInt32(value * picAltRainbow.Width);
            e.Graphics.FillPolygon(Brushes.Black, new Point[] { new Point(x - 5, 0), new Point(x, 5), new Point(x + 5, 0) });
            e.Graphics.FillPolygon(Brushes.Black, new Point[] { new Point(x - 5, 50), new Point(x, 45), new Point(x + 5, 50) });
        }

        private void picRainbowSample_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new SolidBrush(rainbowColor))
            {
                e.Graphics.FillRectangle(brush, picRainbowSample.ClientRectangle);
            }
        }

        private void picGraySample_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new SolidBrush(grayColor))
            {
                e.Graphics.FillRectangle(brush, picGraySample.ClientRectangle);
            }
        }

        private void picAltRainbowSample_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new SolidBrush(altRainbowColor))
            {
                e.Graphics.FillRectangle(brush, picAltRainbowSample.ClientRectangle);
            }
        }

        private void tmrMoveSample_Tick(object sender, EventArgs e)
        {
            value += 0.02f;
            if (value > 1f)
                value = 0;
            rainbowColor = ColorPalette.GetRainbowColor(value);
            grayColor = ColorPalette.GetGrayColor(value);
            altRainbowColor = ColorPalette.GetAltRainbowColor(value);
            lblColor.Text = $"Value: {value:F2}\nRainbow Color: {rainbowColor.R}, {rainbowColor.G}, {rainbowColor.B}\nGray Color: {grayColor.R}, {grayColor.G}, {grayColor.B}\nAlt Rainbow Color: {altRainbowColor.R}, {altRainbowColor.G}, {altRainbowColor.B}";
            picRainbow.Refresh();
            picRainbowSample.Refresh();
            picGray.Refresh();
            picGraySample.Refresh();
            picAltRainbow.Refresh();
            picAltRainbowSample.Refresh();
        }
    }
}