namespace OOP20
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonANS_Click(object sender, EventArgs e)
        {
            try
            {
                double X = double.Parse(textBoxX.Text);
                double Y = double.Parse(textBoxY.Text);

                FuzzyNumber fuzzyNumber = new FuzzyNumber(X, Y);
                FuzzyNumber inverseFuzzyNumber = fuzzyNumber.Inverse();

                label_ans.Text = $"[{inverseFuzzyNumber.X}; {inverseFuzzyNumber.Y}]";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введіть данні коректно.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Неможе бути 0.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
