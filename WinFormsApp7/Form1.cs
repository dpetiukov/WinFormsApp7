namespace WinFormsApp7;

public partial class Form1 : Form
{
    private System.Windows.Forms.Timer timer;
    private int timeLeft;
    private Random random = new Random();
    private int guessNumber;
    public Form1()
    {
        InitializeComponent();
        timer = new System.Windows.Forms.Timer();
        timer.Interval = 1000;
        timer.Tick += Timer_Tick;
        buttonGuess.Enabled = false;
        textBoxNumber.Enabled = false;
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        timeLeft = timeLeft - 1;
        labelTimeLeft.Text = $"{timeLeft.ToString()} seconds left";
        if (timeLeft <= 0)
        {
            timer.Stop();
            MessageBox.Show("Час вийшов! Спробуйте ще раз!");
        }
    }

    private void buttonStart_Click(object sender, EventArgs e)
    {
        guessNumber = random.Next(1, 101);
        timeLeft = 10;
        labelTimeLeft.Text = $"{timeLeft.ToString()} seconds left";
        timer.Start();
        buttonStart.Enabled = false;
        buttonGuess.Enabled = true;
        textBoxNumber.Enabled = true;
    }

    private void buttonGuess_Click(object sender, EventArgs e)
    {
        buttonStart.Enabled = true;
        buttonGuess.Enabled = false;
        textBoxNumber.Enabled = false;
        int textBoxNumberInt;
        if (int.TryParse(textBoxNumber.Text, out textBoxNumberInt))
        {
            if (textBoxNumberInt == guessNumber)
            {
                timer.Stop();
                MessageBox.Show("Вітаємо! Ви вгадали число!");
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Неправильно! Правильне число було: " + guessNumber);
            }
        }
        else
        {
            timer.Stop();
            MessageBox.Show("Введіть ціле число!");
        }
        textBoxNumber.Clear();
        labelTimeLeft.Text = String.Empty;
    }
}
