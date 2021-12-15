using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5thTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int xvalue, yvalue;
        string xstr, ystr;
        List<int> xlist = new List<int>();
        List<int> ylist = new List<int>();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool xInput = int.TryParse(textBox1.Text, out xvalue);

            if (!xInput || xvalue < 0 || xvalue > 9999)
            {
                // MessageBox.Show("Ignorēt šo paziņojumu.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xint = 0;
            int yint = 0;
            xint = (int)xvalue;
            yint = (int)yvalue;
            xlist.Add(xint);
            label1.Text = xvalue.ToString();
            ylist.Add(yint);
            label4.Text = yvalue.ToString();

            textBox1.Text = "";
            textBox2.Text = "";

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bool yInput = int.TryParse(textBox2.Text, out yvalue);

            if (!yInput || yvalue < 0 || yvalue > 9999)
            {
                // 
            }
        }
        
          private void button3_Click(object sender, EventArgs e)
        {
            foreach (int x in xlist)
            {
                xstr = xvalue.ToString();
                listBox1.DataSource = xlist;
                
            }

            foreach (int y in ylist)
            {
                ystr = yvalue.ToString();
                listBox2.DataSource = ylist;
            }
        }

        private Font fnt = new Font("Arial", 10);
        private void button2_Click(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int[] xarray = xlist.ToArray();
            int[] yarray = ylist.ToArray();
            g.DrawLine(System.Drawing.Pens.Red, 10, 10, 20, 20);
        }

        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }















        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
