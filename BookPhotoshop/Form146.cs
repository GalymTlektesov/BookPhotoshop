using System;
using System.Threading;
using System.Windows.Forms;

namespace BookPhotoshop
{
    public partial class Form146 : Page
    {
        public static double score;
        public Form146()
        {
            InitializeComponent();
        }

        private void Form146_Load(object sender, EventArgs e)
        {
            score = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread thread;
            this.Close();
            thread = new Thread(Open);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void Open(object obj)
        {
            Application.Run(new Form147());
        }

        private void Back(object obj)
        {
            Application.Run(new Form145());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread;
            this.Close();
            thread = new Thread(Back);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                score++;
            }
            if (!radioButton1.Checked)
            {
                score--;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                score++;
            }
            if (!radioButton7.Checked)
            {
                score--;
            }
        }
    }
}
