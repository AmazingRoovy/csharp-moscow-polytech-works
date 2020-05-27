namespace Practice_Work_03
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.generateData_button = new System.Windows.Forms.Button();
            this.rowNumber_textBox = new System.Windows.Forms.TextBox();
            this.columnNumber_textBox = new System.Windows.Forms.TextBox();
            this.rowNumber_label = new System.Windows.Forms.Label();
            this.columnNumber_label = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1013, 543);
            this.dataGridView.TabIndex = 0;
            // 
            // generateData_button
            // 
            this.generateData_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateData_button.Location = new System.Drawing.Point(541, 666);
            this.generateData_button.Name = "generateData_button";
            this.generateData_button.Size = new System.Drawing.Size(222, 75);
            this.generateData_button.TabIndex = 1;
            this.generateData_button.Text = "Сгенерирвать таблицу!";
            this.generateData_button.UseVisualStyleBackColor = true;
            this.generateData_button.Click += new System.EventHandler(this.generateData_button_Click);
            // 
            // rowNumber_textBox
            // 
            this.rowNumber_textBox.Location = new System.Drawing.Point(309, 596);
            this.rowNumber_textBox.Name = "rowNumber_textBox";
            this.rowNumber_textBox.Size = new System.Drawing.Size(176, 26);
            this.rowNumber_textBox.TabIndex = 2;
            // 
            // columnNumber_textBox
            // 
            this.columnNumber_textBox.Location = new System.Drawing.Point(309, 675);
            this.columnNumber_textBox.Name = "columnNumber_textBox";
            this.columnNumber_textBox.Size = new System.Drawing.Size(176, 26);
            this.columnNumber_textBox.TabIndex = 3;
            // 
            // rowNumber_label
            // 
            this.rowNumber_label.AutoSize = true;
            this.rowNumber_label.Location = new System.Drawing.Point(319, 637);
            this.rowNumber_label.Name = "rowNumber_label";
            this.rowNumber_label.Size = new System.Drawing.Size(147, 20);
            this.rowNumber_label.TabIndex = 4;
            this.rowNumber_label.Text = "Количество строк";
            // 
            // columnNumber_label
            // 
            this.columnNumber_label.AutoSize = true;
            this.columnNumber_label.Location = new System.Drawing.Point(319, 721);
            this.columnNumber_label.Name = "columnNumber_label";
            this.columnNumber_label.Size = new System.Drawing.Size(166, 20);
            this.columnNumber_label.TabIndex = 5;
            this.columnNumber_label.Text = "Количество колонок";
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error_label.Location = new System.Drawing.Point(541, 596);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 29);
            this.error_label.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 774);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.columnNumber_label);
            this.Controls.Add(this.rowNumber_label);
            this.Controls.Add(this.columnNumber_textBox);
            this.Controls.Add(this.rowNumber_textBox);
            this.Controls.Add(this.generateData_button);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Генератор таблиц";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button generateData_button;
        private System.Windows.Forms.TextBox rowNumber_textBox;
        private System.Windows.Forms.TextBox columnNumber_textBox;
        private System.Windows.Forms.Label rowNumber_label;
        private System.Windows.Forms.Label columnNumber_label;
        private System.Windows.Forms.Label error_label;
    }
}

