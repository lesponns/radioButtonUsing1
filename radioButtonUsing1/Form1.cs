namespace radioButtonUsing1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void black_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
        }

        private void yellow_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            this.ForeColor = Color.Black;
        }

        private void red_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            this.ForeColor = Color.White;
        }

        private void pink_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
            this.ForeColor = Color.Black;
        }

        private void white_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
        }
    }
}
