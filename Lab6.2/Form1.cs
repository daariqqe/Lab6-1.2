using System;
using System.Windows.Forms;
using Lab6_2;
namespace Lab6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }     

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Solid cube = new Cube() 
            {
                A = double.Parse(nudA.Text)
            };
            Solid rect = new RectSolid()
            {
                C = double.Parse(nudC.Text),
                D = double.Parse(nudD.Text),
                H = double.Parse(nudH.Text)

            };

            lblCubeVolume.Text = $"{cube.GetVolume():F1}";
            lblRectVolume.Text = $"{rect.GetVolume():F1}";
        }
    }
}
