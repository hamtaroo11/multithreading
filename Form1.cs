using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace _320210097_project1_question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rdm = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Circle);
            t.Start();
            for (int i = 0; i <200; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Color.Red, 3), new Rectangle(rdm.Next(0,800), rdm.Next(0,800), 10, 10));
                Thread.Sleep(50);
            }
            t.Join();
            MessageBox.Show("finished");

        }
        public void Circle()
        {
            for (int i = 0; i <200; i++)
            {
                CreateGraphics().DrawEllipse(new Pen(Color.Black, 3), new Rectangle(rdm.Next(0,800), rdm.Next(0,800), 10, 10));
                Thread.Sleep(50);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
