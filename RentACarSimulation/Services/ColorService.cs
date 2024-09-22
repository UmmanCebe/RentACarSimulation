using RentACarSimulation.Data;
using RentACarSimulation.Models;
namespace RentACarSimulation.Services;

public class ColorService
{
    ColorRepository colorRepository = new ColorRepository();
    public void GetAll()
    {
        List<Color> colors = colorRepository.GetAll();

        foreach(Color color in colors)
        {
            Console.WriteLine(color);
        }
    }

    public void GetById(int id)
    {
        Color? color = colorRepository.GetById(id);

        if (color is null)
        {
            Console.WriteLine($"Aradığınız id ye göre Renk Bulunamadı. ID:{id}");
            return;
        }
        Console.WriteLine(color);
    }

    public void Add(Color color)
    {
        foreach (Color a in colorRepository.GetAll())
        {
            if (color.Id == a.Id)
            {
                Console.WriteLine($"Bu id li Renk Var. ID: {color.Id}");
            }
            return;
        }
        colorRepository.Add(color);
        GetAll();
    }

    public void UpdatedColor(Color color)
    {
        Console.WriteLine("Renk Güncellendi...");
        colorRepository.UpdatedColor(color);
        GetAll();
    }

    public void Delete(int id)
    {
        Color? deletedColor = colorRepository.Delete(id);
        if (deletedColor is null)
        {
            Console.WriteLine($"Renk Bulunamadı: id = {id}");
            return;
        }
        Console.WriteLine("Ürün Silindi");
        Console.WriteLine(deletedColor);
    }

    public List<Color> GetAllColors()
    {
        return colorRepository.GetAll();
    }
}