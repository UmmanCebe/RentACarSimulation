using RentACarSimulation.Models;
namespace RentACarSimulation.Data;

public class FuelRepository
{
    private List<Fuel> fuels = new List<Fuel>()
    {
        new Fuel(1,"Benzin"),
        new Fuel(2,"Motorin")
    };

    public List<Fuel> GetAll()
    {
        return fuels;
    }

    public Fuel? GetById(int id)
    {
        Fuel? fuel = fuels.SingleOrDefault(x => x.Id == id);
        return fuel;
    }

    public Fuel Add(Fuel fuel)
    {
        fuels.Add(fuel);
        return fuel;
    }

    public Fuel? UpdatedFuel(Fuel updatedFuel)
    {
        Fuel? fuel = fuels.FirstOrDefault(x => x.Id == updatedFuel.Id);
        if (fuel != null)
        {
            int index = fuels.IndexOf(fuel);
            fuels[index] = updatedFuel;
            return fuel;
        }
        return null;
    }

    public Fuel? Delete(int id)
    {
        Fuel? fuel = GetById(id);
        if (fuel != null)
        {
            fuels.Remove(fuel);
        }
        else
        {
            return null;
        }
        return fuel;
    }
}