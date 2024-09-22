using RentACarSimulation.Data;
using RentACarSimulation.Models;
using RentACarSimulation.Models.Dtos;
namespace RentACarSimulation.Services;

public class CarService
{
    ColorService colorService = new ColorService();
    FuelService fuelService = new FuelService();
    TransmissionService transmissionService = new TransmissionService();

    CarRepository carRepository = new CarRepository();

    public void GetAll()
    {
        List<Car> cars = carRepository.GetAll();

        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }
    }

    public void GetById(int id)
    {
        Car? car = carRepository.GetById(id);

        if (car is null)
        {
            Console.WriteLine($"Aradığınız id ye göre Araba Bulunamadı. ID:{id}");
            return;
        }
        Console.WriteLine(car);
    }

    public void Add(Car car)
    {
        foreach (Car a in carRepository.GetAll())
        {
            if (car.Id == a.Id)
            {
                Console.WriteLine($"Bu id li Araba Var. ID: {car.Id}");
            }
            return;
        }
        carRepository.Add(car);
        GetAll();
    }

    public void UpdatedCar(Car car)
    {
        Console.WriteLine("Araç Güncellendi...");
        carRepository.UpdatedCar(car);
        GetAll();
    }

    public void Delete(int id)
    {
        Car? deletedCar = carRepository.Delete(id);
        if (deletedCar is null)
        {
            Console.WriteLine($"Araç Bulunamadı: id = {id}");
            return;
        }
        Console.WriteLine("Ürün Silindi");
        Console.WriteLine(deletedCar);
    }

    public void GetAllDetails()
    {
        List<Color> colors = colorService.GetAllColors();
        List<Fuel> fuels = fuelService.GetAllFuels();
        List<Transmission> transmissions = transmissionService.GetAllTransmissions();

        List<CarDetailDto> carDetails = carRepository.GetAllDetails(colors, fuels, transmissions);
        carDetails.ForEach(x => Console.WriteLine(x));
    }

    public void GetAllDetailsByFuelId(int id)
    {
        List<Color> colors = colorService.GetAllColors();
        List<Fuel> fuels = fuelService.GetAllFuels();
        List<Transmission> transmissions = transmissionService.GetAllTransmissions();

        List<CarDetailDto> carDetails = carRepository.GetAllDetailsByFuelId(id, colors, fuels, transmissions);
        if (carDetails == null || !carDetails.Any())
        {
            Console.WriteLine("Araç Bulunamadı");
            return;
        }
        carDetails.ForEach(x => Console.WriteLine(x));
    }

    public void GetAllDetailsByColorId(int id)
    {
        List<Color> colors = colorService.GetAllColors();
        List<Fuel> fuels = fuelService.GetAllFuels();
        List<Transmission> transmissions = transmissionService.GetAllTransmissions();

        List<CarDetailDto> carDetails = carRepository.GetAllDetailsByColorId(id, colors, fuels, transmissions);

        if (carDetails == null || !carDetails.Any())
        {
            Console.WriteLine("Araç Bulunamadı");
            return;
        }
        carDetails.ForEach(x => Console.WriteLine(x));
    }

    public void GetAllDetailsByPriceRange(double min, double max)
    {
        List<Color> colors = colorService.GetAllColors();
        List<Fuel> fuels = fuelService.GetAllFuels();
        List<Transmission> transmissions = transmissionService.GetAllTransmissions();

        List<CarDetailDto> carDetailsByPrice = carRepository.GetAllDetailsByPriceRange(min, max, colors, fuels, transmissions);

        if (carDetailsByPrice == null || !carDetailsByPrice.Any())
        {
            Console.WriteLine("Araç Bulunamadı");
            return;
        }
        carDetailsByPrice.ForEach(x => Console.WriteLine(x));
    }

    public void GetAllDetailsByBrandNameContains(string brandName)
    {
        List<Color> colors = colorService.GetAllColors();
        List<Fuel> fuels = fuelService.GetAllFuels();
        List<Transmission> transmissions = transmissionService.GetAllTransmissions();

        List<CarDetailDto> carDetailWithContain = carRepository.GetAllDetailsByBrandNameContains(brandName, colors, fuels, transmissions);

        if (carDetailWithContain is null || !carDetailWithContain.Any())
        {
            Console.WriteLine("Araç Bulunamadı");
            return;
        }
        carDetailWithContain.ForEach(x => Console.WriteLine(x));
    }

    public void GetAllDetailsByModelNameContains(string modelName)
    {
        List<Color> colors = colorService.GetAllColors();
        List<Fuel> fuels = fuelService.GetAllFuels();
        List<Transmission> transmissions = transmissionService.GetAllTransmissions();

        List<CarDetailDto> carDetailWithContain = carRepository.GetAllDetailsByModelNameContains(modelName, colors, fuels, transmissions);

        if (carDetailWithContain is null || !carDetailWithContain.Any())
        {
            Console.WriteLine("Araç Bulunamadı");
            return;
        }
        carDetailWithContain.ForEach(x => Console.WriteLine(x));
    }

    public void GetAllDetailsByKilometerRange(int min, int max)
    {
        List<Color> colors = colorService.GetAllColors();
        List<Fuel> fuels = fuelService.GetAllFuels();
        List<Transmission> transmissions = transmissionService.GetAllTransmissions();

        List<CarDetailDto> carDetailByKilometer = carRepository.GetAllDetailsByKilometerRange(min, max, colors, fuels, transmissions);

        if (carDetailByKilometer is null || !carDetailByKilometer.Any())
        {
            Console.WriteLine("Araç Bulunamadı");
            return;
        }
        carDetailByKilometer.ForEach(x => Console.WriteLine(x));
    }
}