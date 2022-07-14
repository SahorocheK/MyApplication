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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }
        public Password(string windowTitle, string message)
        {
            InitializeComponent();
            this.Text = windowTitle;
            label1.Text = message;
        }

        public static string Show(string windowTitle, string message)
        {
            using(Password inputDlg = new Password(windowTitle, message))
            {
                inputDlg.ShowDialog();
                return inputDlg.textBox1.Text;
            }
        }
    }
}
