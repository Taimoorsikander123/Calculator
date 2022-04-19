namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        string operatApplied = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void num_Click(object sender, EventArgs e)
        {
            if((textBox.Text == "0"))
            {
                textBox.Clear();
            }
            Button button  = (Button)sender;
            textBox.Text = textBox.Text + button.Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void operat_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;


            if (result != 0 && operatApplied != "")
            {
                string dec = "";
                switch (operatApplied)
                {
                    case "+":
                        dec = (result + Double.Parse(textBox.Text)).ToString();
                        label1.Text = dec + operatApplied;
                        result = double.Parse(dec);
                        break;
                    case "-":
                        dec = (result - Double.Parse(textBox.Text)).ToString();
                        label1.Text = dec + operatApplied;
                        result = double.Parse(dec);
                        break;
                    case "*":
                        dec = (result * Double.Parse(textBox.Text)).ToString();
                        label1.Text = dec + operatApplied;
                        result = double.Parse(dec);
                        break;
                    case "/":
                        dec = (result / Double.Parse(textBox.Text)).ToString();
                        label1.Text = dec + operatApplied;
                        result = double.Parse(dec);
                        break;
                    default:
                        break;
                }
                operatApplied = button.Text;
            } else
            {
                result = Double.Parse(textBox.Text);
                operatApplied = button.Text;
                label1.Text = result.ToString() + operatApplied;

            }

            textBox.Text = "0";
        }

        private void clear_click(object sender, EventArgs e)
        {
            textBox.Text="0";
        }

        private void cut_click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            result = 0;
            label1.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 46) {
                    if (textBox.Text == "0" && (int)e.KeyChar == 46)
                    {
                        textBox.Text = "0.";
                    }
                    else
                    {
                        if ((int)e.KeyChar == 46 && !textBox.Text.Contains("."))
                        {
                            textBox.Text += e.KeyChar;
                        }
                        else if ((int)e.KeyChar != 46)
                        {
                            if (textBox.Text == "0")
                            {
                                textBox.Text = e.KeyChar.ToString();
                            }
                            else
                            {
                                textBox.Text += e.KeyChar;
                            }
                        }
                }
            }

            if ((int)e.KeyChar == 42 ||
                 (int)e.KeyChar == 43 ||
                 (int)e.KeyChar == 45 ||
                 (int)e.KeyChar == 46
            ) {
                    if (e.KeyChar.ToString() != operatApplied && operatApplied!= "")
                    {
                        operatApplied = e.KeyChar.ToString();
                    }

                    if (operatApplied != "" && operatApplied != "" && textBox.Text != "0")
                    {
                    }

                    operatApplied = textBox.Text;
                    operatApplied = e.KeyChar.ToString();

                    label1.Text = $"{operatApplied} {operatApplied}";

                    textBox.Text = "0";
                }


    }

        private void decimalcovert(object sender, EventArgs e)
        {
            textBox.Text = Convert.ToInt32(textBox.Text, 2).ToString();


        }

        private void BINcovert(object sender, EventArgs e)
        {

            try
            {
                string sum = "";
                int n, i;
                int[] a = new int[100];

                n = int.Parse(textBox.Text);
                for (i = 0; n > 0; i++)
                {
                    a[i] = n % 2;
                    n = n / 2;
                }

                for (i = i - 1; i >= 0; i--)
                {
                    sum = sum + a[i].ToString();
                }
                textBox.Text = sum;
            }
            catch
            {
                textBox.Text = "Error";
            }

        }

        private void e(object sender, EventArgs e)
        {

        }

        private void EqualTo_Click(object sender, EventArgs e)
        {
            switch (operatApplied)
            {
                case "+":
                    label1.Text = (result + Double.Parse(textBox.Text)).ToString();

                    break;
                case "-":
                    label1.Text = (result - Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    label1.Text = (result * Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    label1.Text = (result / Double.Parse(textBox.Text)).ToString();
                    break;
                default:
                    break;
            }

        }
    }
}
