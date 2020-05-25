namespace MyGameMed
{
    partial class Game_Answer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Answer));
            this.body_answer = new System.Windows.Forms.Panel();
            this.text = new System.Windows.Forms.RichTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.picture = new System.Windows.Forms.PictureBox();
            this.doc = new System.Windows.Forms.Panel();
            this.video = new System.Windows.Forms.PictureBox();
            this.answering = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.body_answer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.doc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // body_answer
            // 
            this.body_answer.AutoScroll = true;
            this.body_answer.Controls.Add(this.text);
            this.body_answer.Controls.Add(this.splitter1);
            this.body_answer.Controls.Add(this.picture);
            this.body_answer.Controls.Add(this.doc);
            this.body_answer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_answer.Location = new System.Drawing.Point(0, 0);
            this.body_answer.Name = "body_answer";
            this.body_answer.Size = new System.Drawing.Size(782, 507);
            this.body_answer.TabIndex = 4;
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text.Location = new System.Drawing.Point(369, 0);
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(413, 447);
            this.text.TabIndex = 6;
            this.text.Text = "";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(366, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 447);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // picture
            // 
            this.picture.Dock = System.Windows.Forms.DockStyle.Left;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(366, 447);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 5;
            this.picture.TabStop = false;
            this.picture.Visible = false;
            // 
            // doc
            // 
            this.doc.Controls.Add(this.video);
            this.doc.Controls.Add(this.answering);
            this.doc.Controls.Add(this.back);
            this.doc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.doc.Location = new System.Drawing.Point(0, 447);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(782, 60);
            this.doc.TabIndex = 4;
            // 
            // video
            // 
            this.video.Dock = System.Windows.Forms.DockStyle.Right;
            this.video.Image = global::MyGameMed.Properties.Resources.adsdsad;
            this.video.Location = new System.Drawing.Point(482, 0);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(100, 60);
            this.video.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.video.TabIndex = 8;
            this.video.TabStop = false;
            this.video.Visible = false;
            this.video.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // answering
            // 
            this.answering.Dock = System.Windows.Forms.DockStyle.Right;
            this.answering.Image = global::MyGameMed.Properties.Resources._678134_sign_check_256;
            this.answering.Location = new System.Drawing.Point(582, 0);
            this.answering.Name = "answering";
            this.answering.Size = new System.Drawing.Size(100, 60);
            this.answering.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.answering.TabIndex = 5;
            this.answering.TabStop = false;
            this.answering.Click += new System.EventHandler(this.start_answer_Click);
            // 
            // back
            // 
            this.back.Dock = System.Windows.Forms.DockStyle.Right;
            this.back.Image = global::MyGameMed.Properties.Resources.arrow_back_icon;
            this.back.Location = new System.Drawing.Point(682, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 60);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 4;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // Game_Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.body_answer);
            this.Name = "Game_Answer";
            this.Size = new System.Drawing.Size(782, 507);
            this.body_answer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.doc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.video)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel body_answer;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel doc;
        private System.Windows.Forms.PictureBox answering;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox video;
    }
}
