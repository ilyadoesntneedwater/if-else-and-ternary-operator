using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_else_debug
{
    public partial class Form1 : Form
    {
        //readonly byte number = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\ILYA\Desktop\1.txt"))
            {
                label1.Text = "Файл существует";
            }
            else if (File.Exists(@"C:\Users\ILYA\Desktop\2.txt"))
            {
                label1.Text = "И этот тоже";
            }
            else
            {
                label1.Text = "ну сорян бро";
            }





        }


        //{
        //    label1.Text = File.Exists(@"C:\Users\ILYA\Desktop\1.txt") ? checkBox1.Checked ?  "Да, чекнут и 1тхт есть" : "Да, чекнут но файла нет(" : "Нет";
        //}



    }
}
