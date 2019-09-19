using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

namespace Calculator
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Calculate calculate = new Calculate();
        private void button_Click(object sender, EventArgs e)
        {
            int n;
            String input_string = textBox1.Text;
            Regex regex = new Regex("^[0-9]*$");
            if (regex.IsMatch(input_string))
            {
                n = int.Parse(input_string);
                if (n <= 0)
                {
                    MessageBox.Show("请输入大于0的数字！");
                }
                else
                {
                    calculate.makeExercises(n);//生成算式列表
                    MessageBox.Show("题目已经生成！");
                }

            }
            else
            {
                MessageBox.Show("请输入大于0的数字！");
            }
        }
    }

}
