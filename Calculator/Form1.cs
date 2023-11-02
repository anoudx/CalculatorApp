namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(TxtNum1.Text);

            double txt2 = Convert.ToDouble(TxtNum2.Text);

            double sum = txt1 + txt2;

            TextOutput.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double txt1 = Convert.ToDouble(TxtNum1.Text);

            double txt2 = Convert.ToDouble(TxtNum2.Text);

            double diff = txt1 - txt2;

            TextOutput.Text = diff.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(TxtNum1.Text);

            double txt2 = Convert.ToDouble(TxtNum2.Text);

            double mul = txt1 * txt2;

            TextOutput.Text = mul.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(TxtNum1.Text);

            double txt2 = Convert.ToDouble(TxtNum2.Text);

            double div = txt1 / txt2;

            TextOutput.Text = div.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}