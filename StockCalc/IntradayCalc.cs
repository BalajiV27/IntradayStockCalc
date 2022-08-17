using System.Text.RegularExpressions;

namespace StockCalc
{
    public partial class IntradayCalc : Form
    {
        public IntradayCalc()
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
            try
            {
                if(!string.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.Text = Regex.Replace(textBox1.Text, "[^0-9.]", "");
                    if(!string.IsNullOrEmpty(textBox1.Text))
                    {
                        double ltp = Convert.ToDouble(Regex.Replace(textBox1.Text, "[^0-9.]", ""));
                        GenerateResult(ltp);
                        textBox1.SelectionStart = textBox1.Text.Length;
                        textBox1.SelectionLength = 0;
                    }
                }
                
            }
            catch (Exception)
            {
                throw;
            }
        }

      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
         //   e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private double CaculatePercent(double num, int percent)
        {
            return Math.Round(((num * percent * 0.2) / 100) + num,2);
        }

        private void GenerateResult(double ltp)
        {
            b1_valuelabel.Text =CaculatePercent(ltp, 1).ToString();
            b2_valuelabel.Text = CaculatePercent(ltp, 2).ToString();
            b3_valuelabel.Text = CaculatePercent(ltp, 3).ToString();
            b4_valuelabel.Text = CaculatePercent(ltp, 4).ToString();
            b5_valuelabel.Text = CaculatePercent(ltp, 5).ToString();
            b6_valuelabel.Text = CaculatePercent(ltp, 6).ToString();
            b7_valuelabel.Text = CaculatePercent(ltp, 7).ToString();
            b8_valuelabel.Text = CaculatePercent(ltp, 8).ToString();
            b9_valuelabel.Text = CaculatePercent(ltp, 9).ToString();
            b10_valuelabel.Text = CaculatePercent(ltp, 10).ToString();
            b12_valuelabel.Text = CaculatePercent(ltp, 12).ToString();
            b15_valuelabel.Text = CaculatePercent(ltp, 15).ToString();
            b20_valuelabel.Text = CaculatePercent(ltp, 20).ToString();

            s1_labelvalue.Text = CaculatePercent(ltp, -1).ToString();
            s2_labelvalue.Text = CaculatePercent(ltp, -2).ToString();
            s3_labelvalue.Text = CaculatePercent(ltp, -3).ToString();
            s4_labelvalue.Text = CaculatePercent(ltp, -4).ToString();
            s5_labelvalue.Text = CaculatePercent(ltp, -5).ToString();
            s6_labelvalue.Text = CaculatePercent(ltp, -6).ToString();
            s7_labelvalue.Text = CaculatePercent(ltp, -7).ToString();
            s8_labelvalue.Text = CaculatePercent(ltp, -8).ToString();
            s9_labelvalue.Text = CaculatePercent(ltp, -9).ToString();
            s10_labelvalue.Text = CaculatePercent(ltp, -10).ToString();
            s12_labelvalue.Text = CaculatePercent(ltp, -12).ToString();
            s15_labelvalue.Text = CaculatePercent(ltp, -15).ToString();
            s20_labelvalue.Text = CaculatePercent(ltp, -20).ToString();
        }
    }
}