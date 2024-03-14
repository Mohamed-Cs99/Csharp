using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archive
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                fileBox.Text = of.FileName;
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("ملازم");
            comboBox1.Items.Add("ملازم اول");
            comboBox1.Items.Add("نقيب");
            comboBox1.Items.Add("رائد");
            comboBox1.Items.Add("مقدم");
            comboBox1.Items.Add("عقيد");
            comboBox1.Items.Add("عميد");
            comboBox1.Items.Add("لـواء");
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 lgForm =new Form1();
            lgForm.ShowDialog();
            //this.Close();
        }
    }
}

