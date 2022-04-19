namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        string operatApplied = "";
        bool isoperatApplied = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void num_Click(object sender, EventArgs e)
        {
            if((textBox.Text == "0")|| (isoperatApplied))
            {
                textBox.Clear();
            }
            isoperatApplied = false;
            Button button  = (Button)sender;
            textBox.Text = textBox.Text + button.Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void operat_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatApplied = button.Text;

            result = Double.Parse(textBox.Text);
            EqualTo_Click();
            if (result != 0)
            {
                switch (operatApplied)
                {
                    case "+":
                        label1.Text = (result + Double.Parse(textBox.Text)).ToString();
                        break;
                    case "-":
                        label1.Text = (result + Double.Parse(textBox.Text)).ToString();
                        break;
                    case "*":
                        label1.Text = (result + Double.Parse(textBox.Text)).ToString();
                        break;
                    case "/":
                        label1.Text = (result + Double.Parse(textBox.Text)).ToString();
                        break;
                    default:
                        break;
                }
                label1.Text = result + " " + operatApplied;
                isoperatApplied = true;
            }
        }

        private void clear_click(object sender, EventArgs e)
        {
            textBox.Text="0";
        }

        private void cut_click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            result = 0;
        }

        private void EqualTo_Click()
        {
            switch (operatApplied)
            {
                case "+":
                    label1.Text = (result + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    label1.Text = (result + Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    label1.Text = (result + Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    label1.Text = (result + Double.Parse(textBox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}