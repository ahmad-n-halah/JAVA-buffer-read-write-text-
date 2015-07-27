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

            string str1 = (" ");


            TextWriter tw = new StreamWriter("Ordering1.txt");
            TextWriter tw2 = new StreamWriter("Ordering2.txt");
            TextWriter tw3 = new StreamWriter("Ordering3.txt");
            TextWriter tw4 = new StreamWriter("Ordering4.txt");

            foreach (string line in File.ReadAllLines(textBox1.Text))
            {
                string[] parts = line.Split(' ');
                foreach (string part in parts)
                {
                    str1 = part;


                    tw.WriteLine(str1);

                    Ordering.Items.Add(str1);
                }

            }
            tw.Close();

            foreach (string line in File.ReadAllLines(textBox2.Text))
            {
                string[] parts = line.Split(' ');
                foreach (string part in parts)
                {
                    str1 = part;


                    tw2.WriteLine(str1);

                    Ordering2.Items.Add(str1);
                }

            }
            tw.Close();

            foreach (string line in File.ReadAllLines(textBox4.Text))
            {
                string[] parts = line.Split(' ');
                foreach (string part in parts)
                {
                    str1 = part;


                    tw3.WriteLine(str1);

                    Ordering3.Items.Add(str1);
                }

            }
            tw.Close();

            foreach (string line in File.ReadAllLines(textBox5.Text))
            {
                string[] parts = line.Split(' ');
                foreach (string part in parts)
                {
                    str1 = part;


                    tw4.WriteLine(str1);

                    Ordering4.Items.Add(str1);
                }

            }
            tw.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Ordering.Items.Count-1; i++)
            {
                if (Ordering.Items[i].ToString() == textBox3.Text)
                {
                    VB_Un_Ga.Items.Add(i + 1);
                }

            }

            for (int i = 0; i < Ordering.Items.Count - 1; i++)
            {
                if (Ordering2.Items[i].ToString() == textBox3.Text)
                {
                    listBox4.Items.Add(i + 1);
                }

            }
            for (int i = 0; i < Ordering.Items.Count - 1; i++)
            {
                if (Ordering3.Items[i].ToString() == textBox3.Text)
                {
                    listBox5.Items.Add(i + 1);
                }

            }
            for (int i = 0; i < Ordering.Items.Count - 1; i++)
            {
                if (Ordering4.Items[i].ToString() == textBox3.Text)
                {
                    listBox6.Items.Add(i + 1);
                }

            }
        }
           

        private void button4_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter(@textBox1.Text + textBox3.Text + "Mohammed1.txt");
            for (int i = 0; i < VB_Un_Ga.Items.Count; i++)
            {
                for (int j = 0; j < Convert.ToInt32(VB_Un_Ga.Items[i]); j++)
                {
                    tw.Write("1");
                }
                tw.Write("0");
            }
            tw.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter(@textBox1.Text + textBox3.Text + "mohammed2.txt");
            for (int i = 0; i < VB_Un_Ga.Items.Count; i++)
            {
                string binary = Convert.ToString(Convert.ToInt32(VB_Un_Ga.Items[i]), 2);
                for (int j = 0; j < Convert.ToInt32(VB_Un_Ga.Items[i]) - 1; j++)
                {
                    tw.Write("1");
                }
                tw.Write("0" + ',' + Convert.ToString(Convert.ToInt32(VB_Un_Ga.Items[i]), 2));
            }
            tw.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str1 = (" ");

            TextWriter tw = new StreamWriter("vb.txt");
            for (int i = 0; i < Ordering.Items.Count; i++)
            {
                tw.WriteLine(str1);
                tw.Write(Convert.ToString(Convert.ToInt32(Ordering.Items[i].GetHashCode()), 2));
                
            }
            tw.Close();
           
       
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VB_Un_Ga.Items.Clear();
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            Ordering.Items.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            string str1 = (" ");
            string un;
            
            TextWriter tw = new StreamWriter("unary.txt");

            for (int i = 0; i < Ordering.Items.Count; i++)
            {
                un = Ordering.Items[i].ToString();

                for (int j = 0; j < un.Length; j++)
                { tw.Write("1"); }
                
                
                tw.Write(0);
               
                tw.WriteLine(str1);

            }
            tw.Close();
           
           
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string str1 = (" ");
            foreach (string line in File.ReadAllLines("binary.txt"))
            {
                string[] parts = line.Split(' ');
                foreach (string part in parts)
                {   
                    //offset
                    str1 = part;
                    listBox1.Items.Add(str1);

                }

            }

            foreach (string line in File.ReadAllLines("unary.txt"))
            {
                string[] parts = line.Split(' ');
                foreach (string part in parts)
                {
                    str1 = part;
                    listBox2.Items.Add(str1);
                }

            }

            string length;
            int l;

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
               length= listBox2.Items[i].ToString();
               l = length.Length;
               length = Convert.ToString(l, 2);

               listBox3.Items.Add(length+listBox1.Items[i]);
            }

            TextWriter tw = new StreamWriter("gama.txt");
            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                tw.Write(listBox3.Items[i].ToString());
                tw.WriteLine(str1);
          
            }
            tw.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string str1 = (" ");
            string un;
            TextWriter tw = new StreamWriter("binary.txt");


            for (int i = 0; i < Ordering.Items.Count; i++)
            {
                un=Ordering.Items[i].ToString();

                foreach (char c in un.ToCharArray())
                {
                    un=Convert.ToString(c, 2);
                    tw.Write(un.ToString());
                    tw.WriteLine(str1);
                }
            }
            tw.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox5.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox4.Text = openFileDialog1.FileName.ToString();
            }
        }

      

       

        

   
    }
}