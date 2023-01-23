using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColonyOptimization
{
    public partial class app : Form
    {
        public Colony colony;

        private DrawingForm DrawMDI;

        public app()
        {
            InitializeComponent();
            Init();
            //Invalidate();
        }
        
        private void Init()
        {
            CreateColony();

            DrawMDI = new DrawingForm(ref colony);
            DrawMDI.MdiParent = this;
            
            DrawingPanel.Controls.Add(DrawMDI);

            DrawMDI.Show();
            DrawMDI.Invalidate();

            Update();
        }

        private void CreateColony()
        {
            int n = Convert.ToInt32(NumPointRead.Value);
            colony = new Colony(n, 500, 300);

            Drawing.shortWayVisible = checkBoxShowWay.Checked;
            Drawing.numOfPointVisible = numOfPointVisible.Checked;

            ReloadDistMatrix();
            ReloadPhMatrix();
            ConstUpdate();
        }

        private void ConstUpdate()
        {
            textBoxAlfa.Text = Searching.a.ToString();
            textBoxBeta.Text = Searching.b.ToString();
            textBoxL.Text    = Searching.l.ToString();
            textBoxQ.Text    = Searching.Q.ToString();
            textBoxP.Text    = Searching.p.ToString();
            textBoxNIt.Text  = Searching.NumOfIt.ToString();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            //newMDIChild.OnPaint(sender, e);
            //dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            DrawMDI.Invalidate();
        }
        
        private void ReloadSearchingBtn_Click(object sender, EventArgs e)
        {
            colony.ReloadSearching();
            Update();
        }

        private void Update()
        {
            float shortWay = colony.findShort;
            if (shortWay == 10000f)
                ShortWayText.Text = "No way";
            else
                ShortWayText.Text = shortWay.ToString();

            StepNumberText.Text = colony.step.ToString();
            ReloadPhMatrix();

            Invalidate();
            DrawMDI.Invalidate();
        }

        private void DoStep_Click(object sender, EventArgs e)
        {
            Searching.OneStep(ref colony);
            Update();
        }

        private void DoFiveStepButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                Searching.OneStep(ref colony);

            Update();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            DrawMDI.Close();
            Init();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Drawing.shortWayVisible = checkBoxShowWay.Checked;
            DrawMDI.Invalidate();
        }

        private void numOfPointVisible_CheckedChanged(object sender, EventArgs e)
        {
            Drawing.numOfPointVisible = numOfPointVisible.Checked;
            DrawMDI.Invalidate();
        }

        private void textBoxAlfa_KeyPr(object sender, KeyPressEventArgs e)
        {
            /*
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            */
        }

        private void textBoxAlfa_KeyUp(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.Enter)
                if (textBoxAlfa.Text.Length < 7 && textBoxAlfa.Text != "")
                {
                    float result = 1.2f;
                    try
                    {
                        Convert.ToSingle(textBoxAlfa.Text);
                        
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("FormatException", "error");
                        textBoxAlfa.Text = colony.a.ToString();
                        return;
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("OverflowException", "error");
                        textBoxAlfa.Text = colony.a.ToString();
                        return;
                    }
                    colony.a = result;
                }
                else
                {
                    MessageBox.Show("send other number", "error");
                    textBoxAlfa.Text = colony.a.ToString();
                }
            */
        }

        private void NumPointRead_paint(object sender, PaintEventArgs e)
        {
            var c = (NumericUpDown)sender;
            ControlPaint.DrawBorder(e.Graphics, c.ClientRectangle,
                                    Color.Black, ButtonBorderStyle.Solid);
            var r = new Rectangle(1, 1, c.Width - 2, c.Height - 2);
            e.Graphics.SetClip(r);
        }
    }
}
