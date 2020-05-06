using System;
using System.Threading;
using System.Windows.Forms;

namespace BookPhotoshop
{
    public partial class Form157 : Page
    {
        public Form157()
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
            Application.Run(new Form158());
        }

        private void Back(object obj)
        {
            Application.Run(new Form156());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread;
            this.Close();
            thread = new Thread(Back);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Form146.score++;
            }
            if (!radioButton2.Checked)
            {
                Form146.score--;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                Form146.score += 0.5;
            }
            if (!radioButton8.Checked)
            {
                Form146.score -= 0.5;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                Form146.score += 0.5;
            }
            if (!radioButton7.Checked)
            {
                Form146.score -= 0.5;
            }
        }
    }
}
