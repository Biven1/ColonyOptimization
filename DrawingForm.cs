using System.Drawing;
using System.Windows.Forms;

namespace ColonyOptimization
{
    public partial class DrawingForm : Form
    {
        private Colony colony;
        public DrawingForm(Colony colony)
        {
            InitializeComponent();
            this.colony = colony;

            Invalidate();
        }

        public void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            colony.Draw(g);
        }
    }
}
