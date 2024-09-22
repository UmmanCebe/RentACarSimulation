namespace RentACarSimulation.Models.Dtos;
public record CarDetailDto(
    int Id,
    string FuelName,
    string TransmissionName,
    string ColorName,
    string CarState,
    int Kilometer,
    short ModelYear,
    string Plate,
    string BrandName,
    string ModelName,
    double DailyPrice
);