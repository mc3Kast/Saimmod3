using Math3.Lib;

namespace MathInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(tbN.Text);
            double p1 = Double.Parse(tbP1.Text);
            double p2 = Double.Parse(tbP2.Text);
            Model model = new Model((float)p1, (float)p2);
            model.Run(n);
            float a = (float)model.exit.finishedRequests / n;
            float p = (float)(model.generator.generatedRequests - model.exit.finishedRequests) / model.generator.generatedRequests;
            float l = (float)model.queue.ticksInQueue / n;
            float w = l * 2;

            lbA.Text = $"A: {a}";
            lbPotk.Text = $"Potk: {p}";
            lbL.Text = $"L: {l}";
            lbW.Text = $"W: {w}";
        }
    }
}