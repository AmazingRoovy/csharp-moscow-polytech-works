namespace Practice_Work_04
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            this.add_button = new System.Windows.Forms.Button();
            this.stateNumber_label = new System.Windows.Forms.Label();
            this.stateNumber_textBox = new System.Windows.Forms.TextBox();
            this.initialsBoss_textBox = new System.Windows.Forms.TextBox();
            this.initialsBoss_label = new System.Windows.Forms.Label();
            this.stateCount_textBox = new System.Windows.Forms.TextBox();
            this.stateCount_label = new System.Windows.Forms.Label();
            this.role_textBox = new System.Windows.Forms.TextBox();
            this.role_label = new System.Windows.Forms.Label();
            this.initialsWorker_textBox = new System.Windows.Forms.TextBox();
            this.initialsWorker_label = new System.Windows.Forms.Label();
            this.stateNumberWorker_textBox = new System.Windows.Forms.TextBox();
            this.stateNumberWorker_label = new System.Windows.Forms.Label();
            this.enroll_label = new System.Windows.Forms.Label();
            this.salary_textBox = new System.Windows.Forms.TextBox();
            this.salary_label = new System.Windows.Forms.Label();
            this.change_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.changeTable_button = new System.Windows.Forms.Button();
            this.second_groupBox = new System.Windows.Forms.GroupBox();
            this.enrollData_textBox = new System.Windows.Forms.TextBox();
            this.first_groupBox = new System.Windows.Forms.GroupBox();
            this.error_label = new System.Windows.Forms.Label();
            this.state_tableTableAdapter = new Practice_Work_04.Workers_DatabaseDataSetTableAdapters.state_tableTableAdapter();
            this.statetableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.workertableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worker_tableTableAdapter = new Practice_Work_04.Workers_DatabaseDataSetTableAdapters.worker_tableTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers_DatabaseDataSet)).BeginInit();
            this.second_groupBox.SuspendLayout();
            this.first_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statetableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workertableBindingSource)).BeginInit();
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
            this.dataGridView.Location = new System.Drawing.Point(13, 22);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1384, 446);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // номерОтделаDataGridViewTextBoxColumn
            // 
            this.номерОтделаDataGridViewTextBoxColumn.DataPropertyName = "Номер отдела";
            this.номерОтделаDataGridViewTextBoxColumn.HeaderText = "Номер отдела";
            this.номерОтделаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.номерОтделаDataGridViewTextBoxColumn.Name = "номерОтделаDataGridViewTextBoxColumn";
            this.номерОтделаDataGridViewTextBoxColumn.Width = 150;
            // 
            // фамилияИИнициалыНачальникаDataGridViewTextBoxColumn
            // 
            this.фамилияИИнициалыНачальникаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия и инициалы начальника";
            this.фамилияИИнициалыНачальникаDataGridViewTextBoxColumn.HeaderText = "Фамилия и инициалы начальника";
            this.фамилияИИнициалыНачальникаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.фамилияИИнициалыНачальникаDataGridViewTextBoxColumn.Name = "фамилияИИнициалыНачальникаDataGridViewTextBoxColumn";
            this.фамилияИИнициалыНачальникаDataGridViewTextBoxColumn.Width = 150;
            // 
            // штатDataGridViewTextBoxColumn
            // 
            this.штатDataGridViewTextBoxColumn.DataPropertyName = "Штат";
            this.штатDataGridViewTextBoxColumn.HeaderText = "Штат";
            this.штатDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.штатDataGridViewTextBoxColumn.Name = "штатDataGridViewTextBoxColumn";
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
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_button.Location = new System.Drawing.Point(472, 497);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(198, 41);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Добавить запись";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // stateNumber_label
            // 
            this.stateNumber_label.AutoSize = true;
            this.stateNumber_label.Location = new System.Drawing.Point(46, 48);
            this.stateNumber_label.Name = "stateNumber_label";
            this.stateNumber_label.Size = new System.Drawing.Size(120, 20);
            this.stateNumber_label.TabIndex = 2;
            this.stateNumber_label.Text = "Номер отдела";
            // 
            // stateNumber_textBox
            // 
            this.stateNumber_textBox.Location = new System.Drawing.Point(23, 71);
            this.stateNumber_textBox.Name = "stateNumber_textBox";
            this.stateNumber_textBox.Size = new System.Drawing.Size(234, 26);
            this.stateNumber_textBox.TabIndex = 4;
            this.stateNumber_textBox.Leave += new System.EventHandler(this.stateNumber_textBox_Leave);
            // 
            // initialsBoss_textBox
            // 
            this.initialsBoss_textBox.Location = new System.Drawing.Point(23, 132);
            this.initialsBoss_textBox.Name = "initialsBoss_textBox";
            this.initialsBoss_textBox.Size = new System.Drawing.Size(234, 26);
            this.initialsBoss_textBox.TabIndex = 6;
            this.initialsBoss_textBox.Leave += new System.EventHandler(this.initialsBoss_textBox_Leave);
            // 
            // initialsBoss_label
            // 
            this.initialsBoss_label.AutoSize = true;
            this.initialsBoss_label.Location = new System.Drawing.Point(19, 109);
            this.initialsBoss_label.Name = "initialsBoss_label";
            this.initialsBoss_label.Size = new System.Drawing.Size(267, 20);
            this.initialsBoss_label.TabIndex = 5;
            this.initialsBoss_label.Text = "Фамилия и инициалы начальника";
            // 
            // stateCount_textBox
            // 
            this.stateCount_textBox.Location = new System.Drawing.Point(23, 190);
            this.stateCount_textBox.Name = "stateCount_textBox";
            this.stateCount_textBox.Size = new System.Drawing.Size(234, 26);
            this.stateCount_textBox.TabIndex = 8;
            this.stateCount_textBox.Leave += new System.EventHandler(this.stateCount_textBox_Leave);
            // 
            // stateCount_label
            // 
            this.stateCount_label.AutoSize = true;
            this.stateCount_label.Location = new System.Drawing.Point(46, 167);
            this.stateCount_label.Name = "stateCount_label";
            this.stateCount_label.Size = new System.Drawing.Size(49, 20);
            this.stateCount_label.TabIndex = 7;
            this.stateCount_label.Text = "Штат";
            // 
            // role_textBox
            // 
            this.role_textBox.Location = new System.Drawing.Point(22, 219);
            this.role_textBox.Name = "role_textBox";
            this.role_textBox.Size = new System.Drawing.Size(234, 26);
            this.role_textBox.TabIndex = 14;
            this.role_textBox.Leave += new System.EventHandler(this.role_textBox_Leave);
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.Location = new System.Drawing.Point(45, 196);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(95, 20);
            this.role_label.TabIndex = 13;
            this.role_label.Text = "Должность";
            // 
            // initialsWorker_textBox
            // 
            this.initialsWorker_textBox.Location = new System.Drawing.Point(22, 140);
            this.initialsWorker_textBox.Name = "initialsWorker_textBox";
            this.initialsWorker_textBox.Size = new System.Drawing.Size(234, 26);
            this.initialsWorker_textBox.TabIndex = 12;
            this.initialsWorker_textBox.Leave += new System.EventHandler(this.initialsWorker_textBox_Leave);
            // 
            // initialsWorker_label
            // 
            this.initialsWorker_label.AutoSize = true;
            this.initialsWorker_label.Location = new System.Drawing.Point(18, 117);
            this.initialsWorker_label.Name = "initialsWorker_label";
            this.initialsWorker_label.Size = new System.Drawing.Size(265, 20);
            this.initialsWorker_label.TabIndex = 11;
            this.initialsWorker_label.Text = "Фамилия и инициалы сотрудника";
            // 
            // stateNumberWorker_textBox
            // 
            this.stateNumberWorker_textBox.Location = new System.Drawing.Point(22, 54);
            this.stateNumberWorker_textBox.Name = "stateNumberWorker_textBox";
            this.stateNumberWorker_textBox.Size = new System.Drawing.Size(234, 26);
            this.stateNumberWorker_textBox.TabIndex = 10;
            this.stateNumberWorker_textBox.Leave += new System.EventHandler(this.stateNumberWorker_textBox_Leave);
            // 
            // stateNumberWorker_label
            // 
            this.stateNumberWorker_label.AutoSize = true;
            this.stateNumberWorker_label.Location = new System.Drawing.Point(45, 31);
            this.stateNumberWorker_label.Name = "stateNumberWorker_label";
            this.stateNumberWorker_label.Size = new System.Drawing.Size(120, 20);
            this.stateNumberWorker_label.TabIndex = 9;
            this.stateNumberWorker_label.Text = "Номер отдела";
            // 
            // enroll_label
            // 
            this.enroll_label.AutoSize = true;
            this.enroll_label.Location = new System.Drawing.Point(333, 31);
            this.enroll_label.Name = "enroll_label";
            this.enroll_label.Size = new System.Drawing.Size(149, 20);
            this.enroll_label.TabIndex = 15;
            this.enroll_label.Text = "Дата поступления";
            // 
            // salary_textBox
            // 
            this.salary_textBox.Location = new System.Drawing.Point(324, 140);
            this.salary_textBox.Name = "salary_textBox";
            this.salary_textBox.Size = new System.Drawing.Size(234, 26);
            this.salary_textBox.TabIndex = 17;
            this.salary_textBox.Leave += new System.EventHandler(this.salary_textBox_Leave);
            // 
            // salary_label
            // 
            this.salary_label.AutoSize = true;
            this.salary_label.Location = new System.Drawing.Point(347, 117);
            this.salary_label.Name = "salary_label";
            this.salary_label.Size = new System.Drawing.Size(84, 20);
            this.salary_label.TabIndex = 16;
            this.salary_label.Text = "Зарплата";
            // 
            // change_button
            // 
            this.change_button.Location = new System.Drawing.Point(472, 559);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(198, 41);
            this.change_button.TabIndex = 18;
            this.change_button.Text = "Изменить запись";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.remove_button.Location = new System.Drawing.Point(472, 627);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(198, 41);
            this.remove_button.TabIndex = 19;
            this.remove_button.Text = "Удалить запись";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.return_button.Location = new System.Drawing.Point(1172, 770);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(225, 41);
            this.return_button.TabIndex = 20;
            this.return_button.Text = "Вернуться к просмотру...";
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // changeTable_button
            // 
            this.changeTable_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.changeTable_button.Location = new System.Drawing.Point(472, 691);
            this.changeTable_button.Name = "changeTable_button";
            this.changeTable_button.Size = new System.Drawing.Size(198, 41);
            this.changeTable_button.TabIndex = 21;
            this.changeTable_button.Text = "Сменить таблицу...";
            this.changeTable_button.UseVisualStyleBackColor = false;
            this.changeTable_button.Click += new System.EventHandler(this.changeTable_button_Click);
            // 
            // second_groupBox
            // 
            this.second_groupBox.Controls.Add(this.enrollData_textBox);
            this.second_groupBox.Controls.Add(this.initialsWorker_label);
            this.second_groupBox.Controls.Add(this.stateNumberWorker_label);
            this.second_groupBox.Controls.Add(this.stateNumberWorker_textBox);
            this.second_groupBox.Controls.Add(this.initialsWorker_textBox);
            this.second_groupBox.Controls.Add(this.salary_textBox);
            this.second_groupBox.Controls.Add(this.role_label);
            this.second_groupBox.Controls.Add(this.salary_label);
            this.second_groupBox.Controls.Add(this.role_textBox);
            this.second_groupBox.Controls.Add(this.enroll_label);
            this.second_groupBox.Location = new System.Drawing.Point(722, 487);
            this.second_groupBox.Name = "second_groupBox";
            this.second_groupBox.Size = new System.Drawing.Size(675, 277);
            this.second_groupBox.TabIndex = 22;
            this.second_groupBox.TabStop = false;
            this.second_groupBox.Text = "Запись о сотруднике";
            // 
            // enrollData_textBox
            // 
            this.enrollData_textBox.Location = new System.Drawing.Point(324, 54);
            this.enrollData_textBox.Name = "enrollData_textBox";
            this.enrollData_textBox.Size = new System.Drawing.Size(234, 26);
            this.enrollData_textBox.TabIndex = 18;
            this.enrollData_textBox.Leave += new System.EventHandler(this.enrollData_textBox_Leave);
            // 
            // first_groupBox
            // 
            this.first_groupBox.Controls.Add(this.stateCount_textBox);
            this.first_groupBox.Controls.Add(this.stateNumber_label);
            this.first_groupBox.Controls.Add(this.stateNumber_textBox);
            this.first_groupBox.Controls.Add(this.initialsBoss_label);
            this.first_groupBox.Controls.Add(this.initialsBoss_textBox);
            this.first_groupBox.Controls.Add(this.stateCount_label);
            this.first_groupBox.Location = new System.Drawing.Point(13, 487);
            this.first_groupBox.Name = "first_groupBox";
            this.first_groupBox.Size = new System.Drawing.Size(391, 256);
            this.first_groupBox.TabIndex = 23;
            this.first_groupBox.TabStop = false;
            this.first_groupBox.Text = "Запись об отделе";
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error_label.Location = new System.Drawing.Point(47, 791);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 28);
            this.error_label.TabIndex = 26;
            // 
            // state_tableTableAdapter
            // 
            this.state_tableTableAdapter.ClearBeforeFill = true;
            // 
            // statetableBindingSource1
            // 
            this.statetableBindingSource1.DataMember = "state_table";
            this.statetableBindingSource1.DataSource = this.workersDatabaseDataSetBindingSource;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1429, 863);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.first_groupBox);
            this.Controls.Add(this.second_groupBox);
            this.Controls.Add(this.changeTable_button);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.change_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер v0.6 (Режим редактирования)";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workers_DatabaseDataSet)).EndInit();
            this.second_groupBox.ResumeLayout(false);
            this.second_groupBox.PerformLayout();
            this.first_groupBox.ResumeLayout(false);
            this.first_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statetableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workertableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label stateNumber_label;
        private System.Windows.Forms.TextBox stateNumber_textBox;
        private System.Windows.Forms.TextBox initialsBoss_textBox;
        private System.Windows.Forms.Label initialsBoss_label;
        private System.Windows.Forms.TextBox stateCount_textBox;
        private System.Windows.Forms.Label stateCount_label;
        private System.Windows.Forms.TextBox role_textBox;
        private System.Windows.Forms.Label role_label;
        private System.Windows.Forms.TextBox initialsWorker_textBox;
        private System.Windows.Forms.Label initialsWorker_label;
        private System.Windows.Forms.TextBox stateNumberWorker_textBox;
        private System.Windows.Forms.Label stateNumberWorker_label;
        private System.Windows.Forms.Label enroll_label;
        private System.Windows.Forms.TextBox salary_textBox;
        private System.Windows.Forms.Label salary_label;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button changeTable_button;
        private System.Windows.Forms.GroupBox second_groupBox;
        private System.Windows.Forms.GroupBox first_groupBox;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.BindingSource workersDatabaseDataSetBindingSource;
        private Workers_DatabaseDataSet workers_DatabaseDataSet;
        private System.Windows.Forms.BindingSource statetableBindingSource;
        private Workers_DatabaseDataSetTableAdapters.state_tableTableAdapter state_tableTableAdapter;
        private System.Windows.Forms.BindingSource statetableBindingSource1;
        private System.Windows.Forms.BindingSource workertableBindingSource;
        private Workers_DatabaseDataSetTableAdapters.worker_tableTableAdapter worker_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерОтделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияИИнициалыНачальникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn штатDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox enrollData_textBox;
    }
}