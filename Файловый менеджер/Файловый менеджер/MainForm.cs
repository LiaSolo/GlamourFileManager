using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;



namespace Файловый_менеджер
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeStyle();

            DriveInfo[] drives = DriveInfo.GetDrives();
            listBoxFiles.Items.AddRange(drives);

            ToolTip tips = new ToolTip();
            tips.ShowAlways = true;
            tips.SetToolTip(this.buttonArchieve, "Архивировать");
            tips.SetToolTip(this.buttonCopy, "Копировать");
            tips.SetToolTip(this.buttonDelete, "Удалить");
            tips.SetToolTip(this.buttonMove, "Переместить");
            tips.SetToolTip(this.buttonNewFile, "Новый файлик");
            tips.SetToolTip(this.buttonNewFolder, "Новая папочка");
            tips.SetToolTip(this.buttonRename, "Переименовать");
            tips.SetToolTip(this.buttonSearch, "Найти");
            tips.SetToolTip(this.buttonBack, "Назад");
            tips.SetToolTip(this.buttonDownload, "Скачать");
            tips.SetToolTip(this.buttonCancelDownload, "Отменить скачивание");
            tips.SetToolTip(this.buttonSearchRegex, "Найти совпадения");
        }

        #region красота
        private void InitializeStyle()
        {
            comboBoxFont.Text = Settings.GetCurrent().currentFont;
            comboBoxFont_SelectedIndexChanged(comboBoxFont, null);

            comboBoxTheme.Text = Settings.GetCurrent().currentTheme;
            comboBoxTheme_SelectedIndexChanged(comboBoxTheme, null);

            comboBoxTextSize.Text = Settings.GetCurrent().currentTextSize.ToString();
            comboBoxTextSize_SelectedIndexChanged(comboBoxTextSize, null);
        }

        private void ChangeTheme(int red, int green, int blue, Color colorText)
        {
            buttonSearch.BackColor = Color.FromArgb(red, green, blue);
            buttonSearchRegex.BackColor = Color.FromArgb(red, green, blue);
            buttonRename.BackColor = Color.FromArgb(red, green, blue);
            buttonNewFolder.BackColor = Color.FromArgb(red, green, blue);
            buttonNewFile.BackColor = Color.FromArgb(red, green, blue);
            buttonMove.BackColor = Color.FromArgb(red, green, blue);
            buttonDelete.BackColor = Color.FromArgb(red, green, blue);
            buttonCopy.BackColor = Color.FromArgb(red, green, blue);
            buttonArchieve.BackColor = Color.FromArgb(red, green, blue);
            buttonBack.BackColor = Color.FromArgb(red, green, blue);
            buttonDownload.BackColor = Color.FromArgb(red, green, blue);
            buttonCancelDownload.BackColor = Color.FromArgb(red, green, blue);

            listBoxFiles.BackColor = Color.FromArgb(red, green, blue);
            textBoxFileWay.BackColor = Color.FromArgb(red, green, blue);
            comboBoxFont.BackColor = Color.FromArgb(red, green, blue);
            comboBoxTextSize.BackColor = Color.FromArgb(red, green, blue);
            comboBoxTheme.BackColor = Color.FromArgb(red, green, blue);
            labelTheme.BackColor = Color.FromArgb(red, green, blue);
            labelFont.BackColor = Color.FromArgb(red, green, blue);
            labelTextSize.BackColor = Color.FromArgb(red, green, blue);

            listBoxFiles.ForeColor = colorText;
            textBoxFileWay.ForeColor = colorText;
            comboBoxFont.ForeColor = colorText;
            comboBoxTextSize.ForeColor = colorText;
            comboBoxTheme.ForeColor = colorText;
            labelTextSize.ForeColor = colorText;
            labelFont.ForeColor = colorText;
            labelTheme.ForeColor = colorText;
        }

        private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.GetCurrent().currentTheme = ((ComboBox)sender).Text;
            switch (((ComboBox)sender).Text)
            {
                case "Розовый минимализм":
                    this.BackgroundImage = global::Файловый_менеджер.Properties.Resources.светло_розовый_фон;
                    ChangeTheme(255, 128, 128, Color.White);
                    break;
                case "Ночная птица":
                    this.BackgroundImage = global::Файловый_менеджер.Properties.Resources.фон_чёрные_перья;
                    ChangeTheme(107, 97, 103, Color.White);
                    break;
                case "Белый пушистик":
                    this.BackgroundImage = global::Файловый_менеджер.Properties.Resources.белый_мех;
                    ChangeTheme(255, 255, 255, Color.Black);
                    break;
                case "Жемчуг":
                    this.BackgroundImage = global::Файловый_менеджер.Properties.Resources.жемчужный_фон;
                    ChangeTheme(246, 224, 200, Color.Black);
                    break;
                case "Сверкающий алмаз":
                    this.BackgroundImage = global::Файловый_менеджер.Properties.Resources.алмазный_фон;
                    ChangeTheme(220, 198, 249, Color.Black);
                    break;
            }
        }

        //смена шрифта
        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newFont = ((ComboBox)sender).Text;
            Settings.GetCurrent().currentFont = newFont;
            float currentTextSize = Settings.GetCurrent().currentTextSize;

            textBoxFileWay.Font = new Font(newFont, currentTextSize);
            listBoxFiles.Font = new Font(newFont, currentTextSize);
            comboBoxFont.Font = new Font(newFont, currentTextSize);
            comboBoxTextSize.Font = new Font(newFont, currentTextSize);
            comboBoxTheme.Font = new Font(newFont, currentTextSize);
            labelTheme.Font = new Font(newFont, currentTextSize);
            labelFont.Font = new Font(newFont, currentTextSize);
            labelTextSize.Font = new Font(newFont, currentTextSize);
        }

        //смена размера текста
        private void comboBoxTextSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.GetCurrent().currentTextSize = float.Parse(((ComboBox)sender).Text);
            string currentFont = comboBoxFont.Text;
            float newTextSize = Settings.GetCurrent().currentTextSize;

            textBoxFileWay.Font = new Font(currentFont, newTextSize);
            listBoxFiles.Font = new Font(currentFont, newTextSize);
            comboBoxFont.Font = new Font(currentFont, newTextSize);
            comboBoxTextSize.Font = new Font(currentFont, newTextSize);
            comboBoxTheme.Font = new Font(currentFont, newTextSize);
            labelTheme.Font = new Font(currentFont, newTextSize);
            labelFont.Font = new Font(currentFont, newTextSize);
            labelTextSize.Font = new Font(currentFont, newTextSize);
        }

        #endregion

        #region кнопочки действий

        //двойное нажатие на элементы листбокса
        private void listBoxFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxFiles.SelectedItem == null) return;
            string currentPath = Path.Combine(textBoxFileWay.Text,
                listBoxFiles.SelectedItem.ToString());
            Open(currentPath);
        }

        //переход в новую (указанную) папочку
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
            else if (Directory.Exists(currentPath))
            {
                ChangeFolder(currentPath);
            }
            else
            {
                MessageBox.Show("Нужная папочка или файлик не существует :(");
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

        //переход в папочку по пути, либо открытие файлика (но в папку, где файл, не переходит)
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string forwardTo = textBoxFileWay.Text;
            Open(forwardTo);
        }

        //перемещение папочек и файликов
        private void buttonMove_Click(object sender, EventArgs e)
        {
            SpecialForm moveForm = new SpecialForm();
            moveForm.Text = "Переместить";
            moveForm.ShowDialog();
            if (!moveForm.IsAccepted) return;

            string newPathWithoutIteam = moveForm.ReturnTextBox();
            if (!Directory.Exists(newPathWithoutIteam))
            {
                MessageBox.Show("Нужная папочка не существует :(");
                return;
            }

            string oldPath = Path.Combine(textBoxFileWay.Text, listBoxFiles.SelectedItem.ToString());
            if (File.Exists(oldPath))
            {
                string newPath = Path.Combine(newPathWithoutIteam, listBoxFiles.SelectedItem.ToString());
                File.Move(oldPath, newPath);
            }
            else //if (Directory.Exists(oldPath))
            {
                string newPath = Path.Combine(newPathWithoutIteam, listBoxFiles.SelectedItem.ToString());
                Directory.Move(oldPath, newPath);

            }
            ChangeFolder(newPathWithoutIteam);
        }

        //переименовывание папочек и файликов
        private void buttonRename_Click(object sender, EventArgs e)
        {
            SpecialForm renameForm = new SpecialForm();
            renameForm.Text = "Переименовать";
            renameForm.ShowDialog();
            if (!renameForm.IsAccepted) return;

            string newName = renameForm.ReturnTextBox();

            string ext = (new FileInfo(listBoxFiles.SelectedItem.ToString())).Extension;

            string oldPath = Path.Combine(textBoxFileWay.Text,
                listBoxFiles.SelectedItem.ToString());
            string newPath = Path.Combine(textBoxFileWay.Text, newName + ext);

            if (Directory.Exists(oldPath))
            {
                Directory.Move(oldPath, newPath);
            }
            else //if (File.Exists(oldPath))
            {
                File.Move(oldPath, newPath);
            }
            ChangeFolder(textBoxFileWay.Text);
        }

        //копирование папочек и файликов
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            SpecialForm copyForm = new SpecialForm();
            copyForm.Text = "Копировать";
            copyForm.ShowDialog();
            if (!copyForm.IsAccepted) return;

            string newPath = copyForm.ReturnTextBox();

            if (!Directory.Exists(newPath))
            {
                MessageBox.Show("Нужная папочка не существует :(");
                return;
            }

            string oldPath = Path.Combine(textBoxFileWay.Text,
                listBoxFiles.SelectedItem.ToString());
            if (File.Exists(oldPath))
            {
                string newFile = Path.Combine(copyForm.ReturnTextBox(),
                listBoxFiles.SelectedItem.ToString());
                File.Copy(oldPath, newFile, false);
            }
            else //if (Directory.Exists(oldPath))
            {
                FoldersCopy(oldPath, newPath);
            }
            ChangeFolder(newPath);
        }

        //создание нового файлика
        private void buttonNewFile_Click(object sender, EventArgs e)
        {
            SpecialForm newFileForm = new SpecialForm();
            newFileForm.Text = "Новый файлик";
            newFileForm.ShowDialog();
            if (!newFileForm.IsAccepted) return;

            string newFileName = newFileForm.ReturnTextBox() + ".txt";
            using (FileStream newFile = new FileStream(Path.Combine(textBoxFileWay.Text, newFileName), FileMode.CreateNew)) ;
            listBoxFiles.Items.Add(newFileName);
        }

        //создание новой папочки
        private void buttonNewFolder_Click(object sender, EventArgs e)
        {
            SpecialForm newFolderForm = new SpecialForm();
            newFolderForm.Text = "Новая папочка";
            newFolderForm.ShowDialog();
            if (!newFolderForm.IsAccepted) return;

            string newFolderName = newFolderForm.ReturnTextBox();
            Directory.CreateDirectory(Path.Combine(textBoxFileWay.Text, newFolderName));
            listBoxFiles.Items.Add(newFolderName);
        }

        //удаление файликов и папочек
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string iteamName;
            if (listBoxFiles.SelectedItem != null)
            {
                iteamName = Path.Combine(textBoxFileWay.Text, listBoxFiles.SelectedItem.ToString());
            }
            //если ничего не выбрано
            else
            {
                MessageBox.Show("Чтобы что-то удалить, надо это что-то сначала выбрать");
                return;
            }

            if (File.Exists(iteamName))
            {
                File.Delete(iteamName);
            }
            else //if (Directory.Exists(iteamName))
            {
                Directory.Delete(iteamName, true);
            }

            ChangeFolder(textBoxFileWay.Text);
        }

        //архивирование файликов и папочек
        private void buttonArchieve_Click(object sender, EventArgs e)
        {
            string oldPath = Path.Combine(textBoxFileWay.Text, listBoxFiles.SelectedItem.ToString());
            string newPath = oldPath + ".zip";

            if (File.Exists(oldPath))
            {
                string newFolder = Path.Combine(textBoxFileWay.Text,
                    Path.GetFileNameWithoutExtension(oldPath));
                Directory.CreateDirectory(newFolder);
                File.Copy(oldPath, Path.Combine(newFolder, listBoxFiles.SelectedItem.ToString()), false);
                ZipFile.CreateFromDirectory(newFolder, newPath);
                Directory.Delete(newFolder, true);
            }
            else
            {
                ZipFile.CreateFromDirectory(oldPath, newPath);
            }
            ChangeFolder(textBoxFileWay.Text);
        }

        //закрытие формы (сериализуемся)
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            BinaryFormatter formater = new BinaryFormatter();
            using (FileStream configs = new FileStream("configSettings.txt", FileMode.OpenOrCreate))
            {
                formater.Serialize(configs, Settings.GetCurrent());
            }

            Application.Exit();
        }

        //вернуться назад
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (textBoxFileWay.Text == "") return;

            DirectoryInfo parentPath = new DirectoryInfo(textBoxFileWay.Text).Parent;
            if (parentPath == null)
            {
                listBoxFiles.Items.Clear();
                DriveInfo[] drives = DriveInfo.GetDrives();
                listBoxFiles.Items.AddRange(drives);
                textBoxFileWay.Text = "";
                return;
            }

            ChangeFolder(parentPath.FullName);

        }

        //поиск совпадений
        private void buttonSearchRegex_Click(object sender, EventArgs e)
        {
            FindForm findForm = new FindForm(textBoxFileWay.Text);
            findForm.Show();
        }

        #endregion

        #region асинхронное скачивание
        //сам не умеет определять тип файла
        public static CancellationTokenSource cancelToken = new CancellationTokenSource();

        private async void buttonDownload_Click(object sender, EventArgs e)
        {
            DownloadForm newDownloadForm = new DownloadForm();
            newDownloadForm.Text = "Скачать файлик";
            newDownloadForm.ShowDialog();
            if (!newDownloadForm.IsAccepted) return;

            string fullFileName = Path.Combine(textBoxFileWay.Text, newDownloadForm.ReturnNewName());
            await Task.Run(() => DownloadFile(newDownloadForm.ReturnLink(), fullFileName));
            ChangeFolder(textBoxFileWay.Text);         
        }

        public static void DownloadFile(string link, string newFileName)
        {
            Stream remoteStream = null;
            Stream localStream = null;
            WebResponse response = null;

            try
            {
                WebRequest request = WebRequest.Create(link);
                if (request != null)
                {
                    response = request.GetResponse();
                    if (response != null)
                    {
                        remoteStream = response.GetResponseStream();
                        localStream = File.Create(newFileName);
                        byte[] buffer = new byte[1024];
                        int bytesRead;            
                        cancelToken = new CancellationTokenSource();
             
                        do
                        {
                            if (cancelToken.Token.IsCancellationRequested)
                            {                               
                                MessageBox.Show("Скачивание прервано :(");
                                localStream.Close();
                                File.Delete(newFileName);
                                
                                return;
                            }
                            bytesRead = remoteStream.Read(buffer, 0, buffer.Length);
                            localStream.Write(buffer, 0, bytesRead);

                        } while (bytesRead > 0);
                    }
                }

                MessageBox.Show("Файлик успешно скачан :)");
                if (localStream != null) localStream.Close();
            }
            catch
            {
                if (localStream != null) localStream.Close();
                File.Delete(newFileName);
                MessageBox.Show("Что-то пошло не так :(");
            }

            if (response != null) response.Close();
            
            if (remoteStream != null) remoteStream.Close();
            
            cancelToken.Dispose();
        }

        private void buttonCancelDownload_Click(object sender, EventArgs e)
        {
            cancelToken.Cancel();
        }
        #endregion        
    }
}
