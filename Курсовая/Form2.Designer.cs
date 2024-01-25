namespace Курсовая
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Game = new System.Windows.Forms.PictureBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.ProgressBar2 = new System.Windows.Forms.ProgressBar();
            this.ProgressBar3 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Happy = new System.Windows.Forms.Timer(this.components);
            this.Soon = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Game)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Gray;
            this.imageList1.Images.SetKeyName(0, "Грусть.png");
            this.imageList1.Images.SetKeyName(1, "Ласково.png");
            this.imageList1.Images.SetKeyName(2, "Счастье.png");
            this.imageList1.Images.SetKeyName(3, "Удовлетворительно.png");
            this.imageList1.Images.SetKeyName(4, "Сон.png");
            this.imageList1.Images.SetKeyName(5, "Проигрыш.jpg");
            // 
            // Game
            // 
            this.Game.Location = new System.Drawing.Point(73, 104);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(283, 191);
            this.Game.TabIndex = 0;
            this.Game.TabStop = false;
            this.Game.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button1.Location = new System.Drawing.Point(40, 37);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(125, 37);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Кормить";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button2.Location = new System.Drawing.Point(184, 37);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(109, 37);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "Играть";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button3.Location = new System.Drawing.Point(311, 37);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(106, 37);
            this.Button3.TabIndex = 3;
            this.Button3.Text = "Спать";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button4.Location = new System.Drawing.Point(439, 37);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(138, 37);
            this.Button4.TabIndex = 4;
            this.Button4.Text = "Разбудить";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(546, 129);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(232, 23);
            this.ProgressBar1.TabIndex = 5;
            this.ProgressBar1.Value = 50;
            // 
            // ProgressBar2
            // 
            this.ProgressBar2.Location = new System.Drawing.Point(545, 231);
            this.ProgressBar2.Name = "ProgressBar2";
            this.ProgressBar2.Size = new System.Drawing.Size(232, 23);
            this.ProgressBar2.TabIndex = 6;
            this.ProgressBar2.Value = 50;
            this.ProgressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // ProgressBar3
            // 
            this.ProgressBar3.Location = new System.Drawing.Point(546, 181);
            this.ProgressBar3.Name = "ProgressBar3";
            this.ProgressBar3.Size = new System.Drawing.Size(232, 23);
            this.ProgressBar3.TabIndex = 7;
            this.ProgressBar3.Value = 50;
            this.ProgressBar3.Click += new System.EventHandler(this.ProgressBar3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Бодрость";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Сытость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Счастье";
            // 
            // Happy
            // 
            this.Happy.Enabled = true;
            this.Happy.Interval = 1000;
            this.Happy.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Soon
            // 
            this.Soon.Enabled = true;
            this.Soon.Interval = 1000;
            this.Soon.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Курсовая.Properties.Resources.mRXRG_Icu38;
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(805, 448);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProgressBar3);
            this.Controls.Add(this.ProgressBar2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.Game);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Накорми обезьянку";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Game)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox Game;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Happy;
        private System.Windows.Forms.Timer Soon;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.ProgressBar ProgressBar3;
        public System.Windows.Forms.Button Button1;
        public System.Windows.Forms.Button Button2;
        public System.Windows.Forms.Button Button3;
        public System.Windows.Forms.Button Button4;
        public System.Windows.Forms.ProgressBar ProgressBar1;
        public System.Windows.Forms.ProgressBar ProgressBar2;
    }
}

