using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int k;
        Control[] num;
        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[k];
            for (int i = 0; i < k; i++)
            {
                int x = Convert.ToInt32(num[i].Text);
                a[i] = x;
            }
            int n, lastN = a[0], count = 0; //переменные
            for (int i = 1; i < k; i++)
            {
                n = a[i]; //Очередной элемент массива
                if (n == lastN)
                    count++;  //Увеличивает count на 1
                lastN = n;
            }
            textBox2.Text = Convert.ToString(count); //Вывод count
            chart1.Series[0].Points.Add(Convert.ToDouble(count), Convert.ToDouble(textBox2.T\][ext));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            k = Convert.ToInt32(textBox1.Text);
            num = new Control[k];
            for (int i = 0; i < k; i++)
            {
                num[i] = new TextBox() { Name = i.ToString(), Location = new Point(36, (i + 1) * 46), Text = "Введите значение " + i.ToString(), Size = textBox1.Size };
                this.Controls.Add(num[i]);
            }
            for (int i = 1; i <= k; i++) {
                this.Controls.Add(new TextBox() { Name = i.ToString(), Location = new Point(36, 46 * i), Text = "I lave Lysya!", Size = textBox1.Size});
            }
      }
  }
}
