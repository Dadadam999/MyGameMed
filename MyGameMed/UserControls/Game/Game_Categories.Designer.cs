namespace MyGameMed
{
    partial class Game_Categories
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
            this.body = new System.Windows.Forms.FlowLayoutPanel();
            this.uppanel = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.PictureBox();
            this.footer = new System.Windows.Forms.PictureBox();
            this.kote = new System.Windows.Forms.PictureBox();
            this.uppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kote)).BeginInit();
            this.SuspendLayout();
            // 
            // body
            // 
            this.body.AutoScroll = true;
            this.body.Location = new System.Drawing.Point(0, 125);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(666, 280);
            this.body.TabIndex = 5;
            // 
            // uppanel
            // 
            this.uppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(197)))), ((int)(((byte)(243)))));
            this.uppanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uppanel.Controls.Add(this.back);
            this.uppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uppanel.Location = new System.Drawing.Point(0, 0);
            this.uppanel.Name = "uppanel";
            this.uppanel.Size = new System.Drawing.Size(666, 25);
            this.uppanel.TabIndex = 1;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Dock = System.Windows.Forms.DockStyle.Left;
            this.back.Image = global::MyGameMed.Properties.Resources.arrow_back_icon;
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(25, 25);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 1;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 25);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(666, 100);
            this.header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.header.TabIndex = 1;
            this.header.TabStop = false;
            this.header.Visible = false;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.Transparent;
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 405);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(666, 50);
            this.footer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.footer.TabIndex = 0;
            this.footer.TabStop = false;
            this.footer.Visible = false;
            // 
            // kote
            // 
            this.kote.Image = global::MyGameMed.Properties.Resources.кот_в_мешке;
            this.kote.Location = new System.Drawing.Point(0, 355);
            this.kote.Name = "kote";
            this.kote.Size = new System.Drawing.Size(60, 60);
            this.kote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kote.TabIndex = 0;
            this.kote.TabStop = false;
            this.kote.Visible = false;
            this.kote.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Game_Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.kote);
            this.Controls.Add(this.body);
            this.Controls.Add(this.header);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.uppanel);
            this.Name = "Game_Categories";
            this.Size = new System.Drawing.Size(666, 455);
            this.Resize += new System.EventHandler(this.Game_Categories_Resize);
            this.uppanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel body;
        private System.Windows.Forms.Panel uppanel;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox footer;
        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.PictureBox kote;
    }
}
