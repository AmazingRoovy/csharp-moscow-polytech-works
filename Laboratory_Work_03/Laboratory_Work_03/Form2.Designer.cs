namespace Laboratory_Work_03
{
    partial class Help_Form
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
            this.button_return = new System.Windows.Forms.Button();
            this.listBox_Help = new System.Windows.Forms.ListBox();
            this.help_label = new System.Windows.Forms.Label();
            this.label_help2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_return
            // 
            this.button_return.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_return.Location = new System.Drawing.Point(858, 572);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(276, 97);
            this.button_return.TabIndex = 1;
            this.button_return.Text = "Вернуться!";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // listBox_Help
            // 
            this.listBox_Help.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Help.FormattingEnabled = true;
            this.listBox_Help.ItemHeight = 29;
            this.listBox_Help.Location = new System.Drawing.Point(49, 12);
            this.listBox_Help.Name = "listBox_Help";
            this.listBox_Help.Size = new System.Drawing.Size(1169, 468);
            this.listBox_Help.TabIndex = 0;
            this.listBox_Help.Click += new System.EventHandler(this.listBox_Help_Click);
            // 
            // help_label
            // 
            this.help_label.AutoSize = true;
            this.help_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_label.Location = new System.Drawing.Point(50, 509);
            this.help_label.Name = "help_label";
            this.help_label.Size = new System.Drawing.Size(325, 29);
            this.help_label.TabIndex = 2;
            this.help_label.Text = "Справка по грузоперевозкам:";
            this.help_label.Click += new System.EventHandler(this.help_label_Click);
            // 
            // label_help2
            // 
            this.label_help2.AutoSize = true;
            this.label_help2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_help2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_help2.Location = new System.Drawing.Point(53, 572);
            this.label_help2.Name = "label_help2";
            this.label_help2.Size = new System.Drawing.Size(404, 87);
            this.label_help2.TabIndex = 3;
            this.label_help2.Text = "Название компании:\r\nЗапланированный объём, тыс. на км:\r\nСтоимость перевозки, 1 ты" +
    "с. на км:\r\n";
            // 
            // Help_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 920);
            this.Controls.Add(this.label_help2);
            this.Controls.Add(this.help_label);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.listBox_Help);
            this.Name = "Help_Form";
            this.Text = "Справка учётной книги";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button button_return;
        public System.Windows.Forms.ListBox listBox_Help;
        public System.Windows.Forms.Label help_label;
        private System.Windows.Forms.Label label_help2;
    }
}