namespace Pongue
{
    public partial class Form1 : Form
    {
        private int ballMoveX = 8;
        private int ballMoveY = 8;

        int pointL = 0;
        int pointR = 0;
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;

            timer1.Interval = 5;   // milliseconds
            timer1.Tick += timer1_Tick;  // set handler
            timer1.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int lY = paddleL.Location.Y;
            int lX = paddleL.Location.X;
            int rY = paddleR.Location.Y;
            int rX = paddleR.Location.X;

            if (e.KeyCode == Keys.Up) rY -= 25;
            else if (e.KeyCode == Keys.Down) rY += 25;
            else if (e.KeyCode == Keys.W) lY -= 25;
            else if (e.KeyCode == Keys.S) lY += 25;
            else if (e.KeyCode == Keys.M)
            {
                ballMoveX = -ballMoveX;
                ballMoveY = -ballMoveY;
            }

            paddleL.Location = new Point(lX, lY);
            paddleR.Location = new Point(rX, rY);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ballPosX = ball.Location.X;
            int ballPosY = ball.Location.Y;
            int ballWidth = 40;
            int ballHeight = 40;

            if (ballPosX < 0)
            {
                pointR += 1;
                ballPosX = 881;
                ballPosY = 486;
                scoreR.Text = Convert.ToString(pointR);
                ballMoveY = -ballMoveY;
                ballMoveX = -ballMoveX;
            }
            else if (ballPosX + ballWidth > this.ClientSize.Width)
            {
                pointL += 1;
                ballPosX = 881;
                ballPosY = 486;
                scoreL.Text = Convert.ToString(pointL);
            }
            else if (ballPosY < 0 || ballPosY + ballHeight > this.ClientSize.Height)
            {
                ballMoveY = -ballMoveY;
            }
            else if (ball.Bounds.IntersectsWith(paddleR.Bounds) || ball.Bounds.IntersectsWith(paddleL.Bounds))
            {
                ballMoveX = -ballMoveX;
            }

            ballPosX += ballMoveX;
            ballPosY += ballMoveY;

            ball.Location = new Point(ballPosX, ballPosY);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}