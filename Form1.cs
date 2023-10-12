namespace colorbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redBox_Click(object sender, EventArgs e)
        {

        }

        private void numericRed_ValueChanged(object sender, EventArgs e)
        {
            int redValue = (int)numericRed.Value;
            int blueValue = 0;
            int greenValue = 0;

            redBox.BackColor = Color.FromArgb(redValue, blueValue, greenValue);
          
        }

        private void numericBlue_ValueChanged(object sender, EventArgs e)
        {
            int redValue = 0;
            int blueValue = (int)numericBlue.Value;
            int greenValue = 0;

            blueBox.BackColor = Color.FromArgb(redValue, blueValue, greenValue);
        }
    }
}