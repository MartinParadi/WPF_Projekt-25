using System;
using System.Windows;
using CarDealer.Models;
using CarDealer.ViewModels;

namespace CarDealer
{
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _vm;

        public MainWindow()
        {
            InitializeComponent();
            _vm = new MainViewModel();
            DataContext = _vm;
        }

        private void AddCar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var car = new Car
                {
                    Manufacturer = TxtManufacturer.Text,
                    Model = TxtModel.Text,
                    Year = int.Parse(TxtYear.Text),
                    Displ = double.Parse(TxtDispl.Text),
                    Cyl = int.Parse(TxtCyl.Text),
                    Trans = TxtTrans.Text,
                    Drv = TxtDrv.Text,
                    Cty = int.Parse(TxtCty.Text),
                    Hwy = int.Parse(TxtHwy.Text),
                    Fl = TxtFl.Text,
                    Class = TxtClass.Text
                };

                _vm.AddCar(car);
                MessageBox.Show("Car added!");
            }
            catch
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private void DeleteCar_Click(object sender, RoutedEventArgs e)
        {
            _vm.DeleteCar();
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            _vm.SaveChanges();
            MessageBox.Show("All changes saved.");
        }
    }
}