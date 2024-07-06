namespace Calculator
{
    public partial class Form1 : Form
    {

        double FirstNumber;
        string Operation;
        double SecondNumber;
        double Result;

        bool op_pressed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                if (textBox1.TextLength < textBox1.MaxLength)
                {
                    textBox1.Text = textBox1.Text + "1";
                }

            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                if (textBox1.TextLength < textBox1.MaxLength)
                    textBox1.Text = textBox1.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                if (textBox1.TextLength < textBox1.MaxLength)
                    textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                if (textBox1.TextLength < textBox1.MaxLength)
                    textBox1.Text = textBox1.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                if (textBox1.TextLength < textBox1.MaxLength)
                    textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                if (textBox1.TextLength < textBox1.MaxLength)
                    textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                if (textBox1.TextLength < textBox1.MaxLength)
                    textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                if (textBox1.TextLength < textBox1.MaxLength)
                    textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                if (textBox1.TextLength < textBox1.MaxLength)
                    textBox1.Text = textBox1.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                return;
            }
            else
            {
                if (textBox1.TextLength < textBox1.MaxLength)
                    textBox1.Text = textBox1.Text + "0";
            }
        }

        private void n00_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                return;
            }
            else
            {
                if (textBox1.TextLength < textBox1.MaxLength - 1)
                    textBox1.Text = textBox1.Text + "00";
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < textBox1.MaxLength - 1 && !textBox1.Text.EndsWith("."))
                textBox1.Text = textBox1.Text + ".";
        }

        private void bmult_Click(object sender, EventArgs e)
        {
            if (op_pressed)
            {
                bequal_Click(bequal, EventArgs.Empty);
            }
            else
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
            }

            textBox1.Text = "0";
            Operation = "*";
            op_pressed = true;

        }

        private void bad_Click(object sender, EventArgs e)
        {
            if (op_pressed)
            {
                bequal_Click(bequal, EventArgs.Empty);
            }
            else
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
               
            }

            textBox1.Text = "0";
            Operation = "+";
            op_pressed = true;
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            if (op_pressed)
            {
                bequal_Click(bequal, EventArgs.Empty);
            }
            else
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
            }

            textBox1.Text = "0";
            Operation = "/";
            op_pressed = true;
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            if (op_pressed)
            {
                bequal_Click(bequal, EventArgs.Empty);
            }
            else
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
               
            }
            textBox1.Text = "0";
            Operation = "-";
            op_pressed = true;
        }

        private void bequal_Click(object sender, EventArgs e)
        {
            
            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            op_pressed = false;
        }

        private void bac_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            FirstNumber = 0;
            SecondNumber = 0;
            Result = 0;
        }

        private void bc_Click(object sender, EventArgs e)
        {
            if(Result!=0)
                textBox1.Text = Convert.ToString(Result);
            else
            {
                textBox1.Text = "0";
                FirstNumber = 0;
            }
               

        }
    }
}
