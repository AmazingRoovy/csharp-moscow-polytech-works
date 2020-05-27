using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Practice_Work_04
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.second_groupBox.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workers_DatabaseDataSet.worker_table". При необходимости она может быть перемещена или удалена.
            //this.worker_tableTableAdapter.Fill(this.workers_DatabaseDataSet.worker_table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workers_DatabaseDataSet.state_table". При необходимости она может быть перемещена или удалена.
            this.state_tableTableAdapter.Fill(this.workers_DatabaseDataSet.state_table);

        }

        private void stateNumber_textBox_Leave(object sender, EventArgs e)
        {
            error_label.Text = "Проблем не найдено.";
            error_label.ForeColor = Color.DarkGreen;

            int number_of_state;

            if (!int.TryParse(stateNumber_textBox.Text.Trim(), out number_of_state) || number_of_state < 0)
            {
                error_label.Text = "Невозможно преобразовать текст к номеру штата!";
                error_label.ForeColor = Color.DarkRed;
                this.stateNumber_textBox.Text = "0";
            }
        }

        private void initialsBoss_textBox_Leave(object sender, EventArgs e)
        {
            error_label.Text = "Проблем не найдено.";
            error_label.ForeColor = Color.DarkGreen;

            string[] splitted_initials = this.initialsBoss_textBox.Text.Trim().Split(new Char[] { ' ' });

            if (this.initialsBoss_textBox.Text.Any(char.IsDigit))
            {
                error_label.Text = "Символы-цифры в фамилии и инициалах!";
                error_label.ForeColor = Color.DarkRed;
            }

            if (splitted_initials.Length != 3)
            {
                error_label.Text = "Некорректный формат фамилии и инициалов!";
                error_label.ForeColor = Color.DarkRed;
            }
            else if (splitted_initials[1].Trim().Length != 2 || splitted_initials[2].Trim().Length != 2)
            {
                error_label.Text = "Инициалы должны быть однобуквенными с точкой!";
                error_label.ForeColor = Color.DarkRed;
            }
            else 
            {
                this.initialsBoss_textBox.Text = splitted_initials[0].Substring(0, 1).ToUpper() + splitted_initials[0].Substring(1, splitted_initials[0].Length - 1).ToLower() + " " +
                    splitted_initials[1].ToUpper() + " " + splitted_initials[2].ToUpper();
            }
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 view_form = new Form1();
            view_form.Show();
        }

        private void changeTable_button_Click(object sender, EventArgs e)
        {
            if (this.first_groupBox.Enabled)
            {
                this.dataGridView.AutoGenerateColumns = true;
                this.second_groupBox.Enabled = true;
                this.first_groupBox.Enabled = false;
                this.dataGridView.DataSource = workertableBindingSource;
                this.worker_tableTableAdapter.Fill(this.workers_DatabaseDataSet.worker_table);
            }
            else
            {
                this.dataGridView.AutoGenerateColumns = true;
                this.second_groupBox.Enabled = false;
                this.first_groupBox.Enabled = true;
                this.dataGridView.DataSource = statetableBindingSource;
                this.state_tableTableAdapter.Fill(this.workers_DatabaseDataSet.state_table);
            }

        }

        private void stateCount_textBox_Leave(object sender, EventArgs e)
        {
            error_label.Text = "Проблем не найдено.";
            error_label.ForeColor = Color.DarkGreen;

            int workers_counter;

            if (!int.TryParse(stateCount_textBox.Text.Trim(), out workers_counter) || workers_counter < 0)
            {
                error_label.Text = "Невозможно преобразовать текст к количеству сотрудников!";
                error_label.ForeColor = Color.DarkRed;
                this.stateCount_textBox.Text = "0";
            } 

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (this.first_groupBox.Enabled && this.error_label.ForeColor == Color.DarkGreen)
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\ALEX EY\Documents\Workers_Database.accdb";

                OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
                OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
                myOleDbCommand.CommandText = "SELECT * FROM state_table";
                myOleDbConnection.Open();

                OleDbCommand addNewRecord;

                try
                {
                    addNewRecord = myOleDbConnection.CreateCommand();
                    addNewRecord.CommandText = $@"INSERT INTO state_table VALUES ({Convert.ToInt32(this.stateNumber_textBox.Text)}, '{this.initialsBoss_textBox.Text}', {Convert.ToInt32(this.stateCount_textBox.Text)});";
                    addNewRecord.ExecuteNonQuery();

                    this.error_label.Text = $"Добавление новой записи отдела проведено успешно.";
                    this.error_label.ForeColor = Color.DarkGreen;
                }

                catch (Exception ex)
                {
                    this.error_label.Text = "Отдел с таким номером уже существует!";
                    this.error_label.ForeColor = Color.DarkRed;
                }

                myOleDbConnection.Close();

                this.state_tableTableAdapter.Update(this.workers_DatabaseDataSet.state_table);
                this.state_tableTableAdapter.Fill(this.workers_DatabaseDataSet.state_table);
            }

            else if (this.second_groupBox.Enabled && this.error_label.ForeColor == Color.DarkGreen)
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\ALEX EY\Documents\Workers_Database.accdb";

                OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
                OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
                myOleDbCommand.CommandText = "SELECT * FROM worker_table";
                myOleDbConnection.Open();

                OleDbCommand addNewRecord;

                try
                {
                    addNewRecord = myOleDbConnection.CreateCommand();
                    addNewRecord.CommandText = $@"INSERT INTO worker_table VALUES ({Convert.ToInt32(this.stateNumberWorker_textBox.Text)}, '{this.initialsWorker_textBox.Text}',
                    '{this.role_textBox.Text}', '{this.enrollData_textBox.Text}', '{this.salary_textBox.Text}');";
                    addNewRecord.ExecuteNonQuery();

                    this.error_label.Text = $"Добавление новой записи работника проведено успешно.";
                    this.error_label.ForeColor = Color.DarkGreen;
                }

                catch (Exception ex)
                {
                    this.error_label.Text = "Возникло исключение!";
                    this.error_label.ForeColor = Color.DarkRed;
                }

                myOleDbConnection.Close();

                this.worker_tableTableAdapter.Update(this.workers_DatabaseDataSet.worker_table);
                this.worker_tableTableAdapter.Fill(this.workers_DatabaseDataSet.worker_table);
            }

            else
            {
                this.error_label.Text = "Проверьте все данные на корректность формата!";
                this.error_label.ForeColor = Color.DarkRed;
            }
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            if (this.first_groupBox.Enabled && this.error_label.ForeColor == Color.DarkGreen)
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\ALEX EY\Documents\Workers_Database.accdb";

                OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
                OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
                myOleDbCommand.CommandText = "SELECT * FROM state_table";
                myOleDbConnection.Open();

                OleDbCommand changeRecord;

                if (dataGridView.SelectedRows.Count == 1)
                {
                    DataGridViewRow row = dataGridView.SelectedRows[0];

                    changeRecord = myOleDbConnection.CreateCommand();
                    changeRecord.CommandText = $@"UPDATE state_table SET [Номер отдела] = {Convert.ToInt32(this.stateNumber_textBox.Text)}, [Фамилия и инициалы начальника] = '{this.initialsBoss_textBox.Text}',
                                                [Штат] = {Convert.ToInt32(this.stateCount_textBox.Text)} WHERE [Номер отдела] = {Convert.ToInt32(row.Cells[0].Value)}";

                    changeRecord.ExecuteNonQuery();
                    this.error_label.Text = $"Изменение строки {row.Index + 1} проведено успешно.";
                    this.error_label.ForeColor = Color.DarkGreen;

                }
                else
                {
                    this.error_label.Text = "Выберите одну строку в таблице для изменения!";
                    this.error_label.ForeColor = Color.DarkRed;
                }


                myOleDbConnection.Close();

                this.state_tableTableAdapter.Update(this.workers_DatabaseDataSet.state_table);
                this.state_tableTableAdapter.Fill(this.workers_DatabaseDataSet.state_table);
            }
            else if (this.second_groupBox.Enabled && this.error_label.ForeColor == Color.DarkGreen)
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\ALEX EY\Documents\Workers_Database.accdb";

                OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
                OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
                myOleDbCommand.CommandText = "SELECT * FROM worker_table";
                myOleDbConnection.Open();

                OleDbCommand changeRecord;

                if (dataGridView.SelectedRows.Count == 1)
                {
                    DataGridViewRow row = dataGridView.SelectedRows[0];

                    changeRecord = myOleDbConnection.CreateCommand();
                    changeRecord.CommandText = $@"UPDATE worker_table SET [Номер отдела] = {Convert.ToInt32(this.stateNumberWorker_textBox.Text)}, 
                        [Фамилия и инициалы сотрудника] = '{this.initialsWorker_textBox.Text}', [Должность] = '{this.role_textBox.Text}', [Дата поступления] = '{this.enrollData_textBox.Text}', 
                        [Зарплата] = '{this.salary_textBox.Text}' WHERE [Фамилия и инициалы сотрудника] = '{Convert.ToString(row.Cells[1].Value)}';";

                    changeRecord.ExecuteNonQuery();
                    this.error_label.Text = $"Изменение строки {row.Index + 1} проведено успешно.";
                    this.error_label.ForeColor = Color.DarkGreen;

                }
                else
                {
                    this.error_label.Text = "Выберите одну строку в таблице для изменения!";
                    this.error_label.ForeColor = Color.DarkRed;
                }


                myOleDbConnection.Close();

                this.worker_tableTableAdapter.Update(this.workers_DatabaseDataSet.worker_table);
                this.worker_tableTableAdapter.Fill(this.workers_DatabaseDataSet.worker_table);
            }
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            if (this.first_groupBox.Enabled)
            {
                if (dataGridView.SelectedRows.Count == 1)
                {
                    DataGridViewRow row = this.dataGridView.SelectedRows[0];
                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\ALEX EY\Documents\\Workers_Database.accdb";

                    OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
                    OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
                    myOleDbCommand.CommandText = "SELECT * FROM state_table";
                    myOleDbConnection.Open();
                    OleDbCommand addNewRecord;

                    addNewRecord = myOleDbConnection.CreateCommand();
                    addNewRecord.CommandText = $@"DELETE FROM state_table WHERE [Номер отдела] = {Convert.ToInt32(row.Cells[0].Value)};";
                    addNewRecord.ExecuteNonQuery();

                    myOleDbConnection.Close();

                    this.error_label.Text = $"Строка {row.Index + 1} успешно удалена.";
                    this.error_label.ForeColor = Color.DarkGreen;

                    this.state_tableTableAdapter.Update(this.workers_DatabaseDataSet.state_table);
                    this.state_tableTableAdapter.Fill(this.workers_DatabaseDataSet.state_table);
                }
                else
                {
                    this.error_label.Text = "Выберите одну строку в таблице для удаления!";
                    this.error_label.ForeColor = Color.DarkRed;
                }
            }
            else
            {
                if (dataGridView.SelectedRows.Count == 1)
                {
                    DataGridViewRow row = this.dataGridView.SelectedRows[0];
                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\ALEX EY\Documents\\Workers_Database.accdb";

                    OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
                    OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
                    myOleDbCommand.CommandText = "SELECT * FROM worker_table";
                    myOleDbConnection.Open();
                    OleDbCommand addNewRecord;

                    addNewRecord = myOleDbConnection.CreateCommand();
                    addNewRecord.CommandText = $@"DELETE FROM worker_table WHERE [Номер отдела] = {Convert.ToInt32(row.Cells[0].Value)} AND [Фамилия и инициалы сотрудника] = '{row.Cells[1].Value}';";
                    addNewRecord.ExecuteNonQuery();

                    myOleDbConnection.Close();

                    this.error_label.Text = $"Строка {row.Index + 1} успешно удалена.";
                    this.error_label.ForeColor = Color.DarkGreen;

                    this.worker_tableTableAdapter.Update(this.workers_DatabaseDataSet.worker_table);
                    this.worker_tableTableAdapter.Fill(this.workers_DatabaseDataSet.worker_table);
                }
                else
                {
                    this.error_label.Text = "Выберите одну строку в таблице для удаления!";
                    this.error_label.ForeColor = Color.DarkRed;
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            error_label.Text = "Проблем не найдено.";
            error_label.ForeColor = Color.DarkGreen;

            if (this.first_groupBox.Enabled) 
            { 
                if (this.dataGridView.SelectedRows.Count == 1)
                {
                    this.stateNumber_textBox.Text = this.dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    this.initialsBoss_textBox.Text = this.dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    this.stateCount_textBox.Text = this.dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                }

                if (this.stateNumber_textBox.Text.Trim() == "")
                    this.stateNumber_textBox.Text = "0";
                

                if (this.stateCount_textBox.Text.Trim() == "")
                    this.stateNumber_textBox.Text = "0";
            } 
            else
            {
                if (this.dataGridView.SelectedRows.Count == 1)
                {
                    try
                    {
                        string format = "dd.MM.yyyy";

                        this.stateNumberWorker_textBox.Text = this.dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                        this.initialsWorker_textBox.Text = this.dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                        this.role_textBox.Text = this.dataGridView.SelectedRows[0].Cells[2].Value.ToString();

                        DateTime dt_from_table = (DateTime)this.dataGridView.SelectedRows[0].Cells[3].Value;
                        this.enrollData_textBox.Text = dt_from_table.ToString(format);

                        this.salary_textBox.Text = Convert.ToString(this.dataGridView.SelectedRows[0].Cells[4].Value);
                    }
                    catch (Exception choose_ex)
                    {
                        this.error_label.Text = "Выбрана некорректная запись для редактирования или удаления!";
                        error_label.ForeColor = Color.DarkRed;
                    }
                }
            }
        }

        private void stateNumberWorker_textBox_Leave(object sender, EventArgs e)
        {
            error_label.Text = "Проблем не найдено.";
            error_label.ForeColor = Color.DarkGreen;

            int number_of_state;

            if (!int.TryParse(stateNumberWorker_textBox.Text.Trim(), out number_of_state) || number_of_state < 0)
            {
                error_label.Text = "Невозможно преобразовать текст к номеру штата!";
                error_label.ForeColor = Color.DarkRed;
                this.stateNumberWorker_textBox.Text = "0";
            }
        }

        private void initialsWorker_textBox_Leave(object sender, EventArgs e)
        {
            error_label.Text = "Проблем не найдено.";
            error_label.ForeColor = Color.DarkGreen;

            string[] splitted_initials = this.initialsWorker_textBox.Text.Trim().Split(new Char[] { ' ' });

            if (this.initialsWorker_textBox.Text.Any(char.IsDigit))
            {
                error_label.Text = "Символы-цифры в фамилии и инициалах!";
                error_label.ForeColor = Color.DarkRed;
            }

            if (splitted_initials.Length != 3)
            {
                error_label.Text = "Некорректный формат фамилии и инициалов!";
                error_label.ForeColor = Color.DarkRed;
            }
            else if (splitted_initials[1].Trim().Length != 2 || splitted_initials[2].Trim().Length != 2)
            {
                error_label.Text = "Инициалы должны быть однобуквенными с точкой!";
                error_label.ForeColor = Color.DarkRed;
            }
            else
            {
                this.initialsWorker_textBox.Text = splitted_initials[0].Substring(0, 1).ToUpper() + splitted_initials[0].Substring(1, splitted_initials[0].Length - 1).ToLower() + " " +
                    splitted_initials[1].ToUpper() + " " + splitted_initials[2].ToUpper();
            }
        }

        private void role_textBox_Leave(object sender, EventArgs e)
        {
            error_label.Text = "Проблем не найдено.";
            error_label.ForeColor = Color.DarkGreen;

            if (role_textBox.Text.Trim() == "")
            {
                error_label.Text = "Поле с должностью не заполнено!";
                error_label.ForeColor = Color.DarkRed;
            }
        }

        private void salary_textBox_Leave(object sender, EventArgs e)
        {
            error_label.Text = "Проблем не найдено.";
            error_label.ForeColor = Color.DarkGreen;

            int salary_amount;

            if (!int.TryParse(salary_textBox.Text.Trim(), out salary_amount) || salary_amount < 0)
            {
                this.error_label.Text = "Невозможно преобразовать текст к размеру зарплаты!";
                this.error_label.ForeColor = Color.DarkRed;
                this.salary_textBox.Text = "0";
            }
            else if (salary_amount < 50000 || salary_amount > 500000)
            {
                this.error_label.Text = "Зарплата выходит за допустимые пределы значений!";
                this.error_label.ForeColor = Color.DarkRed;
                if (salary_amount < 50000)
                {
                    salary_amount = 50000;
                }
                else
                {
                    salary_amount = 500000;
                }
                salary_textBox.Text = salary_amount.ToString();
            }
        }

        private void enrollData_textBox_Leave(object sender, EventArgs e)
        {
            string format = "dd.MM.yyyy";
            error_label.Text = "Проблем не найдено.";
            error_label.ForeColor = Color.DarkGreen;

            string[] splitted_data = enrollData_textBox.Text.Split(new Char[] { '.' });
            if (splitted_data.Length == 3)
            {
                int tmp;
                for (int index = 0; index < 3; ++index)
                {
                    if (!int.TryParse(splitted_data[index].Trim(), out tmp) || (index == 0 && (tmp < 1 || tmp > 31)) ||
                        (index == 1 && (tmp < 1 || tmp > 12)) || (index == 2 && (tmp < 2019 || tmp > 2020)))
                    {
                        this.error_label.Text = "Некорректный формат даты или выход за допустимые границы!";
                        this.error_label.ForeColor = Color.DarkRed;
                    }
                }
            }
            else
            {
                this.error_label.Text = "Неправильное количество токенов в дате поступления!";
                this.error_label.ForeColor = Color.DarkRed;
            }
            if (this.error_label.ForeColor == Color.DarkGreen)
            {
                DateTime dateTimeText = Convert.ToDateTime(this.enrollData_textBox.Text);
                enrollData_textBox.Text = dateTimeText.ToString(format);
            }
            else
            {
                DateTime dt_from_table = Convert.ToDateTime(this.dataGridView.SelectedRows[0].Cells[3].Value);
                this.enrollData_textBox.Text = dt_from_table.ToString(format);
            }
        }
    }
}