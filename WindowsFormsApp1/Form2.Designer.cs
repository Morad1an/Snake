using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = Color.White;
            this.dataGridView1.BorderStyle = BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.Score});
            this.dataGridView1.Location = new System.Drawing.Point(30, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = Color.FromArgb(173, 204, 174);
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.button1.ForeColor = Color.White;
            this.button1.Location = new System.Drawing.Point(370, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.BorderColor = Color.FromArgb(120, 160, 130);
            this.button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 190, 150);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Names
            // 
            this.Names.HeaderText = "Имена";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Width = 150;
            // 
            // Score
            // 
            this.Score.HeaderText = "Очки";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 150;
            // 
            // form2BindingSource
            // 
            this.form2BindingSource.DataSource = typeof(WindowsFormsApp1.Form2);
            // 
            // form2BindingSource1
            // 
            this.form2BindingSource1.DataSource = typeof(WindowsFormsApp1.Form2);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(500, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица рекордов";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource form2BindingSource;
        private System.Windows.Forms.BindingSource form2BindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}
