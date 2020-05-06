using System;
using System.Threading;
using System.Windows.Forms;

namespace BookPhotoshop
{
    public partial class Form149 : Page
    {
        public Form149()
        {
            InitializeComponent();
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
            Application.Run(new Form150());
        }

        private void Back(object obj)
        {
            Application.Run(new Form148());
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
                Form146.score += 0.5;
            }
            if (!radioButton1.Checked)
            {
                Form146.score -= 0.5;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Form146.score += 0.5;
            }
            if (!radioButton3.Checked)
            {
                Form146.score -= 0.5;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                Form146.score++;
            }
            if (!radioButton5.Checked)
            {
                Form146.score--;
            }
        }
    }
}
