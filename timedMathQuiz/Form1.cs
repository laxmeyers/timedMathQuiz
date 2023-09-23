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
        //variables for the subtraction problem
        int minuend;
        int subtrahend;
        //variables for the multiplication problem
        int multiend;
        int multiplier;
        //variables for the division problem
        int dividend;
        int divisor;
        //for the clock
        int timeLeft;

        //showing current date

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

            //start the timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();

        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiend * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }

        public Form1()
        {
            InitializeComponent();
            currentDate.Text = DateTime.Now.ToString();

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                    "Congrats!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft -= 1;
                timeLabel.Text = timeLeft + "seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiend * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {
            currentDate.Text = DateTime.Now.ToString();
        }
    }
}