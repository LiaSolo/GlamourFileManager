using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Файловый_менеджер
{
    [Serializable]
    internal class Settings
    {
        private static Settings current;
        //private Settings() { }

        public static Settings GetCurrent()
        {
            if (current == null)  current = new Settings();
            return current;
        }
        public static Settings GetCurrent(Settings settings)
        {
            if (current == null)  current = settings;
            return current;
        }
        public string[] fonts = new string[] { "Arial", "Courier New", "Gabriola", "Impact", "Monotype Corsiva", "Times New Roman" };
        public int[] textSize = new int[] { 8, 10, 12, 14, 16, 18, 20 };
        public string[] themes = new string[] { "Розовый минимализм", "Белый пушистик", "Жемчуг", "Серебряный блеск", "Сверкающий алмаз", "Ночная птица" };
        public string currentFont;
        public string currentTheme;
        public int currenTextSize;
    }
}
