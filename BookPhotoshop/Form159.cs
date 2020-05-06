using System;
using System.Threading;
using System.Windows.Forms;

namespace BookPhotoshop
{
    public partial class Form159 : Page
    {
        public Form159()
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
            Application.Run(new Form160());
        }

        private void Back(object obj)
        {
            Application.Run(new Form158());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread;
            this.Close();
            thread = new Thread(Back);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                Form146.score++;
            }
            if (!radioButton7.Checked)
            {
                Form146.score--;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Form146.score++;
            }
            if (!radioButton4.Checked)
            {
                Form146.score--;
            }
        }
    }
}
