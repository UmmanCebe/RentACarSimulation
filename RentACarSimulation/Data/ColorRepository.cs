using RentACarSimulation.Models;

namespace RentACarSimulation.Data;

public class ColorRepository
{
    private List<Color> colors = new List<Color>()
    {
        new Color(1,"Red"),
        new Color(2,"Yellow"),
        new Color(3,"White"),
        new Color(4,"Green"),
        new Color(5,"Pink"),
        new Color(6,"Grey"),
    };

    public List<Color> GetAll()
    {
        return colors;
    }

    public Color? GetById(int id)
    {
        Color? color = colors.SingleOrDefault(x => x.Id == id);
        return color;
    }

    public Color Add(Color color)
    {
        colors.Add(color);
        return color;
    }

    public Color? UpdatedColor(Color updatedColor)
    {
        Color? color = colors.FirstOrDefault(x => x.Id == updatedColor.Id);
        if (color != null)
        {
            int index = colors.IndexOf(color);
            colors[index] = updatedColor;
            return color;
        }
        return null;
    }


    public Color? Delete(int id)
    {
        Color? color = GetById(id);
        if (color != null)
        {
            colors.Remove(color);
        }
        else
        {
            return null;
        }
        return color;
    }

}