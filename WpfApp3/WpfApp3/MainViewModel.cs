using System.Collections.ObjectModel;
using System.Windows;
using CarDealer.Models;
using CarDealer.Services;

namespace CarDealer.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Car> Cars { get; set; }
        private readonly CarRepository _repo = new CarRepository();

        public Car SelectedCar { get; set; }

        public MainViewModel()
        {
            Cars = new ObservableCollection<Car>(_repo.Load());
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
            _repo.Save(new List<Car>(Cars));
        }

        public void DeleteCar()
        {
            if (SelectedCar == null)
            {
                MessageBox.Show("Please select a car to delete.");
                return;
            }

            Cars.Remove(SelectedCar);
            _repo.Save(new List<Car>(Cars));
        }

        public void SaveChanges()
        {
            _repo.Save(new List<Car>(Cars));
        }
    }
}