/*
 * Абахтимов Алексей Александрович. Группа 191-311 (Управление в технических системах, 1 курс).
 * Московский Политехнический университет.
 * Ссылка на GitHub: https://github.com/AmazingRoovy
 * Дата и время последнего редактирования: 19:50 22.05.2020.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Work_03
{
    public partial class Form1 : Form
    {
        public const int NUM_DEFAULT_ROWS    = 3;
        public const int NUM_DEFAULT_COLUMNS = 3;

        public Form1()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Refresh();

            DataGridViewTextBoxColumn col;
            for (int c = 0; c < NUM_DEFAULT_COLUMNS; ++c)
            {
                col = new DataGridViewTextBoxColumn();
                col.HeaderText = "Column " + (c + 1).ToString();
                col.ReadOnly = true;
                col.Width = 125;

                dataGridView.Columns.Add(col);
            }

            Random random = new Random();
            DataGridViewRow row;
            DataGridViewTextBoxCell cell;
            for (int r = 0; r < NUM_DEFAULT_ROWS; ++r)
            {
                row = new DataGridViewRow();
                for (int c = 0; c < NUM_DEFAULT_COLUMNS; ++c)
                {
                    cell = new DataGridViewTextBoxCell();
                    // Отображение в бежевом - лучшее качество просмотра.
                    cell.Style.BackColor = Color.Beige;

                    cell.Style.ForeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256), random.Next(256));
                    cell.Value = random.Next(101).ToString();
                    row.Cells.Add(cell);
                }
                dataGridView.Rows.Add(row);
            }
        }

        private void generateData_button_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Refresh();

            this.error_label.Text = "";

            int rowNumber;
            int columnNumber;

            if (this.rowNumber_textBox.Text == "")
                rowNumber_textBox.Text = NUM_DEFAULT_ROWS.ToString();
            if (this.columnNumber_textBox.Text == "")
                columnNumber_textBox.Text = NUM_DEFAULT_COLUMNS.ToString();

            if (!int.TryParse(this.rowNumber_textBox.Text.Trim(), out rowNumber))
            {
                this.error_label.Text = "Неправильный формат!";
                rowNumber = NUM_DEFAULT_ROWS;
            }

            if (!int.TryParse(this.columnNumber_textBox.Text.Trim(), out columnNumber))
            {
                this.error_label.Text = "Неправильный формат!";
                columnNumber = NUM_DEFAULT_COLUMNS;
            }

            // Ограничение по оптимальному количеству корректно добавляемых колонок в DataGridView. 
            if (columnNumber > 654)
            {
                columnNumber = 654;
                columnNumber_textBox.Text = columnNumber.ToString();
            }

            Random random = new Random();
            DataGridViewTextBoxColumn col;
            for (int c = 0; c < columnNumber; ++c)
            {
                col = new DataGridViewTextBoxColumn();
                col.HeaderText = "Column " + (c + 1).ToString();
                col.ReadOnly = true;
                col.Width = 125;

                dataGridView.Columns.Add(col);
            }

            DataGridViewRow row;
            DataGridViewTextBoxCell cell;
            for (int r = 0; r < rowNumber; ++r)
            {
                row = new DataGridViewRow();
                for (int c = 0; c < columnNumber; ++c)
                {
                    cell = new DataGridViewTextBoxCell();
                    // Отображение в бежевом - лучшее качество просмотра.
                    cell.Style.BackColor = Color.Beige;

                    cell.Style.ForeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256), random.Next(256));
                    cell.Value = random.Next(101).ToString();
                    row.Cells.Add(cell);
                }
                dataGridView.Rows.Add(row);
            }
            
        }
    }
}
