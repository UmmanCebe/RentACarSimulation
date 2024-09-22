using RentACarSimulation.Models;
namespace RentACarSimulation.Data;
public class TransmissionRepository
{
    private List<Transmission> transmissions = new List<Transmission>()
    {
        new Transmission(1,"Tiptronic"),
        new Transmission(2,"Manuel"),
        new Transmission(3,"DGS"),
        new Transmission(4,"CVT"),
        new Transmission(5,"Semi Auto")
    };


    public List<Transmission> GetAll()
    {
        return transmissions;
    }

    public Transmission? GetById(int id)
    {
        Transmission? transmission = transmissions.SingleOrDefault(x => x.Id == id);
        return transmission;
    }

    public Transmission Add(Transmission transmission)
    {
        transmissions.Add(transmission);
        return transmission;
    }

    public Transmission? UpdatedTransmission(Transmission updatedTransmission)
    {
        Transmission? transmission = transmissions.FirstOrDefault(x => x.Id == updatedTransmission.Id);
        if (transmission != null)
        {
            int index = transmissions.IndexOf(transmission);
            transmissions[index] = updatedTransmission;
            return transmission;
        }
        return null;
    }

    public Transmission? Delete(int id)
    {
        Transmission? transmission = GetById(id);
        if (transmission != null)
        {
            transmissions.Remove(transmission);
        }
        else
        {
            return null;
        }
        return transmission;
    }
}