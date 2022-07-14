using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Мои_проекты
{
    public partial class MenuApps : Form
    {
        public MenuApps()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                string password = Password.Show("Аутентификация", "Введите пароль");

                if(password != "qwerty45")
                {
                    MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    MessageBox.Show("Пароль неверный", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                }
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Form frm = new Calculator();
            frm.Show();
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
