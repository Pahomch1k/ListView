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

namespace Dz_13_ListView
{
    public partial class FEdit : Form
    {
        public FEdit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Заполните поле поиска");
            else if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                MessageBox.Show("Заполните все поля");
            else
            {
                StreamReader sr = new StreamReader("Users.txt", Encoding.UTF8);
                string lineW = "", lineR;

                int flag = 0, flag2 = 0;
                while ((lineR = sr.ReadLine()) != null)
                {
                    if (flag2 == 0)
                    {
                        if (flag == 0 && lineR == textBox1.Text) flag2++;
                        else lineW += lineR + "\n";
                    }

                    flag++;
                    if (flag == 4)
                    {
                        flag = 0;
                        flag2 = 0;
                    }
                }
                sr.Close();

                lineW += textBox2.Text + "\n" + textBox3.Text + "\n" + textBox4.Text + "\n" + textBox5.Text;

                StreamWriter sw = new StreamWriter("Users.txt", false);
                sw.WriteLine(lineW);
                sw.Close();
            }
        }
    }
}
