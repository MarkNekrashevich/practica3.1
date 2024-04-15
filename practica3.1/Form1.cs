using System;
using System.Linq;
using System.Windows.Forms;

namespace practica3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] elements = textBox1.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int[] array = new int[elements.Length];
                for (int i = 0; i < elements.Length; i++)
                {
                    if (!int.TryParse(elements[i], out array[i]))
                    {
                        throw new FormatException();
                    }
                }
                var oddNumbers = array.Where((num, index) => num % 2 != 0).OrderBy(num => num);
                var evenNumbers = array.Where((num, index) => num % 2 == 0).OrderByDescending(num => num);
                textBox2.Clear();
                foreach (var num in oddNumbers)
                {
                    textBox2.Text += num + " ";
                }
                foreach (var num in evenNumbers)
                {
                    textBox2.Text += num + " ";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: Введите числовые значения в поле для ввода.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
