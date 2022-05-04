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
        //нужны ли проверки на исключения?
        //проверка на существование нового пути? почему миша проверяет старый?
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

        //копирование папочек
        void FoldersCopy(string currentPath, string newPath)
        {
            string newFolder = Path.Combine(newPath,
                listBoxFiles.SelectedItem.ToString());
            Directory.CreateDirectory(newFolder);
            foreach (string oldFile in Directory.GetFiles(currentPath))
            {
                string newFile = Path.Combine(newFolder, Path.GetFileName(oldFile));
                File.Copy(oldFile, newFile, false);
            }
            foreach (string folder in Directory.GetDirectories(currentPath))
            {
                FoldersCopy(folder, Path.Combine(newPath, Path.GetFileName(folder)));
            }
        }

        //переход в папочку по пути, либо открытие файлика (но в папку, где файл, не открывает)
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string forwardTo = textBoxFileWay.Text;
            Open(forwardTo);
        }

        //перемещение папочек и файликов
        private void buttonMove_Click(object sender, EventArgs e)
        {
            SpecialForm moveForm = new SpecialForm();
            moveForm.Text = buttonMove.Text;
            moveForm.ShowDialog();
            if (!moveForm.IsAccepted) return;
           
            string newPathWithoutIteam = moveForm.ReturnTextBox();

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

        //переименовывание папочек и файликов
        private void buttonRename_Click(object sender, EventArgs e)
        {
            SpecialForm renameForm = new SpecialForm();
            renameForm.Text = buttonRename.Text;
            renameForm.ShowDialog();
            if (!renameForm.IsAccepted) return;

            string newName = renameForm.ReturnTextBox();
            
            string ext = (new FileInfo(listBoxFiles.SelectedItem.ToString())).Extension;

            string oldPath = Path.Combine(textBoxFileWay.Text, 
                listBoxFiles.SelectedItem.ToString());
            string newPath = Path.Combine(textBoxFileWay.Text, newName + ext);
            MessageBox.Show(newPath);
            if (Directory.Exists(oldPath))
            {
                Directory.Move(oldPath, newPath);
                ChangeFolder(textBoxFileWay.Text);
            }
            if (File.Exists(oldPath))
            {
                File.Move(oldPath, newPath);
                ChangeFolder(textBoxFileWay.Text);
            }
            
        }

        //копирование папочек и файликов
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            SpecialForm copyForm = new SpecialForm();
            copyForm.Text = buttonCopy.Text;
            copyForm.ShowDialog();
            if (!copyForm.IsAccepted) return;

            string newPath = copyForm.ReturnTextBox();

            string oldPath = Path.Combine(textBoxFileWay.Text, 
                listBoxFiles.SelectedItem.ToString());
            if (File.Exists(oldPath))
            {
                string newFile = Path.Combine(copyForm.ReturnTextBox(),
                listBoxFiles.SelectedItem.ToString());
                File.Copy(oldPath, newFile, false);
                ChangeFolder(newPath);
            }
            else if (Directory.Exists(oldPath))
            {

                FoldersCopy(oldPath, newPath);
                
                ChangeFolder(newPath);
            }
        }

        //создание нового файлика
        private void buttonNewFile_Click(object sender, EventArgs e)
        {
            SpecialForm newFileForm = new SpecialForm();
            newFileForm.Text = buttonNewFile.Text;
            newFileForm.ShowDialog();
            if (!newFileForm.IsAccepted) return;

            string newFileName = newFileForm.ReturnTextBox() + ".txt";
            FileStream newFile = new FileStream(Path.Combine(textBoxFileWay.Text, newFileName), FileMode.CreateNew);
            listBoxFiles.Items.Add(newFileName);
        }

        //создание новой папочки
        private void buttonNewFolder_Click(object sender, EventArgs e)
        {
            SpecialForm newFolderForm = new SpecialForm();
            newFolderForm.Text = buttonNewFolder.Text;
            newFolderForm.ShowDialog();
            if (!newFolderForm.IsAccepted) return;

            string newFolderName = newFolderForm.ReturnTextBox();
            Directory.CreateDirectory(Path.Combine(textBoxFileWay.Text, newFolderName));
            listBoxFiles.Items.Add(newFolderName);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
