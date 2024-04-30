using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace GameSnake
{
    public partial class Form1 : Form
    {
        readonly int sizeOfSides = 20;
        private int dirX, dirY;
        private int rndX, rndY;
        private int score;
        private readonly Label labelScore;
        private readonly PictureBox fruit;
        private readonly PictureBox[] snake;
        readonly SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Yuriy\source\repos\GameSnake\Resources\MusicSnake.wav");
        readonly SoundPlayer simpleSoundGameOver = new SoundPlayer(@"C:\Users\Yuriy\source\repos\GameSnake\Resources\GameOver.wav");
        private bool musicOnOff;
       
        public Form1()
        {
            InitializeComponent();

            btnMusic.Image = Properties.Resources.Звук_Черный;
            musicOnOff = true;
            simpleSound.PlayLooping();

            snake = new PictureBox[200];

            labelScore = new Label
            {
                Location = new Point(70, 20),
                Font = new Font("Monotype Corsiva", 25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                Text = "Счет : 0",
                AutoSize = true
            };
            Controls.Add(labelScore);
            
            snake[0] = new PictureBox
            {
                Location = new Point(0, 0),
                Size = new Size(sizeOfSides, sizeOfSides),
                BackColor = Color.Red,
                BorderStyle = BorderStyle.FixedSingle
            };

            fruit = new PictureBox
            {
                BackColor = Color.Yellow,
                Size = new Size(sizeOfSides, sizeOfSides),
                BorderStyle = BorderStyle.FixedSingle
            };

            score = 0;
            dirX = 1;
            dirY = 0;
            map.Controls.Add(snake[0]);
            GenerateFruit();
            timer.Start();
        }
        private void NewGame()
        {
            lbGameOver.Visible = false;
            btnStartPause.Enabled = true;
            snake[0].Location = new Point(0, 0);

            for (int i = 1; i <= score; i++)
            {
                map.Controls.Remove(snake[i]);
            }

            score = 0;
            dirX = 1;
            dirY = 0;

            labelScore.Text = "Счет : 0";
            
            GenerateFruit();
            timer.Start();

            if(musicOnOff)
            {
                simpleSound.PlayLooping();
            }
        }

        private void EatFruit()
        {
            if (snake[0].Location.X == rndX && snake[0].Location.Y == rndY)
            {
                labelScore.Text = "Счет : " + ++score;
                snake[score] = new PictureBox 
                {
                    Location = new Point(snake[score - 1].Location.X + dirX * sizeOfSides, snake[score - 1].Location.Y + dirY * sizeOfSides),
                    Size = new Size(sizeOfSides, sizeOfSides),
                    BackColor = Color.Red,
                    BorderStyle = BorderStyle.FixedSingle
                };
                map.Controls.Add(snake[score]);
                
                GenerateFruit();
            }
        }
        private void CheckBorder()
        {
            if (snake[0].Location.X < 0 || snake[0].Location.X > map.Width - sizeOfSides ||
                snake[0].Location.Y < 0 || snake[0].Location.Y > map.Height - sizeOfSides)
            {
                GameOverInitial();
            }
        }
        private void GenerateFruit()
        {
            Random rn = new Random();
            rndX = rn.Next(0, map.Size.Width - sizeOfSides)  / sizeOfSides * sizeOfSides;
            rndY = rn.Next(0, map.Size.Height - sizeOfSides) / sizeOfSides * sizeOfSides;
            fruit.Location = new Point(rndX, rndY);
            fruit.BringToFront();
            map.Controls.Add(fruit);
        }

        private void EatYourself()
        {
            for(int i = 1; i < score; i++)
            {
                if (snake[0].Location == snake[i].Location)
                {
                    GameOverInitial();
                }
            }
        }

        private void GameOverInitial()
        {
            timer.Stop();
            lbGameOver.Visible = true;
            btnStartPause.Enabled = false;
            simpleSound.Stop();
            simpleSoundGameOver.Play();
        }

        private void EventKeyDown(object sender, KeyEventArgs e)
        {
            if (timer.Enabled)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left: dirX = -1; dirY = 0; break;
                    case Keys.Right: dirX = 1; dirY = 0; break;
                    case Keys.Up: dirX = 0; dirY = -1; break;
                    case Keys.Down: dirX = 0; dirY = 1; break;
                }
            }
        }

        private void EventPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (timer.Enabled)
            { 
                switch (e.KeyCode)
                {
                    case Keys.Left: e.IsInputKey = true; break;
                    case Keys.Right: e.IsInputKey = true; break;
                    case Keys.Up: e.IsInputKey = true; break;
                    case Keys.Down: e.IsInputKey = true; break;
                }
            }
        }

        private void btnStartPause_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                simpleSound.Stop();
            }
            else
            {
                timer.Start();
                
                if (musicOnOff)
                {
                    simpleSound.PlayLooping();
                }
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e) => NewGame();

        private void btnMusic_Click(object sender, EventArgs e)
        {
            if (musicOnOff)
            {
                btnMusic.Image = Properties.Resources.Звук_Серый;
                musicOnOff = false;
                simpleSound.Stop();
            }
            else
            {
                btnMusic.Image = Properties.Resources.Звук_Черный;
                musicOnOff = true;
                simpleSound.PlayLooping();
            }
        }

        private void MoveSnake()
        {
            for (int i = score; i > 0; i--)
            {
                snake[i].Location = snake[i - 1].Location;
            }
            snake[0].Location = new Point(snake[0].Location.X + dirX * sizeOfSides, snake[0].Location.Y + dirY * sizeOfSides);
            EatYourself();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            CheckBorder();
            EatFruit();
            MoveSnake();

            if (score < 3) timer.Interval = 300;
            else if (score < 9) timer.Interval = 275;
            else if (score < 12) timer.Interval = 250;
            else if (score < 15) timer.Interval = 225;
            else if (score < 18) timer.Interval = 200;
            else if (score < 21) timer.Interval = 175;
            else if (score < 24) timer.Interval = 150;
            else if (score < 27) timer.Interval = 125;
            else if (score < 30) timer.Interval = 100;
            else timer.Interval = 75;
        }
    }
}
