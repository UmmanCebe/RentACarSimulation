using RentACarSimulation.Data;
using RentACarSimulation.Models;

namespace RentACarSimulation.Services;

public class TransmissionService
{
    TransmissionRepository transmissionRepository = new TransmissionRepository();
    public void GetAll()
    {
        List<Transmission> transmissions = transmissionRepository.GetAll();

        foreach (Transmission transmission in transmissions)
        {
            Console.WriteLine(transmission);
        }
    }

    public void GetById(int id)
    {
        Transmission? transmission = transmissionRepository.GetById(id);

        if (transmission is null)
        {
            Console.WriteLine($"Aradığınız id ye göre Transmisyon Bulunamadı. ID:{id}");
            return;
        }
        Console.WriteLine(transmission);
    }

    public void Add(Transmission transmission)
    {
        foreach (Transmission a in transmissionRepository.GetAll())
        {
            if (transmission.Id == a.Id)
            {
                Console.WriteLine($"Bu id li transmisyon Var. ID: {transmission.Id}");
            }
            return;
        }
        transmissionRepository.Add(transmission);
        GetAll();
    }

    public void UpdatedCar(Transmission transmission)
    {
        Console.WriteLine("Transmisyon Güncellendi...");
        transmissionRepository.UpdatedTransmission(transmission);
        GetAll();
    }

    public void Delete(int id)
    {
        Transmission? deletedTransmission = transmissionRepository.Delete(id);
        if (deletedTransmission is null)
        {
            Console.WriteLine($"Transmisyon Bulunamadı: id = {id}");
            return;
        }
        Console.WriteLine("Ürün Silindi");
        Console.WriteLine(deletedTransmission);
    }

    public List<Transmission> GetAllTransmissions()
    {
        return transmissionRepository.GetAll();
    }
}
