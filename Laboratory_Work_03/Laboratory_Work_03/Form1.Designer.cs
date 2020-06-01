namespace Laboratory_Work_03
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid_transportCargo = new System.Windows.Forms.DataGridView();
            this.TransportCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlannedSizeOfCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OneCargoPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeDataRow_Button = new System.Windows.Forms.Button();
            this.help_button = new System.Windows.Forms.Button();
            this.transportCompanyName_textField = new System.Windows.Forms.TextBox();
            this.plannedSizeCargo_textField = new System.Windows.Forms.TextBox();
            this.oneCargoPrice_textField = new System.Windows.Forms.TextBox();
            this.plannedSizeCargo_slider = new System.Windows.Forms.TrackBar();
            this.oneCargoPrice_slider = new System.Windows.Forms.TrackBar();
            this.error_label = new System.Windows.Forms.Label();
            this.plannedSizeCargo_label = new System.Windows.Forms.Label();
            this.oneCargoPrice_label = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_transportCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedSizeCargo_slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneCargoPrice_slider)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_transportCargo
            // 
            this.dataGrid_transportCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_transportCargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransportCompanyName,
            this.PlannedSizeOfCargo,
            this.OneCargoPrice});
            this.dataGrid_transportCargo.Location = new System.Drawing.Point(12, 24);
            this.dataGrid_transportCargo.Name = "dataGrid_transportCargo";
            this.dataGrid_transportCargo.RowHeadersWidth = 62;
            this.dataGrid_transportCargo.RowTemplate.Height = 28;
            this.dataGrid_transportCargo.Size = new System.Drawing.Size(1074, 648);
            this.dataGrid_transportCargo.TabIndex = 0;
            this.dataGrid_transportCargo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_transportCargo_CellClick);
            // 
            // TransportCompanyName
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TransportCompanyName.DefaultCellStyle = dataGridViewCellStyle1;
            this.TransportCompanyName.HeaderText = "Название транспортного предприятия";
            this.TransportCompanyName.MinimumWidth = 8;
            this.TransportCompanyName.Name = "TransportCompanyName";
            this.TransportCompanyName.Width = 150;
            // 
            // PlannedSizeOfCargo
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PlannedSizeOfCargo.DefaultCellStyle = dataGridViewCellStyle2;
            this.PlannedSizeOfCargo.HeaderText = "Объём грузооборота, т*км";
            this.PlannedSizeOfCargo.MinimumWidth = 8;
            this.PlannedSizeOfCargo.Name = "PlannedSizeOfCargo";
            this.PlannedSizeOfCargo.Width = 150;
            // 
            // OneCargoPrice
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OneCargoPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.OneCargoPrice.HeaderText = "Себестоимость перевозки, т*км";
            this.OneCargoPrice.MinimumWidth = 8;
            this.OneCargoPrice.Name = "OneCargoPrice";
            this.OneCargoPrice.Width = 150;
            // 
            // changeDataRow_Button
            // 
            this.changeDataRow_Button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeDataRow_Button.Location = new System.Drawing.Point(29, 736);
            this.changeDataRow_Button.Name = "changeDataRow_Button";
            this.changeDataRow_Button.Size = new System.Drawing.Size(161, 102);
            this.changeDataRow_Button.TabIndex = 1;
            this.changeDataRow_Button.Text = "Изменить запись";
            this.changeDataRow_Button.UseVisualStyleBackColor = true;
            this.changeDataRow_Button.Click += new System.EventHandler(this.changeDataRow_Button_Click);
            // 
            // help_button
            // 
            this.help_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.help_button.Location = new System.Drawing.Point(29, 844);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(161, 101);
            this.help_button.TabIndex = 2;
            this.help_button.Text = "Открыть справку";
            this.help_button.UseVisualStyleBackColor = true;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // transportCompanyName_textField
            // 
            this.transportCompanyName_textField.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transportCompanyName_textField.Location = new System.Drawing.Point(29, 687);
            this.transportCompanyName_textField.Name = "transportCompanyName_textField";
            this.transportCompanyName_textField.Size = new System.Drawing.Size(198, 37);
            this.transportCompanyName_textField.TabIndex = 3;
            this.transportCompanyName_textField.Text = "Название";
            this.transportCompanyName_textField.Click += new System.EventHandler(this.transportCompanyName_textField_Click);
            // 
            // plannedSizeCargo_textField
            // 
            this.plannedSizeCargo_textField.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plannedSizeCargo_textField.Location = new System.Drawing.Point(252, 687);
            this.plannedSizeCargo_textField.Name = "plannedSizeCargo_textField";
            this.plannedSizeCargo_textField.Size = new System.Drawing.Size(262, 37);
            this.plannedSizeCargo_textField.TabIndex = 4;
            this.plannedSizeCargo_textField.Text = "Объём";
            this.plannedSizeCargo_textField.TextChanged += new System.EventHandler(this.plannedSizeCargo_textField_TextChanged);
            // 
            // oneCargoPrice_textField
            // 
            this.oneCargoPrice_textField.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneCargoPrice_textField.Location = new System.Drawing.Point(555, 687);
            this.oneCargoPrice_textField.Name = "oneCargoPrice_textField";
            this.oneCargoPrice_textField.Size = new System.Drawing.Size(281, 37);
            this.oneCargoPrice_textField.TabIndex = 5;
            this.oneCargoPrice_textField.Text = "Стоимость перевозки";
            this.oneCargoPrice_textField.TextChanged += new System.EventHandler(this.oneCargoPrice_textField_TextChanged);
            // 
            // plannedSizeCargo_slider
            // 
            this.plannedSizeCargo_slider.Location = new System.Drawing.Point(261, 736);
            this.plannedSizeCargo_slider.Maximum = 50;
            this.plannedSizeCargo_slider.Name = "plannedSizeCargo_slider";
            this.plannedSizeCargo_slider.Size = new System.Drawing.Size(245, 69);
            this.plannedSizeCargo_slider.TabIndex = 6;
            this.plannedSizeCargo_slider.ValueChanged += new System.EventHandler(this.plannedSizeCargo_slider_ValueChanged);
            // 
            // oneCargoPrice_slider
            // 
            this.oneCargoPrice_slider.Location = new System.Drawing.Point(580, 736);
            this.oneCargoPrice_slider.Maximum = 50;
            this.oneCargoPrice_slider.Name = "oneCargoPrice_slider";
            this.oneCargoPrice_slider.Size = new System.Drawing.Size(242, 69);
            this.oneCargoPrice_slider.TabIndex = 7;
            this.oneCargoPrice_slider.ValueChanged += new System.EventHandler(this.oneCargoPrice_slider_ValueChanged);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.error_label.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(294, 894);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 33);
            this.error_label.TabIndex = 8;
            // 
            // plannedSizeCargo_label
            // 
            this.plannedSizeCargo_label.AutoSize = true;
            this.plannedSizeCargo_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plannedSizeCargo_label.Location = new System.Drawing.Point(270, 797);
            this.plannedSizeCargo_label.Name = "plannedSizeCargo_label";
            this.plannedSizeCargo_label.Size = new System.Drawing.Size(209, 58);
            this.plannedSizeCargo_label.TabIndex = 9;
            this.plannedSizeCargo_label.Text = "Запланированный \r\nобъем";
            this.plannedSizeCargo_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oneCargoPrice_label
            // 
            this.oneCargoPrice_label.AutoSize = true;
            this.oneCargoPrice_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneCargoPrice_label.Location = new System.Drawing.Point(622, 797);
            this.oneCargoPrice_label.Name = "oneCargoPrice_label";
            this.oneCargoPrice_label.Size = new System.Drawing.Size(152, 58);
            this.oneCargoPrice_label.TabIndex = 10;
            this.oneCargoPrice_label.Text = "Стоимость за \r\n1 перевозку";
            this.oneCargoPrice_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.close_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_button.Location = new System.Drawing.Point(924, 871);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(162, 83);
            this.close_button.TabIndex = 11;
            this.close_button.Text = "Закрыть приложение";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 957);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.oneCargoPrice_label);
            this.Controls.Add(this.plannedSizeCargo_label);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.oneCargoPrice_slider);
            this.Controls.Add(this.plannedSizeCargo_slider);
            this.Controls.Add(this.oneCargoPrice_textField);
            this.Controls.Add(this.plannedSizeCargo_textField);
            this.Controls.Add(this.transportCompanyName_textField);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.changeDataRow_Button);
            this.Controls.Add(this.dataGrid_transportCargo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт грузоперевозок";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_transportCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedSizeCargo_slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneCargoPrice_slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGrid_transportCargo;
        public System.Windows.Forms.Button changeDataRow_Button;
        public System.Windows.Forms.Button help_button;
        public System.Windows.Forms.DataGridViewTextBoxColumn TransportCompanyName;
        public System.Windows.Forms.DataGridViewTextBoxColumn PlannedSizeOfCargo;
        public System.Windows.Forms.DataGridViewTextBoxColumn OneCargoPrice;
        public System.Windows.Forms.TextBox transportCompanyName_textField;
        public System.Windows.Forms.TextBox plannedSizeCargo_textField;
        public System.Windows.Forms.TextBox oneCargoPrice_textField;
        public System.Windows.Forms.TrackBar plannedSizeCargo_slider;
        public System.Windows.Forms.TrackBar oneCargoPrice_slider;
        public System.Windows.Forms.Label error_label;
        public System.Windows.Forms.Label plannedSizeCargo_label;
        public System.Windows.Forms.Label oneCargoPrice_label;
        public System.Windows.Forms.Button close_button;
    }
}

