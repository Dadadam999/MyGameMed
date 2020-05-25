namespace MyGameMed
{
    partial class FirstMainMenu
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menu = new System.Windows.Forms.Panel();
            this.contin = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.editor = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu.Controls.Add(this.contin);
            this.menu.Controls.Add(this.change);
            this.menu.Controls.Add(this.load);
            this.menu.Controls.Add(this.exit);
            this.menu.Controls.Add(this.editor);
            this.menu.Controls.Add(this.help);
            this.menu.Location = new System.Drawing.Point(268, 130);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(135, 223);
            this.menu.TabIndex = 5;
            // 
            // contin
            // 
            this.contin.Location = new System.Drawing.Point(10, 3);
            this.contin.Name = "contin";
            this.contin.Size = new System.Drawing.Size(116, 23);
            this.contin.TabIndex = 5;
            this.contin.Text = "Продолжить игру";
            this.contin.UseVisualStyleBackColor = true;
            this.contin.Click += new System.EventHandler(this.contin_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(10, 119);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(116, 23);
            this.change.TabIndex = 4;
            this.change.Text = "Изменить игру";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(10, 39);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(116, 23);
            this.load.TabIndex = 0;
            this.load.Text = "Начать игру";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(32, 195);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // editor
            // 
            this.editor.Location = new System.Drawing.Point(10, 78);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(116, 23);
            this.editor.TabIndex = 1;
            this.editor.Text = "Создать игру";
            this.editor.UseVisualStyleBackColor = true;
            this.editor.Click += new System.EventHandler(this.editor_Click);
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(10, 157);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(116, 23);
            this.help.TabIndex = 2;
            this.help.Text = "Описание";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // FirstMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.menu);
            this.Name = "FirstMainMenu";
            this.Size = new System.Drawing.Size(670, 448);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button editor;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button contin;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
