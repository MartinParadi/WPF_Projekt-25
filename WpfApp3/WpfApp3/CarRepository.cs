using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using CarDealer.Models;

namespace CarDealer.Services
{
    public class CarRepository
    {
        private readonly string _filePath = "cars.json";

        public List<Car> Load()
        {
            if (!File.Exists(_filePath))
                return new List<Car>();

            string json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Car>>(json);
        }

        public void Save(List<Car> cars)
        {
            string json = JsonConvert.SerializeObject(
                cars,
                Newtonsoft.Json.Formatting.Indented
            );

            File.WriteAllText(_filePath, json);
        }
    }
}