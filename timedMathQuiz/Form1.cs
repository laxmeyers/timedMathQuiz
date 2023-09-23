namespace timedMathQuiz
{
    public partial class Form1 : Form
    {
        //Create a Random object called randomizer
        //to generate random numbers
        Random randomizer = new Random();

        //variables for the addition problem
        int addend1;
        int addend2;

        int minuend;
        int subtrahend;

        int multiend;
        int multiplier;

        int dividend;
        int divisor;

        public void StartQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            sum.Value = 0;
            //for the subtraction
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);

            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();

            difference.Value = 0;
            //for the multiplication
            multiend = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);

            timesLeftLabel.Text = multiend.ToString();
            timesRightLabel.Text = multiplier.ToString();

            product.Value = 0;
            //for the division
            dividend = randomizer.Next(2, 11);
            divisor = randomizer.Next(2, 11);

            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();

            quotient.Value = 0;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void product_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartQuiz();
            startButton.Enabled = false;
        }
    }
}