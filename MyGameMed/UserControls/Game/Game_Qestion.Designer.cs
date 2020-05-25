namespace MyGameMed
{
    partial class Game_Qestion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Qestion));
            this.body_answer = new System.Windows.Forms.Panel();
            this.text = new System.Windows.Forms.RichTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.picture = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.doc = new System.Windows.Forms.Panel();
            this.video = new System.Windows.Forms.PictureBox();
            this.start_time = new System.Windows.Forms.PictureBox();
            this.start_answer = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.timer_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.body_answer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.doc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_answer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // body_answer
            // 
            this.body_answer.AutoScroll = true;
            this.body_answer.Controls.Add(this.text);
            this.body_answer.Controls.Add(this.splitter1);
            this.body_answer.Controls.Add(this.picture);
            this.body_answer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_answer.Location = new System.Drawing.Point(0, 0);
            this.body_answer.Name = "body_answer";
            this.body_answer.Size = new System.Drawing.Size(847, 449);
            this.body_answer.TabIndex = 2;
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text.Location = new System.Drawing.Point(369, 0);
            this.text.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(478, 449);
            this.text.TabIndex = 4;
            this.text.Text = "";
            this.text.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(366, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 449);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // picture
            // 
            this.picture.Dock = System.Windows.Forms.DockStyle.Left;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(366, 449);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            this.picture.Visible = false;
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
            // doc
            // 
            this.doc.Controls.Add(this.video);
            this.doc.Controls.Add(this.start_time);
            this.doc.Controls.Add(this.start_answer);
            this.doc.Controls.Add(this.back);
            this.doc.Controls.Add(this.timer_label);
            this.doc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.doc.Location = new System.Drawing.Point(0, 449);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(847, 60);
            this.doc.TabIndex = 3;
            // 
            // video
            // 
            this.video.Dock = System.Windows.Forms.DockStyle.Right;
            this.video.Image = global::MyGameMed.Properties.Resources.adsdsad;
            this.video.Location = new System.Drawing.Point(447, 0);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(100, 60);
            this.video.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.video.TabIndex = 7;
            this.video.TabStop = false;
            this.video.Visible = false;
            this.video.Click += new System.EventHandler(this.video_Click);
            // 
            // start_time
            // 
            this.start_time.Dock = System.Windows.Forms.DockStyle.Right;
            this.start_time.Image = global::MyGameMed.Properties.Resources.icon_time_01_1024x1024;
            this.start_time.Location = new System.Drawing.Point(547, 0);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(100, 60);
            this.start_time.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.start_time.TabIndex = 6;
            this.start_time.TabStop = false;
            this.start_time.Click += new System.EventHandler(this.start_time_Click);
            // 
            // start_answer
            // 
            this.start_answer.Dock = System.Windows.Forms.DockStyle.Right;
            this.start_answer.Image = global::MyGameMed.Properties.Resources.imessage_icon_1;
            this.start_answer.Location = new System.Drawing.Point(647, 0);
            this.start_answer.Name = "start_answer";
            this.start_answer.Size = new System.Drawing.Size(100, 60);
            this.start_answer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.start_answer.TabIndex = 5;
            this.start_answer.TabStop = false;
            this.start_answer.Click += new System.EventHandler(this.start_answer_Click);
            // 
            // back
            // 
            this.back.Dock = System.Windows.Forms.DockStyle.Right;
            this.back.Image = global::MyGameMed.Properties.Resources.arrow_back_icon;
            this.back.Location = new System.Drawing.Point(747, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 60);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 4;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.timer_label.Font = new System.Drawing.Font("RussellSquare", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label.ForeColor = System.Drawing.Color.Red;
            this.timer_label.Location = new System.Drawing.Point(0, 0);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(165, 57);
            this.timer_label.TabIndex = 0;
            this.timer_label.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Game_Qestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.body_answer);
            this.Controls.Add(this.doc);
            this.Name = "Game_Qestion";
            this.Size = new System.Drawing.Size(847, 509);
            this.body_answer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.doc.ResumeLayout(false);
            this.doc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_answer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel body_answer;
        private System.Windows.Forms.Panel doc;
        private System.Windows.Forms.Label timer_label;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox start_time;
        private System.Windows.Forms.PictureBox start_answer;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox video;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.Splitter splitter1;
    }
}
