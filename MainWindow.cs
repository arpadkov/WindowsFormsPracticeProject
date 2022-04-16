using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPracticeProject
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World!";
        }

        private void lblHelloWorld_Click(object sender, EventArgs e)
        {

        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        private void formsPlot1_MouseMoved(object sender, MouseEventArgs e)
        {
            (double x, double y) = formsPlot1.GetMouseCoordinates();
            MousePositionLabel.Text = String.Format("Mouse Position: {0} - {1}", x, y);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double[] values = { 26, 20, 23, 7, 16 };
            formsPlot1.Plot.AddBar(values);
            formsPlot1.Plot.Title("MyPlot");

            formsPlot1.Refresh();
        }
    }
}
