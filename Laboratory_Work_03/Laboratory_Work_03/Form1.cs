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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeDataRow_Button_Click(object sender, EventArgs e)
        {
            
            error_label.Text = "";
            if (long.Parse(plannedSizeCargo_textField.Text) < 0)
                plannedSizeCargo_textField.Text = "0";
            else if (long.Parse(plannedSizeCargo_textField.Text) > 50)
                plannedSizeCargo_textField.Text = "50";

            if (long.Parse(oneCargoPrice_textField.Text) < 0)
                oneCargoPrice_textField.Text = "0";
            else if (long.Parse(oneCargoPrice_textField.Text) > 50)
                oneCargoPrice_textField.Text = "50";
            try
            {
                if (dataGrid_transportCargo.SelectedRows.Count == 1)
                {
                    foreach (DataGridViewRow row in dataGrid_transportCargo.Rows)
                    {
                        if (row.Selected)
                        {
                            if (transportCompanyName_textField.Text != "")
                            {
                                row.Cells[0].Value = transportCompanyName_textField.Text;
                                row.Cells[1].Value = plannedSizeCargo_textField.Text;
                                row.Cells[2].Value = oneCargoPrice_textField.Text;
                                //if (dataGrid_transportCargo.CurrentRow != null)
                                //    dataGrid_transportCargo.CurrentCell =
                                //       dataGrid_transportCargo.Rows[Math.Min(dataGrid_transportCargo.CurrentRow.Index + 1, dataGrid_transportCargo.Rows.Count - 1)]
                                //        .Cells[dataGrid_transportCargo.CurrentCell.ColumnIndex];
                                break;
                            }
                            else
                            {
                                error_label.Text = "Введите название компании!";
                            }
                        }

                    }
                }
                else
                {
                    if (transportCompanyName_textField.Text != "")
                    {
                        dataGrid_transportCargo.Rows.Add(transportCompanyName_textField.Text, long.Parse(plannedSizeCargo_textField.Text),
                            long.Parse(oneCargoPrice_textField.Text));
                    }
                    else
                    {
                        error_label.Text = "Введите название компании!";
                    }
                }
            }
            catch (FormatException format_ex)
            {
                Console.WriteLine("Format Exception has been called! Try other data for input.");
                error_label.Text = "Ошибка формата данных!";
            }
        }

        private void plannedSizeCargo_slider_Scroll(object sender, EventArgs e)
        {
             
        }

        private void plannedSizeCargo_slider_ValueChanged(object sender, EventArgs e)
        {
            plannedSizeCargo_textField.Text = Convert.ToString(plannedSizeCargo_slider.Value);
        }

        private void oneCargoPrice_slider_ValueChanged(object sender, EventArgs e)
        {
            oneCargoPrice_textField.Text = Convert.ToString(oneCargoPrice_slider.Value);
        }

        private void transportCompanyName_textField_Click(object sender, EventArgs e)
        {
            if (this.Text == "Название")
            {
                this.Text = "";
            }
        }

        private void plannedSizeCargo_textField_TextChanged(object sender, EventArgs e)
        {
            if (this.Text == "Объём")
            {
                this.Text = "";
            }
        }

        private void oneCargoPrice_textField_TextChanged(object sender, EventArgs e)
        {
            if (this.Text == "Стоимость перевозки")
            {
                this.Text = "";
            }
        }

        private void dataGrid_transportCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_transportCargo.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in dataGrid_transportCargo.Rows)
                {
                    if (row.Selected)
                    {
                        transportCompanyName_textField.Text = Convert.ToString(row.Cells[0].Value);
                        plannedSizeCargo_textField.Text = Convert.ToString(row.Cells[1].Value);
                        oneCargoPrice_textField.Text = Convert.ToString(row.Cells[2].Value);
                        break;
                    }

                }
            }
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGrid_transportCargo.Rows) 
            {
                CargoUnit cargo_unit = new CargoUnit(Convert.ToString(row.Cells[0].Value), Convert.ToInt64(row.Cells[1].Value), Convert.ToInt64(row.Cells[2].Value));
                cargo_unit.CargoUnit_Add();
            }


            Help_Form help_form2 = new Help_Form();
            this.Hide();
            help_form2.ShowDialog();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class CargoUnit
    {
        
        public CargoUnit ()
        {
            this.oneCargoPrice = 50;
            this.plannedCargoSize = 50;
            this.transportCompanyName = "No-name Company";
        }

        public CargoUnit (long oneCargoPrice_, long plannedCargoSize_)
        {
            this.oneCargoPrice = oneCargoPrice_;
            this.plannedCargoSize = plannedCargoSize_;
            this.transportCompanyName = "No-name Company";
        }

        public CargoUnit(string transportCompanyName_, long oneCargoPrice_, long plannedCargoSize_)
        {
            this.transportCompanyName = transportCompanyName_;
            this.oneCargoPrice = oneCargoPrice_;
            this.plannedCargoSize = plannedCargoSize_;
        }

        public CargoUnit(string transportCompanyName_)
        {
            this.oneCargoPrice = 50;
            this.plannedCargoSize = 50;
            this.transportCompanyName = transportCompanyName_;
        }

        public void CargoUnit_Add()
        {
            cargoUnitArray_.Add(this);
        }

        public static void CargoUnit_Clear()
        {
            cargoUnitArray_.Clear();
        }

        public override string ToString()
        {
            string propertiesString = "Название компании: " + Convert.ToString(TransportCompanyName) + "\tСтоимость одного груза: " + Convert.ToString(OneCargoPrice) +
                "\tЗапланированный объём: " + Convert.ToString(PlannedCargoSize);
            
            return base.ToString();
        }

        public static List<CargoUnit> CargoUnit_GetList()
        {
            return cargoUnitArray_;
        }

        public long OneCargoPrice
        {
            get
            {
                return oneCargoPrice;
            }
            set
            {
                if (value >= 0 && value <= 0)
                    oneCargoPrice = value;
                else
                    oneCargoPrice = 0;
            }
        }

        public long PlannedCargoSize
        {
            get
            {
                return plannedCargoSize;
            }
            set
            {
                if (value >= 0 && value <= 0)
                    plannedCargoSize = value;
                else
                    plannedCargoSize = 0;
            }
        }

        public string TransportCompanyName
        {
            get
            {
                return transportCompanyName;
            }
            set
            {
                if (value != "")
                    transportCompanyName = value;
                else
                    transportCompanyName = "No-name Company";
            }
        }

        private long oneCargoPrice;
        private long plannedCargoSize;
        private string transportCompanyName;

        public static List<CargoUnit> cargoUnitArray_ = new List<CargoUnit>();
    }

    

}
