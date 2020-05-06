using System;
using System.Threading;
using System.Windows.Forms;

namespace BookPhotoshop
{
    public partial class Form160 : Page
    {
        public Form160()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread;
            this.Close();
            thread = new Thread(Back);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void Back(object obj)
        {
            Application.Run(new Form159());
        }

        private void Form160_Load(object sender, EventArgs e)
        {
            label2.Text += "\n" + Form146.score + "/27";
        }
    }
}
