using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Файловый_менеджер
{
    public partial class FindForm : Form
    {
        string pathFindedFile;
        public FindForm(string path)
        {
            InitializeComponent();
            pathFindedFile = path;           
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxFinded.Items.Clear();
            List<string> finded = new List<string>();
            Regex regex = new Regex(textBoxRegex.Text);

            //если ищем совпадения в файлике
            if (File.Exists(pathFindedFile))
            {
                string stringFile = File.ReadAllText(pathFindedFile);               
                MatchCollection matches = regex.Matches(stringFile);

                foreach (Match match in matches)
                {
                    finded.Add(match.Groups[0].Value);
                }
            }
            else
            {
                //если ищем файлы в папке (в том числе в папках в папке)
                RecursiveSearching(pathFindedFile);

                void RecursiveSearching(string currentPath)
                {
                    //разбираем внутренние папки на файлики
                    Parallel.ForEach(Directory.GetDirectories(currentPath), pathDirectories =>
                    {
                        MatchCollection matches = regex.Matches(new DirectoryInfo(pathDirectories).Name);
                        if (matches.Count > 0) finded.Add(new DirectoryInfo(pathDirectories).Name);
                        RecursiveSearching(pathDirectories);
                    });
                    //просматриваем названия файлов на совпадения
                    Parallel.ForEach(Directory.GetFiles(currentPath), pathFiles =>
                    {
                        MatchCollection matches = regex.Matches(new DirectoryInfo(pathFiles).Name);
                        if (matches.Count > 0) finded.Add(new DirectoryInfo(pathFiles).Name);

                        string stringFile = File.ReadAllText(pathFiles);
                        //надо искат совпадения только если ткст
                        if (Path.GetExtension(pathFiles) == ".txt")
                        {
                            MatchCollection matchesss = regex.Matches(stringFile);
                            foreach (Match match in matchesss) finded.Add($"В файлике {Path.GetFileName(pathFiles)}: {match.Groups[0].Value}");
                        }                 
                        
                    });
                }
            }
            
            foreach (string item in finded) listBoxFinded.Items.Add(item);
        }
    }
}
