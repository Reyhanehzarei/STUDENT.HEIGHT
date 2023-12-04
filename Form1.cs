using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_height
{

    public partial class Form1 : Form
    {
        int count = 0, average = 0, sum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = 0, counter = 0, avg;
                int input_num = int.Parse(textBox1.Text);

                while (counter < 20)
                {

                    listBox1.Items.Add(input_num);
                    sum += input_num;
                    counter++;
                    avg = sum / counter;
                    textBox2.Text = avg.ToString();
                    int height = int.Parse(textBox1.Text);
                    count++;
                    if (count > 20)
                    {
                        MessageBox.Show("Max reached");
                    }
                    else
                    {
                        listBox1.Items.Add(height);
                        textBox1.Text = "";

                        sum += height;
                        average = sum / count;
                        textBox2.Text = average.ToString();
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}

