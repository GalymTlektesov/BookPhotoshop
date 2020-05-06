using System;
using System.Threading;
using System.Windows.Forms;

namespace BookPhotoshop
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread;
            this.Close();
            thread = new Thread(Back);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void Back(object obj)
        {
            Application.Run(new Form5());
        }

        private void Open(object obj)
        {
            Application.Run(new Form7());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread;
            this.Close();
            thread = new Thread(Open);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
