using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculation
{
    public partial class From1 : Form
    {
        //ArrayList shizi = new ArrayList();
        String[] shizi = new String[10000];
        String[] shizi1 = new String[10000];
        String[] shizi2 = new String[10000];
        public From1()
        {
            InitializeComponent();
        }
       public void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox1.Text = "";
                MessageBox.Show("未输入生成计算题数量！");
            }
            else
            {
                textBox1.Text = "";
                int num;
                Makequality gen = new Makequality();
                Makefour m = new Makefour();
                num = Convert.ToInt32(textBox2.Text);
                int n1 = num / 2;
                int n2 = num / 2;
                shizi1 = gen.fun3(n1);
                shizi2 = m.fun4(n2);
                shizi1.CopyTo(shizi, 0);
                shizi2.CopyTo(shizi, shizi1.Length);
                if (checkBox1.CheckState == CheckState.Checked)
                    for (int i = 0; i < num; i++)
                        textBox1.Text = textBox1.Text + (i + 1).ToString() + ": " + shizi[i] + Environment.NewLine;
                else
                {
                    for (int i = 0; i < num; i++)
                    {
                        String[] str = shizi[i].Split('=');
                        textBox1.Text = textBox1.Text + (i + 1).ToString() + ": " + str[0] + '=' + Environment.NewLine;
                    }
                }

            }                  
                
        }
       public void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {          
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)          
                e.Handled = true;
        }

       public void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("无计算题，无法导出！");
            else
            {
                FileStream fs = new FileStream(".\\text.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(textBox1.Text);
                sw.Flush();
                sw.Close();
                fs.Close();
                MessageBox.Show("您的四则运算题目生成成功并导出，请注意查收计算题导出成功！");
            }
        }

       public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try {
                textBox1.Text = "";
                int num;
                num = Convert.ToInt32(textBox2.Text);
                if (checkBox1.CheckState == CheckState.Checked)
                    for (int i = 0; i < num; i++)
                        textBox1.Text = textBox1.Text + (i + 1).ToString() + ": " + shizi[i] + Environment.NewLine;
                else
                {
                    for (int i = 0; i < num; i++)
                    {
                        String[] str = shizi[i].Split('=');
                        textBox1.Text = textBox1.Text + (i + 1).ToString() + ": " + str[0] + '=' + Environment.NewLine;
                    }
                }
            }
            catch (Exception ) {
                MessageBox.Show("请先输入题目");
            }

        }

       public void button3_Click(object sender, EventArgs e)
        {
        }

       public void From1_Load(object sender, EventArgs e)
        {

        }
    }
}
