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
    public partial class Form2 : Form
    {
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

        public Form2()
        {
            InitializeComponent();
            PS.Clear();
            LoadDataFromFile();
            load();
        }

        void load()
        {
            dataGridView1.Rows.Clear();
            foreach (var PS1 in PS)
            {
                dataGridView1.Rows.Add(PS1.Name, PS1.Score);
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
                PS.Sort(delegate (Playerscore t1, Playerscore t2)
                { return (t2.Score.CompareTo(t1.Score)); });
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.FromArgb(245, 255, 250);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 255, 220);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(245, 255, 250);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 255, 230);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            load();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
