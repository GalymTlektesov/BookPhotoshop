using System;
using System.Threading;
using System.Windows.Forms;

namespace BookPhotoshop
{
    public partial class Form152 : Page
    {
        public Form152()
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
            Application.Run(new Form153());
        }

        private void Back(object obj)
        {
            Application.Run(new Form151());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread;
            this.Close();
            thread = new Thread(Back);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
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

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                Form146.score++;
            }
            if (!radioButton9.Checked)
            {
                Form146.score--;
            }
        }
    }
}
