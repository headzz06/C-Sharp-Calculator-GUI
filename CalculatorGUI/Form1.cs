namespace CalculatorGUI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }
        int operandPartOne;
        string op;

        private void button1_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "7");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "4");
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "9");
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            int operandPartTwo = int.Parse(answerBox.Text);

            if (op == "+")
            {
                string answer = (Convert.ToString((operandPartOne + operandPartTwo)));
                answerBox.Text = answer;
            }
            else if (op == "-")
            {
                string answer = (Convert.ToString((operandPartOne - operandPartTwo)));
                answerBox.Text = answer;
            }
            else if (op =="*")
            {
                string answer = (Convert.ToString((operandPartOne * operandPartTwo)));
                answerBox.Text = answer;
            }
            
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "8");
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "5");
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "6");
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "1");
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "2");
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "3");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            answerBox.Text = "";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            op = "+";
            operandPartOne = Int32.Parse(answerBox.Text);
            answerBox.Text = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            op = "-";
            operandPartOne = Int32.Parse(answerBox.Text);
            answerBox.Text = "";
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            op = "*";
            operandPartOne = Int32.Parse(answerBox.Text);
            answerBox.Text = "";
        }
    }
}