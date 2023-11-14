namespace Finals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                flowLayoutPanel2.Height += 10;
                if (flowLayoutPanel2.Height >= 196)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }

            }

            else
            {
                flowLayoutPanel2.Height -= 10;
                if (flowLayoutPanel2.Height <= 67)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 48)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {


                sidebar.Width += 10;
                if (sidebar.Width >= 284)
                {

                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }

            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
    }
}