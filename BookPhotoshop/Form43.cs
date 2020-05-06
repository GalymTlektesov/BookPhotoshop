using System;
using System.Threading;
using System.Windows.Forms;

namespace BookPhotoshop
{
    public partial class Form43 : Page
    {
        public Form43()
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
            Application.Run(new Form44());
        }

        private void Back(object obj)
        {
            Application.Run(new Form42());
        }

        private void Form43_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread;
            this.Close();
            thread = new Thread(Back);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
