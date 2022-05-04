using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Файловый_менеджер
{
    //называть формочки по-разному для разных действий
    public partial class SpecialForm : Form
    {
        private bool flag;
        public SpecialForm()
        {
            InitializeComponent();
            
        }

        public void buttonOk_Click(object sender, EventArgs e)
        {
            flag = true;
            this.Close();
            
        }

        public string ReturnTextBox()
        {
            return textBoxSpecial.Text;
        }

        public bool IsAccepted => flag;

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxSpecial.Text = "";
            flag = false;
            this.Close();
        }
    }
}
