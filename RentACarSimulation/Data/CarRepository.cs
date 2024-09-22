using RentACarSimulation.Models;
using RentACarSimulation.Models.Dtos;

namespace RentACarSimulation.Data;
public class CarRepository
{
    private List<Car> cars = new List<Car>()
    {
        new Car(1,1,1,1,"Sıfır",0,2022,"34 UMN 25","Ferrari","SF90",15000000),
        new Car(2,1,1,1,"Sıfır",0,2023,"34 SLT 34","Volvo","XC90",450000),
        new Car(3,2,2,2,"İkinci El",150000,2013,"48 PST 41","Fiat","Egea",450000),
        new Car(4,3,2,2,"İkinci El",55000,2019,"54 DTF 548","Honda","Civic",900000),
        new Car(5,4,1,2,"İkinci El",100000,2018,"61 OF 61","Peugeot","508",1000000),
        new Car(6,5,2,2,"İkinci El",175000,2016,"81 DC 259","Peugeot","206",875000),
    };

    public List<Car> GetAll()
    {
        return cars;
    }

    public Car? GetById(int id)
    {
        Car? car = cars.SingleOrDefault(x => x.Id == id);
        return car;
    }

    public Car Add(Car car)
    {
        cars.Add(car);
        return car;
    }

    public Car? UpdatedCar(Car updatedCar)
    {
        
        Car? car = cars.FirstOrDefault(x=> x.Id == updatedCar.Id);
        if (car != null)
        {
            int index = cars.IndexOf(car);
            cars[index] = updatedCar; // ilgili indekste güncelledik
            return car;
        }
       return null;
    }

    public Car? Delete(int id)
    {
        Car? car = GetById(id);
        if (car != null)
        {
            cars.Remove(car);
        }
        else
        {
            return null;
        }
        return car;
    }

    public List<CarDetailDto> GetAllDetails(List<Color> colors, List<Fuel> fuels, List<Transmission> transmissions)
    {
        var result = from car in cars
                     join color in colors on car.ColorId equals color.Id
                     join fuel in fuels on car.FuelId equals fuel.Id
                     join transmission in transmissions on car.TransmissionId equals transmission.Id

                     select new CarDetailDto(
                         Id: car.Id,
                         FuelName: fuel.Name,
                         TransmissionName: transmission.Name,
                         ColorName: color.Name,
                         CarState: car.CarState,
                         Kilometer: car.Kilometer,
                         ModelYear: car.ModelYear,
                         Plate: car.Plate,
                         BrandName: car.BrandName,
                         ModelName: car.ModelName,
                         DailyPrice: car.DailyPrice
                     );
        return result.ToList();
    }

    public List<CarDetailDto> GetAllDetailsByFuelId(int id,List<Color> colors, List<Fuel> fuels, List<Transmission> transmissions)
    {
        var result = from car in cars
                     where car.FuelId == id
                     join color in colors on car.ColorId equals color.Id
                     join fuel in fuels on car.FuelId equals fuel.Id
                     join transmission in transmissions on car.TransmissionId equals transmission.Id

                     select new CarDetailDto(
                         Id: car.Id,
                         FuelName: fuel.Name,
                         TransmissionName: transmission.Name,
                         ColorName: color.Name,
                         CarState: car.CarState,
                         Kilometer: car.Kilometer,
                         ModelYear: car.ModelYear,
                         Plate: car.Plate,
                         BrandName: car.BrandName,
                         ModelName: car.ModelName,
                         DailyPrice: car.DailyPrice
                     );
        return result.ToList();
    }

    public List<CarDetailDto> GetAllDetailsByColorId(int id, List<Color> colors, List<Fuel> fuels, List<Transmission> transmissions)
    {
        var result = from car in cars
                     where car.ColorId == id
                     join color in colors on car.ColorId equals color.Id
                     join fuel in fuels on car.FuelId equals fuel.Id
                     join transmission in transmissions on car.TransmissionId equals transmission.Id

                     select new CarDetailDto(
                         Id: car.Id,
                         FuelName: fuel.Name,
                         TransmissionName: transmission.Name,
                         ColorName: color.Name,
                         CarState: car.CarState,
                         Kilometer: car.Kilometer,
                         ModelYear: car.ModelYear,
                         Plate: car.Plate,
                         BrandName: car.BrandName,
                         ModelName: car.ModelName,
                         DailyPrice: car.DailyPrice
                     );
        return result.ToList();
    }

