namespace Archive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "admin" && PassBox.Text == "admin123")
            {
                this.Hide();
                MainForm mf = new MainForm();
                mf.ShowDialog();
               // this.Close();

            }
            else
            {
                MessageBox.Show("Error in userName or password!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            PassBox.Text = ""; 
        }
    }
}
