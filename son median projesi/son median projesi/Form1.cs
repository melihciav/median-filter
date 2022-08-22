using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace son_median_projesi
{
    public partial class MedianFilter : Form
    {
        public int[] array = new int[10];
        public int[] medianArray = new int[8];
        public int[] geciciDizi = new int[3];
        public MedianFilter()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Random sayi = new Random();
            for (int i = 0; i < 10; i++)
            {
                int num = sayi.Next(10, 100);
                array[i] = num;
                textBox1.Text += " " + array[i].ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            int temp;
            int n = 0;

            for (int i = 0; i < array.Length - 2; i++)
            {
                int a = i + 1;
                int b = a + 1;
                
                geciciDizi[0] = array[i];
                geciciDizi[1] = array[a];
                geciciDizi[2] = array[b];

                for (int m = 0; m < geciciDizi.Length - 1; m++)
                {
                    for (int j = m; j < geciciDizi.Length; j++)
                    {
                        // >(büyük) işareti <(küçük ) olarak değiştirilirse büyükten küçüğe sıralanır
                        if (geciciDizi[m] > geciciDizi[j])
                        {
                            temp = geciciDizi[j];
                            geciciDizi[j] = geciciDizi[m];
                            geciciDizi[m] = temp;
                        }
                    }
                }

                medianArray[n]= geciciDizi[1];
                n = n + 1;
            }
            for (int l = 0; l < 8; l++)
            {
                textBox2.Text += " " + medianArray[l].ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

