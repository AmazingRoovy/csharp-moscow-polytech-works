namespace Practice_Work_04
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.номерОтделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияИИнициалыНачальникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.штатDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workers_DatabaseDataSet = new Practice_Work_04.Workers_DatabaseDataSet();
            this.role_textBox = new System.Windows.Forms.TextBox();
            this.role_label = new System.Windows.Forms.Label();
            this.role_button = new System.Windows.Forms.Button();
            this.enroll_button = new System.Windows.Forms.Button();
            this.fromDate_label = new System.Windows.Forms.Label();
            this.untilDate_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.salary_button = new System.Windows.Forms.Button();
            this.salaryRole_label = new System.Windows.Forms.Label();
            this.salaryRole_textBox = new System.Windows.Forms.TextBox();
            this.salarySum_label = new System.Windows.Forms.Label();
            this.salarySum_textBox = new System.Windows.Forms.TextBox();
            this.mid_listView = new System.Windows.Forms.ListView();
            this.mid_button = new System.Windows.Forms.Button();
            this.mid_label = new System.Windows.Forms.Label();
            this.fromDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.untilDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toEditForm_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.changeTable_button = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.state_tableTableAdapter = new Practice_Work_04.Workers_DatabaseDataSetTableAdapters.state_tableTableAdapter();
            this.workertableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worker_tableTableAdapter = new Practice_Work_04.Workers_DatabaseDataSetTableAdapters.worker_tableTableAdapter();
            this.salaryUp_groupBox = new System.Windows.Forms.GroupBox();
            this.role_groupBox = new System.Windows.Forms.GroupBox();
            this.dateFind_groupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workertableBindingSource)).BeginInit();
            this.salaryUp_groupBox.SuspendLayout();
            this.role_groupBox.SuspendLayout();
            this.dateFind_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерОтделаDataGridViewTextBoxColumn,
            this.фамилияИИнициалыНачальникаDataGridViewTextBoxColumn,
            this.штатDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.statetableBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1886, 530);
            this.dataGridView.TabIndex = 0;
            // 
            // номерОтделаDataGridViewTextBoxColumn
            // 
            this.номерОтделаDataGridViewTextBoxColumn.DataPropertyName = "Номер отдела";
            this.номерОтделаDataGridViewTextBoxColumn.HeaderText = "Номер отдела";
            this.номерОтделаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.номерОтделаDataGridViewTextBoxColumn.Name = "номерОтделаDataGridViewTextBoxColumn";
            this.номерОтделаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерОтделаDataGridViewTextBoxColumn.Width = 150;
            // 
            // фамилияИИнициалыНачальникаDataGridViewTextBoxColumn
            // 
            this.фамилияИИнициалыНачальникаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия и инициалы начальника";
            this.фамилияИИнициалыНачальникаDataGridViewTextBoxColumn.HeaderText = "Фамилия и инициалы начальника";
            this.фамилияИИнициалыНачальникаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.фамилияИИнициалыНачальникаDataGridViewTextBoxColumn.Name = "фамилияИИнициалыНачальникаDataGridViewTextBoxColumn";
            this.фамилияИИнициалыНачальникаDataGridViewTextBoxColumn.ReadOnly = true;
            this.фамилияИИнициалыНачальникаDataGridViewTextBoxColumn.Width = 150;
            // 
            // штатDataGridViewTextBoxColumn
            // 
            this.штатDataGridViewTextBoxColumn.DataPropertyName = "Штат";
            this.штатDataGridViewTextBoxColumn.HeaderText = "Штат";
            this.штатDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.штатDataGridViewTextBoxColumn.Name = "штатDataGridViewTextBoxColumn";
            this.штатDataGridViewTextBoxColumn.ReadOnly = true;
            this.штатDataGridViewTextBoxColumn.Width = 150;
            // 
            // statetableBindingSource
            // 
            this.statetableBindingSource.DataMember = "state_table";
            this.statetableBindingSource.DataSource = this.workersDatabaseDataSetBindingSource;
            // 
            // workersDatabaseDataSetBindingSource
            // 
            this.workersDatabaseDataSetBindingSource.DataSource = this.workers_DatabaseDataSet;
            this.workersDatabaseDataSetBindingSource.Position = 0;
            // 
            // workers_DatabaseDataSet
            // 
            this.workers_DatabaseDataSet.DataSetName = "Workers_DatabaseDataSet";
            this.workers_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // role_textBox
            // 
            this.role_textBox.Location = new System.Drawing.Point(17, 60);
            this.role_textBox.Name = "role_textBox";
            this.role_textBox.Size = new System.Drawing.Size(256, 26);
            this.role_textBox.TabIndex = 1;
            this.role_textBox.Leave += new System.EventHandler(this.role_textBox_Leave);
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.Location = new System.Drawing.Point(34, 34);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(95, 20);
            this.role_label.TabIndex = 2;
            this.role_label.Text = "Должность";
            // 
            // role_button
            // 
            this.role_button.Location = new System.Drawing.Point(17, 105);
            this.role_button.Name = "role_button";
            this.role_button.Size = new System.Drawing.Size(256, 43);
            this.role_button.TabIndex = 3;
            this.role_button.Text = "Поиск по должности";
            this.role_button.UseVisualStyleBackColor = true;
            this.role_button.Click += new System.EventHandler(this.role_button_Click);
            // 
            // enroll_button
            // 
            this.enroll_button.Location = new System.Drawing.Point(6, 182);
            this.enroll_button.Name = "enroll_button";
            this.enroll_button.Size = new System.Drawing.Size(258, 48);
            this.enroll_button.TabIndex = 4;
            this.enroll_button.Text = "Поиск по дате поступления";
            this.enroll_button.UseVisualStyleBackColor = true;
            this.enroll_button.Click += new System.EventHandler(this.enroll_button_Click);
            // 
            // fromDate_label
            // 
            this.fromDate_label.AutoSize = true;
            this.fromDate_label.Location = new System.Drawing.Point(18, 36);
            this.fromDate_label.Name = "fromDate_label";
            this.fromDate_label.Size = new System.Drawing.Size(30, 20);
            this.fromDate_label.TabIndex = 7;
            this.fromDate_label.Text = "От";
            // 
            // untilDate_label
            // 
            this.untilDate_label.AutoSize = true;
            this.untilDate_label.Location = new System.Drawing.Point(18, 101);
            this.untilDate_label.Name = "untilDate_label";
            this.untilDate_label.Size = new System.Drawing.Size(156, 20);
            this.untilDate_label.TabIndex = 8;
            this.untilDate_label.Text = "До (включительно)";
            // 
            // salary_button
            // 
            this.salary_button.Location = new System.Drawing.Point(20, 165);
            this.salary_button.Name = "salary_button";
            this.salary_button.Size = new System.Drawing.Size(196, 48);
            this.salary_button.TabIndex = 11;
            this.salary_button.Text = "Увеличить зарплату";
            this.salary_button.UseVisualStyleBackColor = true;
            this.salary_button.Click += new System.EventHandler(this.salary_button_Click);
            // 
            // salaryRole_label
            // 
            this.salaryRole_label.AutoSize = true;
            this.salaryRole_label.Location = new System.Drawing.Point(24, 37);
            this.salaryRole_label.Name = "salaryRole_label";
            this.salaryRole_label.Size = new System.Drawing.Size(95, 20);
            this.salaryRole_label.TabIndex = 10;
            this.salaryRole_label.Text = "Должность";
            // 
            // salaryRole_textBox
            // 
            this.salaryRole_textBox.Location = new System.Drawing.Point(20, 64);
            this.salaryRole_textBox.Name = "salaryRole_textBox";
            this.salaryRole_textBox.Size = new System.Drawing.Size(196, 26);
            this.salaryRole_textBox.TabIndex = 9;
            this.salaryRole_textBox.Leave += new System.EventHandler(this.salaryRole_textBox_Leave);
            // 
            // salarySum_label
            // 
            this.salarySum_label.AutoSize = true;
            this.salarySum_label.Location = new System.Drawing.Point(24, 102);
            this.salarySum_label.Name = "salarySum_label";
            this.salarySum_label.Size = new System.Drawing.Size(183, 20);
            this.salarySum_label.TabIndex = 13;
            this.salarySum_label.Text = "Сумма для повышения";
            // 
            // salarySum_textBox
            // 
            this.salarySum_textBox.Location = new System.Drawing.Point(20, 128);
            this.salarySum_textBox.Name = "salarySum_textBox";
            this.salarySum_textBox.Size = new System.Drawing.Size(196, 26);
            this.salarySum_textBox.TabIndex = 12;
            this.salarySum_textBox.Leave += new System.EventHandler(this.salarySum_textBox_Leave);
            // 
            // mid_listView
            // 
            this.mid_listView.HideSelection = false;
            this.mid_listView.Location = new System.Drawing.Point(1299, 586);
            this.mid_listView.Name = "mid_listView";
            this.mid_listView.Size = new System.Drawing.Size(599, 398);
            this.mid_listView.TabIndex = 14;
            this.mid_listView.UseCompatibleStateImageBehavior = false;
            this.mid_listView.View = System.Windows.Forms.View.List;
            // 
            // mid_button
            // 
            this.mid_button.Location = new System.Drawing.Point(1009, 811);
            this.mid_button.Name = "mid_button";
            this.mid_button.Size = new System.Drawing.Size(256, 48);
            this.mid_button.TabIndex = 15;
            this.mid_button.Text = "Средний стаж по проф.";
            this.mid_button.UseVisualStyleBackColor = true;
            this.mid_button.Click += new System.EventHandler(this.mid_button_Click);
            // 
            // mid_label
            // 
            this.mid_label.AutoSize = true;
            this.mid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mid_label.Location = new System.Drawing.Point(1295, 559);
            this.mid_label.Name = "mid_label";
            this.mid_label.Size = new System.Drawing.Size(265, 20);
            this.mid_label.TabIndex = 16;
            this.mid_label.Text = "Средний стаж по профессиям";
            // 
            // fromDate_dateTimePicker
            // 
            this.fromDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDate_dateTimePicker.Location = new System.Drawing.Point(6, 62);
            this.fromDate_dateTimePicker.Name = "fromDate_dateTimePicker";
            this.fromDate_dateTimePicker.Size = new System.Drawing.Size(258, 26);
            this.fromDate_dateTimePicker.TabIndex = 17;
            // 
            // untilDate_dateTimePicker
            // 
            this.untilDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.untilDate_dateTimePicker.Location = new System.Drawing.Point(6, 127);
            this.untilDate_dateTimePicker.Name = "untilDate_dateTimePicker";
            this.untilDate_dateTimePicker.Size = new System.Drawing.Size(258, 26);
            this.untilDate_dateTimePicker.TabIndex = 18;
            // 
            // toEditForm_button
            // 
            this.toEditForm_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.toEditForm_button.Location = new System.Drawing.Point(991, 932);
            this.toEditForm_button.Name = "toEditForm_button";
            this.toEditForm_button.Size = new System.Drawing.Size(291, 52);
            this.toEditForm_button.TabIndex = 19;
            this.toEditForm_button.Text = "Перейти к редактированию...";
            this.toEditForm_button.UseVisualStyleBackColor = false;
            this.toEditForm_button.Click += new System.EventHandler(this.toEditForm_button_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 596);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(628, 390);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Информация о специалистах";
            // 
            // changeTable_button
            // 
            this.changeTable_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.changeTable_button.Location = new System.Drawing.Point(991, 872);
            this.changeTable_button.Name = "changeTable_button";
            this.changeTable_button.Size = new System.Drawing.Size(291, 52);
            this.changeTable_button.TabIndex = 22;
            this.changeTable_button.Text = "Сменить таблицу...";
            this.changeTable_button.UseVisualStyleBackColor = false;
            this.changeTable_button.Click += new System.EventHandler(this.changeTable_button_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error_label.Location = new System.Drawing.Point(1574, 551);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 28);
            this.error_label.TabIndex = 23;
            // 
            // state_tableTableAdapter
            // 
            this.state_tableTableAdapter.ClearBeforeFill = true;
            // 
            // workertableBindingSource
            // 
            this.workertableBindingSource.DataMember = "worker_table";
            this.workertableBindingSource.DataSource = this.workersDatabaseDataSetBindingSource;
            // 
            // worker_tableTableAdapter
            // 
            this.worker_tableTableAdapter.ClearBeforeFill = true;
            // 
            // salaryUp_groupBox
            // 
            this.salaryUp_groupBox.Controls.Add(this.salaryRole_textBox);
            this.salaryUp_groupBox.Controls.Add(this.salaryRole_label);
            this.salaryUp_groupBox.Controls.Add(this.salary_button);
            this.salaryUp_groupBox.Controls.Add(this.salarySum_textBox);
            this.salaryUp_groupBox.Controls.Add(this.salarySum_label);
            this.salaryUp_groupBox.Location = new System.Drawing.Point(1009, 559);
            this.salaryUp_groupBox.Name = "salaryUp_groupBox";
            this.salaryUp_groupBox.Size = new System.Drawing.Size(241, 237);
            this.salaryUp_groupBox.TabIndex = 24;
            this.salaryUp_groupBox.TabStop = false;
            this.salaryUp_groupBox.Text = "Повышение зарплаты";
            // 
            // role_groupBox
            // 
            this.role_groupBox.Controls.Add(this.role_textBox);
            this.role_groupBox.Controls.Add(this.role_label);
            this.role_groupBox.Controls.Add(this.role_button);
            this.role_groupBox.Location = new System.Drawing.Point(658, 559);
            this.role_groupBox.Name = "role_groupBox";
            this.role_groupBox.Size = new System.Drawing.Size(293, 173);
            this.role_groupBox.TabIndex = 25;
            this.role_groupBox.TabStop = false;
            this.role_groupBox.Text = "Поиск по должности";
            // 
            // dateFind_groupBox
            // 
            this.dateFind_groupBox.Controls.Add(this.fromDate_dateTimePicker);
            this.dateFind_groupBox.Controls.Add(this.enroll_button);
            this.dateFind_groupBox.Controls.Add(this.fromDate_label);
            this.dateFind_groupBox.Controls.Add(this.untilDate_label);
            this.dateFind_groupBox.Controls.Add(this.untilDate_dateTimePicker);
            this.dateFind_groupBox.Location = new System.Drawing.Point(658, 738);
            this.dateFind_groupBox.Name = "dateFind_groupBox";
            this.dateFind_groupBox.Size = new System.Drawing.Size(293, 248);
            this.dateFind_groupBox.TabIndex = 26;
            this.dateFind_groupBox.TabStop = false;
            this.dateFind_groupBox.Text = "Поиск по дате поступления";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1910, 999);
            this.Controls.Add(this.dateFind_groupBox);
            this.Controls.Add(this.role_groupBox);
            this.Controls.Add(this.salaryUp_groupBox);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.changeTable_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toEditForm_button);
            this.Controls.Add(this.mid_label);
            this.Controls.Add(this.mid_button);
            this.Controls.Add(this.mid_listView);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Менеджер v0.6";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workertableBindingSource)).EndInit();
            this.salaryUp_groupBox.ResumeLayout(false);
            this.salaryUp_groupBox.PerformLayout();
            this.role_groupBox.ResumeLayout(false);
            this.role_groupBox.PerformLayout();
            this.dateFind_groupBox.ResumeLayout(false);
            this.dateFind_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox role_textBox;
        private System.Windows.Forms.Label role_label;
        private System.Windows.Forms.Button role_button;
        private System.Windows.Forms.Button enroll_button;
        private System.Windows.Forms.Label fromDate_label;
        private System.Windows.Forms.Label untilDate_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button salary_button;
        private System.Windows.Forms.Label salaryRole_label;
        private System.Windows.Forms.TextBox salaryRole_textBox;
        private System.Windows.Forms.Label salarySum_label;
        private System.Windows.Forms.TextBox salarySum_textBox;
        private System.Windows.Forms.ListView mid_listView;
        private System.Windows.Forms.Button mid_button;
        private System.Windows.Forms.Label mid_label;
        private System.Windows.Forms.DateTimePicker fromDate_dateTimePicker;
        private System.Windows.Forms.DateTimePicker untilDate_dateTimePicker;
        private System.Windows.Forms.Button toEditForm_button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeTable_button;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.BindingSource workersDatabaseDataSetBindingSource;
        private Workers_DatabaseDataSet workers_DatabaseDataSet;
        private System.Windows.Forms.BindingSource statetableBindingSource;
        private Workers_DatabaseDataSetTableAdapters.state_tableTableAdapter state_tableTableAdapter;
        private System.Windows.Forms.BindingSource workertableBindingSource;
        private Workers_DatabaseDataSetTableAdapters.worker_tableTableAdapter worker_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерОтделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияИИнициалыНачальникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn штатDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox salaryUp_groupBox;
        private System.Windows.Forms.GroupBox role_groupBox;
        private System.Windows.Forms.GroupBox dateFind_groupBox;
    }
}

