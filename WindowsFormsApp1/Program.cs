using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System.IO;
using WindowsFormsApp1;

namespace Example
{
    public class Program : Form
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        public class coord
        {
            public int X;
            public int Y;
            public coord(int x, int y)
            {
                X = x; Y = y;
            }
        }

        Timer timer = new Timer();
        Random rand = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
        int S = 20;
        List<coord> snake = new List<coord>();
        coord apple;
        int way = 0; // направление движения змеи: 0 - вверх, 1 - вправо, 2 - вниз, 3 - влево
        int apples = 0;
        int stage = 1;
        public int score = 0;
        public string name;
        static string path = @"base.txt";
        static List<Playerscore> PS = new List<Playerscore>();

        struct Playerscore
        {
            public string Name;
            public int Score;
            public Playerscore(string nam, int scr)
            {
                Name = nam;
                Score = scr;
            }
        }

        public Program(string Nname)
        {
            this.name = Nname;
            this.Text = "Змейка";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;

            this.Size = new Size(800, 600);

            this.Paint += new PaintEventHandler(Program_Paint);
            this.KeyDown += new KeyEventHandler(Program_KeyDown);

            timer.Interval = 130;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            snake.Add(new coord(200, 200));
            apple = new coord(rand.Next(0, 38) * S, rand.Next(0, 27) * S);
        }

        void Program_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Up:
                    if (way != 2) way = 0;
                    break;
                case Keys.Right:
                    if (way != 3) way = 1;
                    break;
                case Keys.Down:
                    if (way != 0) way = 2;
                    break;
                case Keys.Left:
                    if (way != 1) way = 3;
                    break;
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            EatItself();
            int x = snake[0].X, y = snake[0].Y;
            Ushel(x, y);
            switch (way)
            {
                case 0: y -= S; break;
                case 1: x += S; break;
                case 2: y += S; break;
                case 3: x -= S; break;
            }
            coord c = new coord(x, y);
            snake.Insert(0, c);
            if ((apple.X == snake[0].X) && (apple.Y == snake[0].Y))
            {
                apple = new coord(rand.Next(0, 38) * S, rand.Next(0, 27) * S);
                apples++;
                score += stage;
                if (apples % 10 == 0)
                {
                    stage++;
                    timer.Interval -= 10;
                }
            }
            else
                snake.RemoveAt(snake.Count - 1);

            Invalidate();
        }

        void EatItself()
        {
            if (snake.Count > 1)
            {
                for (int i = 2; i < snake.Count; i++)
                {
                    if (snake[0].X == snake[i].X && snake[0].Y == snake[i].Y)
                    {
                        GameOver();
                    }
                }
            }
        }

        void Ushel(int x, int y)
        {
            if ((x < 0) || (x > 760) || (y < 0) || (y > 550))
            {
                GameOver();
            }
        }

        void GameOver()
        {
            timer.Stop();
            MessageBox.Show("Вы проиграли\nВаш счёт: " + score.ToString());

            LoadDataFromFile();
            PS.Add(new Playerscore(name, score));
            SaveDataToFile();
            Application.Exit();
        }

        static void SaveDataToFile()
        {
            using (StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8))
            {
                foreach (var PS1 in PS)
                {
                    writer.WriteLine($"{PS1.Name},{PS1.Score}");
                }
            }
        }

        static void LoadDataFromFile()
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path, Encoding.UTF8);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        Playerscore kekw = new Playerscore
                        {
                            Name = parts[0],
                            Score = int.TryParse(parts[1], out int score) ? score : 0
                        };

                        PS.Add(kekw);
                    }
                }
                PS.Sort((t1, t2) => t2.Score.CompareTo(t1.Score));
            }
        }

        void Program_Paint(object sender, PaintEventArgs e)
        {
            DrawApple(e.Graphics, apple.X, apple.Y);

            e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(102, 169, 107)), new Rectangle(snake[0].X, snake[0].Y, S, S));

            DrawSnakeEyes(e.Graphics, snake[0].X, snake[0].Y);

            for (int i = 1; i < snake.Count; i++)
                e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(132, 199, 137)), new Rectangle(snake[i].X, snake[i].Y, S, S));

            string state = "Яблоки:" + apples.ToString() + "\n" +
                           "Этап:" + stage.ToString() + "\n" + "Счёт:" + score.ToString();
            e.Graphics.DrawString(state, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(5, 5));
        }
        void DrawApple(Graphics g, int x, int y)
        {
            Brush appleBrush = new SolidBrush(Color.Red);
            g.FillEllipse(appleBrush, new Rectangle(x, y, S, S));

            Brush stemBrush = new SolidBrush(Color.Brown);
            g.FillRectangle(stemBrush, x + S / 2 - 2, y - 5, 4, 10);

            Brush leafBrush = new SolidBrush(Color.Green);
            Point[] leafPoints =
            {
                new Point(x + S / 2 + 5, y - 10),
                new Point(x + S / 2 + 10, y - 5),
                new Point(x + S / 2, y - 5)
            };
            g.FillPolygon(leafBrush, leafPoints);
        }
        void DrawSnakeEyes(Graphics g, int x, int y)
        {
            Brush eyeBrush = new SolidBrush(Color.White);
            g.FillEllipse(eyeBrush, new Rectangle(x + 5, y + 5, 7, 7));
            Brush pupilBrush = new SolidBrush(Color.Black);
            g.FillEllipse(pupilBrush, new Rectangle(x + 8, y + 8, 3, 3));
        }
    }
}
