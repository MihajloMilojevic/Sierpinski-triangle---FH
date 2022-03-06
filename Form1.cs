using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sierpinski_triangle
{
    public partial class form : Form
    {
        private Sierpinski triangle;
        private Graphics g;
        private int trianglesDrawn = 0;
        private PointF A = new PointF(100,400);
        private PointF B = new PointF(400,400);
        private PointF C = new PointF(250, 140.192379f);
        public form()
        {
            InitializeComponent();
            g = image.CreateGraphics();
            triangle = new Sierpinski(A, B, C, 1);
            triangle.Draw(g, triangleColor.Color);
        }

        private void Reset()
        {
            image.Refresh();
            triangle.Reset(); 
            trianglesDrawn = 0;
            drawnLabel.Text = trianglesDrawn.ToString();
            playStopButton.Visible = false;
            clearButton.Visible = false;
            startButton.Visible = true;
            timer.Enabled = false;
        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
                e.Cancel = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (triangle.End() && !loopCheck.Checked)
            {
                timer.Enabled = false;
                return;
            }
            else if (loopCheck.Checked && triangle.End())
            {
                image.Refresh();
                triangle.Reset();
                triangle.DrawOriginal(g, triangleColor.Color);
                trianglesDrawn = 0;
                drawnLabel.Text = trianglesDrawn.ToString();
            }
            triangle.DrawEmpty(g, backgroundColor.Color);
            trianglesDrawn++;
            drawnLabel.Text = trianglesDrawn.ToString();
            
        }

        private void playStopButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
            playStopButton.Text = timer.Enabled ? "STOP" : "PLAY";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void triangleColorButton_Click(object sender, EventArgs e)
        {
            if(triangleColor.ShowDialog() == DialogResult.OK)
            {
                triangleColorButton.BackColor = triangleColor.Color;
                Reset();
            }
        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            if (backgroundColor.ShowDialog() == DialogResult.OK)
            {
                image.BackColor = backgroundColor.Color;
                backgroundColorButton.BackColor = backgroundColor.Color;
                Reset();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int value = (int)stopAtInput.Value;
            if (value < 0 || value > 100)
            {
                MessageBox.Show("Invalid value for stoping index, please enter value between 1 and 100", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            value = (int)timerIntervalInput.Value;
            if (value < 0 || value > 3000)
            {
                MessageBox.Show("Invalid value for timer interval, please enter value between 10 and 3000", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            timer.Interval = (int)timerIntervalInput.Value;

            triangle = new Sierpinski(A, B, C, (int)stopAtInput.Value);

            triangle.DrawOriginal(g, triangleColor.Color);
            trianglesDrawn++;
            drawnLabel.Text = trianglesDrawn.ToString();
            timer.Enabled = true;
            startButton.Visible = false;
            playStopButton.Visible = true;
            clearButton.Visible = true;
        }

        private void stopAtInput_ValueChanged(object sender, EventArgs e)
        { 
            Reset();
            int value = (int)stopAtInput.Value;
            if (value < 0 || value > 100)
                MessageBox.Show("Invalid value for stoping index, please enter value between 1 and 100", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void timerIntervalInput_ValueChanged(object sender, EventArgs e)
        {
            Reset();
            int value = (int)timerIntervalInput.Value;
            if (value < 0 || value > 3000)
                MessageBox.Show("Invalid value for timer interval, please enter value between 1 and 3000", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
