using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Глобальная переменная видна всем методам
        int[] Mas = new int[23];

        // Заполнение исходного массива        
        private void button1_Click(object sender, EventArgs e)
        {
            // Очищаем элемент управления
            listBox1.Items.Clear();
            // Инициализируем класс случайных чисел
            Random rand = new Random();
            // Генерируем и выводим 15 элементов
            for (int i = 0; i < 23; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }
        }

        int summ;
        int number;
        private void button2_Click(object sender, EventArgs e)
        {
            // Очищаем элемент управления
            listBox2.Items.Clear();
            
            listBox2.Items.Add("Все значения c[i] > 3,5");
            // Обрабатываем все элементы
            for (int i = 0; i < 23; i++)
            {
                if (Mas[i] > 3.5)
                {
                summ += Mas[i];
                number++;
                listBox2.Items.Add("Mas[" + Convert.ToString(i) + "] = " + Mas[i].ToString());
                }
            }
            listBox2.Items.Add("Среднее арифметическое:" + Convert.ToString(summ/number));
        }
    }
}