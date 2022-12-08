using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;


namespace Goldfish
{
    public partial class Form1 : Form
    {
        private Bitmap screenshot (Point start, Point end)
        {
            Bitmap screenshot = new Bitmap(end.X - start.X, end.Y - start.Y, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(screenshot);
            graphics.CopyFromScreen(start, new Point(0, 0), screenshot.Size);
            graphics.Dispose();
            return screenshot;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void snapPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            screenshot(Location, new Point(Location.X + Size.Width, Location.Y + Size.Height)).Save("screenshot.png", ImageFormat.Png);
        }
    }
}
