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
        
        //переход в следующую папочку
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

        //открытие папочек и файликов
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

        //перемещение папочек и файликов
        private void buttonMove_Click(object sender, EventArgs e)
        {
            SpecialForm newForm = new SpecialForm();
            newForm.ShowDialog();
            if (!newForm.IsAccepted()) return;
           
            string newPathWithoutIteam = newForm.ReturnTextBox();
            MessageBox.Show(newPathWithoutIteam);

            string oldPath = Path.Combine(textBoxFileWay.Text, listBoxFiles.SelectedItem.ToString());
            if (File.Exists(oldPath))
            {
                string newPath = Path.Combine(newPathWithoutIteam, listBoxFiles.SelectedItem.ToString());
                File.Move(oldPath, newPath);
                ChangeFolder(newPathWithoutIteam);
            }
            else if (Directory.Exists(oldPath))
            {
                string newPath = Path.Combine(newPathWithoutIteam, listBoxFiles.SelectedItem.ToString());
                try
                {
                    Directory.Move(oldPath, newPath);
                }
                catch (Exception ex)
                {

                }
                ChangeFolder(newPathWithoutIteam);
            }
        }
    }
}
