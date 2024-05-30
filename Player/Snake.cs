using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class Snake : Form
    {
        private const int cellSize = 20;
        private const int boardSize = 20;
        private PictureBox[,] pictureBoxes;
        private Point[] snake;
        private Point food;
        private System.Windows.Forms.Timer timer;
        private int score;
        private int snakeLength;
        private bool alert;
        private bool directionUpdated;

        public Snake()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void Snake_Load(object sender, EventArgs e)
        {

        }

        private void InitializeGame()
        {
            score = 0;
            pictureBoxes = new PictureBox[boardSize, boardSize];
            snake = new Point[boardSize * boardSize];
            snakeLength = 1; 
            directionUpdated = false;

            for (int y = 0; y < boardSize; y++)
            {
                for (int x = 0; x < boardSize; x++)
                {
                    pictureBoxes[x, y] = new PictureBox
                    {
                        Size = new Size(cellSize, cellSize),
                        Location = new Point(x * cellSize, y * cellSize),
                        BorderStyle = BorderStyle.FixedSingle,
                        Visible = true,
                        Parent = this,
                        BackColor = Color.White 
                    };
                }
            }

            snake[0] = new Point(boardSize / 2, boardSize / 2);

            GenerateFood();

            timer = new System.Windows.Forms.Timer { Interval = 100 };
            timer.Tick += Timer_Tick;
            timer.Start();

            this.KeyDown += new KeyEventHandler(Snake_KeyDown);
            this.Focus();
        }

        private void GenerateFood()
        {
            Random rand = new Random();
            do
            {
                food = new Point(rand.Next(0, boardSize), rand.Next(0, boardSize));
            } while (Array.IndexOf(snake, food, 0, snakeLength) != -1);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MoveSnake();
            CheckCollision();
            UpdateUI();
            directionUpdated = false;
        }

        private void MoveSnake()
        {
            for (int i = snakeLength; i > 0; i--)
            {
                snake[i] = snake[i - 1];
            }

            switch (direction)
            {
                case Direction.Up:
                    snake[0] = new Point(snake[0].X, snake[0].Y - 1);
                    break;
                case Direction.Down:
                    snake[0] = new Point(snake[0].X, snake[0].Y + 1);
                    break;
                case Direction.Left:
                    snake[0] = new Point(snake[0].X - 1, snake[0].Y);
                    break;
                case Direction.Right:
                    snake[0] = new Point(snake[0].X + 1, snake[0].Y);
                    break;
            }
        }

        private void CheckCollision()
        {
            if (snake[0].X < 0 || snake[0].X >= boardSize || snake[0].Y < 0 || snake[0].Y >= boardSize)
            {
                GameOver();
                return;
            }

            if (snake[0] == food)
            {
                score++;
                snakeLength++;
                GenerateFood();
            }

            for (int i = 1; i < snakeLength; i++)
            {
                if (snake[i] == snake[0])
                {
                    GameOver();
                    return;
                }
            }
        }

        private void UpdateUI()
        {
            foreach (var pb in pictureBoxes)
            {
                pb.BackColor = Color.White;
            }

            for (int i = 0; i < snakeLength; i++)
            {
                pictureBoxes[snake[i].X, snake[i].Y].BackColor = Color.Black;
            }

            pictureBoxes[food.X, food.Y].BackColor = Color.Red;

            lblScore.Text = $"Score: {score}";
        }

        private void GameOver()
        {
            timer.Stop();
            if (!alert)
            {
                MessageBox.Show($"Game Over! Your score is {score}");
                alert = true;
            }

            InitializeGame();
        }
        private enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        private Direction direction = Direction.Right;
        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            if (directionUpdated) return;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (direction != Direction.Down)
                    {
                        direction = Direction.Up;
                        directionUpdated = true;
                    }
                    break;
                case Keys.Down:
                    if (direction != Direction.Up)
                    {
                        direction = Direction.Down;
                        directionUpdated = true;
                    }
                    break;
                case Keys.Left:
                    if (direction != Direction.Right)
                    {
                        direction = Direction.Left;
                        directionUpdated = true;
                    }
                    break;
                case Keys.Right:
                    if (direction != Direction.Left)
                    {
                        direction = Direction.Right;
                        directionUpdated = true;
                    }
                    break;
                case Keys.W:
                case Keys.A:
                case Keys.S:
                case Keys.D:
                    HandleWASDKeys(e.KeyCode);
                    break;
                default:
                    break;
            }
        }

        private void HandleWASDKeys(Keys key)
        {
            if (directionUpdated) return;

            switch (key)
            {
                case Keys.W:
                    if (direction != Direction.Down)
                    {
                        direction = Direction.Up;
                        directionUpdated = true;
                    }
                    break;
                case Keys.A:
                    if (direction != Direction.Right)
                    {
                        direction = Direction.Left;
                        directionUpdated = true;
                    }
                    break;
                case Keys.S:
                    if (direction != Direction.Up)
                    {
                        direction = Direction.Down;
                        directionUpdated = true;
                    }
                    break;
                case Keys.D:
                    if (direction != Direction.Left)
                    {
                        direction = Direction.Right;
                        directionUpdated = true;
                    }
                    break;
            }
        }
    }
}
