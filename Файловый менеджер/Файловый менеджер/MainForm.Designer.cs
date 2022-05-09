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
            this.comboBoxTheme = new System.Windows.Forms.ComboBox();
            this.labelColour = new System.Windows.Forms.Label();
            this.labelFont = new System.Windows.Forms.Label();
            this.labelTextSize = new System.Windows.Forms.Label();
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.comboBoxTextSize = new System.Windows.Forms.ComboBox();
            this.buttonNewFolder = new System.Windows.Forms.Button();
            this.buttonNewFile = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonArchieve = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 16;
            this.listBoxFiles.Location = new System.Drawing.Point(15, 67);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(518, 324);
            this.listBoxFiles.TabIndex = 0;
            this.listBoxFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFiles_MouseDoubleClick);
            // 
            // textBoxFileWay
            // 
            this.textBoxFileWay.Location = new System.Drawing.Point(15, 28);
            this.textBoxFileWay.Name = "textBoxFileWay";
            this.textBoxFileWay.Size = new System.Drawing.Size(518, 22);
            this.textBoxFileWay.TabIndex = 2;
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.FormattingEnabled = true;
            this.comboBoxTheme.Location = new System.Drawing.Point(15, 429);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(125, 24);
            this.comboBoxTheme.TabIndex = 13;
            this.comboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.comboBoxTheme_SelectedIndexChanged);
            // 
            // labelColour
            // 
            this.labelColour.AutoSize = true;
            this.labelColour.Location = new System.Drawing.Point(12, 403);
            this.labelColour.Name = "labelColour";
            this.labelColour.Size = new System.Drawing.Size(41, 16);
            this.labelColour.TabIndex = 14;
            this.labelColour.Text = "Тема";
            this.labelColour.Click += new System.EventHandler(this.labelColour_Click);
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(199, 403);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(52, 16);
            this.labelFont.TabIndex = 15;
            this.labelFont.Text = "Шрифт";
            // 
            // labelTextSize
            // 
            this.labelTextSize.AutoSize = true;
            this.labelTextSize.Location = new System.Drawing.Point(386, 403);
            this.labelTextSize.Name = "labelTextSize";
            this.labelTextSize.Size = new System.Drawing.Size(104, 16);
            this.labelTextSize.TabIndex = 16;
            this.labelTextSize.Text = "Размер текста";
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Location = new System.Drawing.Point(202, 429);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(125, 24);
            this.comboBoxFont.TabIndex = 18;
            this.comboBoxFont.SelectedIndexChanged += new System.EventHandler(this.comboBoxFont_SelectedIndexChanged);
            // 
            // comboBoxTextSize
            // 
            this.comboBoxTextSize.FormattingEnabled = true;
            this.comboBoxTextSize.Location = new System.Drawing.Point(389, 429);
            this.comboBoxTextSize.Name = "comboBoxTextSize";
            this.comboBoxTextSize.Size = new System.Drawing.Size(125, 24);
            this.comboBoxTextSize.TabIndex = 19;
            // 
            // buttonNewFolder
            // 
            this.buttonNewFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonNewFolder.BackgroundImage = global::Файловый_менеджер.Properties.Resources.значок_новая_папка;
            this.buttonNewFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNewFolder.Location = new System.Drawing.Point(542, 291);
            this.buttonNewFolder.Name = "buttonNewFolder";
            this.buttonNewFolder.Size = new System.Drawing.Size(50, 50);
            this.buttonNewFolder.TabIndex = 24;
            this.buttonNewFolder.UseVisualStyleBackColor = false;
            this.buttonNewFolder.Click += new System.EventHandler(this.buttonNewFolder_Click);
            // 
            // buttonNewFile
            // 
            this.buttonNewFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonNewFile.BackgroundImage = global::Файловый_менеджер.Properties.Resources.значок_новый_файл;
            this.buttonNewFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNewFile.Location = new System.Drawing.Point(542, 347);
            this.buttonNewFile.Name = "buttonNewFile";
            this.buttonNewFile.Size = new System.Drawing.Size(50, 50);
            this.buttonNewFile.TabIndex = 23;
            this.buttonNewFile.UseVisualStyleBackColor = false;
            this.buttonNewFile.Click += new System.EventHandler(this.buttonNewFile_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDelete.BackgroundImage = global::Файловый_менеджер.Properties.Resources.значок_удалить;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.Location = new System.Drawing.Point(542, 403);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(50, 50);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRename
            // 
            this.buttonRename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonRename.BackgroundImage = global::Файловый_менеджер.Properties.Resources.значок_переименовать;
            this.buttonRename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRename.Location = new System.Drawing.Point(542, 67);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(50, 50);
            this.buttonRename.TabIndex = 10;
            this.buttonRename.UseVisualStyleBackColor = false;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonMove.BackgroundImage = global::Файловый_менеджер.Properties.Resources.значок_переместить;
            this.buttonMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMove.Location = new System.Drawing.Point(542, 123);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(50, 50);
            this.buttonMove.TabIndex = 9;
            this.buttonMove.UseVisualStyleBackColor = false;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCopy.BackgroundImage = global::Файловый_менеджер.Properties.Resources.значок_копировать;
            this.buttonCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCopy.Location = new System.Drawing.Point(542, 179);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(50, 50);
            this.buttonCopy.TabIndex = 8;
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonArchieve
            // 
            this.buttonArchieve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonArchieve.BackgroundImage = global::Файловый_менеджер.Properties.Resources.значок_архивировать;
            this.buttonArchieve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonArchieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArchieve.Location = new System.Drawing.Point(542, 235);
            this.buttonArchieve.Name = "buttonArchieve";
            this.buttonArchieve.Size = new System.Drawing.Size(50, 50);
            this.buttonArchieve.TabIndex = 7;
            this.buttonArchieve.UseVisualStyleBackColor = false;
            this.buttonArchieve.Click += new System.EventHandler(this.buttonArchieve_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSearch.BackgroundImage = global::Файловый_менеджер.Properties.Resources.значок_найти;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.Location = new System.Drawing.Point(542, 14);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(50, 50);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 471);
            this.Controls.Add(this.buttonNewFolder);
            this.Controls.Add(this.buttonNewFile);
            this.Controls.Add(this.comboBoxTextSize);
            this.Controls.Add(this.comboBoxFont);
            this.Controls.Add(this.labelTextSize);
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.labelColour);
            this.Controls.Add(this.comboBoxTheme);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.ComboBox comboBoxTheme;
        private System.Windows.Forms.Label labelColour;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.Label labelTextSize;
        private System.Windows.Forms.ComboBox comboBoxFont;
        private System.Windows.Forms.ComboBox comboBoxTextSize;
        private System.Windows.Forms.Button buttonNewFile;
        private System.Windows.Forms.Button buttonNewFolder;
    }
}

