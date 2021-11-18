using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Справочник
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))    // Text - сво-во
            {
                MessageBox.Show("Данные некорректны. \n" + "Необходимо заполнить оба поля", "Справочник", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string d = textBox1.Text;
                string text = File.ReadAllText("D:\\Новая папка\\Справочник.txt");
                using (StreamReader sr = new StreamReader("D:\\Новая папка\\Справочник.txt"))
                {
                    if (text.Contains (d))
                    {
                        MessageBox.Show("Такой контакт уже внесен в список");
                    }
                else
                    {
                        sr.Close();
                        System.IO.StreamWriter writer = new System.IO.StreamWriter("D:\\Новая папка\\Справочник.txt", true);

                        writer.WriteLine(textBox1.Text);
                        writer.WriteLine(textBox2.Text);
                        writer.Close();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        MessageBox.Show("Сохранен");

                    }
                }
            }
        }
    }
}
