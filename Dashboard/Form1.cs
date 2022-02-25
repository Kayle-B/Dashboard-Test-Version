namespace Dashboard
{
    public partial class Form1 : Form
    {
        calculator calculator = new calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            caluclatedTextBox.Text = calculator.calculate(Int32.Parse(value1TextBox.Text), Int32.Parse(value2TextBox.Text), "+").ToString();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            caluclatedTextBox.Text = calculator.calculate(Int32.Parse(value1TextBox.Text), Int32.Parse(value2TextBox.Text), "-").ToString();
        }

        private void devideButton_Click(object sender, EventArgs e)
        {
            caluclatedTextBox.Text = calculator.calculate(Int32.Parse(value1TextBox.Text), Int32.Parse(value2TextBox.Text), "/").ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            caluclatedTextBox.Text = calculator.calculate(Int32.Parse(value1TextBox.Text), Int32.Parse(value2TextBox.Text), "*").ToString();
        }
    }
}