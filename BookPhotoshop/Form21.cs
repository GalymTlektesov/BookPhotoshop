using System;
using System.Threading;
using System.Windows.Forms;

namespace BookPhotoshop
{
    public partial class Form21 : Page
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread;
            this.Close();
            thread = new Thread(Open);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void Open(object obj)
        {
            Application.Run(new Form22());
        }

        private void Back(object obj)
        {
            Application.Run(new Form20());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread thread;
            this.Close();
            thread = new Thread(Back);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
