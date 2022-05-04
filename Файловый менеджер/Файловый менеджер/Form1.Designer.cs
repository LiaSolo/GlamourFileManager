namespace Файловый_менеджер
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.textBoxFileWay = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonArchieve = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxColour = new System.Windows.Forms.ComboBox();
            this.labelColour = new System.Windows.Forms.Label();
            this.labelFont = new System.Windows.Forms.Label();
            this.labelTextSize = new System.Windows.Forms.Label();
            this.labelCat = new System.Windows.Forms.Label();
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.comboBoxTextSize = new System.Windows.Forms.ComboBox();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.pictureBoxCat = new System.Windows.Forms.PictureBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonNewFile = new System.Windows.Forms.Button();
            this.buttonNewFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 16;
            this.listBoxFiles.Location = new System.Drawing.Point(15, 50);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(518, 324);
            this.listBoxFiles.TabIndex = 0;
            this.listBoxFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFiles_MouseDoubleClick);
            // 
            // textBoxFileWay
            // 
            this.textBoxFileWay.Location = new System.Drawing.Point(15, 14);
            this.textBoxFileWay.Name = "textBoxFileWay";
            this.textBoxFileWay.Size = new System.Drawing.Size(518, 22);
            this.textBoxFileWay.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSearch.Location = new System.Drawing.Point(542, 14);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(125, 30);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonArchieve
            // 
            this.buttonArchieve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonArchieve.Location = new System.Drawing.Point(542, 86);
            this.buttonArchieve.Name = "buttonArchieve";
            this.buttonArchieve.Size = new System.Drawing.Size(125, 30);
            this.buttonArchieve.TabIndex = 7;
            this.buttonArchieve.Text = "Архивировать";
            this.buttonArchieve.UseVisualStyleBackColor = false;
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCopy.Location = new System.Drawing.Point(542, 194);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(125, 30);
            this.buttonCopy.TabIndex = 8;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonMove.Location = new System.Drawing.Point(542, 158);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(125, 30);
            this.buttonMove.TabIndex = 9;
            this.buttonMove.Text = "Переместить";
            this.buttonMove.UseVisualStyleBackColor = false;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRename
            // 
            this.buttonRename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonRename.Location = new System.Drawing.Point(542, 122);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(125, 30);
            this.buttonRename.TabIndex = 10;
            this.buttonRename.Text = "Переименовать";
            this.buttonRename.UseVisualStyleBackColor = false;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDelete.Location = new System.Drawing.Point(542, 230);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 30);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Параметры окна";
            // 
            // comboBoxColour
            // 
            this.comboBoxColour.FormattingEnabled = true;
            this.comboBoxColour.Location = new System.Drawing.Point(15, 452);
            this.comboBoxColour.Name = "comboBoxColour";
            this.comboBoxColour.Size = new System.Drawing.Size(125, 24);
            this.comboBoxColour.TabIndex = 13;
            // 
            // labelColour
            // 
            this.labelColour.AutoSize = true;
            this.labelColour.Location = new System.Drawing.Point(12, 433);
            this.labelColour.Name = "labelColour";
            this.labelColour.Size = new System.Drawing.Size(41, 16);
            this.labelColour.TabIndex = 14;
            this.labelColour.Text = "Тема";
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(143, 433);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(52, 16);
            this.labelFont.TabIndex = 15;
            this.labelFont.Text = "Шрифт";
            // 
            // labelTextSize
            // 
            this.labelTextSize.AutoSize = true;
            this.labelTextSize.Location = new System.Drawing.Point(277, 433);
            this.labelTextSize.Name = "labelTextSize";
            this.labelTextSize.Size = new System.Drawing.Size(104, 16);
            this.labelTextSize.TabIndex = 16;
            this.labelTextSize.Text = "Размер текста";
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Location = new System.Drawing.Point(405, 433);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(45, 16);
            this.labelCat.TabIndex = 17;
            this.labelCat.Text = "Котик";
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Location = new System.Drawing.Point(146, 452);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(125, 24);
            this.comboBoxFont.TabIndex = 18;
            // 
            // comboBoxTextSize
            // 
            this.comboBoxTextSize.FormattingEnabled = true;
            this.comboBoxTextSize.Location = new System.Drawing.Point(277, 452);
            this.comboBoxTextSize.Name = "comboBoxTextSize";
            this.comboBoxTextSize.Size = new System.Drawing.Size(125, 24);
            this.comboBoxTextSize.TabIndex = 19;
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(408, 452);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(125, 24);
            this.comboBoxCat.TabIndex = 20;
            // 
            // pictureBoxCat
            // 
            this.pictureBoxCat.Location = new System.Drawing.Point(673, 50);
            this.pictureBoxCat.Name = "pictureBoxCat";
            this.pictureBoxCat.Size = new System.Drawing.Size(292, 318);
            this.pictureBoxCat.TabIndex = 21;
            this.pictureBoxCat.TabStop = false;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonOK.Location = new System.Drawing.Point(542, 446);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(125, 30);
            this.buttonOK.TabIndex = 22;
            this.buttonOK.Text = "Применить";
            this.buttonOK.UseVisualStyleBackColor = false;
            // 
            // buttonNewFile
            // 
            this.buttonNewFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonNewFile.Location = new System.Drawing.Point(542, 302);
            this.buttonNewFile.Name = "buttonNewFile";
            this.buttonNewFile.Size = new System.Drawing.Size(125, 30);
            this.buttonNewFile.TabIndex = 23;
            this.buttonNewFile.Text = "Новый файлик";
            this.buttonNewFile.UseVisualStyleBackColor = false;
            this.buttonNewFile.Click += new System.EventHandler(this.buttonNewFile_Click);
            // 
            // buttonNewFolder
            // 
            this.buttonNewFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonNewFolder.Location = new System.Drawing.Point(542, 266);
            this.buttonNewFolder.Name = "buttonNewFolder";
            this.buttonNewFolder.Size = new System.Drawing.Size(125, 30);
            this.buttonNewFolder.TabIndex = 24;
            this.buttonNewFolder.Text = "Новая папочка";
            this.buttonNewFolder.UseVisualStyleBackColor = false;
            this.buttonNewFolder.Click += new System.EventHandler(this.buttonNewFolder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(968, 504);
            this.Controls.Add(this.buttonNewFolder);
            this.Controls.Add(this.buttonNewFile);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.pictureBoxCat);
            this.Controls.Add(this.comboBoxCat);
            this.Controls.Add(this.comboBoxTextSize);
            this.Controls.Add(this.comboBoxFont);
            this.Controls.Add(this.labelCat);
            this.Controls.Add(this.labelTextSize);
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.labelColour);
            this.Controls.Add(this.comboBoxColour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonArchieve);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxFileWay);
            this.Controls.Add(this.listBoxFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Гламурный файловый менеджер";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.TextBox textBoxFileWay;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonArchieve;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxColour;
        private System.Windows.Forms.Label labelColour;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.Label labelTextSize;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.ComboBox comboBoxFont;
        private System.Windows.Forms.ComboBox comboBoxTextSize;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.PictureBox pictureBoxCat;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonNewFile;
        private System.Windows.Forms.Button buttonNewFolder;
    }
}

