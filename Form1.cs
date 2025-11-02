namespace tictactoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int player = 2;
        public int turns = 0;
        public int winspl1 = 0;
        public int winspl2 = 0;
        public int draws = 0;

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
            }
            else
            {
                button.Text = "0";
                player++;
                turns++;
            }
        }

        private void A20_MouseCaptureChanged(object sender, EventArgs e)
        {

        }
    }
}
