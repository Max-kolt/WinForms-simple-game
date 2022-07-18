using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace MinPlanet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rndCoord = new Random();
        int xBomb, yBomb, bcy, bcx;
        double dist;
        int bombs = 3, timeLine = 30, GameTime, defusingBomb = 0;
        SoundPlayer sound;
        

        private void Form1_Load(object sender, EventArgs e)
        { 
            xBomb = rndCoord.Next(1, GamePanel.Width - picBomb.Width - 2);
            yBomb = rndCoord.Next(1, GamePanel.Height - picBomb.Height - 2);
            picBomb.Location = new Point(xBomb, yBomb);
            MenuPanel.Dock = DockStyle.Fill;
            GamePanel.Dock = DockStyle.Top;
            PlayTheme.Dock = DockStyle.Fill;
            restartPanel.Dock = DockStyle.Fill;
            btnLow.Checked = true;
            MenuLabelTime.Text = "Время: " + timeLine.ToString() + " сек.";
            MenuPanel.BringToFront();
            timer.Interval = 1000;
            sound = new SoundPlayer();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameTime--;

            if (GameTime > 4) labTime.Text = GameTime.ToString() + " секунд";
            else if (GameTime == 1) labTime.Text = GameTime.ToString() + " секунда";
            else if (GameTime <= 4 && GameTime > 0) labTime.Text = GameTime.ToString() + " секунды";
            else if (GameTime <= 0) GameLose();
        }

        private void GameStartBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            sound.Stream = Properties.Resources.button;
            sound.Play();
            sound.Stream = Properties.Resources.bomb_detect;
            btn.Enabled = false;
            BombsCalc.Enabled = false;
            nonBombs.Text = bombs.ToString();
            defBombs.Text = defusingBomb.ToString();
            GameTime = timeLine;
            labTime.Text = GameTime.ToString() + " секунд";
            PlayTheme.BringToFront();
            timer.Start();
        }

        private void GoToMenu_Click(object sender, EventArgs e)
        {
            sound.Stream = Properties.Resources.button;
            sound.Play();
            GameStartBtn.Enabled = true;
            BombsCalc.Enabled = true;
            MenuPanel.BringToFront();
        }

        

        private void BombsCalc_ValueChanged(object sender, EventArgs e)
        {
            sound.Stream = Properties.Resources.button;
            sound.Play();
            bombs = (int)BombsCalc.Value;
            if (btnLow.Checked) timeLine = bombs * 10;
            else if (btnHigh.Checked) timeLine = bombs * 5; 
            MenuLabelTime.Text = "Время: " + timeLine.ToString() + " сек.";
        }

        private void RulesBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажимая на кнопку НАЧАТЬ вас отправят на минное поле. Ваша задача найти определенное количество мин за выданное вам время. Ищите мины опираясь на расстояние которое выводится в левом нижнем углу.", "Правила игры");
        }

        private void radioComplexityChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb == btnLow) timeLine = bombs * 10;
            else if (rb == btnHigh) timeLine = bombs * 5;
            MenuLabelTime.Text = "Время: " + timeLine.ToString() + " сек.";
        }

       

        private void gamePanel_MouseMove(object sender, MouseEventArgs e)
        {
            
            bcy = picBomb.Top + (picBomb.Height / 2);
            bcx = picBomb.Left + (picBomb.Width / 2);

            dist = Math.Sqrt(Math.Pow(e.X - bcx,2)+ Math.Pow(e.Y - bcy,2));
            dist = Math.Round(dist);
            
            labDist.Text = Convert.ToString(dist);

            if (dist <= 40)
            {
                picBomb.Visible = true;
                sound.Play();
            }
            else picBomb.Visible = false;
        }

       

        private void picBomb_Click(object sender, EventArgs e)
        {
            sound.Stream = Properties.Resources.boom;
            sound.Play();
            picBomb.Image = new Bitmap(Properties.Resources._4xjg);
            picBomb.Size = new Size(120,120);
            timer.Stop();
            Task.Delay(1000).GetAwaiter().GetResult();
            timer.Start();
            picBomb.Visible = false;
            sound.Stream = Properties.Resources.bomb_detect;
            xBomb = rndCoord.Next(1, GamePanel.Width - picBomb.Width - 2);
            yBomb = rndCoord.Next(1, GamePanel.Height - picBomb.Height - 2);
            picBomb.Size = new Size(87,87);
            picBomb.Image = new Bitmap(Properties.Resources.bomb);
            picBomb.Location = new Point(xBomb, yBomb);
            bombs--;
            defusingBomb++;
            nonBombs.Text = bombs.ToString();
            defBombs.Text = defusingBomb.ToString();
            if (bombs == 0) GameWon();
        }

        public void GameLose()
        {
            sound.Stream = Properties.Resources.game_lost;
            sound.Play();
            buttonRestart.Enabled = true;
            timer.Stop();
            labOutput.Text = "Поражение";
            restartPanel.BackColor = Color.LightCoral;
            restartPanel.BringToFront();
            bombs += defusingBomb;
            defusingBomb = 0;
            
        }

        public void GameWon()
        {
            sound.Stream = Properties.Resources.game_won;
            sound.Play();
            buttonRestart.Enabled = true;
            timer.Stop();
            labOutput.Text = "Победа";
            restartPanel.BackColor = Color.PaleGreen;
            restartPanel.BringToFront();
            bombs += defusingBomb;
            defusingBomb = 0;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
