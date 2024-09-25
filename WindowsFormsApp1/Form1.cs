using Example;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDataFromFile();
            SaveDataToFile();
        }

        string name;

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        public static string path = @"base.txt";
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

        static List<Playerscore> PS = new List<Playerscore>();

        static void LoadDataFromFile()
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        Playerscore kekw = new Playerscore
                        {
                            Name = parts[0],
                            Score = int.Parse(parts[1])
                        };

                        PS.Add(kekw);
                    }
                }
                PS.Sort(delegate (Playerscore t1, Playerscore t2)
                { return (t2.Score.CompareTo(t1.Score)); });
            }
        }

        static void SaveDataToFile()
        {
            using (StreamWriter writer = new StreamWriter(path, false, Encoding.Default))
            {
                foreach (var PS1 in PS)
                {
                    writer.WriteLine($"{PS1.Name},{PS1.Score}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            if (IsLatin(name))
            {
                if (!string.IsNullOrEmpty(name))
                {
                    this.Hide();
                    Program newprog = new Program(name);
                    newprog.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Введите имя пользователя!");
                }
            }
            else
            {
                MessageBox.Show("Имя пользователя должно содержать только латиницу!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Tablica = new Form2();
            Tablica.ShowDialog();
            this.Show();
        }

        private bool IsLatin(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) || c < 'A' || (c > 'Z' && c < 'a') || c > 'z')
                {
                    return false;
                }
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
