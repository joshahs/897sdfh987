using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Office_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            pen.Width = 10;
            e.Graphics.DrawLine(pen, new PointF(0, 0), new PointF(panel1.Width, 0));
            e.Graphics.DrawLine(pen, new PointF(0, 0), new PointF(0, panel1.Height));
            e.Graphics.DrawLine(pen, new PointF(panel1.Width, 0), new PointF(panel1.Width, panel1.Height));
            e.Graphics.DrawLine(pen, new PointF(0, panel1.Height), new PointF(panel1.Width, panel1.Height));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            pen.Width = 10;
            e.Graphics.DrawLine(pen, new PointF(0, 0), new PointF(panel2.Width, 0));
            e.Graphics.DrawLine(pen, new PointF(0, 0), new PointF(0, panel2.Height));
            e.Graphics.DrawLine(pen, new PointF(panel2.Width, 0), new PointF(panel2.Width, panel2.Height));
            e.Graphics.DrawLine(pen, new PointF(0, panel2.Height), new PointF(panel2.Width, panel2.Height));
        }
    }
}
