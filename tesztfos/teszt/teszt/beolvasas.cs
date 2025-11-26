using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows;

namespace JsonReaderApp
{
    public partial class MainWindow : Window
    {
        private void LoadCars()
        {
            try
            {
                string jsonFilePath = "cars.json";

                if (!File.Exists(jsonFilePath))
                {
                    MessageBox.Show("A cars.json fájl nem található!");
                    return;
                }

                string json = File.ReadAllText(jsonFilePath);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                List<Car> cars = JsonSerializer.Deserialize<List<Car>>(json, options);

                foreach (var car in cars)
                {
                    CarListBox.Items.Add(car.Manufacturer);
                }
            }
            catch (JsonException ex)
            {
                MessageBox.Show("JSON hiba: " + ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Fájl hiba: " + ex.Message);
            }
        }
    }
}
