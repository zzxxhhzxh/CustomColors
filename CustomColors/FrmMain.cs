using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Xml.Linq;


namespace CustomColors
{
    public partial class FrmMain : Form
    {
        List<Label> lbls;
        List<CustomColor> customColors;
        struct CustomColor
        {
            public string Name;
            public int R;
            public int G;
            public int B;

            public CustomColor(string name, int r, int g, int b)
            {
                Name = name;
                R = r;
                G = g;
                B = b;
            }

            public CustomColor(string name, Color color)
            {
                Name = name;
                R = color.R;
                G = color.G;
                B = color.B;
            }
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lbls = new List<Label>();
            SetSystemColors();
            ShowColorLabels();
        }    

        private void BtnSystem_Click(object sender, EventArgs e)
        {
            SetSystemColors();
            ShowColorLabels();
        }

        private void BtnSystem2_Click(object sender, EventArgs e)
        {
            SetCustomColors("SystemColor2.xml");
            ShowColorLabels(8);
        }

        private void BtnCustom_Click(object sender, EventArgs e)
        {
            SetCustomColors("CustomColor1.xml");
            ShowColorLabels();
        }

        private void btnFlatUI_Click(object sender, EventArgs e)
        {
            SetCustomColors("FlatUIColor.xml");
            ShowColorLabels(2);
        }

        private void BtnNikita_Click(object sender, EventArgs e)
        {
            SetCustomColors("NikitaColor.xml");
            ShowColorLabels();
        }


        private void btnPalette_Click(object sender, EventArgs e)
        {
            new FrmPalette().ShowDialog();
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            int i = lbls.IndexOf((Label)sender);
            var c = customColors[i];
            Clipboard.SetDataObject($"Color.FromArgb({c.R}, {c.G}, {c.B}); // {c.Name}");
            WindowState = FormWindowState.Minimized;
        }

        private void SetSystemColors()
        {
            customColors = new List<CustomColor>();
            foreach (var color in typeof(Color).GetProperties())
            {
                if (Color.FromName(color.Name).IsKnownColor)
                    customColors.Add(new CustomColor(color.Name, Color.FromName(color.Name)));
            }       
        }

        private void SetCustomColors(string name)
        {
            var xe = XElement.Load(name);
            customColors = new List<CustomColor>();

            foreach (var ele in xe.Elements("Color"))
                customColors.Add(new CustomColor(ele.Attribute("title").Value, GetColor(ele.Attribute("color").Value)));
        }

        private void ShowColorLabels(int col = 10)
        {
            foreach (var lbl in lbls)
            {
                try
                {
                    Controls.Remove(lbl);
                }
                catch { }
            }
                
            lbls = new List<Label>();
            for (int i = 0; i < customColors.Count; i++)
            {
                var cc = customColors[i];
                Label lbl = new Label()
                {
                    Size = new Size(110, 30),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = $"{cc.Name}\n{cc.R}, {cc.G}, {cc.B}",
                    ForeColor = cc.R < 192 && cc.G < 128 ? Color.White : Color.Black,
                    BackColor = Color.FromArgb(cc.R, cc.G, cc.B),
                    Location = new Point(10 + i % col * 111, 10 + i / col * 31)
                };
                lbl.Click += new EventHandler(lbl_Click);
                lbls.Add(lbl);
                Controls.Add(lbl);
            }
        }

        private Color GetColor(string item)
        {
            int r = Convert.ToInt32(item.Substring(1, 2), 16);
            int g = Convert.ToInt32(item.Substring(3, 2), 16);
            int b = Convert.ToInt32(item.Substring(5, 2), 16);
            return Color.FromArgb(r, g, b);
        }
    }
}