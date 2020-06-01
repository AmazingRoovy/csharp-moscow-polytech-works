using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Work_03
{
    public partial class Help_Form : Form
    {
        public Help_Form()
        {
            InitializeComponent();
            listBox_Help.BeginUpdate();
            foreach (var cargo_unit in CargoUnit.cargoUnitArray_)
            {
                this.listBox_Help.Items.Add("Название компании: " + cargo_unit.TransportCompanyName + "  Запланированный объём: " + cargo_unit.PlannedCargoSize.ToString() + 
                    "  Стоимость одной грузоперевозки: " + cargo_unit.OneCargoPrice.ToString());
            }
            this.listBox_Help.Items.RemoveAt(this.listBox_Help.Items.Count - 1);
            this.listBox_Help.EndUpdate();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main_form = new Form1();
            main_form.Show();

            foreach (CargoUnit cu_iter in CargoUnit.cargoUnitArray_)
            {
                main_form.dataGrid_transportCargo.Rows.Add(cu_iter.TransportCompanyName, cu_iter.PlannedCargoSize, cu_iter.OneCargoPrice);
            }
            main_form.dataGrid_transportCargo.Rows.RemoveAt(CargoUnit.cargoUnitArray_.Count - 1);
            CargoUnit.cargoUnitArray_.Clear();

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void help_label_Click(object sender, EventArgs e)
        {

        }

        private void listBox_Help_Click(object sender, EventArgs e)
        {
            if (this.listBox_Help.SelectedItems.Count == 1)
            {
                CargoUnit selectedCargoUnit = CargoUnit.cargoUnitArray_[this.listBox_Help.SelectedIndex];
                this.label_help2.Text = "Название компании: " + selectedCargoUnit.TransportCompanyName + "\nЗапланированный объём, тыс. на км: " + selectedCargoUnit.PlannedCargoSize.ToString() +
                    "\nCтоимость перевозки, 1 тыс.на км: " + selectedCargoUnit.OneCargoPrice.ToString();
            }
        }
    }
}
