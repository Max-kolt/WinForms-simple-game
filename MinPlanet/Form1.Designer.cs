namespace MinPlanet
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GamePanel = new System.Windows.Forms.Panel();
            this.picBomb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labDist = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PlayTheme = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.defBombs = new System.Windows.Forms.Label();
            this.nonBombs = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLow = new System.Windows.Forms.RadioButton();
            this.btnHigh = new System.Windows.Forms.RadioButton();
            this.GameStartBtn = new System.Windows.Forms.Button();
            this.MenuLabelTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BombsCalc = new System.Windows.Forms.NumericUpDown();
            this.LabelMenu = new System.Windows.Forms.Label();
            this.restartPanel = new System.Windows.Forms.Panel();
            this.labOutput = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.GoToMenu = new System.Windows.Forms.Button();
            this.RulesBtn = new System.Windows.Forms.Button();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBomb)).BeginInit();
            this.PlayTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BombsCalc)).BeginInit();
            this.restartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GamePanel.Controls.Add(this.picBomb);
            this.GamePanel.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.GamePanel.Location = new System.Drawing.Point(3, 3);
            this.GamePanel.MaximumSize = new System.Drawing.Size(1270, 570);
            this.GamePanel.MinimumSize = new System.Drawing.Size(1270, 570);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(1270, 570);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gamePanel_MouseMove);
            // 
            // picBomb
            // 
            this.picBomb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picBomb.Image = ((System.Drawing.Image)(resources.GetObject("picBomb.Image")));
            this.picBomb.Location = new System.Drawing.Point(673, 150);
            this.picBomb.Name = "picBomb";
            this.picBomb.Size = new System.Drawing.Size(87, 87);
            this.picBomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBomb.TabIndex = 0;
            this.picBomb.TabStop = false;
            this.picBomb.Visible = false;
            this.picBomb.Click += new System.EventHandler(this.picBomb_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Snyder Speed Brush Cyr", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(-182, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Растояние до мины:";
            // 
            // labDist
            // 
            this.labDist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDist.AutoSize = true;
            this.labDist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labDist.Font = new System.Drawing.Font("Snyder Speed Brush Cyr", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDist.ForeColor = System.Drawing.Color.Maroon;
            this.labDist.Location = new System.Drawing.Point(129, 603);
            this.labDist.Name = "labDist";
            this.labDist.Size = new System.Drawing.Size(59, 33);
            this.labDist.TabIndex = 5;
            this.labDist.Text = "50";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PlayTheme
            // 
            this.PlayTheme.Controls.Add(this.pictureBox1);
            this.PlayTheme.Controls.Add(this.pictureBox2);
            this.PlayTheme.Controls.Add(this.defBombs);
            this.PlayTheme.Controls.Add(this.nonBombs);
            this.PlayTheme.Controls.Add(this.GamePanel);
            this.PlayTheme.Controls.Add(this.labTime);
            this.PlayTheme.Controls.Add(this.label5);
            this.PlayTheme.Controls.Add(this.labDist);
            this.PlayTheme.Controls.Add(this.label1);
            this.PlayTheme.Location = new System.Drawing.Point(405, 4);
            this.PlayTheme.Name = "PlayTheme";
            this.PlayTheme.Size = new System.Drawing.Size(863, 681);
            this.PlayTheme.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(762, 603);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(933, 603);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 33);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // defBombs
            // 
            this.defBombs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.defBombs.AutoSize = true;
            this.defBombs.Font = new System.Drawing.Font("Snyder Speed Brush Cyr", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defBombs.Location = new System.Drawing.Point(957, 603);
            this.defBombs.Name = "defBombs";
            this.defBombs.Size = new System.Drawing.Size(59, 33);
            this.defBombs.TabIndex = 11;
            this.defBombs.Text = "50";
            // 
            // nonBombs
            // 
            this.nonBombs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nonBombs.AutoSize = true;
            this.nonBombs.Font = new System.Drawing.Font("Snyder Speed Brush Cyr", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonBombs.Location = new System.Drawing.Point(795, 603);
            this.nonBombs.Name = "nonBombs";
            this.nonBombs.Size = new System.Drawing.Size(59, 33);
            this.nonBombs.TabIndex = 10;
            this.nonBombs.Text = "50";
            // 
            // labTime
            // 
            this.labTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("Snyder Speed Brush Cyr", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.Location = new System.Drawing.Point(530, 603);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(59, 33);
            this.labTime.TabIndex = 7;
            this.labTime.Text = "50";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Snyder Speed Brush Cyr", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 603);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "Оставшееся время:";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.MenuPanel.Controls.Add(this.RulesBtn);
            this.MenuPanel.Controls.Add(this.buttonExit);
            this.MenuPanel.Controls.Add(this.label2);
            this.MenuPanel.Controls.Add(this.btnLow);
            this.MenuPanel.Controls.Add(this.btnHigh);
            this.MenuPanel.Controls.Add(this.GameStartBtn);
            this.MenuPanel.Controls.Add(this.MenuLabelTime);
            this.MenuPanel.Controls.Add(this.label3);
            this.MenuPanel.Controls.Add(this.BombsCalc);
            this.MenuPanel.Controls.Add(this.LabelMenu);
            this.MenuPanel.Location = new System.Drawing.Point(12, 206);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(656, 512);
            this.MenuPanel.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExit.Location = new System.Drawing.Point(254, 457);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(133, 30);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "ВЫЙТИ";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snyder Speed Brush Cyr", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(173, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сложность :";
            // 
            // btnLow
            // 
            this.btnLow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLow.AutoSize = true;
            this.btnLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLow.Location = new System.Drawing.Point(395, 320);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(82, 24);
            this.btnLow.TabIndex = 6;
            this.btnLow.TabStop = true;
            this.btnLow.Text = "Низкая";
            this.btnLow.UseVisualStyleBackColor = true;
            this.btnLow.CheckedChanged += new System.EventHandler(this.radioComplexityChanged);
            // 
            // btnHigh
            // 
            this.btnHigh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHigh.AutoSize = true;
            this.btnHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHigh.Location = new System.Drawing.Point(395, 290);
            this.btnHigh.Name = "btnHigh";
            this.btnHigh.Size = new System.Drawing.Size(92, 24);
            this.btnHigh.TabIndex = 5;
            this.btnHigh.TabStop = true;
            this.btnHigh.Text = "Высокая";
            this.btnHigh.UseVisualStyleBackColor = true;
            this.btnHigh.CheckedChanged += new System.EventHandler(this.radioComplexityChanged);
            // 
            // GameStartBtn
            // 
            this.GameStartBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GameStartBtn.Font = new System.Drawing.Font("Snyder Speed Brush Cyr", 21.75F);
            this.GameStartBtn.Location = new System.Drawing.Point(197, 378);
            this.GameStartBtn.Name = "GameStartBtn";
            this.GameStartBtn.Size = new System.Drawing.Size(249, 60);
            this.GameStartBtn.TabIndex = 4;
            this.GameStartBtn.Text = "Начать";
            this.GameStartBtn.UseVisualStyleBackColor = true;
            this.GameStartBtn.Click += new System.EventHandler(this.GameStartBtn_Click);
            // 
            // MenuLabelTime
            // 
            this.MenuLabelTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MenuLabelTime.AutoSize = true;
            this.MenuLabelTime.Font = new System.Drawing.Font("Snyder Speed Brush Cyr", 21.75F);
            this.MenuLabelTime.Location = new System.Drawing.Point(208, 234);
            this.MenuLabelTime.Name = "MenuLabelTime";
            this.MenuLabelTime.Size = new System.Drawing.Size(259, 35);
            this.MenuLabelTime.TabIndex = 3;
            this.MenuLabelTime.Text = "Время: 30 сек.";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Snyder Speed Brush Cyr", 21.75F);
            this.label3.Location = new System.Drawing.Point(162, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кол-во мин:";
            // 
            // BombsCalc
            // 
            this.BombsCalc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BombsCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BombsCalc.Location = new System.Drawing.Point(395, 164);
            this.BombsCalc.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BombsCalc.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.BombsCalc.Name = "BombsCalc";
            this.BombsCalc.Size = new System.Drawing.Size(92, 38);
            this.BombsCalc.TabIndex = 1;
            this.BombsCalc.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.BombsCalc.ValueChanged += new System.EventHandler(this.BombsCalc_ValueChanged);
            // 
            // LabelMenu
            // 
            this.LabelMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelMenu.AutoSize = true;
            this.LabelMenu.Font = new System.Drawing.Font("Snyder Speed Brush Cyr", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMenu.Location = new System.Drawing.Point(30, 32);
            this.LabelMenu.Name = "LabelMenu";
            this.LabelMenu.Size = new System.Drawing.Size(593, 77);
            this.LabelMenu.TabIndex = 0;
            this.LabelMenu.Text = "Настройка игры";
            this.LabelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restartPanel
            // 
            this.restartPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.restartPanel.Controls.Add(this.labOutput);
            this.restartPanel.Controls.Add(this.buttonRestart);
            this.restartPanel.Controls.Add(this.GoToMenu);
            this.restartPanel.ForeColor = System.Drawing.Color.Black;
            this.restartPanel.Location = new System.Drawing.Point(422, 2);
            this.restartPanel.Name = "restartPanel";
            this.restartPanel.Size = new System.Drawing.Size(572, 362);
            this.restartPanel.TabIndex = 7;
            // 
            // labOutput
            // 
            this.labOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labOutput.AutoEllipsis = true;
            this.labOutput.AutoSize = true;
            this.labOutput.Font = new System.Drawing.Font("Snyder Speed Brush Cyr", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labOutput.Location = new System.Drawing.Point(141, 56);
            this.labOutput.Name = "labOutput";
            this.labOutput.Size = new System.Drawing.Size(285, 77);
            this.labOutput.TabIndex = 8;
            this.labOutput.Text = "Победа";
            this.labOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRestart.Font = new System.Drawing.Font("Snyder Speed Brush Cyr", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestart.Location = new System.Drawing.Point(63, 156);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(449, 71);
            this.buttonRestart.TabIndex = 1;
            this.buttonRestart.Text = "Еще раз";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.GameStartBtn_Click);
            // 
            // GoToMenu
            // 
            this.GoToMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GoToMenu.Font = new System.Drawing.Font("Snyder Speed Brush Cyr", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToMenu.Location = new System.Drawing.Point(63, 248);
            this.GoToMenu.Name = "GoToMenu";
            this.GoToMenu.Size = new System.Drawing.Size(449, 71);
            this.GoToMenu.TabIndex = 0;
            this.GoToMenu.Text = "Перейти к настройкам";
            this.GoToMenu.UseVisualStyleBackColor = true;
            this.GoToMenu.Click += new System.EventHandler(this.GoToMenu_Click);
            // 
            // RulesBtn
            // 
            this.RulesBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RulesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RulesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RulesBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RulesBtn.Location = new System.Drawing.Point(473, 390);
            this.RulesBtn.Name = "RulesBtn";
            this.RulesBtn.Size = new System.Drawing.Size(42, 40);
            this.RulesBtn.TabIndex = 9;
            this.RulesBtn.Text = "?";
            this.RulesBtn.UseVisualStyleBackColor = false;
            this.RulesBtn.Click += new System.EventHandler(this.RulesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1270, 681);
            this.Controls.Add(this.restartPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.PlayTheme);
            this.MaximumSize = new System.Drawing.Size(1286, 720);
            this.MinimumSize = new System.Drawing.Size(1286, 720);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Разменируй поле";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBomb)).EndInit();
            this.PlayTheme.ResumeLayout(false);
            this.PlayTheme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BombsCalc)).EndInit();
            this.restartPanel.ResumeLayout(false);
            this.restartPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.PictureBox picBomb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labDist;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel PlayTheme;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button GameStartBtn;
        private System.Windows.Forms.Label MenuLabelTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown BombsCalc;
        private System.Windows.Forms.Label LabelMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton btnLow;
        private System.Windows.Forms.RadioButton btnHigh;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label defBombs;
        private System.Windows.Forms.Label nonBombs;
        private System.Windows.Forms.Panel restartPanel;
        private System.Windows.Forms.Label labOutput;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button GoToMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button RulesBtn;
    }
}

