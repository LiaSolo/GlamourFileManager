using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace Файловый_менеджер
{
    public partial class DownloadForm : Form
    {
        public DownloadForm()
        {
            InitializeComponent();
        }

        private bool flag;

        public void buttonOk_Click(object sender, EventArgs e)
        {
            flag = true;
            this.Close();

        }

        public string ReturnNewName() => textBoxNewName.Text;

        public string ReturnLink() => textBoxLink.Text;

        public bool IsAccepted => flag;

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            flag = false;
            this.Close();
        }
    }
}
