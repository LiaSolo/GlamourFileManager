namespace Файловый_менеджер
{
    partial class DownloadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadForm));
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.labelLink = new System.Windows.Forms.Label();
            this.labelNewName = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(180, 27);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(329, 22);
            this.textBoxLink.TabIndex = 0;
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(12, 27);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(143, 16);
            this.labelLink.TabIndex = 1;
            this.labelLink.Text = "Ссылочка на файлик";
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Location = new System.Drawing.Point(12, 77);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(137, 16);
            this.labelNewName.TabIndex = 2;
            this.labelNewName.Text = "Новое имя файлика";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(180, 74);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(329, 22);
            this.textBoxNewName.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonOk.Location = new System.Drawing.Point(15, 120);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(225, 50);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Оки";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancel.Location = new System.Drawing.Point(284, 120);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(225, 50);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(533, 198);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.labelNewName);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.textBoxLink);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DownloadForm";
            this.Text = "Скачать";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}