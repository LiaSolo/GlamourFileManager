using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;




namespace Файловый_менеджер
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DriveInfo[] drives = DriveInfo.GetDrives();
            listBoxFiles.Items.AddRange(drives);
        }

        //двойное нажатие на элементы листбокса
        private void listBoxFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxFiles.SelectedItem == null) return;
            string currentPath = Path.Combine(textBoxFileWay.Text,
                listBoxFiles.SelectedItem.ToString());
            Open(currentPath);
        }
        
        //открытие следующей папочки
        private void ChangeFolder(string currentPath)
        {            
            string[] foldersAndFiles = new DirectoryInfo(currentPath).EnumerateFiles().
                  Where(files => (files.Attributes & FileAttributes.Hidden) == 0).
                  Select(files => files.Name).

                  Union(new DirectoryInfo(currentPath).EnumerateDirectories().
                  Where(folders => (folders.Attributes & FileAttributes.Hidden) == 0).
                  Select(folders => folders.Name)).ToArray();
            textBoxFileWay.Text = currentPath;
            listBoxFiles.Items.Clear();
            listBoxFiles.Items.AddRange(foldersAndFiles);
        }

        private void Open(string currentPath)
        {
            if (File.Exists(currentPath))
            {
                Process.Start(new ProcessStartInfo(currentPath) { UseShellExecute = true });
                return;
            }

            if (Directory.Exists(currentPath)) 
            {
                ChangeFolder(currentPath);
            }
            else 
            {
                MessageBox.Show("Нужная папочка не существует :(");
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string forwardTo = textBoxFileWay.Text;
            Open(forwardTo);
        }
    }
}
