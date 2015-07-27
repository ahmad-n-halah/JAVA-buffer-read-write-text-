using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;


namespace tokens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) 
            {
                textBox1.Text = openFileDialog1.FileName.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
            string str1 = "";
            
            
            TextWriter tw = new StreamWriter(@textBox1.Text + " " + "Fixed.txt");
            foreach (string line in File.ReadAllLines(textBox1.Text))
            {
                string[] parts = line.Split(' ');
                      foreach (string part in parts)
                      {
                          str1 = part.ToString();


                          tw.Write(str1 + "               ");
                          Fixed.Items.Add(str1);
                          
                    
                }
               
            }
            tw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Fixed.Items.Count; i++)
	{
	    if (Fixed.Items[i].ToString() == textBox3.Text)
	    {
		Vb.Items.Add(i+1);
	    }
        
    }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*TextWriter tw = new StreamWriter(@textBox1.Text + textBox3.Text + "unary.txt");
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                for (int j = 0; j < Convert.ToInt32(listBox2.Items[i]); j++)
                {
                    tw.Write("1");
                }
                tw.Write("0");
            }
            tw.Close();*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*TextWriter tw = new StreamWriter(@textBox1.Text + textBox3.Text + "gama.txt");
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                string binary = Convert.ToString(Convert.ToInt32(listBox2.Items[i]), 2);
                for (int j = 0; j < Convert.ToInt32(listBox2.Items[i])-1; j++)
                {
                    tw.Write("1");
                }
                tw.Write("0" +','+ Convert.ToString(Convert.ToInt32(listBox2.Items[i]), 2));
            }
            tw.Close();*/

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter(@textBox1.Text + textBox3.Text + "vb.txt");
            for (int i = 0; i < Vb.Items.Count; i++)
            {
                tw.Write(Convert.ToString(Convert.ToInt32(Vb.Items[i]), 2));
            }
            tw.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Vb.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }       
            
           
        
    }
}
