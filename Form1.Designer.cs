namespace Lab8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(152, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(486, 232);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Нулевая матрица";
            this.button1.UseVisualStyleBackColor = true;
            button1.Click += (s, e) => GenerateMatrix(new ZeroMatrixGenerator());
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Еденичная матрица";
            this.button2.UseVisualStyleBackColor = true;
            button2.Click += (s, e) => GenerateMatrix(new DiagonalOnesGenerator());
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 83);
            this.button3.TabIndex = 4;
            this.button3.Text = "Главная диагональ рандомные значения";
            this.button3.UseVisualStyleBackColor = true;
            button3.Click += (s, e) => GenerateMatrix(new RandomDiagonalGenerator());
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(46, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 99);
            this.button4.TabIndex = 5;
            this.button4.Text = "Заполнение всей матрицы рандомными значениями";
            this.button4.UseVisualStyleBackColor = true;
            button4.Click += (s, e) => GenerateMatrix(new RandomMatrixGenerator());
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(46, 351);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 73);
            this.button5.TabIndex = 6;
            this.button5.Text = "Заполнение всей матрицы змейкой";
            this.button5.UseVisualStyleBackColor = true;
            button5.Click += (s,e) => GenerateMatrix(new SnakeMatrixGenerator());
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 452);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

