using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows;
using teszt;

namespace JsonReaderApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadCars();
            
        }

        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string selection = lb_manufacturer_select.SelectedValue.ToString();
            CarListBox.Items.Clear();
            CarListBox.Items.Add(selection);
            foreach (var car in cars)
            {
                if (car.Manufacturer == selection)
                {
                    if (!CarListBox.Items.Contains(car.Model))
                    {
                        CarListBox.Items.Add($"{car.Model}");
                    }
                }
            }
        }

        private void CarListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var selection = CarListBox.SelectedItem;
            if (selection != null)
            {
                CarListBox.Items.Clear();
                CarListBox.Items.Add(selection);
                MessageBox.Show($"{selection}");
                foreach (var car in cars)
                {
                    if (car.Model == selection.ToString())
                    {
                        MessageBox.Show($"{selection}");
                        CarListBox.Items.Add($"{car.Manufacturer} | {car.Model} | {car.Year} | {car.Class} | {car.Displ} | {car.Cyl} | {car.Trans} | {car.Drv}");
                    }
                }
            }
        }
    }

    
}
