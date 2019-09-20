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
    public partial class Form1 : Form
    {
        //ArrayList shizi = new ArrayList();
        String[] shizi = new String[10000];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                textBox1.Text = "";
                MessageBox.Show("未输入生成计算题数量！");
            }                
            else
            {
                textBox1.Text = "";
                int num;
                generate gen = new generate();
                num = Convert.ToInt32(textBox2.Text);
                shizi = gen.fun(num);
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
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {          
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)          
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
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
                MessageBox.Show("计算题导出成功！");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
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
    }
}
