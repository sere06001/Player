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

            // Initialize PictureBoxes and snake array
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
                        BackColor = Color.White // Set initial color of cells
                    };
                }
            }

            // Initialize snake
            snake[0] = new Point(boardSize / 2, boardSize / 2);

            // Generate initial food
            GenerateFood();

            // Initialize timer
            timer = new System.Windows.Forms.Timer { Interval = 100 };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void GenerateFood()
        {
            Random rand = new Random();
            do
            {
                food = new Point(rand.Next(0, boardSize), rand.Next(0, boardSize));
            } while (Array.IndexOf(snake, food) != -1); // Ensure food is not on the snake
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MoveSnake();
            CheckCollision();
            UpdateUI();
        }

        private void MoveSnake()
        {
            // Move snake's body
            for (int i = snake.Length - 1; i > 0; i--)
            {
                snake[i] = snake[i - 1];
            }

            // Move snake's head
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
            // Check for collision with boundaries
            if (snake[0].X < 0 || snake[0].X >= boardSize || snake[0].Y < 0 || snake[0].Y >= boardSize)
            {
                GameOver();
                return;
            }

            // Check for collision with food
            if (snake[0] == food)
            {
                score++;
                GenerateFood();
            }

            // Check for collision with itself
            for (int i = 1; i < snake.Length; i++)
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
            // Update PictureBoxes to reflect snake's position
            foreach (var pb in pictureBoxes)
            {
                pb.BackColor = Color.White; // Reset all cells to white
            }

            foreach (var segment in snake)
            {
                pictureBoxes[segment.X, segment.Y].BackColor = Color.Black; // Draw snake
            }

            pictureBoxes[food.X, food.Y].BackColor = Color.Red; // Draw food

            // Update score label
            lblScore.Text = $"Score: {score}";
        }

        private void GameOver()
        {
            timer.Stop();
            MessageBox.Show($"Game Over! Your score is {score}");
            InitializeGame();
        }

        // Direction enum
        private enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        private Direction direction = Direction.Right; // Initial direction

        // KeyDown event handler
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    direction = Direction.Up;
                    break;
                case Keys.Down:
                    direction = Direction.Down;
                    break;
                case Keys.Left:
                    direction = Direction.Left;
                    break;
                case Keys.Right:
                    direction = Direction.Right;
                    break;
            }
        }
    }
}
