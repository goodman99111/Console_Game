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

namespace AUT
{
    public partial class Form1 : Form
    {
        private ServerObject Server = ServerObject.getInstance();

        public Form1()
        {
            InitializeComponent();
        }

        public void Check()
        {

            string path = @"C:\Users\Gmui\Documents\C#_Projects\AUT\Source\NamePassword.txt";
            bool flag = false;

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] word = line.Split(' ');

                    if (word[0] == tbLogin.Text && word[1] == tbPassword.Text)
                    {
                        MessageBox.Show("correct");
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                    MessageBox.Show("uncorrect");
            }
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            //Check();
            if (tbLogin.Text != null || tbPassword.Text != null)
            {
                Server.SendMessage($"Check {tbLogin.Text} {tbPassword.Text}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Server.Connect();
        }
    }
}
