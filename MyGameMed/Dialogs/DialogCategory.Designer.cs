namespace MyGameMed
{
    partial class DialogCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogCategory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.Button();
            this.kot = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.input);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 21);
            this.panel1.TabIndex = 0;
            // 
            // name
            // 
            this.name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name.Location = new System.Drawing.Point(0, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(495, 20);
            this.name.TabIndex = 0;
            // 
            // input
            // 
            this.input.Dock = System.Windows.Forms.DockStyle.Right;
            this.input.Location = new System.Drawing.Point(495, 0);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(75, 21);
            this.input.TabIndex = 2;
            this.input.Text = "Ввод";
            this.input.UseVisualStyleBackColor = true;
            this.input.Click += new System.EventHandler(this.button2_Click);
            // 
            // kot
            // 
            this.kot.AutoSize = true;
            this.kot.Dock = System.Windows.Forms.DockStyle.Top;
            this.kot.Location = new System.Drawing.Point(0, 21);
            this.kot.Name = "kot";
            this.kot.Size = new System.Drawing.Size(570, 17);
            this.kot.TabIndex = 1;
            this.kot.Text = "Эта категория: \"Кот в мешке\"";
            this.kot.UseVisualStyleBackColor = true;
            this.kot.Click += new System.EventHandler(this.kot_Click);
            // 
            // DialogCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 45);
            this.Controls.Add(this.kot);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DialogCategory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.CheckBox kot;
    }
}