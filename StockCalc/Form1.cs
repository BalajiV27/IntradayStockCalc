namespace StockCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textboxClick(object sender, EventArgs e)
        {
           double ltp = Convert.ToDouble(textBox1.Text);
            label5.Text = CaculatePercent(ltp,1).ToString();
            label8.Text = CaculatePercent(ltp,2).ToString();
            label9.Text = CaculatePercent(ltp,3).ToString();
            label10.Text = CaculatePercent(ltp,4).ToString();
            label11.Text = CaculatePercent(ltp,5).ToString();

        }

        private double CaculatePercent(double num, int percent)
        {
            return ((num * percent * 0.2)/100)+num;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}