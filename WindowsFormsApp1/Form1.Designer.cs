using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = Color.FromArgb(173, 204, 174);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.button1.ForeColor = Color.White;
            this.button1.Location = new System.Drawing.Point(35, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Играть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.BorderColor = Color.FromArgb(120, 160, 130);
            this.button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 190, 150);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = Color.FromArgb(173, 204, 174);
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.button2.ForeColor = Color.White;
            this.button2.Location = new System.Drawing.Point(35, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Таблица рекордов";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.BorderColor = Color.FromArgb(120, 160, 130);
            this.button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 190, 150);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.label1.ForeColor = Color.FromArgb(55, 71, 79);
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите имя игрока:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.textBox1.ForeColor = Color.FromArgb(55, 71, 79);
            this.textBox1.Location = new System.Drawing.Point(35, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(250, 260);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Змейка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Button button2;
        private Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
