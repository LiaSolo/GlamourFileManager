using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;





namespace Файловый_менеджер
{ 
    public partial class MainForm : Form
    {
        //нужны ли проверки на исключения?
        //проверка на существование нового пути?
        //вынести в отдельный класс работу с файлами
        public MainForm()
        {
            //DriveInfo[] drives = DriveInfo.GetDrives();
            //listBoxFiles.Items.AddRange(drives);

            try
            {
                BinaryFormatter formater = new BinaryFormatter();
                using (FileStream configSetting = new FileStream("configSetting.txt", FileMode.OpenOrCreate))
                {
                    Settings.GetCurrent((Settings)formater.Deserialize(configSetting));
                }

            }
            catch (Exception ex) { }

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

            //тут у миши что-то, с чем надо разобраться

        }

        private void InitializeStyle()
        {
            comboBoxFont.Text = Settings.GetCurrent().currentFont;
            comboBoxFont.Items.AddRange(Settings.GetCurrent().fonts); //почему бы не прописать сразу самой?
            comboBoxFont_SelectedIndexChanged(comboBoxFont, null);

            comboBoxTheme.Text = Settings.GetCurrent().currentTheme;
            comboBoxTheme.Items.AddRange(Settings.GetCurrent().themes);
            comboBoxTheme_SelectedIndexChanged(comboBoxTheme, null);

        }


        private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.GetCurrent().currentTheme = ((ComboBox)sender).Text;
            switch (((ComboBox)sender).Text)
            {
                case "Розовый минимализм":
                    this.BackgroundImage = Image.FromFile(@"C:\Users\HP\Desktop\Мой файловый менеджер\Файловый менеджер\Файловый менеджер\светло-розовый фон.jpg");
                    break;
                case "Ночная птица":
                    this.BackgroundImage = Image.FromFile(@"C:\Users\HP\Desktop\Мой файловый менеджер\Файловый менеджер\Файловый менеджер\фон чёрные перья.jpg");
                    break;
                case "Белый пушистик":
                    this.BackgroundImage = Image.FromFile(@"C:\Users\HP\Desktop\Мой файловый менеджер\Файловый менеджер\Файловый менеджер\белый мех.jpg");
                    break;
                case "Жемчуг":
                    this.BackgroundImage = Image.FromFile(@"C:\Users\HP\Desktop\Мой файловый менеджер\Файловый менеджер\Файловый менеджер\фон жемчуг.jpg"); 
                    break;
                case "Серебряный блеск":
                    this.BackgroundImage = Image.FromFile(@"C:\Users\HP\Desktop\Мой файловый менеджер\Файловый менеджер\Файловый менеджер\фон блеск серебро.jpg");
                    break;
                case "Сверкающий алмаз":
                    this.BackgroundImage = Image.FromFile(@"C:\Users\HP\Desktop\Мой файловый менеджер\Файловый менеджер\Файловый менеджер\алмазный фон.jpg");
                    break;
                default:
                    this.BackgroundImage = Image.FromFile(@"C:\Users\HP\Desktop\Мой файловый менеджер\Файловый менеджер\Файловый менеджер\светло-розовый фон.jpg");
                    break;
            }
        }

        public void InitializeTheme() //пока не надо
        {
            //string path = Settings.GetCurrent().currentPicture;
            //this.BackgroundImage = Image.FromFile(path);
            //ещё нужны цвета для кнопочек и боксов
        }


        //смена шрифта (без размера)
        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.GetCurrent().currentFont = ((ComboBox)sender).Text;
            //float currentFontSize = ((ComboBox)sender).Font.Size;
            string CcurrentFont = comboBoxFont.Text;
            buttonCopy.Font = new Font(CcurrentFont, 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonArchieve.Font = new Font(CcurrentFont, 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Font = new Font(CcurrentFont, 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMove.Font = new Font(CcurrentFont, 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNewFile.Font = new Font(CcurrentFont, 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNewFolder.Font = new Font(CcurrentFont, 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRename.Font = new Font(CcurrentFont, 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.Font = new Font(CcurrentFont, 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFileWay.Font = new Font(CcurrentFont, 8F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxFiles.Font = new Font(CcurrentFont, 8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFont.Font = new Font(CcurrentFont, 8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTextSize.Font = new Font(CcurrentFont, 8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTheme.Font = new Font(CcurrentFont, 8F, FontStyle.Regular, GraphicsUnit.Point);        
            labelColour.Font = new Font(CcurrentFont, 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelFont.Font = new Font(CcurrentFont, 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTextSize.Font = new Font(CcurrentFont, 8F, FontStyle.Regular, GraphicsUnit.Point);
        }


        #region кнопочки действий

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
            renameForm.Text = buttonRename.Text;
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

        #endregion


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            BinaryFormatter formater = new BinaryFormatter();
            using (FileStream configs = new FileStream("configSetting.txt", FileMode.OpenOrCreate))
            {
                formater.Serialize(configs, Settings.GetCurrent());
            }

            Application.Exit();
        }

        private void labelColour_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