    public List<CarDetailDto> GetAllDetailsByPriceRange(double min,double max, List<Color> colors, List<Fuel> fuels, List<Transmission> transmissions)
    {
        var result = from car in cars
                     where car.DailyPrice>=min && car.DailyPrice<=max
                     join color in colors on car.ColorId equals color.Id
                     join fuel in fuels on car.FuelId equals fuel.Id
                     join transmission in transmissions on car.TransmissionId equals transmission.Id

                     select new CarDetailDto(
                         Id: car.Id,
                         FuelName: fuel.Name,
                         TransmissionName: transmission.Name,
                         ColorName: color.Name,
                         CarState: car.CarState,
                         Kilometer: car.Kilometer,
                         ModelYear: car.ModelYear,
                         Plate: car.Plate,
                         BrandName: car.BrandName,
                         ModelName: car.ModelName,
                         DailyPrice: car.DailyPrice
                     );
        return result.ToList();
    }

    public List<CarDetailDto> GetAllDetailsByBrandNameContains(string brandName, List<Color> colors, List<Fuel> fuels, List<Transmission> transmissions)
    {
        var result = from car in cars
                     where car.BrandName.ToLower().Contains(brandName.ToLower())
                     join color in colors on car.ColorId equals color.Id
                     join fuel in fuels on car.FuelId equals fuel.Id
                     join transmission in transmissions on car.TransmissionId equals transmission.Id

                     select new CarDetailDto(
                         Id: car.Id,
                         FuelName: fuel.Name,
                         TransmissionName: transmission.Name,
                         ColorName: color.Name,
                         CarState: car.CarState,
                         Kilometer: car.Kilometer,
                         ModelYear: car.ModelYear,
                         Plate: car.Plate,
                         BrandName: car.BrandName,
                         ModelName: car.ModelName,
                         DailyPrice: car.DailyPrice
                     );
        return result.ToList();
    }

    public List<CarDetailDto> GetAllDetailsByModelNameContains(string modelName, List<Color> colors, List<Fuel> fuels, List<Transmission> transmissions)
    {
        var result = from car in cars
                     where car.ModelName.ToLower().Contains(modelName.ToLower())
                     join color in colors on car.ColorId equals color.Id
                     join fuel in fuels on car.FuelId equals fuel.Id
                     join transmission in transmissions on car.TransmissionId equals transmission.Id

                     select new CarDetailDto(
                         Id: car.Id,
                         FuelName: fuel.Name,
                         TransmissionName: transmission.Name,
                         ColorName: color.Name,
                         CarState: car.CarState,
                         Kilometer: car.Kilometer,
                         ModelYear: car.ModelYear,
                         Plate: car.Plate,
                         BrandName: car.BrandName,
                         ModelName: car.ModelName,
                         DailyPrice: car.DailyPrice
                     );
        return result.ToList();
    }

    public List<CarDetailDto> GetAllDetailsByKilometerRange(int min, int max, List<Color> colors, List<Fuel> fuels, List<Transmission> transmissions)
    {
        var result = from car in cars
                     where car.Kilometer >= min && car.Kilometer <= max
                     join color in colors on car.ColorId equals color.Id
                     join fuel in fuels on car.FuelId equals fuel.Id
                     join transmission in transmissions on car.TransmissionId equals transmission.Id

                     select new CarDetailDto(
                         Id: car.Id,
                         FuelName: fuel.Name,
                         TransmissionName: transmission.Name,
                         ColorName: color.Name,
                         CarState: car.CarState,
                         Kilometer: car.Kilometer,
                         ModelYear: car.ModelYear,
                         Plate: car.Plate,
                         BrandName: car.BrandName,
                         ModelName: car.ModelName,
                         DailyPrice: car.DailyPrice
                     );
        return result.ToList();
    }
}