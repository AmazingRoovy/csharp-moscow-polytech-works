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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.salaryUp_groupBox.Enabled = false;
            this.role_groupBox.Enabled = false;
            this.dateFind_groupBox.Enabled = false;
            this.mid_button.Enabled = false;
            this.dataGridView.Columns[1].Width = 200;
            this.error_label.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workers_DatabaseDataSet.worker_table". При необходимости она может быть перемещена или удалена.
            this.worker_tableTableAdapter.Fill(this.workers_DatabaseDataSet.worker_table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workers_DatabaseDataSet.state_table". При необходимости она может быть перемещена или удалена.
            this.state_tableTableAdapter.Fill(this.workers_DatabaseDataSet.state_table);

        }

        private void changeTable_button_Click(object sender, EventArgs e)
        {
            if (this.dataGridView.DataSource == statetableBindingSource)
            {
                this.dataGridView.AutoGenerateColumns = true;
                this.dataGridView.DataSource = workertableBindingSource;
                this.salaryUp_groupBox.Enabled = true;
                this.role_groupBox.Enabled = true;
                this.dateFind_groupBox.Enabled = true;
                this.mid_button.Enabled = true;
                this.worker_tableTableAdapter.Fill(this.workers_DatabaseDataSet.worker_table);
                this.dataGridView.Columns[1].Width = 125;
                this.dataGridView.Columns[2].Width = 200;
            }
            else
            {
                this.dataGridView.AutoGenerateColumns = true;
                this.dataGridView.DataSource = statetableBindingSource;
                this.salaryUp_groupBox.Enabled = false;
                this.role_groupBox.Enabled = false;
                this.dateFind_groupBox.Enabled = false;
                this.mid_button.Enabled = false;
                this.state_tableTableAdapter.Fill(this.workers_DatabaseDataSet.state_table);
                this.dataGridView.Columns[1].Width = 125;
            }
        }

        private void role_button_Click(object sender, EventArgs e)
        {
            this.error_label.Text = "";
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\ALEX EY\Documents\Workers_Database.accdb";
            string workerRole = this.role_textBox.Text.Trim();
            string format = "dd.MM.yyyy.";
            this.listView1.Items.Clear();

            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.CommandText = "SELECT * FROM worker_table";
            myOleDbConnection.Open();

            OleDbDataReader myOleDbDataReader = myOleDbCommand.ExecuteReader();

            listView1.BeginUpdate();
            while (myOleDbDataReader.Read())
            {
                if (myOleDbDataReader["Должность"].ToString().Trim() == workerRole) 
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = myOleDbDataReader["Номер отдела"].ToString().Trim() + " " +
                        myOleDbDataReader["Фамилия и инициалы сотрудника"].ToString().Trim() + " " +
                        Convert.ToDateTime(myOleDbDataReader["Дата поступления"]).ToString(format).Trim() + " " +
                        myOleDbDataReader["Зарплата"].ToString().Trim();

                    if (!listView1.Items.Contains(listViewItem))
                        listView1.Items.Add(listViewItem);
                }
            }
            listView1.EndUpdate();
        }

        private void enroll_button_Click(object sender, EventArgs e)
        {
            this.error_label.Text = "";
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\ALEX EY\Documents\Workers_Database.accdb";
            DateTime fromTime = fromDate_dateTimePicker.Value;
            DateTime toTime = untilDate_dateTimePicker.Value;
            string format = "dd.MM.yyyy.";
            this.listView1.Items.Clear();

            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.CommandText = "SELECT * FROM worker_table";
            myOleDbConnection.Open();

            OleDbDataReader myOleDbDataReader = myOleDbCommand.ExecuteReader();

            listView1.BeginUpdate();
            while (myOleDbDataReader.Read())
            {
                if (Convert.ToDateTime(myOleDbDataReader["Дата поступления"]) >= fromTime &&
                    Convert.ToDateTime(myOleDbDataReader["Дата поступления"]) <= toTime)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = myOleDbDataReader["Номер отдела"].ToString().Trim() + " " +
                        myOleDbDataReader["Фамилия и инициалы сотрудника"].ToString().Trim() + " " +
                        myOleDbDataReader["Должность"].ToString().Trim() + " " +
                        Convert.ToDateTime(myOleDbDataReader["Дата поступления"]).ToString(format).Trim() + " " +
                        myOleDbDataReader["Зарплата"].ToString().Trim();

                    if (!listView1.Items.Contains(listViewItem))
                        listView1.Items.Add(listViewItem);
                }
            }
            listView1.EndUpdate();
        }

        private void salary_button_Click(object sender, EventArgs e)
        {
            this.error_label.Text = "";
            if (this.salarySum_textBox.ForeColor == Color.DarkGreen && this.salaryRole_textBox.ForeColor == Color.DarkGreen) 
            { 
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\ALEX EY\Documents\Workers_Database.accdb";
                string workerRole = this.salaryRole_textBox.Text;
                int sumUp = Convert.ToInt32(this.salarySum_textBox.Text);

                OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
                OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
                myOleDbCommand.CommandText = "SELECT * FROM worker_table";
                myOleDbConnection.Open();

                OleDbCommand changeRecord = myOleDbConnection.CreateCommand();

                try
                {
                    List<int> workersSalaries = new List<int>(); 
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (Convert.ToString(row.Cells[2].Value).Trim() == workerRole)
                        {
                            workersSalaries.Add(Convert.ToInt32(row.Cells[4].Value));
                        }
                    }

                    foreach (int salary in workersSalaries)
                    {
                        changeRecord.CommandText = $@"UPDATE worker_table SET [Зарплата] = {salary + sumUp} WHERE [Должность] = '{workerRole}';";
                    }

                    changeRecord.ExecuteNonQuery();

                    this.error_label.Text = "Зарплата обновлена!";
                    this.error_label.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    this.error_label.Text = ex.Message;
                    this.error_label.ForeColor = Color.DarkRed;
                }

                myOleDbConnection.Close();

                this.worker_tableTableAdapter.Update(this.workers_DatabaseDataSet.worker_table);
                this.worker_tableTableAdapter.Fill(this.workers_DatabaseDataSet.worker_table);
            }
        }

        private void toEditForm_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 second_form = new Form2();
            second_form.Show();
        }

        private void mid_button_Click(object sender, EventArgs e)
        {
            this.error_label.Text = "";
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\ALEX EY\Documents\Workers_Database.accdb";
            this.mid_listView.Items.Clear();


            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.CommandText = "SELECT * FROM worker_table";
            myOleDbConnection.Open();

            OleDbDataReader myOleDbDataReader = myOleDbCommand.ExecuteReader();

            Dictionary<string, int> dict = new Dictionary <string, int>();
            int current_number = 0;

            while (myOleDbDataReader.Read())
            {
                if (dict.TryGetValue(myOleDbDataReader["Должность"].ToString(), out current_number))
                {
                    dict[myOleDbDataReader["Должность"].ToString()] = current_number + 1;
                    continue;
                }
                dict.Add(myOleDbDataReader["Должность"].ToString(), 1);
            }

            myOleDbDataReader.Close();

            int mid; 
            
            mid_listView.BeginUpdate();
            foreach (string dict_el in dict.Keys)
            {
                myOleDbDataReader = myOleDbCommand.ExecuteReader();
                mid = 0;
                while (myOleDbDataReader.Read())
                {
                    if (myOleDbDataReader["Должность"].ToString().Trim() == dict_el)
                    {
                        TimeSpan exp_time = DateTime.Now - Convert.ToDateTime(myOleDbDataReader["Дата поступления"]);
                        mid += exp_time.Days;
                    }
                }
                mid /= dict[dict_el];
                ListViewItem item = new ListViewItem();
                item.Text = dict_el.Trim() + ": " + Convert.ToString(Math.Abs(mid));

                mid_listView.Items.Add(item);
                myOleDbDataReader.Close();
            }
            mid_listView.EndUpdate();

            dict.Clear();
        }

        private void salaryRole_textBox_Leave(object sender, EventArgs e)
        {
            this.error_label.Text = "";
            string[] splitted_salaryRole = salaryRole_textBox.Text.Trim().Split(new Char[] { ' ' });
            this.salaryRole_textBox.ForeColor = Color.DarkGreen;

            for (int splitted_word = 0; splitted_word < splitted_salaryRole.Length; ++splitted_word)
            {
                if (!splitted_salaryRole[splitted_word].All(char.IsLetter))
                {
                    this.salaryRole_textBox.ForeColor = Color.DarkRed;
                }
            }

            this.salaryRole_textBox.Text = this.salaryRole_textBox.Text.Trim();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (Convert.ToString(row.Cells[2].Value).Trim() == this.salaryRole_textBox.Text)
                {
                    this.salaryRole_textBox.ForeColor = Color.DarkGreen;
                    break;
                }
                this.salaryRole_textBox.ForeColor = Color.DarkRed;
            }
        }

        private void salarySum_textBox_Leave(object sender, EventArgs e)
        {
            this.error_label.Text = "";
            int tmp_salary;
            this.salarySum_textBox.ForeColor = Color.DarkGreen;

            if (!int.TryParse(salarySum_textBox.Text.Trim(), out tmp_salary))
            {
                this.salarySum_textBox.ForeColor = Color.DarkRed;
            }
            else if (tmp_salary <= 0) 
                this.salarySum_textBox.Text = "1";
            else if (tmp_salary > 150000)
                this.salarySum_textBox.Text = "150000";

            this.salarySum_textBox.Text = this.salarySum_textBox.Text.Trim();
        }

        private void role_textBox_Leave(object sender, EventArgs e)
        {
            this.error_label.Text = "";

            string[] splitted_salaryRole = role_textBox.Text.Trim().Split(new Char[] { ' ' });
            this.role_textBox.ForeColor = Color.DarkGreen;

            for (int splitted_word = 0; splitted_word < splitted_salaryRole.Length; ++splitted_word)
            {
                if (!splitted_salaryRole[splitted_word].All(char.IsLetter))
                {
                    this.role_textBox.ForeColor = Color.DarkRed;
                    this.error_label.Text = "Цифры и посторонние символы запрещены!";
                    break;
                }
            }

            this.role_textBox.ForeColor = Color.DarkGreen;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                try
                {
                    if (row.Cells[2].Value.ToString() == role_textBox.Text)
                    {
                        this.role_textBox.ForeColor = Color.DarkGreen;
                        this.error_label.Text = "Должность сущетсвует в базе данных.";
                        this.error_label.ForeColor = Color.DarkGreen;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    this.error_label.Text = ex.Message;
                }
            }
        }
    }
}