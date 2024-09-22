using RentACarSimulation.Data;
using RentACarSimulation.Models;

namespace RentACarSimulation.Services;

public class FuelService
{
    FuelRepository fuelRepository = new FuelRepository();
    public void GetAll()
    {
        List<Fuel> fuels = fuelRepository.GetAll();

        foreach (Fuel fuel in fuels)
        {
            Console.WriteLine(fuel);
        }
    }

    public void GetById(int id)
    {
        Fuel? fuel = fuelRepository.GetById(id);

        if (fuel is null)
        {
            Console.WriteLine($"Aradığınız id ye göre Yakıt Bulunamadı. ID:{id}");
            return;
        }
        Console.WriteLine(fuel);
    }

    public void Add(Fuel fuel)
    {
        foreach (Fuel a in fuelRepository.GetAll())
        {
            if (fuel.Id == a.Id)
            {
                Console.WriteLine($"Bu id li Yakıt Var. ID: {fuel.Id}");
            }
            return;
        }
        fuelRepository.Add(fuel);
        GetAll();
    }

    public void UpdatedFuel(Fuel fuel)
    {
        Console.WriteLine("Yakıt Güncellendi...");
        fuelRepository.UpdatedFuel(fuel);
        GetAll();
    }

    public void Delete(int id)
    {
        Fuel? deletedFuel = fuelRepository.Delete(id);
        if (deletedFuel is null)
        {
            Console.WriteLine($"Yakıt Bulunamadı: id = {id}");
            return;
        }
        Console.WriteLine("Ürün Silindi");
        Console.WriteLine(deletedFuel);
    }

    public List<Fuel> GetAllFuels()
    {
        return fuelRepository.GetAll();
    }
}