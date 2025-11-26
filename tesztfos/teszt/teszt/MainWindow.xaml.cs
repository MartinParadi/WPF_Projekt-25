using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows;

namespace JsonReaderApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadCars();
        }

    }

    public class Car
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public double Displ { get; set; }
        public int Year { get; set; }
        public int Cyl { get; set; }
        public string Trans { get; set; }
        public string Drv { get; set; }
        public int Cty { get; set; }
        public int Hwy { get; set; }
        public string Fl { get; set; }
        public string Class { get; set; }
    }
}
