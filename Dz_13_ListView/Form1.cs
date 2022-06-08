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
using static System.Windows.Forms.ListViewItem;

namespace Dz_13_ListView
{
    public partial class Form1 : Form
    {  
        public Form1()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FAdd fA = new FAdd();
            fA.ShowDialog(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            StreamReader sr = new StreamReader("Users.txt", Encoding.UTF8);
            string line;

            int flag = 0, flag2 = 0; 
            while ((line = sr.ReadLine()) != null)
            {
                if (flag == 0) listView1.Items.Add(line); 
                else listView1.Items[flag2].SubItems.Add(new ListViewSubItem().Text = line); 
                flag++;

                if (flag == 4)
                {
                    flag = 0;
                    flag2++;
                } 
            }
            sr.Close(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FDell fD = new FDell();
            fD.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FEdit fE = new FEdit();
            fE.ShowDialog();
        }
    }
}
