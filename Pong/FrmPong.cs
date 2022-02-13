using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class FrmPong : Form
    {
        public static int paddle_speed = 6;
        public static int ball_speed = 8;
        public static bool maxScoreB = false;
        public static int maxScore = 1;
        public static bool rallyB = true;
        public static int singlePlayerRNG = 8;
        
        private Random random = new Random();

        private Player playerOne = new Player(paddle_speed);
        private Player playerTwo = new Player(paddle_speed);

        private Ball ball = new Ball(ball_speed);

        private string gameType;

        private int rally = 0;

        public static UcSettings Settings = new UcSettings();

        public FrmPong()
        {
            InitializeComponent();

            GameStateZero();

            Settings.Location = new Point(245, 120);
            Settings.Visible = false;
            UcSettings.nupPaddleSpeed.Value = paddle_speed;
            UcSettings.nupBallSpeed.Value = ball_speed;
            UcSettings.chbRallyCounter.Checked = rallyB;
            UcSettings.nupSinglePlayerRNG.Value = singlePlayerRNG;
            this.Controls.Add(Settings);
        }

        private void BtnSinglePlayer_Click(object sender, EventArgs e)
        {
            gameType = "Single";
            GameStateOne();
        }

        private void BtnTwoPlayer_Click(object sender, EventArgs e)
        {
            gameType = "Two";
            GameStateOne();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
                control.Hide();

            Settings.Show();
            btnBack.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            GameStateZero();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPong_Click(object sender, EventArgs e)
        {
            if (lblPlay.Visible)
                GameStart();
        }

        private void FrmPong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                playerOne.Up = true;

            if (e.KeyCode == Keys.Down)
                playerOne.Down = true;

            if (gameType == "Two")
            {
                if (e.KeyCode == Keys.W)
                    playerTwo.Up = true;

                if (e.KeyCode == Keys.S)
                    playerTwo.Down = true;
            }
        }

        private void FrmPong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                playerOne.Up = false;

            if (e.KeyCode == Keys.Down)
                playerOne.Down = false;

            if (gameType == "Two")
            {
                if (e.KeyCode == Keys.W)
                    playerTwo.Up = false;

                if (e.KeyCode == Keys.S)
                    playerTwo.Down = false;
            }

            //Pause button
            if (e.KeyCode == Keys.Escape)
            {
                tmrGameEngine.Stop();
                GameStateOne();
            }

            //Game Start using Space bar key
            if (e.KeyCode == Keys.Space)
            {
                if (lblPlay.Visible)
                    GameStart();
            }
        } 

        //Main Menu Screen
        private void GameStateZero()
        {
            SoundPlayer backgroundMusic = new SoundPlayer(Properties.Resources.Miami_Nights_1984___Sunset_Cruise);
            backgroundMusic.PlayLooping();

            foreach (Control control in this.Controls)
                control.Hide();

            this.Cursor = Cursors.Default;
            lblTitle.Show();
            btnSinglePlayer.Show();
            btnTwoPlayer.Show();
            btnSettings.Show();
            btnExit.Show();
            ResetPositions();
        }

        //Get Ready Screen
        private void GameStateOne()
        {
            foreach (Control control in this.Controls)
            {
                if (new Control[] { lblTitle, btnSinglePlayer, btnTwoPlayer, btnSettings, Settings, btnExit, lblWinner, btnRematch }.Contains(control))
                    control.Hide();
                else
                    control.Show();
            }

            this.Cursor = Cursors.Hand;
            this.Focus();

            lblScoreL.Text = "0";
            lblScoreR.Text = "0";
            playerOne.Speed = paddle_speed;
            if (gameType == "Single")
                playerTwo.Speed = ball_speed;
            else
                playerTwo.Speed = paddle_speed;
            ball.Speed = ball_speed;
            if (!rallyB)
                lblRally.Hide();
        }

        //Resets positions of paddles and ball.
        private void ResetPositions()
        {
            pbBall.Location = new Point(490, 315);
            pbPaddleL.Location = new Point(30, 275);
            pbPaddleR.Location = new Point(955, 275);
        }

        //Game Screen
        private void GameStart()
        {
            this.Cursor = Cursors.Default;
            lblPlay.Hide();
            btnBack.Hide();

            this.Focus();

            ResetPositions();
            playerTwo.Up = false;
            playerTwo.Down = false;

            rally = 0;
            lblRally.Text = "Rally: 0";

            ball.Up = false;
            ball.Down = false;

            //Ball picks a direction at start (Left or Right).
            if (random.Next(2) == 0)
            {
                ball.Left = true;
                ball.Right = false;
            }
            else
            {
                ball.Right = true;
                ball.Left = false;
            }

            tmrGameEngine.Start();
        }

        private void MovePlayerOne()
        {
            if (playerOne.Up && pbPaddleR.Top > 10)
                pbPaddleR.Top -= playerOne.Speed;

            if (playerOne.Down && pbPaddleR.Bottom < this.Height- 10)
                pbPaddleR.Top += playerOne.Speed;
        }

        private void MovePlayerTwo()
        {
            if (playerTwo.Up && pbPaddleL.Top > 10)
                pbPaddleL.Top -= playerTwo.Speed;

            if (playerTwo.Down && pbPaddleL.Bottom < this.Height - 10)
                pbPaddleL.Top += playerTwo.Speed;
        }

        private void AIMovement()
        {
            int ball_mid = pbBall.Location.Y + pbBall.Height / 2;
            //Only perform checks when ball is within the specified region.
            if (pbBall.Location.X <= 2*this.Width / 5)
            {
                if (ball_mid < pbPaddleL.Location.Y + pbPaddleL.Height / 2 && random.Next(singlePlayerRNG) != 0)
                    playerTwo.Up = true;
                else
                    playerTwo.Up = false;

                if (ball_mid > pbPaddleL.Location.Y + pbPaddleL.Height / 2 && random.Next(singlePlayerRNG) != 0)
                    playerTwo.Down = true;
                else
                    playerTwo.Down = false;
            }
            else
            {
                playerTwo.Up = false;
                playerTwo.Down = false;
            }
        }

        private void MoveBall()
        {
            int x = pbBall.Location.X;
            int y = pbBall.Location.Y;

            if (ball.Up && pbBall.Top > 0)
                y -= ball.Speed;
            if (ball.Down && pbBall.Bottom < this.Height)
                y += ball.Speed;
            if (ball.Left && pbBall.Left > 0)
                x -= ball.Speed;
            if (ball.Right && pbBall.Right < this.Width)
                x += ball.Speed;

            pbBall.Location = new Point(x, y);
        }

        private void Winner()
        {
            if (lblScoreL.Text == maxScore.ToString())
            {
                tmrGameEngine.Stop();
                foreach (Control control in this.Controls)
                {
                    if (!new Control[] { lblScoreL, lblScoreR }.Contains(control))
                        control.Hide();
                }

                lblWinner.Text = "LEFT WINS";
                lblWinner.Location = new Point(100, 224);
                lblWinner.Show();
                btnRematch.Show();
                btnBack.Show();
            }
            if (lblScoreR.Text == maxScore.ToString())
            {
                tmrGameEngine.Stop();
                foreach (Control control in this.Controls)
                {
                    if (!new Control[] { lblScoreL, lblScoreR }.Contains(control))
                        control.Hide();
                }

                lblWinner.Text = "RIGHT WINS";
                lblWinner.Location = new Point(60, 224);
                lblWinner.Show();
                btnRematch.Show();
                btnBack.Show();
            }
        }

        private void BtnRematch_Click(object sender, EventArgs e)
        {
            GameStateOne();
        }

        private void TmrGameEngine_Tick(object sender, EventArgs e)
        {
            //MOVEMENT
            MoveBall();
            MovePlayerOne();
            if (gameType == "Single")
                AIMovement();
            MovePlayerTwo();

            SoundPlayer paddleHitSound = new SoundPlayer(Properties.Resources.Paddle_Sound);
            SoundPlayer wallHitSound = new SoundPlayer(Properties.Resources.Wall_Sound);
            SoundPlayer scoreSound = new SoundPlayer(Properties.Resources.Score_Sound);

            //COLLISIONS

            //PADDLE HIT SOUND
            if (pbBall.Bounds.IntersectsWith(new Rectangle(pbPaddleL.Location.X, pbPaddleL.Location.Y, pbPaddleL.Width, pbPaddleL.Height)) ||
                pbBall.Bounds.IntersectsWith(new Rectangle(pbPaddleR.Location.X, pbPaddleR.Location.Y, pbPaddleR.Width, pbPaddleR.Height)))
                paddleHitSound.Play();

            //Top L
            if (pbBall.Bounds.IntersectsWith(new Rectangle(pbPaddleL.Location.X, pbPaddleL.Location.Y, pbPaddleL.Width, pbPaddleL.Height / 3)))
            {
                ball.Right = true;
                ball.Up = true;
                ball.Left = false;
                ball.Down = false;
            }
            //Middle L
            if (pbBall.Bounds.IntersectsWith(new Rectangle(pbPaddleL.Location.X, pbPaddleL.Location.Y + pbPaddleL.Height / 3, pbPaddleL.Width, pbPaddleL.Height / 3)))
            {
                ball.Right = true;
                ball.Up = false;
                ball.Left = false;
                ball.Down = false;
            }
            //Bottom L
            if (pbBall.Bounds.IntersectsWith(new Rectangle(pbPaddleL.Location.X, pbPaddleL.Location.Y + 2 * pbPaddleL.Height / 3, pbPaddleL.Width, pbPaddleL.Height / 3)))
            {
                ball.Right = true;
                ball.Down = true;
                ball.Left = false;
                ball.Up = false;
            }

            //Top R
            if (pbBall.Bounds.IntersectsWith(new Rectangle(pbPaddleR.Location.X, pbPaddleR.Location.Y, pbPaddleR.Width, pbPaddleR.Height / 3)))
            {
                ball.Left = true;
                ball.Up = true;
                ball.Right = false;
                ball.Down = false;
            }
            //Middle R
            if (pbBall.Bounds.IntersectsWith(new Rectangle(pbPaddleR.Location.X, pbPaddleR.Location.Y + pbPaddleR.Height / 3, pbPaddleR.Width, pbPaddleR.Height / 3)))
            { 
                ball.Left = true;
                ball.Down = false;
                ball.Right = false;
                ball.Up = false;
            }

            //Bottom R
            if (pbBall.Bounds.IntersectsWith(new Rectangle(pbPaddleR.Location.X, pbPaddleR.Location.Y + 2 * pbPaddleR.Height / 3, pbPaddleR.Width, pbPaddleR.Height / 3)))
            {
                ball.Left = true;
                ball.Down = true;
                ball.Right = false;
                ball.Up = false;
            }

            //TOP AND BOTTOM WALLS
            //WALL HIT SOUND
            if (pbBall.Top <= 0 || pbBall.Bottom >= this.Height)
                wallHitSound.Play();

            if (pbBall.Top <= 0)
            { 
                ball.Down = true;
                ball.Up = false;
            }

            if (pbBall.Bottom >= this.Height)
            {
                ball.Up = true;
                ball.Down = false;
            }

            //SCORING

            //SCORE SOUND
            if (pbBall.Right >= this.Width || pbBall.Left <= 0)
                scoreSound.Play();

            if (pbBall.Right >= this.Width)
            {
                lblScoreL.Text = (Convert.ToInt32(lblScoreL.Text) + 1).ToString();
                GameStart();
            }
            
            if (pbBall.Left <= 0)
            {
                lblScoreR.Text = (Convert.ToInt32(lblScoreR.Text) + 1).ToString();
                GameStart();
            }

            if (pbBall.Bounds.IntersectsWith(pbPaddleR.Bounds))
            {
                rally++;
                lblRally.Text = $"Rally: {rally}";
            }

            if (maxScoreB)
                Winner();
        }
    }
}
