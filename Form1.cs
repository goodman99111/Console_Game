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
using AUT.ServiceReference1;

namespace AUT
{
    public partial class Form1 : Form
    {
        //private ServerObject Server = ServerObject.getInstance();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new AuthorizationClient();

            Thread ServerStatus = new Thread(CheckServerStatus);
            ServerStatus.IsBackground = true;
            ServerStatus.Start();
        }

        private void CheckServerStatus()
        {
            while(true)
            {
                bool status = true;
                
                //Если сервер работает
                while (status)
                {
                    try
                    {
                        client.ServerStatus();
                        Thread.Sleep(250);
                    }
                    catch
                    {
                        status = false;
                        MessageBox.Show("Сервер недоступен. Нажмите ОК для переподключения...");
                    }
                }

                //Если сервер не работает
                while (!status)
                {
                    try
                    {
                        client.ServerStatus();
                        status = true;
                        MessageBox.Show("Подключение восстановлено");

                    }
                    catch
                    {
                        MessageBox.Show("Сервер недоступен. Попытка переподключения...");
                        Thread.Sleep(250);
                    }
                }
            }
            
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            var client = new AuthorizationClient();
            var result = client.Authorization(tbLogin.Text, tbPassword.Text);
            if (result)
                MessageBox.Show("Удачно");
            else
                MessageBox.Show("Неудачно");
            //Check();
            /*
            if (tbLogin.Text != null || tbPassword.Text != null)
            {
                Server.SendMessage($"Check {tbLogin.Text} {tbPassword.Text}");
            }
            */
        }

<<<<<<< HEAD
        

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            var result = client.AvailabilityLogin(tbLogin.Text);
            if(result)
            {
                StatusLogin.ForeColor = Color.Green;
                StatusLogin.Text = "Ник доступен";
                btConnect.Enabled = true;
            }
            else
            {
                StatusLogin.ForeColor = Color.Red;
                StatusLogin.Text = "Ник занят";
                btConnect.Enabled = false;
            }

=======
        private void Form1_Load(object sender, EventArgs e)
        {
            //Server.Connect();
            
>>>>>>> parent of db1d6b9... Добавлена проверка на доступность сервера
        }
    }
}
