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
using System.Threading;
using System.IO;

namespace WindowsFormsApplication1
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

        private void qnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            
        }

        private void output_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[0-9]+$");
            if (!reg.Match(qnum.Text).Success)
            {
                MessageBox.Show("输入有错误，请重新输入!");
            }
            else
            {
                int q = 0;
                generate generate = new generate();
                generate.generatequestion(qnum.Text);
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.ShowDialog();
                Common.outputpath = fd.SelectedPath;
                StreamWriter sw = new StreamWriter(Common.outputpath + "/q.txt", false, Encoding.Default);
                for (q = 0; q < Common.list.Count; q++)
                {
                    sw.WriteLine(Common.list[q]);
                }
                sw.Flush();
                sw.Close();
                if (File.Exists(Common.outputpath + "/q.txt"))
                {
                    MessageBox.Show("创建成功!");
                }
            }
        }
    }
}
