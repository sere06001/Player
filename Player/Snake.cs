using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class Snake : Form
    {
        private const int cellSize = 20;
        private int boardSize;
        private PictureBox[,] pictureBoxes;
        private Point[] snake;
        private Point food;
        private System.Windows.Forms.Timer timer;
        private int score;
        private int snakeLength;
        private bool alert;
        private bool directionUpdated;
        private bool isClosing;

        private int offsetX;
        private int offsetY;
        public Snake()
        {
            InitializeComponent();
        }

        private void Snake_Load(object sender, EventArgs e)
        {

        }
        private void InitializeGame()
        {
            alert = false;
            score = 0;
            snakeLength = 4;
            directionUpdated = false;
            direction = Direction.Right;
            isClosing = false;

            pictureBoxes = new PictureBox[boardSize, boardSize];
            snake = new Point[boardSize * boardSize];

            this.Controls.Clear();

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
                    this.Controls.Add(pictureBoxes[x, y]);
                }
            }

            lblScore = new System.Windows.Forms.Label
            {
                Text = $"Poäng: {score}",
                Location = new Point(offsetX, offsetY),
                AutoSize = true,
                Font = new Font("Arial", 14, FontStyle.Bold)
            };
            this.Controls.Add(lblScore);

            snake[0] = new Point(2, boardSize / 2);

            GenerateFood();

            timer = new System.Windows.Forms.Timer { Interval = 125 };
            timer.Tick += Timer_Tick;
            timer.Start();

            this.KeyDown += new KeyEventHandler(Snake_KeyDown);
            this.FormClosing += new FormClosingEventHandler(Snake_FormClosing);
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
            if (snakeLength > 0)
            {
                pictureBoxes[snake[0].X, snake[0].Y].BackColor = Color.Blue;
            }
            

            for (int i = 1; i < snakeLength; i++)
            {
                pictureBoxes[snake[i].X, snake[i].Y].BackColor = Color.Green;
            }

            pictureBoxes[food.X, food.Y].BackColor = Color.Red;

            lblScore.Text = $"Poäng: {score}";
        }

        private void GameOver()
        {
            timer.Stop();
            if (!alert && !isClosing)
            {
                alert = true;
                DialogResult result = MessageBox.Show($"Du lyckades äta {score} matbitar\nVill du börja om?", "Du dog!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (!isClosing)
                    {
                        ResetGame();
                    }
                }
                else
                {
                    snakeLength = 0;
                    this.Hide();
                    Snake f1 = new Snake();
                    f1.Show();
                }
                alert = false;
            }

            
        }

        private void ResetGame()
        {
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

        private void Snake_FormClosing(object sender, FormClosingEventArgs e)
        {
            isClosing = true;
            timer.Stop();
        }

        private void tillbakabtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Välj_spel f1 = new Välj_spel();
            f1.Show();
        }

        public void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void smallbtn_Click_1(object sender, EventArgs e)
        {
            offsetX = 75;
            offsetY = 215;
            boardSize = 10;
            InitializeGame();
        }

        private void medbtn_Click_1(object sender, EventArgs e)
        {
            offsetX = 100;
            offsetY = 315;
            boardSize = 15;
            InitializeGame();
        }

        private void hardbtn_Click(object sender, EventArgs e)
        {
            offsetX = 125;
            offsetY = 415;
            boardSize = 20;
            InitializeGame();
        }

        private void tillbakabtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Välj_spel f1 = new Välj_spel();
            f1.Show();
        }
    }
}
