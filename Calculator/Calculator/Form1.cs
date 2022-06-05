namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num;
        char symbol;

        private void button1_Click(object sender, EventArgs e)
        {
            process.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            process.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            process.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            process.Text += 4;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            process.Text += 5;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            process.Text += 6;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            process.Text += 7;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            process.Text += 8;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            process.Text += 9;

        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (process.Text.Length != 0)
            {
                symbol = '*';
                if (num != 0)
                    num *= Convert.ToInt32(process.Text);
                else
                    num = Convert.ToInt32(process.Text);
                process.Clear();
                cloud.Text = num.ToString();
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            num = 0;
            process.Clear();
            cloud.Clear();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (process.Text.Length != 0)
            {
                symbol = '+';
                num += Convert.ToInt32(process.Text);
                process.Clear();
                cloud.Text = num.ToString();

            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (process.Text.Length != 0)
            {
                symbol = '-';
                if (num != 0)
                {
                    num -= Convert.ToInt32(process.Text);
                }
                else
                    num = Convert.ToInt32((process.Text));
                process.Clear();
                cloud.Text = num.ToString();
            }

        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (process.Text.Length != 0)
            {
                symbol = '/';
                if (num != 0)
                {
                    num /= Convert.ToInt32(process.Text);
                }
                else
                    num = Convert.ToInt32((process.Text));
                process.Clear();
                cloud.Text = num.ToString();
            }

        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (process.Text.Length != 0)
            {
                if (symbol == '+')
                    num += Convert.ToInt32(process.Text);
                else if(symbol == '-') 
                    num -= Convert.ToInt32(process.Text);
                else if(symbol == '/') 
                    num /= Convert.ToInt32(process.Text);
                else if(symbol == '*')
                    num *= Convert.ToInt32(process.Text);
                process.Clear();
                cloud.Text = num.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            process.Text += 0;
        }
    }
}