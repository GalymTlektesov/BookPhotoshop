using System;
using System.Threading;
using System.Windows.Forms;

namespace BookPhotoshop
{
    public partial class Form147 : Page
    {
        public Form147()
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
            Application.Run(new Form148());
        }

        private void Back(object obj)
        {
            Application.Run(new Form146());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread;
            this.Close();
            thread = new Thread(Back);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Form146.score++;
            }
            if (!radioButton3.Checked)
            {
                Form146.score--;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                Form146.score++;
            }
            if (!radioButton6.Checked)
            {
                Form146.score--;
            }
        }
    }
}
