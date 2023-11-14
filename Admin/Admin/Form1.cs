namespace Admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        private bool isValid()
        {
            if (textBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show(" Enter a valid user name ", " ERROR ");
                return false;
            }
            else if (textBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show(" Enter a valid password ", " ERROR ");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isValid())
            {
                using (SqlConnection conn ==)
            }
        }
    }
}