using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x, y;

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int x0 = Math.Min(x, e.X);
            int y0 = Math.Min(y, e.Y);
            int a = Math.Abs(e.X - x);
            int b = Math.Abs(e.Y - y);
            Graphics g = CreateGraphics();
            g.DrawRectangle(Pens.Black, x0, y0, a, b);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
    }
}
