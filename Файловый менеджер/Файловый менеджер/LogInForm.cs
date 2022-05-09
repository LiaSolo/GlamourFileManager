using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Файловый_менеджер
{
    public partial class LogInForm : Form
    {
        Authorization authorization;
        public LogInForm()
        {
            InitializeComponent();
            authorization = new Authorization();
            textBoxPassword.PasswordChar = '♡';
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream configs = new FileStream("configs.txt", FileMode.OpenOrCreate))
                {
                    authorization = (Authorization)formatter.Deserialize(configs);
                }
            }
            catch (Exception ex) { }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            authorization.userName = textBoxUserName.Text;
            authorization.password = textBoxPassword.Text;
            this.Hide();
            new MainForm().Show();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string inputUserName = textBoxUserName.Text;
            string inputPassword = textBoxPassword.Text;

            if (inputPassword == authorization.password && inputUserName == authorization.userName)
            {
                this.Hide();
                new MainForm().Show();

                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream configs = new FileStream("configs.txt", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(configs, authorization);
                }
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль");
                textBoxUserName.Text = "";
                textBoxPassword.Text = "";
            }
        }
    }
}
